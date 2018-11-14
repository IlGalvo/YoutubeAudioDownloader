namespace YoutubeAudioDownloader2.Main.List.Item
{
    partial class EntryListUserControl
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
            this.webBrowserVideo = new System.Windows.Forms.WebBrowser();
            this.groupBoxVideo = new System.Windows.Forms.GroupBox();
            this.optimizedLabelTitle = new YoutubeAudioDownloader2.Main.OptimizedLabel();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.linkLabelShowExtra = new System.Windows.Forms.LinkLabel();
            this.labelRatingStatic = new System.Windows.Forms.Label();
            this.labelDateStatic = new System.Windows.Forms.Label();
            this.labelDurationStatic = new System.Windows.Forms.Label();
            this.labelTitleStatic = new System.Windows.Forms.Label();
            this.labelAuthorStatic = new System.Windows.Forms.Label();
            this.groupBoxAudio = new System.Windows.Forms.GroupBox();
            this.labelEncoding = new System.Windows.Forms.Label();
            this.labelBitrate = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelSizeStatic = new System.Windows.Forms.Label();
            this.labelBitrateStatic = new System.Windows.Forms.Label();
            this.labelEncodingStatic = new System.Windows.Forms.Label();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.groupBoxVideo.SuspendLayout();
            this.groupBoxAudio.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserVideo
            // 
            this.webBrowserVideo.Location = new System.Drawing.Point(9, 8);
            this.webBrowserVideo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserVideo.Name = "webBrowserVideo";
            this.webBrowserVideo.Size = new System.Drawing.Size(290, 261);
            this.webBrowserVideo.TabIndex = 0;
            // 
            // groupBoxVideo
            // 
            this.groupBoxVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVideo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxVideo.Controls.Add(this.optimizedLabelTitle);
            this.groupBoxVideo.Controls.Add(this.labelAuthor);
            this.groupBoxVideo.Controls.Add(this.labelRating);
            this.groupBoxVideo.Controls.Add(this.labelDuration);
            this.groupBoxVideo.Controls.Add(this.labelDate);
            this.groupBoxVideo.Controls.Add(this.linkLabelShowExtra);
            this.groupBoxVideo.Controls.Add(this.labelRatingStatic);
            this.groupBoxVideo.Controls.Add(this.labelDateStatic);
            this.groupBoxVideo.Controls.Add(this.labelDurationStatic);
            this.groupBoxVideo.Controls.Add(this.labelTitleStatic);
            this.groupBoxVideo.Controls.Add(this.labelAuthorStatic);
            this.groupBoxVideo.Location = new System.Drawing.Point(305, 8);
            this.groupBoxVideo.Name = "groupBoxVideo";
            this.groupBoxVideo.Size = new System.Drawing.Size(420, 131);
            this.groupBoxVideo.TabIndex = 1;
            this.groupBoxVideo.TabStop = false;
            this.groupBoxVideo.Text = "Video";
            // 
            // optimizedLabelTitle
            // 
            this.optimizedLabelTitle.AutoSize = true;
            this.optimizedLabelTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimizedLabelTitle.Location = new System.Drawing.Point(94, 40);
            this.optimizedLabelTitle.Name = "optimizedLabelTitle";
            this.optimizedLabelTitle.Size = new System.Drawing.Size(41, 17);
            this.optimizedLabelTitle.TabIndex = 12;
            this.optimizedLabelTitle.Text = "Titolo";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(94, 23);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(47, 17);
            this.labelAuthor.TabIndex = 11;
            this.labelAuthor.Text = "Autore";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.Location = new System.Drawing.Point(94, 91);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(74, 17);
            this.labelRating.TabIndex = 10;
            this.labelRating.Text = "Valutazione";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuration.Location = new System.Drawing.Point(94, 57);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(47, 17);
            this.labelDuration.TabIndex = 7;
            this.labelDuration.Text = "Durata";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(94, 74);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(35, 17);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Data";
            // 
            // linkLabelShowExtra
            // 
            this.linkLabelShowExtra.AutoSize = true;
            this.linkLabelShowExtra.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelShowExtra.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelShowExtra.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelShowExtra.Location = new System.Drawing.Point(6, 109);
            this.linkLabelShowExtra.Name = "linkLabelShowExtra";
            this.linkLabelShowExtra.Size = new System.Drawing.Size(95, 17);
            this.linkLabelShowExtra.TabIndex = 5;
            this.linkLabelShowExtra.TabStop = true;
            this.linkLabelShowExtra.Text = "Mostra altro...";
            // 
            // labelRatingStatic
            // 
            this.labelRatingStatic.AutoSize = true;
            this.labelRatingStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRatingStatic.Location = new System.Drawing.Point(6, 91);
            this.labelRatingStatic.Name = "labelRatingStatic";
            this.labelRatingStatic.Size = new System.Drawing.Size(80, 17);
            this.labelRatingStatic.TabIndex = 4;
            this.labelRatingStatic.Text = "Valutazione:";
            // 
            // labelDateStatic
            // 
            this.labelDateStatic.AutoSize = true;
            this.labelDateStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateStatic.Location = new System.Drawing.Point(6, 74);
            this.labelDateStatic.Name = "labelDateStatic";
            this.labelDateStatic.Size = new System.Drawing.Size(39, 17);
            this.labelDateStatic.TabIndex = 3;
            this.labelDateStatic.Text = "Data:";
            // 
            // labelDurationStatic
            // 
            this.labelDurationStatic.AutoSize = true;
            this.labelDurationStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurationStatic.Location = new System.Drawing.Point(6, 57);
            this.labelDurationStatic.Name = "labelDurationStatic";
            this.labelDurationStatic.Size = new System.Drawing.Size(52, 17);
            this.labelDurationStatic.TabIndex = 2;
            this.labelDurationStatic.Text = "Durata:";
            // 
            // labelTitleStatic
            // 
            this.labelTitleStatic.AutoSize = true;
            this.labelTitleStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleStatic.Location = new System.Drawing.Point(6, 40);
            this.labelTitleStatic.Name = "labelTitleStatic";
            this.labelTitleStatic.Size = new System.Drawing.Size(45, 17);
            this.labelTitleStatic.TabIndex = 1;
            this.labelTitleStatic.Text = "Titolo:";
            // 
            // labelAuthorStatic
            // 
            this.labelAuthorStatic.AutoSize = true;
            this.labelAuthorStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorStatic.Location = new System.Drawing.Point(6, 23);
            this.labelAuthorStatic.Name = "labelAuthorStatic";
            this.labelAuthorStatic.Size = new System.Drawing.Size(53, 17);
            this.labelAuthorStatic.TabIndex = 0;
            this.labelAuthorStatic.Text = "Autore:";
            // 
            // groupBoxAudio
            // 
            this.groupBoxAudio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAudio.Controls.Add(this.labelEncoding);
            this.groupBoxAudio.Controls.Add(this.labelBitrate);
            this.groupBoxAudio.Controls.Add(this.labelSize);
            this.groupBoxAudio.Controls.Add(this.labelSizeStatic);
            this.groupBoxAudio.Controls.Add(this.labelBitrateStatic);
            this.groupBoxAudio.Controls.Add(this.labelEncodingStatic);
            this.groupBoxAudio.Location = new System.Drawing.Point(305, 145);
            this.groupBoxAudio.Name = "groupBoxAudio";
            this.groupBoxAudio.Size = new System.Drawing.Size(420, 80);
            this.groupBoxAudio.TabIndex = 2;
            this.groupBoxAudio.TabStop = false;
            this.groupBoxAudio.Text = "Audio";
            // 
            // labelEncoding
            // 
            this.labelEncoding.AutoSize = true;
            this.labelEncoding.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncoding.Location = new System.Drawing.Point(94, 23);
            this.labelEncoding.Name = "labelEncoding";
            this.labelEncoding.Size = new System.Drawing.Size(55, 17);
            this.labelEncoding.TabIndex = 12;
            this.labelEncoding.Text = "Codifica";
            // 
            // labelBitrate
            // 
            this.labelBitrate.AutoSize = true;
            this.labelBitrate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBitrate.Location = new System.Drawing.Point(94, 40);
            this.labelBitrate.Name = "labelBitrate";
            this.labelBitrate.Size = new System.Drawing.Size(45, 17);
            this.labelBitrate.TabIndex = 11;
            this.labelBitrate.Text = "Bitrate";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(94, 57);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(76, 17);
            this.labelSize.TabIndex = 10;
            this.labelSize.Text = "Dimensione";
            // 
            // labelSizeStatic
            // 
            this.labelSizeStatic.AutoSize = true;
            this.labelSizeStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSizeStatic.Location = new System.Drawing.Point(6, 57);
            this.labelSizeStatic.Name = "labelSizeStatic";
            this.labelSizeStatic.Size = new System.Drawing.Size(82, 17);
            this.labelSizeStatic.TabIndex = 2;
            this.labelSizeStatic.Text = "Dimensione:";
            // 
            // labelBitrateStatic
            // 
            this.labelBitrateStatic.AutoSize = true;
            this.labelBitrateStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBitrateStatic.Location = new System.Drawing.Point(6, 40);
            this.labelBitrateStatic.Name = "labelBitrateStatic";
            this.labelBitrateStatic.Size = new System.Drawing.Size(51, 17);
            this.labelBitrateStatic.TabIndex = 1;
            this.labelBitrateStatic.Text = "Bitrate:";
            // 
            // labelEncodingStatic
            // 
            this.labelEncodingStatic.AutoSize = true;
            this.labelEncodingStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncodingStatic.Location = new System.Drawing.Point(6, 23);
            this.labelEncodingStatic.Name = "labelEncodingStatic";
            this.labelEncodingStatic.Size = new System.Drawing.Size(58, 17);
            this.labelEncodingStatic.TabIndex = 0;
            this.labelEncodingStatic.Text = "Codifica:";
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.LightCyan;
            this.buttonDownload.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.Location = new System.Drawing.Point(305, 231);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(85, 38);
            this.buttonDownload.TabIndex = 3;
            this.buttonDownload.Text = "Scarica";
            this.buttonDownload.UseVisualStyleBackColor = false;
            // 
            // EntryListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.groupBoxAudio);
            this.Controls.Add(this.groupBoxVideo);
            this.Controls.Add(this.webBrowserVideo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EntryListUserControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.Size = new System.Drawing.Size(734, 276);
            this.groupBoxVideo.ResumeLayout(false);
            this.groupBoxVideo.PerformLayout();
            this.groupBoxAudio.ResumeLayout(false);
            this.groupBoxAudio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserVideo;
        private System.Windows.Forms.GroupBox groupBoxVideo;
        private System.Windows.Forms.GroupBox groupBoxAudio;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Label labelRatingStatic;
        private System.Windows.Forms.Label labelDateStatic;
        private System.Windows.Forms.Label labelDurationStatic;
        private System.Windows.Forms.Label labelTitleStatic;
        private System.Windows.Forms.Label labelAuthorStatic;
        private System.Windows.Forms.Label labelSizeStatic;
        private System.Windows.Forms.Label labelBitrateStatic;
        private System.Windows.Forms.Label labelEncodingStatic;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelEncoding;
        private System.Windows.Forms.Label labelBitrate;
        private System.Windows.Forms.Label labelSize;
        private OptimizedLabel optimizedLabelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.LinkLabel linkLabelShowExtra;
    }
}
