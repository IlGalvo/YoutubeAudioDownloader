namespace YoutubeAudioDownloader2.Main
{
    partial class MainForm
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonResearch = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMenu.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tableLayoutPanelMenu.ColumnCount = 1;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.Controls.Add(this.buttonResearch, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.buttonList, 0, 1);
            this.tableLayoutPanelMenu.Controls.Add(this.buttonDownload, 0, 2);       
            this.tableLayoutPanelMenu.Controls.Add(this.buttonSettings, 0, 3);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 4;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(97, 620);
            this.tableLayoutPanelMenu.TabIndex = 0;
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.Honeydew;
            this.buttonDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDownload.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonDownload.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.buttonDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.buttonDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonDownload.Image = ((System.Drawing.Image)(resources.GetObject("buttonDownload.Image")));
            this.buttonDownload.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDownload.Location = new System.Drawing.Point(3, 310);
            this.buttonDownload.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(91, 152);
            this.buttonDownload.TabIndex = 7;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.menuButtons_Click);
            // 
            // buttonResearch
            // 
            this.buttonResearch.BackColor = System.Drawing.Color.Honeydew;
            this.buttonResearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonResearch.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonResearch.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.buttonResearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.buttonResearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonResearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonResearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonResearch.Image")));
            this.buttonResearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonResearch.Location = new System.Drawing.Point(3, 3);
            this.buttonResearch.Name = "buttonResearch";
            this.buttonResearch.Size = new System.Drawing.Size(91, 149);
            this.buttonResearch.TabIndex = 5;
            this.buttonResearch.Text = "Ricerca";
            this.buttonResearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonResearch.UseVisualStyleBackColor = false;
            this.buttonResearch.Click += new System.EventHandler(this.menuButtons_Click);
            // 
            // buttonList
            // 
            this.buttonList.BackColor = System.Drawing.Color.Honeydew;
            this.buttonList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonList.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonList.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.buttonList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.buttonList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonList.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonList.Image = ((System.Drawing.Image)(resources.GetObject("buttonList.Image")));
            this.buttonList.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonList.Location = new System.Drawing.Point(3, 155);
            this.buttonList.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(91, 152);
            this.buttonList.TabIndex = 6;
            this.buttonList.Text = "Lista";
            this.buttonList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonList.UseVisualStyleBackColor = false;
            this.buttonList.Click += new System.EventHandler(this.menuButtons_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Honeydew;
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSettings.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleGreen;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSettings.Location = new System.Drawing.Point(3, 465);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(91, 152);
            this.buttonSettings.TabIndex = 8;
            this.buttonSettings.Text = "Opzioni";
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.menuButtons_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(Search.SearchUserControl.Instance);
            this.panelContent.Controls.Add(List.ListUserControl.Instance);
            this.panelContent.Controls.Add(Download.DownloadUserControl.Instance);
            this.panelContent.Controls.Add(Settings.SettingsUserControl.Instance);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(97, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(734, 620);
            this.panelContent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(831, 620);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.tableLayoutPanelMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::YoutubeAudioDownloader2.Properties.Resources.Icon;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(750, 377);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanelMenu.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonResearch;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonList;
    }
}

