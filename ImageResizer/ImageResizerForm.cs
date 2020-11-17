using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResizer
{
    public partial class ImageResizerForm : Form
    {
        // atribut ukuran gambar sebelum diperkecil
        private long size = 0;

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
                // Memuat gambar pada pictureBox
                pictureBox.Load(openFileDialog.FileName);
                // Mengatur agar gambar pada pictureBox tidak stretch dan berada di tengah
                var imageSize = pictureBox.Image.Size;
                var fitSize = pictureBox.ClientSize;
                pictureBox.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                    PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
                // Memuat nama gambar pada label-nama-gambar
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
    }
}
