using System.Threading;

namespace YoutubeAudioDownloader.Main.Download.Item
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
            if (IsRunning)
            {
                audioInfo.CancelAsync();
                converterMp3.CancelAsync();

                lock (lockObject)
                {
                    Monitor.Wait(lockObject);
                }
            }

            converterMp3.Dispose();

            if (disposing && (components != null))
            {
                components.Dispose();
            }

            actionToPerform?.Invoke();

            audioInfo.DownloadProgress -= AudioInfo_DownloadProgress;
            audioInfo.DownloadFinished -= AudioInfo_DownloadFinished;

            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryDownloadUserControl));
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.groupBoxDownload = new System.Windows.Forms.GroupBox();
            this.labelInformation = new System.Windows.Forms.Label();
            this.labelBitrateSize = new System.Windows.Forms.Label();
            this.labelTitleStatic = new System.Windows.Forms.Label();
            this.resizableLabelTitle = new CustomControlCollection.ResizableLabel();
            this.labelBitrateSizeStatic = new System.Windows.Forms.Label();
            this.buttonDownloadCancel = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.coloredProgressBarDownload = new CustomControlCollection.ColoredProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.groupBoxDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(9, 8);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(155, 122);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // groupBoxDownload
            // 
            this.groupBoxDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDownload.Controls.Add(this.labelInformation);
            this.groupBoxDownload.Controls.Add(this.labelBitrateSize);
            this.groupBoxDownload.Controls.Add(this.labelTitleStatic);
            this.groupBoxDownload.Controls.Add(this.resizableLabelTitle);
            this.groupBoxDownload.Controls.Add(this.labelBitrateSizeStatic);
            this.groupBoxDownload.Location = new System.Drawing.Point(170, 8);
            this.groupBoxDownload.Name = "groupBoxDownload";
            this.groupBoxDownload.Size = new System.Drawing.Size(521, 86);
            this.groupBoxDownload.TabIndex = 0;
            this.groupBoxDownload.TabStop = false;
            this.groupBoxDownload.Text = "Download Mp3";
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.Location = new System.Drawing.Point(6, 64);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(81, 17);
            this.labelInformation.TabIndex = 5;
            this.labelInformation.Text = "Information";
            // 
            // labelBitrateSize
            // 
            this.labelBitrateSize.AutoSize = true;
            this.labelBitrateSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBitrateSize.Location = new System.Drawing.Point(91, 43);
            this.labelBitrateSize.Name = "labelBitrateSize";
            this.labelBitrateSize.Size = new System.Drawing.Size(73, 17);
            this.labelBitrateSize.TabIndex = 4;
            this.labelBitrateSize.Text = "Bitrate/Size";
            // 
            // labelTitleStatic
            // 
            this.labelTitleStatic.AutoSize = true;
            this.labelTitleStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleStatic.Location = new System.Drawing.Point(6, 26);
            this.labelTitleStatic.Name = "labelTitleStatic";
            this.labelTitleStatic.Size = new System.Drawing.Size(45, 17);
            this.labelTitleStatic.TabIndex = 1;
            this.labelTitleStatic.Text = "Titolo:";
            // 
            // optimizedLabelTitle
            // 
            this.resizableLabelTitle.AutoSize = true;
            this.resizableLabelTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resizableLabelTitle.Location = new System.Drawing.Point(91, 26);
            this.resizableLabelTitle.Name = "optimizedLabelTitle";
            this.resizableLabelTitle.Size = new System.Drawing.Size(41, 17);
            this.resizableLabelTitle.TabIndex = 2;
            this.resizableLabelTitle.Text = "Titolo";
            // 
            // labelBitrateSizeStatic
            // 
            this.labelBitrateSizeStatic.AutoSize = true;
            this.labelBitrateSizeStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBitrateSizeStatic.Location = new System.Drawing.Point(6, 43);
            this.labelBitrateSizeStatic.Name = "labelBitrateSizeStatic";
            this.labelBitrateSizeStatic.Size = new System.Drawing.Size(79, 17);
            this.labelBitrateSizeStatic.TabIndex = 3;
            this.labelBitrateSizeStatic.Text = "Bitrate/Size:";
            // 
            // buttonDownloadCancel
            // 
            this.buttonDownloadCancel.BackColor = System.Drawing.Color.LightCyan;
            this.buttonDownloadCancel.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonDownloadCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonDownloadCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonDownloadCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadCancel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonDownloadCancel.Location = new System.Drawing.Point(170, 100);
            this.buttonDownloadCancel.Name = "buttonDownloadCancel";
            this.buttonDownloadCancel.Size = new System.Drawing.Size(75, 30);
            this.buttonDownloadCancel.TabIndex = 6;
            this.buttonDownloadCancel.Text = "Scarica";
            this.buttonDownloadCancel.UseVisualStyleBackColor = false;
            this.buttonDownloadCancel.Click += new System.EventHandler(this.buttonDownloadCancel_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonRemove.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRemove.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemove.Image")));
            this.buttonRemove.Location = new System.Drawing.Point(700, 56);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(25, 25);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // coloredProgressBarDownload
            // 
            this.coloredProgressBarDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.coloredProgressBarDownload.ForeColor = System.Drawing.Color.Blue;
            this.coloredProgressBarDownload.Location = new System.Drawing.Point(251, 100);
            this.coloredProgressBarDownload.Name = "coloredProgressBarDownload";
            this.coloredProgressBarDownload.ProgressColor = System.Drawing.Color.SkyBlue;
            this.coloredProgressBarDownload.ShowPercentageText = true;
            this.coloredProgressBarDownload.Size = new System.Drawing.Size(440, 30);
            this.coloredProgressBarDownload.TabIndex = 7;
            // 
            // EntryDownloadUserControl
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
            this.Name = "EntryDownloadUserControl";
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
        private CustomControlCollection.ResizableLabel resizableLabelTitle;
        private System.Windows.Forms.Label labelBitrateSizeStatic;
        private System.Windows.Forms.Button buttonDownloadCancel;
        private CustomControlCollection.ColoredProgressBar coloredProgressBarDownload;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelInformation;
    }
}
