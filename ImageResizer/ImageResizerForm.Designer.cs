namespace ImageResizer
{
    partial class ImageResizerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageResizerForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.namaGambarLabel = new System.Windows.Forms.Label();
            this.pilihGambarButton = new System.Windows.Forms.Button();
            this.ukuranBerkasLabel = new System.Windows.Forms.Label();
            this.perkecilUkuranMenjadiLabel = new System.Windows.Forms.Label();
            this.lakukanButton = new System.Windows.Forms.Button();
            this.downloadHasilPadaLinkIniLabel = new System.Windows.Forms.Label();
            this.downloadLinkLabel = new System.Windows.Forms.LinkLabel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.perkiraanHasilUkuranLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.Enabled = false;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(640, 360);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // namaGambarLabel
            // 
            this.namaGambarLabel.AutoSize = true;
            this.namaGambarLabel.Location = new System.Drawing.Point(127, 385);
            this.namaGambarLabel.Name = "namaGambarLabel";
            this.namaGambarLabel.Size = new System.Drawing.Size(117, 20);
            this.namaGambarLabel.TabIndex = 2;
            this.namaGambarLabel.Text = "Nama Gambar:";
            // 
            // pilihGambarButton
            // 
            this.pilihGambarButton.Location = new System.Drawing.Point(12, 379);
            this.pilihGambarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pilihGambarButton.Name = "pilihGambarButton";
            this.pilihGambarButton.Size = new System.Drawing.Size(109, 32);
            this.pilihGambarButton.TabIndex = 3;
            this.pilihGambarButton.Text = "Pilih Gambar";
            this.pilihGambarButton.UseVisualStyleBackColor = true;
            this.pilihGambarButton.Click += new System.EventHandler(this.pilihGambarButton_Click);
            // 
            // ukuranBerkasLabel
            // 
            this.ukuranBerkasLabel.AutoSize = true;
            this.ukuranBerkasLabel.Location = new System.Drawing.Point(8, 425);
            this.ukuranBerkasLabel.Name = "ukuranBerkasLabel";
            this.ukuranBerkasLabel.Size = new System.Drawing.Size(119, 20);
            this.ukuranBerkasLabel.TabIndex = 4;
            this.ukuranBerkasLabel.Text = "Ukuran Berkas:";
            // 
            // perkecilUkuranMenjadiLabel
            // 
            this.perkecilUkuranMenjadiLabel.AutoSize = true;
            this.perkecilUkuranMenjadiLabel.Location = new System.Drawing.Point(336, 425);
            this.perkecilUkuranMenjadiLabel.Name = "perkecilUkuranMenjadiLabel";
            this.perkecilUkuranMenjadiLabel.Size = new System.Drawing.Size(180, 20);
            this.perkecilUkuranMenjadiLabel.TabIndex = 6;
            this.perkecilUkuranMenjadiLabel.Text = "Perkecil ukuran menjadi:";
            // 
            // lakukanButton
            // 
            this.lakukanButton.Location = new System.Drawing.Point(12, 485);
            this.lakukanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lakukanButton.Name = "lakukanButton";
            this.lakukanButton.Size = new System.Drawing.Size(640, 32);
            this.lakukanButton.TabIndex = 7;
            this.lakukanButton.Text = "Lakukan";
            this.lakukanButton.UseVisualStyleBackColor = true;
            this.lakukanButton.Click += new System.EventHandler(this.lakukanButton_Click);
            // 
            // downloadHasilPadaLinkIniLabel
            // 
            this.downloadHasilPadaLinkIniLabel.AutoSize = true;
            this.downloadHasilPadaLinkIniLabel.Location = new System.Drawing.Point(8, 532);
            this.downloadHasilPadaLinkIniLabel.Name = "downloadHasilPadaLinkIniLabel";
            this.downloadHasilPadaLinkIniLabel.Size = new System.Drawing.Size(206, 20);
            this.downloadHasilPadaLinkIniLabel.TabIndex = 8;
            this.downloadHasilPadaLinkIniLabel.Text = "Download hasil pada link ini:";
            // 
            // downloadLinkLabel
            // 
            this.downloadLinkLabel.AutoSize = true;
            this.downloadLinkLabel.Location = new System.Drawing.Point(220, 532);
            this.downloadLinkLabel.Name = "downloadLinkLabel";
            this.downloadLinkLabel.Size = new System.Drawing.Size(104, 20);
            this.downloadLinkLabel.TabIndex = 9;
            this.downloadLinkLabel.TabStop = true;
            this.downloadLinkLabel.Text = "link download";
            this.downloadLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.downloadLinkLabel_LinkClicked);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(522, 421);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(129, 28);
            this.comboBox.TabIndex = 10;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Berkas Gambar|*.jpg;*.jpeg;*.png";
            // 
            // perkiraanHasilUkuranLabel
            // 
            this.perkiraanHasilUkuranLabel.AutoSize = true;
            this.perkiraanHasilUkuranLabel.Location = new System.Drawing.Point(12, 452);
            this.perkiraanHasilUkuranLabel.Name = "perkiraanHasilUkuranLabel";
            this.perkiraanHasilUkuranLabel.Size = new System.Drawing.Size(221, 20);
            this.perkiraanHasilUkuranLabel.TabIndex = 11;
            this.perkiraanHasilUkuranLabel.Text = "Perkiraan hasil ukuran berkas:";
            // 
            // ImageResizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 561);
            this.Controls.Add(this.perkiraanHasilUkuranLabel);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.downloadLinkLabel);
            this.Controls.Add(this.downloadHasilPadaLinkIniLabel);
            this.Controls.Add(this.lakukanButton);
            this.Controls.Add(this.perkecilUkuranMenjadiLabel);
            this.Controls.Add(this.ukuranBerkasLabel);
            this.Controls.Add(this.pilihGambarButton);
            this.Controls.Add(this.namaGambarLabel);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ImageResizerForm";
            this.Text = "Image Resizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label namaGambarLabel;
        private System.Windows.Forms.Button pilihGambarButton;
        private System.Windows.Forms.Label ukuranBerkasLabel;
        private System.Windows.Forms.Label perkecilUkuranMenjadiLabel;
        private System.Windows.Forms.Button lakukanButton;
        private System.Windows.Forms.Label downloadHasilPadaLinkIniLabel;
        private System.Windows.Forms.LinkLabel downloadLinkLabel;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label perkiraanHasilUkuranLabel;
    }
}

