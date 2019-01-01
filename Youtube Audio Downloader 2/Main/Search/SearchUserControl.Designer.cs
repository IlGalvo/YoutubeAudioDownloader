namespace YoutubeAudioDownloader.Main.Search
{
    partial class SearchUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUserControl));
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelActionOffset = new System.Windows.Forms.Panel();
            this.panelAction = new System.Windows.Forms.Panel();
            this.buttonTemp = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.labelInformation = new System.Windows.Forms.Label();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.pictureBoxLoadingImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoadingText = new System.Windows.Forms.PictureBox();
            this.placeholderRichTextBoxSearch = new CustomControlCollection.RichTextBoxes.PlaceholderRichTextBox();
            this.panelActionOffset.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingText)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSearch.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSearch.Location = new System.Drawing.Point(650, 230);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(81, 42);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Cerca";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_ClickAsync);
            // 
            // panelActionOffset
            // 
            this.panelActionOffset.BackColor = System.Drawing.Color.Transparent;
            this.panelActionOffset.Controls.Add(this.panelAction);
            this.panelActionOffset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionOffset.Location = new System.Drawing.Point(0, 540);
            this.panelActionOffset.Name = "panelActionOffset";
            this.panelActionOffset.Size = new System.Drawing.Size(734, 63);
            this.panelActionOffset.TabIndex = 3;
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.SeaGreen;
            this.panelAction.Controls.Add(this.buttonTemp);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAction.Location = new System.Drawing.Point(0, 10);
            this.panelAction.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(734, 53);
            this.panelAction.TabIndex = 4;
            // 
            // buttonTemp
            // 
            this.buttonTemp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonTemp.BackColor = System.Drawing.Color.Honeydew;
            this.buttonTemp.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonTemp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.buttonTemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemp.Location = new System.Drawing.Point(293, 7);
            this.buttonTemp.Name = "buttonTemp";
            this.buttonTemp.Size = new System.Drawing.Size(148, 40);
            this.buttonTemp.TabIndex = 5;
            this.buttonTemp.Text = "Temp";
            this.buttonTemp.UseVisualStyleBackColor = false;
            this.buttonTemp.Visible = false;
            this.buttonTemp.Click += new System.EventHandler(this.buttonSearch_ClickAsync);
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.Controls.Add(this.labelInformation);
            this.panelContent.Controls.Add(this.panelLoading);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(734, 540);
            this.panelContent.TabIndex = 0;
            // 
            // labelInformation
            // 
            this.labelInformation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelInformation.AutoSize = true;
            this.labelInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInformation.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelInformation.Location = new System.Drawing.Point(6, 279);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(115, 25);
            this.labelInformation.TabIndex = 7;
            this.labelInformation.Text = "Information";
            // 
            // panelLoading
            // 
            this.panelLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLoading.Controls.Add(this.pictureBoxLoadingImage);
            this.panelLoading.Controls.Add(this.pictureBoxLoadingText);
            this.panelLoading.Location = new System.Drawing.Point(290, 282);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(148, 101);
            this.panelLoading.TabIndex = 6;
            this.panelLoading.Visible = false;
            // 
            // pictureBoxLoadingImage
            // 
            this.pictureBoxLoadingImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadingImage.Image")));
            this.pictureBoxLoadingImage.Location = new System.Drawing.Point(41, 3);
            this.pictureBoxLoadingImage.Name = "pictureBoxLoadingImage";
            this.pictureBoxLoadingImage.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxLoadingImage.TabIndex = 0;
            this.pictureBoxLoadingImage.TabStop = false;
            // 
            // pictureBoxLoadingText
            // 
            this.pictureBoxLoadingText.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoadingText.Image")));
            this.pictureBoxLoadingText.Location = new System.Drawing.Point(3, 57);
            this.pictureBoxLoadingText.Name = "pictureBoxLoadingText";
            this.pictureBoxLoadingText.Size = new System.Drawing.Size(142, 40);
            this.pictureBoxLoadingText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoadingText.TabIndex = 1;
            this.pictureBoxLoadingText.TabStop = false;
            // 
            // optimizedTextBoxSearch
            // 
            this.placeholderRichTextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.placeholderRichTextBoxSearch.AutoWordSelection = true;
            this.placeholderRichTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderRichTextBoxSearch.Location = new System.Drawing.Point(3, 230);
            this.placeholderRichTextBoxSearch.Multiline = false;
            this.placeholderRichTextBoxSearch.Name = "optimizedTextBoxSearch";
            this.placeholderRichTextBoxSearch.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.placeholderRichTextBoxSearch.PlaceholderText = "Cerca un video o incolla un link...";
            this.placeholderRichTextBoxSearch.PlaceholerFont = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholderRichTextBoxSearch.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.placeholderRichTextBoxSearch.Size = new System.Drawing.Size(650, 43);
            this.placeholderRichTextBoxSearch.TabIndex = 1;
            this.placeholderRichTextBoxSearch.Text = "";
            this.placeholderRichTextBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.optimizedTextBoxSearch_KeyUp);
            // 
            // SearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.placeholderRichTextBoxSearch);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelActionOffset);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(734, 603);
            this.panelActionOffset.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoadingText)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControlCollection.RichTextBoxes.PlaceholderRichTextBox placeholderRichTextBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelActionOffset;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Button buttonTemp;
        private System.Windows.Forms.PictureBox pictureBoxLoadingImage;
        private System.Windows.Forms.PictureBox pictureBoxLoadingText;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Label labelInformation;
    }
}
