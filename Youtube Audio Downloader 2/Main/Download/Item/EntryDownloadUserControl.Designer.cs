namespace YoutubeAudioDownloader2.Main.Download.Item
{
    partial class EntryDownloadUserControl
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.groupBoxDownload = new System.Windows.Forms.GroupBox();
            this.labelBitrateSize = new System.Windows.Forms.Label();
            this.labelTitleStatic = new System.Windows.Forms.Label();
            this.optimizedLabelTitle = new YoutubeAudioDownloader2.Main.OptimizedLabel();
            this.labelInformation = new System.Windows.Forms.Label();
            this.labelBitrateSizeStatic = new System.Windows.Forms.Label();
            this.buttonDownloadCancel = new System.Windows.Forms.Button();
            this.coloredProgressBarDownload = new YoutubeAudioDownloader2.ColoredProgressBar();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.groupBoxDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(9, 8);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(155, 122);
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // groupBoxDownload
            // 
            this.groupBoxDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDownload.Controls.Add(this.labelBitrateSize);
            this.groupBoxDownload.Controls.Add(this.labelTitleStatic);
            this.groupBoxDownload.Controls.Add(this.optimizedLabelTitle);
            this.groupBoxDownload.Controls.Add(this.labelInformation);
            this.groupBoxDownload.Controls.Add(this.labelBitrateSizeStatic);
            this.groupBoxDownload.Location = new System.Drawing.Point(170, 8);
            this.groupBoxDownload.Name = "groupBoxDownload";
            this.groupBoxDownload.Size = new System.Drawing.Size(519, 86);
            this.groupBoxDownload.TabIndex = 1;
            this.groupBoxDownload.TabStop = false;
            this.groupBoxDownload.Text = "Download Mp3";
            // 
            // labelBitrateSize
            // 
            this.labelBitrateSize.AutoSize = true;
            this.labelBitrateSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBitrateSize.Location = new System.Drawing.Point(91, 43);
            this.labelBitrateSize.Name = "labelBitrateSize";
            this.labelBitrateSize.Size = new System.Drawing.Size(73, 17);
            this.labelBitrateSize.TabIndex = 5;
            this.labelBitrateSize.Text = "Bitrate/Size";
            // 
            // labelTitleStatic
            // 
            this.labelTitleStatic.AutoSize = true;
            this.labelTitleStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleStatic.Location = new System.Drawing.Point(6, 26);
            this.labelTitleStatic.Name = "labelTitleStatic";
            this.labelTitleStatic.Size = new System.Drawing.Size(45, 17);
            this.labelTitleStatic.TabIndex = 4;
            this.labelTitleStatic.Text = "Titolo:";
            // 
            // optimizedLabelTitle
            // 
            this.optimizedLabelTitle.AutoSize = true;
            this.optimizedLabelTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimizedLabelTitle.Location = new System.Drawing.Point(91, 26);
            this.optimizedLabelTitle.Name = "optimizedLabelTitle";
            this.optimizedLabelTitle.Size = new System.Drawing.Size(41, 17);
            this.optimizedLabelTitle.TabIndex = 3;
            this.optimizedLabelTitle.Text = "Titolo";
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(6, 62);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(83, 17);
            this.labelInformation.TabIndex = 2;
            this.labelInformation.Text = "Informazioni";
            // 
            // labelBitrateSizeStatic
            // 
            this.labelBitrateSizeStatic.AutoSize = true;
            this.labelBitrateSizeStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBitrateSizeStatic.Location = new System.Drawing.Point(6, 43);
            this.labelBitrateSizeStatic.Name = "labelBitrateSizeStatic";
            this.labelBitrateSizeStatic.Size = new System.Drawing.Size(79, 17);
            this.labelBitrateSizeStatic.TabIndex = 1;
            this.labelBitrateSizeStatic.Text = "Bitrate/Size:";
            // 
            // buttonDownloadCancel
            // 
            this.buttonDownloadCancel.BackColor = System.Drawing.Color.LightCyan;
            this.buttonDownloadCancel.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDownloadCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonDownloadCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonDownloadCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadCancel.Location = new System.Drawing.Point(170, 100);
            this.buttonDownloadCancel.Name = "buttonDownloadCancel";
            this.buttonDownloadCancel.Size = new System.Drawing.Size(75, 30);
            this.buttonDownloadCancel.TabIndex = 2;
            this.buttonDownloadCancel.Text = "Scarica";
            this.buttonDownloadCancel.UseVisualStyleBackColor = false;
            // 
            // coloredProgressBarDownload
            // 
            this.coloredProgressBarDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.coloredProgressBarDownload.ForeColor = System.Drawing.Color.Blue;
            this.coloredProgressBarDownload.Location = new System.Drawing.Point(251, 100);
            this.coloredProgressBarDownload.Name = "coloredProgressBarDownload";
            this.coloredProgressBarDownload.ShowPercentageText = true;
            this.coloredProgressBarDownload.Size = new System.Drawing.Size(438, 30);
            this.coloredProgressBarDownload.TabIndex = 3;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonRemove.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonRemove.Location = new System.Drawing.Point(698, 56);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(27, 27);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "X";
            this.buttonRemove.UseVisualStyleBackColor = false;
            // 
            // ItemDownloadUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.coloredProgressBarDownload);
            this.Controls.Add(this.buttonDownloadCancel);
            this.Controls.Add(this.groupBoxDownload);
            this.Controls.Add(this.pictureBoxImage);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ItemDownloadUserControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.Size = new System.Drawing.Size(734, 138);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.groupBoxDownload.ResumeLayout(false);
            this.groupBoxDownload.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.GroupBox groupBoxDownload;
        private System.Windows.Forms.Label labelBitrateSize;
        private System.Windows.Forms.Label labelTitleStatic;
        private OptimizedLabel optimizedLabelTitle;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Label labelBitrateSizeStatic;
        private System.Windows.Forms.Button buttonDownloadCancel;
        private ColoredProgressBar coloredProgressBarDownload;
        private System.Windows.Forms.Button buttonRemove;
    }
}
