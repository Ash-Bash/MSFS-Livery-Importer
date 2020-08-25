using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSFS_Livery_Importer
{
    public partial class MegapackDownloader : Form
    {

        // Variables
        public string contentPath = "";
        public MSFSLiveryImporterForm form1;
        private bool isInstalling = false;
        private bool isCompleted = false;
        private int progressValue = 0;

        public MegapackDownloader(string path, MSFSLiveryImporterForm form1)
        {
            InitializeComponent();
            this.contentPath = path;
            this.form1 = form1;
        }

        private void MegapackDownloader_Load(object sender, EventArgs e)
        {
            progressValueLabel.Text = "0%";
            progressStateLabel.Text = "";
            //progressValueLabel.Text = contentPath;
        }

        private async Task downloadMegapackAsync() {

            var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var appDir = Path.Combine(localAppData, "MSFS Livery Importer");
            var appCacheDir = Path.Combine(appDir, "Cache");

            WebClient wc = new WebClient();
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
            wc.DownloadFileAsync(new Uri("http://download2343.mediafire.com/dge6lqq3zmfg/xst0szzl9z3o7za/liveriesmegapack.zip"), appCacheDir + @"\liveriesmegapack.zip");
        }

        private void installMegapackAsync() {

            progressStateLabel.Text = "Installing...";

            var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var appDir = Path.Combine(localAppData, "MSFS Livery Importer");
            var appCacheDir = Path.Combine(appDir, "Cache");

            using (ZipArchive archive = ZipFile.OpenRead(appCacheDir + @"\liveriesmegapack.zip"))
            {

                int percentage = 0;
                int dirIndex = 0;
                foreach (ZipArchiveEntry entry in archive.Entries)
                {

                    var root = "liveriesmegapack/";
                    var newName = entry.FullName.Substring(root.Length);
                    string path = Path.Combine(contentPath, newName);

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(path));
                        Debug.WriteLine("Directory Created: " + path);
                    }

                    if (Path.HasExtension(path))
                    {
                        entry.ExtractToFile(path, true);
                    }

                    dirIndex++;
                    percentage = (dirIndex / archive.Entries.Count) * 100;
                    progressValue = progressValue + (percentage / 2);
                    progressValueLabel.Text = progressValue.ToString() + "%";
                    progressBar.Value = progressValue;
                    isInstalling = percentage == 100 ? false : true;
                    isCompleted = !isInstalling;

                    if (isCompleted) {
                        btnInstall.Enabled = true;
                        btnCancel.Enabled = false;
                        btnInstall.Text = "Finnish";
                        form1.CheckIfMagapackInstalled();
                    }
                }

            }
        }

        public void wc_DownloadProgressChanged(Object sender, DownloadProgressChangedEventArgs e)
        {
            progressStateLabel.Text = "Downloading...";
            progressValue = e.ProgressPercentage / 2;
            progressBar.Value = progressValue;
            progressValueLabel.Text = progressValue.ToString() + "%";
        }

        public void wc_DownloadFileCompleted(Object sender, AsyncCompletedEventArgs e)
        {

            if (e.Error != null)
                return;

            progressStateLabel.Text = "Installing...";
            installMegapackAsync();
        }

        private async void btnInstall_Click(object sender, EventArgs e)
        {
            if (!isCompleted)
            {
                isInstalling = true;
                await downloadMegapackAsync();
                btnInstall.Enabled = false;
            }
            else {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
