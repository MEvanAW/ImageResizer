using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Load(openFileDialog.FileName);
                namaGambarLabel.Text = openFileDialog.FileName;
            }
        }
    }
}
