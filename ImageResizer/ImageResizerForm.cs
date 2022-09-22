using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Firebase.Storage;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace ImageResizer
{
    public partial class ImageResizerForm : Form
    {
        // Atribut gambar sebelum diperkecil
        private long size = 0;
        private string url = "";
        private int sizeGambar = 0;
        private int persen = 0;
        private string namaFile = "";

        // Konstruktor kelas ImageResizerForm
        public ImageResizerForm()
        {
            // Membangkitkan komponen-komponen Windows Form
            InitializeComponent();
            // Menambahkan items persen pada combo box
            comboBox.Items.AddRange(new object[] { "90%",
            "75%",
            "50%",
            "25%",
            "10%"});
            comboBox.SelectedIndex = 0;
        }

        // Event ketika tombol pilih-gambar diklik
        private void pilihGambarButton_Click(object sender, EventArgs e)
        {
            // Jika pengguna memilih gambar (tidak cancel)
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
                // Menghitung dan menampilkan perkiraan hasil ukuran berkas
                double percent = Convert.ToDouble((comboBox.SelectedItem as string).Substring(0, 2)) / 100;
                sizeKb = (long)(sizeKb * percent);
                perkiraanHasilUkuranLabel.Text = "Perkiraan hasil ukuran berkas: " + sizeKb + " KB";
                // Assignment atribut persen dan sizeGambar
                persen = Convert.ToInt32((comboBox.SelectedItem as string).Substring(0, 2));
                sizeGambar = Convert.ToInt32(size);
                // Upload berkas gambar ke Firebase Storage
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

        // Metode untuk unggah berkas gambar ke Firebase Storage
        private async void UploadFiles(string url, int persen, int size)
        {
            // Get any Stream - it can be FileStream, MemoryStream or any other type of Stream
            var stream = File.Open(@"" + url, FileMode.Open);

            // Construct FirebaseStorage, path to where you want to upload the file and Put it there
            var task = new FirebaseStorage("kursusku-66845.appspot.com")
                .Child("imageResizerHasil")
                .Child(url)
                .PutAsync(stream);

            // Debugging progresi unggah
            // task.Progress.ProgressChanged += (s, e) => ukuranBerkasLabel.Text = $"Progress: {e.Percentage} %";

            // Membuat task menunggu sampai unggah selesai dan mendapatkan URL download
            string urlGambarUser = await task;

            // Unggah URL ke Firebase Realtime
            var json = JsonConvert.SerializeObject(urlGambarUser);
            var request = WebRequest.CreateHttp("https://kursusku-66845.firebaseio.com/imageResizer/.json");
            request.Method = "POST";
            var buffer = Encoding.UTF8.GetBytes(json);
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            try
            {
                var response = request.GetResponse();
                json = new StreamReader(response.GetResponseStream()).ReadToEnd();
                dynamic data = JObject.Parse(json);
                namaFile = data.name;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // Memuat gambar pada pictureBox
            pictureBox.Load(url);

            // Mengatur agar gambar pada pictureBox tidak stretch dan berada di tengah
            var imageSize = pictureBox.Image.Size;
            var fitSize = pictureBox.ClientSize;
            pictureBox.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
        }

        // Yang terjadi ketika tombol Lakukan diklik
        private void lakukanButton_Click(object sender, EventArgs e)
        {
            if (namaFile != "")
            {
                try
                {
                    // GET URL unduh dari Rest API
                    persen = Convert.ToInt32((comboBox.SelectedItem as string).Substring(0, 2));
                    string returnString;
                    string urlApi = "https://1465fae747ba.ngrok.io/" + persen + "/" + size + "/" + namaFile;
                    var client = new RestClient(urlApi);
                    var request2 = new RestRequest(Method.GET);
                    IRestResponse response2 = client.Execute(request2);
                    JsonObject rajaObj = (JsonObject)SimpleJson.DeserializeObject(response2.Content);
                    returnString = (string)rajaObj["url"];
                    downloadLinkLabel.Text = returnString;
                }
                catch
                {
                    MessageBox.Show("Server sedang mati atau URL ngrok belum diganti.",
                        "Peringatan!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Mohon pilih gambar terlebih dahulu.",
                        "Peringatan!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
        }

        // Membuka gambar pada browser ketika link gambar diklik
        private void downloadLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(downloadLinkLabel.Text);
        }
    }
}
