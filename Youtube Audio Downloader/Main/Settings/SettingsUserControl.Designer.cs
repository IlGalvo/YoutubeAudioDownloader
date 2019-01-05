namespace YoutubeAudioDownloader.Main.Settings
{
    partial class SettingsUserControl
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
            Settings.Save(SettingsService.SettingsPath);

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
            this.buttonRestore = new System.Windows.Forms.Button();
            this.tableLayoutPanelSettings = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.labelSilentDownloadStatic = new System.Windows.Forms.Label();
            this.toggleButtonSilentDownload = new CustomControlCollection.Buttons.ToggleButton();
            this.groupBoxDownload = new System.Windows.Forms.GroupBox();
            this.buttonDownloadPath = new System.Windows.Forms.Button();
            this.richTextBoxDownloadPath = new System.Windows.Forms.RichTextBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labelSearchResultsStatic = new System.Windows.Forms.Label();
            this.numericUpDownSearchResults = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialogPath = new System.Windows.Forms.FolderBrowserDialog();
            this.panelActionOffset.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.tableLayoutPanelSettings.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            this.groupBoxDownload.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSearchResults)).BeginInit();
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
            this.panelActionOffset.TabIndex = 10;
            // 
            // panelAction
            // 
            this.panelAction.BackColor = System.Drawing.Color.SeaGreen;
            this.panelAction.Controls.Add(this.buttonRestore);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAction.Location = new System.Drawing.Point(0, 10);
            this.panelAction.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(734, 53);
            this.panelAction.TabIndex = 11;
            // 
            // buttonRestore
            // 
            this.buttonRestore.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRestore.BackColor = System.Drawing.Color.Honeydew;
            this.buttonRestore.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.buttonRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestore.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonRestore.Location = new System.Drawing.Point(293, 7);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(148, 40);
            this.buttonRestore.TabIndex = 12;
            this.buttonRestore.Text = "Ripristina";
            this.buttonRestore.UseVisualStyleBackColor = false;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // tableLayoutPanelSettings
            // 
            this.tableLayoutPanelSettings.ColumnCount = 1;
            this.tableLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSettings.Controls.Add(this.groupBoxGeneral, 0, 2);
            this.tableLayoutPanelSettings.Controls.Add(this.groupBoxDownload, 0, 1);
            this.tableLayoutPanelSettings.Controls.Add(this.groupBoxSearch, 0, 0);
            this.tableLayoutPanelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSettings.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelSettings.Name = "tableLayoutPanelSettings";
            this.tableLayoutPanelSettings.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanelSettings.RowCount = 3;
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelSettings.Size = new System.Drawing.Size(734, 557);
            this.tableLayoutPanelSettings.TabIndex = 0;
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.labelSilentDownloadStatic);
            this.groupBoxGeneral.Controls.Add(this.toggleButtonSilentDownload);
            this.groupBoxGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGeneral.Location = new System.Drawing.Point(9, 371);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(716, 177);
            this.groupBoxGeneral.TabIndex = 7;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "Generale";
            // 
            // labelSilentDownloadStatic
            // 
            this.labelSilentDownloadStatic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSilentDownloadStatic.AutoSize = true;
            this.labelSilentDownloadStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSilentDownloadStatic.Location = new System.Drawing.Point(5, 81);
            this.labelSilentDownloadStatic.Name = "labelSilentDownloadStatic";
            this.labelSilentDownloadStatic.Size = new System.Drawing.Size(248, 25);
            this.labelSilentDownloadStatic.TabIndex = 8;
            this.labelSilentDownloadStatic.Text = "Attiva download silenzioso:";
            // 
            // toggleButtonSilentDownload
            // 
            this.toggleButtonSilentDownload.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.toggleButtonSilentDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toggleButtonSilentDownload.Location = new System.Drawing.Point(660, 81);
            this.toggleButtonSilentDownload.Name = "toggleButtonSilentDownload";
            this.toggleButtonSilentDownload.OffColor = System.Drawing.Color.Red;
            this.toggleButtonSilentDownload.OnColor = System.Drawing.Color.DodgerBlue;
            this.toggleButtonSilentDownload.Size = new System.Drawing.Size(50, 25);
            this.toggleButtonSilentDownload.TabIndex = 9;
            this.toggleButtonSilentDownload.ToggleColor = System.Drawing.Color.White;
            this.toggleButtonSilentDownload.ToggleState = false;
            this.toggleButtonSilentDownload.ToggleChanged += new CustomControlCollection.Buttons.ToggleButton.ToggledChangedEventHandler(this.toggleButtonSilentDownload_ToggleChanged);
            // 
            // groupBoxDownload
            // 
            this.groupBoxDownload.Controls.Add(this.buttonDownloadPath);
            this.groupBoxDownload.Controls.Add(this.richTextBoxDownloadPath);
            this.groupBoxDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDownload.Location = new System.Drawing.Point(9, 190);
            this.groupBoxDownload.Name = "groupBoxDownload";
            this.groupBoxDownload.Size = new System.Drawing.Size(716, 175);
            this.groupBoxDownload.TabIndex = 4;
            this.groupBoxDownload.TabStop = false;
            this.groupBoxDownload.Text = "Download";
            // 
            // buttonDownloadPath
            // 
            this.buttonDownloadPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonDownloadPath.BackColor = System.Drawing.Color.Honeydew;
            this.buttonDownloadPath.FlatAppearance.BorderColor = System.Drawing.Color.SpringGreen;
            this.buttonDownloadPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.buttonDownloadPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.buttonDownloadPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadPath.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadPath.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonDownloadPath.Location = new System.Drawing.Point(660, 74);
            this.buttonDownloadPath.Name = "buttonDownloadPath";
            this.buttonDownloadPath.Size = new System.Drawing.Size(50, 35);
            this.buttonDownloadPath.TabIndex = 6;
            this.buttonDownloadPath.Text = ". . .";
            this.buttonDownloadPath.UseVisualStyleBackColor = false;
            this.buttonDownloadPath.Click += new System.EventHandler(this.buttonDownloadPath_Click);
            // 
            // richTextBoxDownloadPath
            // 
            this.richTextBoxDownloadPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDownloadPath.BackColor = System.Drawing.Color.White;
            this.richTextBoxDownloadPath.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDownloadPath.Location = new System.Drawing.Point(10, 74);
            this.richTextBoxDownloadPath.Multiline = false;
            this.richTextBoxDownloadPath.Name = "richTextBoxDownloadPath";
            this.richTextBoxDownloadPath.ReadOnly = true;
            this.richTextBoxDownloadPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBoxDownloadPath.Size = new System.Drawing.Size(652, 36);
            this.richTextBoxDownloadPath.TabIndex = 5;
            this.richTextBoxDownloadPath.Text = "C:\\Users\\Andre\\Music";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.labelSearchResultsStatic);
            this.groupBoxSearch.Controls.Add(this.numericUpDownSearchResults);
            this.groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSearch.Location = new System.Drawing.Point(9, 9);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(716, 175);
            this.groupBoxSearch.TabIndex = 1;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Ricerca";
            // 
            // labelSearchResultsStatic
            // 
            this.labelSearchResultsStatic.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSearchResultsStatic.AutoSize = true;
            this.labelSearchResultsStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchResultsStatic.Location = new System.Drawing.Point(5, 81);
            this.labelSearchResultsStatic.Name = "labelSearchResultsStatic";
            this.labelSearchResultsStatic.Size = new System.Drawing.Size(286, 25);
            this.labelSearchResultsStatic.TabIndex = 2;
            this.labelSearchResultsStatic.Text = "Numero risultati ricerca (1 - 20):";
            // 
            // numericUpDownSearchResults
            // 
            this.numericUpDownSearchResults.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownSearchResults.BackColor = System.Drawing.Color.White;
            this.numericUpDownSearchResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSearchResults.Location = new System.Drawing.Point(660, 77);
            this.numericUpDownSearchResults.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownSearchResults.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSearchResults.Name = "numericUpDownSearchResults";
            this.numericUpDownSearchResults.ReadOnly = true;
            this.numericUpDownSearchResults.Size = new System.Drawing.Size(50, 29);
            this.numericUpDownSearchResults.TabIndex = 3;
            this.numericUpDownSearchResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownSearchResults.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSearchResults.ValueChanged += new System.EventHandler(this.numericUpDownSearchResults_ValueChanged);
            // 
            // SettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelSettings);
            this.Controls.Add(this.panelActionOffset);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SettingsUserControl";
            this.Size = new System.Drawing.Size(734, 620);
            this.panelActionOffset.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.tableLayoutPanelSettings.ResumeLayout(false);
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            this.groupBoxDownload.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSearchResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelActionOffset;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.NumericUpDown numericUpDownSearchResults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSettings;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private CustomControlCollection.Buttons.ToggleButton toggleButtonSilentDownload;
        private System.Windows.Forms.GroupBox groupBoxDownload;
        private System.Windows.Forms.Button buttonDownloadPath;
        private System.Windows.Forms.RichTextBox richTextBoxDownloadPath;
        private System.Windows.Forms.Label labelSearchResultsStatic;
        private System.Windows.Forms.Label labelSilentDownloadStatic;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPath;
    }
}
