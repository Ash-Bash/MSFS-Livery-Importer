namespace MSFS_Livery_Importer
{
    partial class MegapackDownloader
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressValueLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.progressStateLabel = new System.Windows.Forms.Label();
            this.linkDiscord = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 73);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(601, 29);
            this.progressBar.TabIndex = 0;
            // 
            // progressValueLabel
            // 
            this.progressValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressValueLabel.AutoSize = true;
            this.progressValueLabel.Location = new System.Drawing.Point(12, 50);
            this.progressValueLabel.Name = "progressValueLabel";
            this.progressValueLabel.Size = new System.Drawing.Size(139, 20);
            this.progressValueLabel.TabIndex = 2;
            this.progressValueLabel.Text = "{PROGRESS_VALUE}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Livery Megapack Downloader";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(419, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(519, 110);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(94, 29);
            this.btnInstall.TabIndex = 1;
            this.btnInstall.Text = "Install";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // progressStateLabel
            // 
            this.progressStateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressStateLabel.AutoSize = true;
            this.progressStateLabel.Location = new System.Drawing.Point(526, 50);
            this.progressStateLabel.Name = "progressStateLabel";
            this.progressStateLabel.Size = new System.Drawing.Size(87, 20);
            this.progressStateLabel.TabIndex = 4;
            this.progressStateLabel.Text = "Download...";
            this.progressStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkDiscord
            // 
            this.linkDiscord.AutoSize = true;
            this.linkDiscord.Location = new System.Drawing.Point(553, 9);
            this.linkDiscord.Name = "linkDiscord";
            this.linkDiscord.Size = new System.Drawing.Size(60, 20);
            this.linkDiscord.TabIndex = 5;
            this.linkDiscord.TabStop = true;
            this.linkDiscord.Text = "Discord";
            this.linkDiscord.Visible = false;
            this.linkDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDiscord_LinkClicked);
            // 
            // MegapackDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 149);
            this.Controls.Add(this.linkDiscord);
            this.Controls.Add(this.progressStateLabel);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressValueLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MegapackDownloader";
            this.Text = "Megapack Downloader (Beta)";
            this.Load += new System.EventHandler(this.MegapackDownloader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressValueLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Label progressStateLabel;
        private System.Windows.Forms.LinkLabel linkDiscord;
    }
}