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

        private void pilihGambarButton_Click(object sender, EventArgs e)
        {
            namaGambarLabel.Text = "Nama Gambar";
            ukuranBerkasLabel.Text = "Ukuran Berkas";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(openFileDialog.FileName);
                namaGambarLabel.Text = namaGambarLabel.Text + ": " + openFileDialog.FileName;
                var size = new FileInfo(openFileDialog.FileName).Length;
                var sizekb = size / 1000;
                ukuranBerkasLabel.Text = ukuranBerkasLabel.Text + ": " + sizekb + " KB";
                var imageSize = pictureBox.Image.Size;
                var fitSize = pictureBox.ClientSize;
                pictureBox.SizeMode = imageSize.Width > fitSize.Width || imageSize.Height > fitSize.Height ?
                    PictureBoxSizeMode.Zoom : PictureBoxSizeMode.CenterImage;
            }
        }
    }
}
