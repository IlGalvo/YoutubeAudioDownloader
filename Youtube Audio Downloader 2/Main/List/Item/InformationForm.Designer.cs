namespace YoutubeAudioDownloader2.Main.List.Item
{
    partial class InformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.groupBoxDescription = new System.Windows.Forms.GroupBox();
            this.groupBoxStatistics = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelViewsVerified = new System.Windows.Forms.Panel();
            this.labelViews = new System.Windows.Forms.Label();
            this.labelVerified = new System.Windows.Forms.Label();
            this.labelVerifiedStatic = new System.Windows.Forms.Label();
            this.labelViewsStatic = new System.Windows.Forms.Label();
            this.panelLikesDislikes = new System.Windows.Forms.Panel();
            this.labelDislikes = new System.Windows.Forms.Label();
            this.labelLikesStatic = new System.Windows.Forms.Label();
            this.labelDislikesStatic = new System.Windows.Forms.Label();
            this.labelLikes = new System.Windows.Forms.Label();
            this.linkLabelVideo = new System.Windows.Forms.LinkLabel();
            this.groupBoxDescription.SuspendLayout();
            this.groupBoxStatistics.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelViewsVerified.SuspendLayout();
            this.panelLikesDislikes.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.AutoWordSelection = true;
            this.richTextBoxDescription.BackColor = System.Drawing.Color.White;
            this.richTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDescription.Location = new System.Drawing.Point(3, 23);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ReadOnly = true;
            this.richTextBoxDescription.Size = new System.Drawing.Size(449, 287);
            this.richTextBoxDescription.TabIndex = 0;
            this.richTextBoxDescription.Text = "";
            // 
            // groupBoxDescription
            // 
            this.groupBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDescription.Controls.Add(this.richTextBoxDescription);
            this.groupBoxDescription.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDescription.Name = "groupBoxDescription";
            this.groupBoxDescription.Size = new System.Drawing.Size(455, 313);
            this.groupBoxDescription.TabIndex = 1;
            this.groupBoxDescription.TabStop = false;
            this.groupBoxDescription.Text = "Descrizione";
            // 
            // groupBoxStatistics
            // 
            this.groupBoxStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStatistics.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxStatistics.Location = new System.Drawing.Point(12, 331);
            this.groupBoxStatistics.Name = "groupBoxStatistics";
            this.groupBoxStatistics.Size = new System.Drawing.Size(452, 90);
            this.groupBoxStatistics.TabIndex = 2;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistiche";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelViewsVerified, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelLikesDislikes, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 64);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelViewsVerified
            // 
            this.panelViewsVerified.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelViewsVerified.Controls.Add(this.labelViews);
            this.panelViewsVerified.Controls.Add(this.labelVerified);
            this.panelViewsVerified.Controls.Add(this.labelVerifiedStatic);
            this.panelViewsVerified.Controls.Add(this.labelViewsStatic);
            this.panelViewsVerified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewsVerified.Location = new System.Drawing.Point(226, 3);
            this.panelViewsVerified.Name = "panelViewsVerified";
            this.panelViewsVerified.Size = new System.Drawing.Size(217, 58);
            this.panelViewsVerified.TabIndex = 2;
            // 
            // labelViews
            // 
            this.labelViews.AutoSize = true;
            this.labelViews.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViews.Location = new System.Drawing.Point(105, 8);
            this.labelViews.Name = "labelViews";
            this.labelViews.Size = new System.Drawing.Size(91, 17);
            this.labelViews.TabIndex = 7;
            this.labelViews.Text = "Visualizzazioni";
            // 
            // labelVerified
            // 
            this.labelVerified.AutoSize = true;
            this.labelVerified.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerified.Location = new System.Drawing.Point(105, 31);
            this.labelVerified.Name = "labelVerified";
            this.labelVerified.Size = new System.Drawing.Size(62, 17);
            this.labelVerified.TabIndex = 6;
            this.labelVerified.Text = "Verificato";
            // 
            // labelVerifiedStatic
            // 
            this.labelVerifiedStatic.AutoSize = true;
            this.labelVerifiedStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerifiedStatic.Location = new System.Drawing.Point(3, 31);
            this.labelVerifiedStatic.Name = "labelVerifiedStatic";
            this.labelVerifiedStatic.Size = new System.Drawing.Size(66, 17);
            this.labelVerifiedStatic.TabIndex = 5;
            this.labelVerifiedStatic.Text = "Verificato:";
            // 
            // labelViewsStatic
            // 
            this.labelViewsStatic.AutoSize = true;
            this.labelViewsStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelViewsStatic.Location = new System.Drawing.Point(3, 8);
            this.labelViewsStatic.Name = "labelViewsStatic";
            this.labelViewsStatic.Size = new System.Drawing.Size(96, 17);
            this.labelViewsStatic.TabIndex = 4;
            this.labelViewsStatic.Text = "Visualizzazioni:";
            // 
            // panelLikesDislikes
            // 
            this.panelLikesDislikes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLikesDislikes.Controls.Add(this.labelDislikes);
            this.panelLikesDislikes.Controls.Add(this.labelLikesStatic);
            this.panelLikesDislikes.Controls.Add(this.labelDislikesStatic);
            this.panelLikesDislikes.Controls.Add(this.labelLikes);
            this.panelLikesDislikes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLikesDislikes.Location = new System.Drawing.Point(3, 3);
            this.panelLikesDislikes.Name = "panelLikesDislikes";
            this.panelLikesDislikes.Size = new System.Drawing.Size(217, 58);
            this.panelLikesDislikes.TabIndex = 1;
            // 
            // labelDislikes
            // 
            this.labelDislikes.AutoSize = true;
            this.labelDislikes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDislikes.Location = new System.Drawing.Point(100, 31);
            this.labelDislikes.Name = "labelDislikes";
            this.labelDislikes.Size = new System.Drawing.Size(86, 17);
            this.labelDislikes.TabIndex = 3;
            this.labelDislikes.Text = "Non mi piace";
            // 
            // labelLikesStatic
            // 
            this.labelLikesStatic.AutoSize = true;
            this.labelLikesStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikesStatic.Location = new System.Drawing.Point(3, 8);
            this.labelLikesStatic.Name = "labelLikesStatic";
            this.labelLikesStatic.Size = new System.Drawing.Size(61, 17);
            this.labelLikesStatic.TabIndex = 0;
            this.labelLikesStatic.Text = "Mi piace:";
            // 
            // labelDislikesStatic
            // 
            this.labelDislikesStatic.AutoSize = true;
            this.labelDislikesStatic.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDislikesStatic.Location = new System.Drawing.Point(3, 31);
            this.labelDislikesStatic.Name = "labelDislikesStatic";
            this.labelDislikesStatic.Size = new System.Drawing.Size(91, 17);
            this.labelDislikesStatic.TabIndex = 1;
            this.labelDislikesStatic.Text = "Non mi piace:";
            // 
            // labelLikes
            // 
            this.labelLikes.AutoSize = true;
            this.labelLikes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikes.Location = new System.Drawing.Point(100, 8);
            this.labelLikes.Name = "labelLikes";
            this.labelLikes.Size = new System.Drawing.Size(58, 17);
            this.labelLikes.TabIndex = 2;
            this.labelLikes.Text = "Mi piace";
            // 
            // linkLabelVideo
            // 
            this.linkLabelVideo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabelVideo.AutoSize = true;
            this.linkLabelVideo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelVideo.Location = new System.Drawing.Point(70, 427);
            this.linkLabelVideo.Name = "linkLabelVideo";
            this.linkLabelVideo.Size = new System.Drawing.Size(81, 20);
            this.linkLabelVideo.TabIndex = 3;
            this.linkLabelVideo.TabStop = true;
            this.linkLabelVideo.Text = "Video Link";
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(479, 456);
            this.Controls.Add(this.linkLabelVideo);
            this.Controls.Add(this.groupBoxStatistics);
            this.Controls.Add(this.groupBoxDescription);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(495, 495);
            this.Name = "InformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformationForm";
            this.groupBoxDescription.ResumeLayout(false);
            this.groupBoxStatistics.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelViewsVerified.ResumeLayout(false);
            this.panelViewsVerified.PerformLayout();
            this.panelLikesDislikes.ResumeLayout(false);
            this.panelLikesDislikes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxDescription;
        private System.Windows.Forms.GroupBox groupBoxStatistics;
        private System.Windows.Forms.LinkLabel linkLabelVideo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelViewsVerified;
        private System.Windows.Forms.Label labelViews;
        private System.Windows.Forms.Label labelVerified;
        private System.Windows.Forms.Label labelVerifiedStatic;
        private System.Windows.Forms.Label labelViewsStatic;
        private System.Windows.Forms.Panel panelLikesDislikes;
        private System.Windows.Forms.Label labelDislikes;
        private System.Windows.Forms.Label labelLikesStatic;
        private System.Windows.Forms.Label labelDislikesStatic;
        private System.Windows.Forms.Label labelLikes;
    }
}