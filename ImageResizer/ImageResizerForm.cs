using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Storage;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace ImageResizer
{
    public partial class ImageResizerForm : Form
    {
        // atribut ukuran gambar sebelum diperkecil
        private long size = 0;
        private string url = "";
        private int sizeGambar = 0;
        private int persen = 0;
        private string namaFile = "";

        public ImageResizerForm()
        {
            InitializeComponent();
            comboBox.Items.AddRange(new object[] { "90%",
            "75%",
            "50%",
            "25%",
            "10%"});
            comboBox.SelectedIndex = 0;
        }

        private void ImageResizerForm_Load(object sender, EventArgs e)
        {

        }

        // Event ketika tombol pilih-gambar diklik
        private void pilihGambarButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Memuat nama gambar pada label-nama-gambar
                url = openFileDialog.FileName;
                namaGambarLabel.Text = "Nama Gambar: " + openFileDialog.FileName;
                // Menghitung ukuran berkas dalam KB
                size = new FileInfo(openFileDialog.FileName).Length;
                double sizeKb = size / 1024;
                // Menampilkan ukuran berkas pada label-ukuran-berkas
                ukuranBerkasLabel.Text = "Ukuran Berkas: " + sizeKb + " KB";
                // Menghitung dan menampilkan perkiraan hasil ukuran berkas pada labelnya
                double percent = Convert.ToDouble((comboBox.SelectedItem as string).Substring(0, 2)) / 100;
                sizeKb = (long)(sizeKb * percent);
                perkiraanHasilUkuranLabel.Text = "Perkiraan hasil ukuran berkas: " + sizeKb + " KB";

                persen = Convert.ToInt32((comboBox.SelectedItem as string).Substring(0, 2));
                sizeGambar = Convert.ToInt32(size);

                // Upload file ke storage firebase
                UploadFiles(url, persen, sizeGambar);
            }
        }



        // Event ketika persen pengecilan diganti
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Menghitung dan menampilkan perkiraan hasil ukuran berkas pada labelnya
            double percent = Convert.ToDouble((comboBox.SelectedItem as string).Substring(0, 2)) / 100;
            double sizeKb = size / 1024 * percent;
            perkiraanHasilUkuranLabel.Text = "Perkiraan hasil ukuran berkas: " + sizeKb + " KB";
        }

        //Method untuk upload file ke storage firebase
        private async void UploadFiles(string url, int persen, int size)
        {
            // Get any Stream - it can be FileStream, MemoryStream or any other type of Stream
            var stream = File.Open(@"" + url, FileMode.Open);

            // Construct FirebaseStorage, path to where you want to upload the file and Put it there
            var task = new FirebaseStorage("kursusku-66845.appspot.com")
                .Child("imageResizerHasil")
                .Child(url)
                .PutAsync(stream);

            // Track progress of the upload
            // task.Progress.ProgressChanged += (s, e) => ukuranBerkasLabel.Text = $"Progress: {e.Percentage} %";

            // await the task to wait until upload completes and get the download url
            string urlGambarUser = await task;

            //upload url ke realtime firebase
            var json = JsonConvert.SerializeObject(urlGambarUser);
            var request = WebRequest.CreateHttp("https://kursusku-66845.firebaseio.com/imageResizer/.json");
            request.Method = "POST";
            var buffer = Encoding.UTF8.GetBytes(json);
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            var response = request.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();
            dynamic data = JObject.Parse(json);
            namaFile = data.name;

            // Memuat gambar pada pictureBox
            pictureBox.Load(url);

            // Mengatur agar gambar pada pictureBox tidak stretch dan berada di tengah
            var imageSize = pictureBox.Image.Size;
            var fitSize = pictureBox.ClientSize;
            pictureBox.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }

        private void downloadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(downloadLinkLabel.Text);
        }

        private void lakukanButton_Click(object sender, EventArgs e)
        {
            //get url from rest API
            string returnString;
            string urlApi = "http://127.0.0.1:5000/" + persen + "/" + size + "/" + namaFile;
            var client = new RestClient(urlApi);
            var request2 = new RestRequest(Method.GET);
            IRestResponse response2 = client.Execute(request2);
            JsonObject rajaObj = (JsonObject)SimpleJson.DeserializeObject(response2.Content);
            returnString = (string)rajaObj["url"];
            downloadLinkLabel.Text = returnString;
        }
    }
}
