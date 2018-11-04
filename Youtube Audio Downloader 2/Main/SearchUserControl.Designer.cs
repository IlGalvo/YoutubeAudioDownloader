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
            this.optimizedTextBoxSearch = new YoutubeAudioDownloader2.OptimizedRichTextBox();
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
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Cerca";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
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
            this.optimizedTextBoxSearch.TabIndex = 0;
            this.optimizedTextBoxSearch.Text = "";
            // 
            // SearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.optimizedTextBoxSearch);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(734, 603);
            this.ResumeLayout(false);

        }

        #endregion

        private OptimizedRichTextBox optimizedTextBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
    }
}
