namespace MSFS_Livery_Importer
{
    partial class MSFSLiveryImporterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSFSLiveryImporterForm));
            this.btnLiveryPathBrowse = new System.Windows.Forms.Button();
            this.liveryPathComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aircraftTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnImport = new System.Windows.Forms.Button();
            this.progressValueLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResetContentPath = new System.Windows.Forms.Button();
            this.isSteamVersionCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contentPathComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnContentPathBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInstallMegapack = new System.Windows.Forms.Button();
            this.liveryPathBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.contentPathBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLiveryPathBrowse
            // 
            this.btnLiveryPathBrowse.Location = new System.Drawing.Point(676, 55);
            this.btnLiveryPathBrowse.Name = "btnLiveryPathBrowse";
            this.btnLiveryPathBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnLiveryPathBrowse.TabIndex = 1;
            this.btnLiveryPathBrowse.Text = "Browse";
            this.btnLiveryPathBrowse.UseVisualStyleBackColor = true;
            this.btnLiveryPathBrowse.Click += new System.EventHandler(this.btnLiveryPathBrowse_Click);
            // 
            // liveryPathComboBox
            // 
            this.liveryPathComboBox.FormattingEnabled = true;
            this.liveryPathComboBox.Location = new System.Drawing.Point(6, 56);
            this.liveryPathComboBox.Name = "liveryPathComboBox";
            this.liveryPathComboBox.Size = new System.Drawing.Size(664, 28);
            this.liveryPathComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Root Livery Path";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // aircraftTypeComboBox
            // 
            this.aircraftTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aircraftTypeComboBox.FormattingEnabled = true;
            this.aircraftTypeComboBox.Location = new System.Drawing.Point(6, 128);
            this.aircraftTypeComboBox.Name = "aircraftTypeComboBox";
            this.aircraftTypeComboBox.Size = new System.Drawing.Size(764, 28);
            this.aircraftTypeComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Aircraft Type";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 441);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 29);
            this.progressBar1.TabIndex = 6;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(694, 476);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(94, 29);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // progressValueLabel
            // 
            this.progressValueLabel.AutoSize = true;
            this.progressValueLabel.Location = new System.Drawing.Point(12, 418);
            this.progressValueLabel.Name = "progressValueLabel";
            this.progressValueLabel.Size = new System.Drawing.Size(135, 20);
            this.progressValueLabel.TabIndex = 8;
            this.progressValueLabel.Text = "{Loading_Progress}";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.liveryPathComboBox);
            this.groupBox1.Controls.Add(this.btnLiveryPathBrowse);
            this.groupBox1.Controls.Add(this.aircraftTypeComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 179);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livery Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnResetContentPath);
            this.groupBox2.Controls.Add(this.isSteamVersionCheckBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.contentPathComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnContentPathBrowse);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 141);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GameData Information";
            // 
            // btnResetContentPath
            // 
            this.btnResetContentPath.Location = new System.Drawing.Point(676, 106);
            this.btnResetContentPath.Name = "btnResetContentPath";
            this.btnResetContentPath.Size = new System.Drawing.Size(94, 29);
            this.btnResetContentPath.TabIndex = 6;
            this.btnResetContentPath.Text = "Reset Path";
            this.btnResetContentPath.UseVisualStyleBackColor = true;
            this.btnResetContentPath.Click += new System.EventHandler(this.btnResetContentPath_Click);
            // 
            // isSteamVersionCheckBox
            // 
            this.isSteamVersionCheckBox.AutoSize = true;
            this.isSteamVersionCheckBox.Location = new System.Drawing.Point(6, 111);
            this.isSteamVersionCheckBox.Name = "isSteamVersionCheckBox";
            this.isSteamVersionCheckBox.Size = new System.Drawing.Size(139, 24);
            this.isSteamVersionCheckBox.TabIndex = 5;
            this.isSteamVersionCheckBox.Text = "Is Steam Version";
            this.isSteamVersionCheckBox.UseVisualStyleBackColor = true;
            this.isSteamVersionCheckBox.CheckedChanged += new System.EventHandler(this.isSteamVersionCheckBox_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "(Change Content Path if Game Content is stored elsewhere)";
            // 
            // contentPathComboBox
            // 
            this.contentPathComboBox.FormattingEnabled = true;
            this.contentPathComboBox.Location = new System.Drawing.Point(6, 46);
            this.contentPathComboBox.Name = "contentPathComboBox";
            this.contentPathComboBox.Size = new System.Drawing.Size(664, 28);
            this.contentPathComboBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Community Path";
            // 
            // btnContentPathBrowse
            // 
            this.btnContentPathBrowse.Location = new System.Drawing.Point(676, 45);
            this.btnContentPathBrowse.Name = "btnContentPathBrowse";
            this.btnContentPathBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnContentPathBrowse.TabIndex = 1;
            this.btnContentPathBrowse.Text = "Browse";
            this.btnContentPathBrowse.UseVisualStyleBackColor = true;
            this.btnContentPathBrowse.Click += new System.EventHandler(this.btnContentPathBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 41);
            this.label5.TabIndex = 11;
            this.label5.Text = "MSFS Livery Importer";
            // 
            // btnInstallMegapack
            // 
            this.btnInstallMegapack.Location = new System.Drawing.Point(543, 476);
            this.btnInstallMegapack.Name = "btnInstallMegapack";
            this.btnInstallMegapack.Size = new System.Drawing.Size(145, 29);
            this.btnInstallMegapack.TabIndex = 12;
            this.btnInstallMegapack.Text = "Install MagaPack";
            this.btnInstallMegapack.UseVisualStyleBackColor = true;
            this.btnInstallMegapack.Click += new System.EventHandler(this.btnInstallMegapack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(663, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // MSFSLiveryImporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInstallMegapack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressValueLabel);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MSFSLiveryImporterForm";
            this.Text = "MSFS Livery Importer - v0.1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLiveryPathBrowse;
        private System.Windows.Forms.ComboBox liveryPathComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox aircraftTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label progressValueLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox contentPathComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnContentPathBrowse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox isSteamVersionCheckBox;
        private System.Windows.Forms.Button btnInstallMegapack;
        private System.Windows.Forms.FolderBrowserDialog liveryPathBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog contentPathBrowserDialog;
        private System.Windows.Forms.Button btnResetContentPath;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

