namespace YoutubeAudioDownloader.Main.List
{
    partial class ListUserControl
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
            this.panelActionOffset = new System.Windows.Forms.Panel();
            this.panelAction = new System.Windows.Forms.Panel();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelActionOffset.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelActionOffset
            // 
            this.panelActionOffset.BackColor = System.Drawing.Color.Transparent;
            this.panelActionOffset.Controls.Add(this.panelAction);
            this.panelActionOffset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActionOffset.Location = new System.Drawing.Point(0, 557);
            this.panelActionOffset.Name = "panelActionOffset";
            this.panelActionOffset.Size = new System.Drawing.Size(734, 63);
            this.panelActionOffset.TabIndex = 1;
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.SeaGreen;
            this.panelAction.Controls.Add(this.buttonShowAll);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAction.Location = new System.Drawing.Point(0, 10);
            this.panelAction.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(734, 53);
            this.panelAction.TabIndex = 2;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonShowAll.BackColor = System.Drawing.Color.Honeydew;
            this.buttonShowAll.Enabled = false;
            this.buttonShowAll.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.buttonShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAll.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonShowAll.Location = new System.Drawing.Point(293, 7);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(148, 40);
            this.buttonShowAll.TabIndex = 3;
            this.buttonShowAll.Text = "Mostra tutti";
            this.buttonShowAll.UseVisualStyleBackColor = false;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(734, 557);
            this.panelContent.TabIndex = 0;
            // 
            // ListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelActionOffset);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListUserControl";
            this.Size = new System.Drawing.Size(734, 620);
            this.panelActionOffset.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelActionOffset;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.Button buttonShowAll;
    }
}
