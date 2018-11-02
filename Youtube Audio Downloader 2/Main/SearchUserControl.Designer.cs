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
            this.button1 = new System.Windows.Forms.Button();
            this.optimizedTextBox1 = new OptimizedRichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Honeydew;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(650, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerca";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // optimizedTextBox1
            // 
            this.optimizedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.optimizedTextBox1.AutoWordSelection = true;
            this.optimizedTextBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimizedTextBox1.Location = new System.Drawing.Point(3, 230);
            this.optimizedTextBox1.Multiline = false;
            this.optimizedTextBox1.Name = "optimizedTextBox1";
            this.optimizedTextBox1.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.optimizedTextBox1.PlaceholderText = "Cerca un video o incolla un link...";
            this.optimizedTextBox1.PlaceholerFont = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimizedTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.optimizedTextBox1.Size = new System.Drawing.Size(650, 43);
            this.optimizedTextBox1.TabIndex = 0;
            this.optimizedTextBox1.Text = "";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.optimizedTextBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(734, 603);
            this.ResumeLayout(false);

        }

        #endregion

        private OptimizedRichTextBox optimizedTextBox1;
        private System.Windows.Forms.Button button1;
    }
}
