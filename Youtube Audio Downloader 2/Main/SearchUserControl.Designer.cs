namespace YoutubeAudioDownloader2.Main
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelActionOffset = new System.Windows.Forms.Panel();
            this.buttonTemp = new System.Windows.Forms.Button();
            this.panelAction = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.optimizedTextBoxSearch = new YoutubeAudioDownloader2.OptimizedRichTextBox();
            this.panelActionOffset.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSearch.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(650, 230);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(81, 42);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Cerca";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // panelActionOffset
            // 
            this.panelActionOffset.BackColor = System.Drawing.Color.Transparent;
            this.panelActionOffset.Controls.Add(this.buttonTemp);
            this.panelActionOffset.Controls.Add(this.panelAction);
            this.panelActionOffset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionOffset.Location = new System.Drawing.Point(0, 540);
            this.panelActionOffset.Name = "panelActionOffset";
            this.panelActionOffset.Size = new System.Drawing.Size(734, 63);
            this.panelActionOffset.TabIndex = 3;
            // 
            // buttonTemp
            // 
            this.buttonTemp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonTemp.BackColor = System.Drawing.Color.Honeydew;
            this.buttonTemp.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonTemp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.buttonTemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTemp.Location = new System.Drawing.Point(293, 17);
            this.buttonTemp.Name = "buttonTemp";
            this.buttonTemp.Size = new System.Drawing.Size(148, 40);
            this.buttonTemp.TabIndex = 5;
            this.buttonTemp.Text = "Temp";
            this.buttonTemp.UseVisualStyleBackColor = false;
            this.buttonTemp.Visible = false;
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.SeaGreen;
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAction.Location = new System.Drawing.Point(0, 10);
            this.panelAction.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(734, 53);
            this.panelAction.TabIndex = 4;
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(734, 540);
            this.panelContent.TabIndex = 0;
            // 
            // optimizedTextBoxSearch
            // 
            this.optimizedTextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.optimizedTextBoxSearch.AutoWordSelection = true;
            this.optimizedTextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimizedTextBoxSearch.Location = new System.Drawing.Point(3, 230);
            this.optimizedTextBoxSearch.Multiline = false;
            this.optimizedTextBoxSearch.Name = "optimizedTextBoxSearch";
            this.optimizedTextBoxSearch.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.optimizedTextBoxSearch.PlaceholderText = "Cerca un video o incolla un link...";
            this.optimizedTextBoxSearch.PlaceholerFont = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimizedTextBoxSearch.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.optimizedTextBoxSearch.Size = new System.Drawing.Size(650, 43);
            this.optimizedTextBoxSearch.TabIndex = 1;
            this.optimizedTextBoxSearch.Text = "";
            this.optimizedTextBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.optimizedTextBoxSearch_KeyUp);
            // 
            // SearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.optimizedTextBoxSearch);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelActionOffset);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(734, 603);
            this.panelActionOffset.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private OptimizedRichTextBox optimizedTextBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelActionOffset;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button buttonTemp;
        private System.Windows.Forms.Panel panelAction;
    }
}
