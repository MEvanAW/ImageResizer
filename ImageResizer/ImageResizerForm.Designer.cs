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
            this.ukuranTextBox = new System.Windows.Forms.TextBox();
            this.perkecilUkuranMenjadiLabel = new System.Windows.Forms.Label();
            this.lakukanButton = new System.Windows.Forms.Button();
            this.downloadHasilPadaLinkIniLabel = new System.Windows.Forms.Label();
            this.downloadLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(640, 360);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // namaGambarLabel
            // 
            this.namaGambarLabel.AutoSize = true;
            this.namaGambarLabel.Location = new System.Drawing.Point(127, 384);
            this.namaGambarLabel.Name = "namaGambarLabel";
            this.namaGambarLabel.Size = new System.Drawing.Size(113, 20);
            this.namaGambarLabel.TabIndex = 2;
            this.namaGambarLabel.Text = "Nama Gambar";
            // 
            // pilihGambarButton
            // 
            this.pilihGambarButton.Location = new System.Drawing.Point(12, 378);
            this.pilihGambarButton.Name = "pilihGambarButton";
            this.pilihGambarButton.Size = new System.Drawing.Size(109, 33);
            this.pilihGambarButton.TabIndex = 3;
            this.pilihGambarButton.Text = "Pilih Gambar";
            this.pilihGambarButton.UseVisualStyleBackColor = true;
            // 
            // ukuranBerkasLabel
            // 
            this.ukuranBerkasLabel.AutoSize = true;
            this.ukuranBerkasLabel.Location = new System.Drawing.Point(8, 424);
            this.ukuranBerkasLabel.Name = "ukuranBerkasLabel";
            this.ukuranBerkasLabel.Size = new System.Drawing.Size(119, 20);
            this.ukuranBerkasLabel.TabIndex = 4;
            this.ukuranBerkasLabel.Text = "Ukuran Berkas:";
            // 
            // ukuranTextBox
            // 
            this.ukuranTextBox.Location = new System.Drawing.Point(560, 421);
            this.ukuranTextBox.Name = "ukuranTextBox";
            this.ukuranTextBox.Size = new System.Drawing.Size(92, 26);
            this.ukuranTextBox.TabIndex = 5;
            // 
            // perkecilUkuranMenjadiLabel
            // 
            this.perkecilUkuranMenjadiLabel.AutoSize = true;
            this.perkecilUkuranMenjadiLabel.Location = new System.Drawing.Point(336, 424);
            this.perkecilUkuranMenjadiLabel.Name = "perkecilUkuranMenjadiLabel";
            this.perkecilUkuranMenjadiLabel.Size = new System.Drawing.Size(218, 20);
            this.perkecilUkuranMenjadiLabel.TabIndex = 6;
            this.perkecilUkuranMenjadiLabel.Text = "Perkecil ukuran menjadi (MB):";
            // 
            // lakukanButton
            // 
            this.lakukanButton.Location = new System.Drawing.Point(12, 457);
            this.lakukanButton.Name = "lakukanButton";
            this.lakukanButton.Size = new System.Drawing.Size(640, 33);
            this.lakukanButton.TabIndex = 7;
            this.lakukanButton.Text = "Lakukan";
            this.lakukanButton.UseVisualStyleBackColor = true;
            // 
            // downloadHasilPadaLinkIniLabel
            // 
            this.downloadHasilPadaLinkIniLabel.AutoSize = true;
            this.downloadHasilPadaLinkIniLabel.Location = new System.Drawing.Point(8, 505);
            this.downloadHasilPadaLinkIniLabel.Name = "downloadHasilPadaLinkIniLabel";
            this.downloadHasilPadaLinkIniLabel.Size = new System.Drawing.Size(206, 20);
            this.downloadHasilPadaLinkIniLabel.TabIndex = 8;
            this.downloadHasilPadaLinkIniLabel.Text = "Download hasil pada link ini:";
            // 
            // downloadLinkLabel
            // 
            this.downloadLinkLabel.AutoSize = true;
            this.downloadLinkLabel.Location = new System.Drawing.Point(220, 505);
            this.downloadLinkLabel.Name = "downloadLinkLabel";
            this.downloadLinkLabel.Size = new System.Drawing.Size(104, 20);
            this.downloadLinkLabel.TabIndex = 9;
            this.downloadLinkLabel.TabStop = true;
            this.downloadLinkLabel.Text = "link download";
            // 
            // ImageResizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 544);
            this.Controls.Add(this.downloadLinkLabel);
            this.Controls.Add(this.downloadHasilPadaLinkIniLabel);
            this.Controls.Add(this.lakukanButton);
            this.Controls.Add(this.perkecilUkuranMenjadiLabel);
            this.Controls.Add(this.ukuranTextBox);
            this.Controls.Add(this.ukuranBerkasLabel);
            this.Controls.Add(this.pilihGambarButton);
            this.Controls.Add(this.namaGambarLabel);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageResizerForm";
            this.Text = "Image Resizer";
            this.Load += new System.EventHandler(this.ImageResizerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label namaGambarLabel;
        private System.Windows.Forms.Button pilihGambarButton;
        private System.Windows.Forms.Label ukuranBerkasLabel;
        private System.Windows.Forms.TextBox ukuranTextBox;
        private System.Windows.Forms.Label perkecilUkuranMenjadiLabel;
        private System.Windows.Forms.Button lakukanButton;
        private System.Windows.Forms.Label downloadHasilPadaLinkIniLabel;
        private System.Windows.Forms.LinkLabel downloadLinkLabel;
    }
}

