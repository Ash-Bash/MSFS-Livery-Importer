using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using static MSFS_Livery_Importer.JSONModel;

namespace MSFS_Livery_Importer
{
    public partial class MSFSLiveryImporterForm : Form
    {

        // Variables
        private List<Aircraft> aircraftList = new List<Aircraft>();
        private string liveryPath = "";
        private string contentPath = "";
        private bool hasGameInstalled = false;
        private bool hasMSVersionInstalled = false;
        private bool hasSteamVersionInstalled = false;
        private bool isSteamInstall = false;
        private bool hasMegapackInstalled = false;
        private bool isCustomContentPath = false;

        // Possible ContentPath Strings
        private string msInstallPath = "";
        private string stFirstInstallPath = "";
        private string stSecondInstallPath = "";
        private string stThirdInstallPath = "";
        private string stForthInstallPath = "";
        private string stFifthInstallPath = "";

        public MSFSLiveryImporterForm()
        {
            InitializeComponent();

            LoadConfigs();
        }

        private void InitialSetup() {
            var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var appDir = Path.Combine(localAppData, "MSFS Livery Importer");
            var appCacheDir = Path.Combine(appDir, "Cache");

            if (!Directory.Exists(appDir)) {
                Directory.CreateDirectory(appDir);

                if (!Directory.Exists(appCacheDir)) {
                    Directory.CreateDirectory(appCacheDir);
                }
            }
        }

        private void LoadConfigs() {

            progressValueLabel.Text = "0%";

            GetPossiblePaths();
            CheckIfInstalled();
            CheckIfMagapackInstalled();
            LoadContentPath();
            LoadAircraft();

            InitialSetup();
        }

        private void LoadAircraft() {
            aircraftList.Add(new Aircraft("a320neo", "Airbus A320neo", "liveries-a320"));
            //aircraftList.Add(new Aircraft("apsS2S", "Aviat Pitts Special S2S", "liveries-pitts"));
            aircraftList.Add(new Aircraft("b747-8", "Boeing 747 - 8 Intercontinental", "liveries-747"));
            aircraftList.Add(new Aircraft("ccxc", "CubCrafters XCub", "liveries-xcub"));
            aircraftList.Add(new Aircraft("tbm930", "Daher TBM 930", "liveries-tbm930"));
            //aircraftList.Add(new Aircraft("da62", "Diamond DA62", "liveries-da62"));
            aircraftList.Add(new Aircraft("da62ng", "Diamond DA40 NG", "liveries-da40ng"));
            aircraftList.Add(new Aircraft("330lt", "EXTRA 330LT", "liveries-e330"));
            //aircraftList.Add(new Aircraft("fdctls", "Flight Design CTLS", "liveries-flightdesignct"));
            aircraftList.Add(new Aircraft("icona5", "ICON A5", "liveries-a5"));
            //aircraftList.Add(new Aircraft("jvl3", "JMB VL-3", "liveries-vl3"));
            //aircraftList.Add(new Aircraft("rcap10", "Robin CAP 10", "liveries-cap10c"));
            //aircraftList.Add(new Aircraft("rdr400-100c", "Robin DR400-100 Cadet", "liveries-dr400"));
            //aircraftList.Add(new Aircraft("bcg36", "Beechcraft Bonanza G36", "liveries-bronanza-g36"));
            //aircraftList.Add(new Aircraft("bc350i", "Beechcraft King Air 350i", "liveries-kingair350"));
            //aircraftList.Add(new Aircraft("c152", "Cessna 152", ""));
            aircraftList.Add(new Aircraft("c172sg1", "Cessna 172 Skyhawk (G1000)", "liveries-c172-as1000"));
            aircraftList.Add(new Aircraft("c208bgcex", "Cessna 208 B Grand Caravan EX", "liveries-cessna208b"));
            aircraftList.Add(new Aircraft("cccj4", "Cessna Citation CJ4", "liveries-cj4"));
            aircraftList.Add(new Aircraft("zsc", "Zlin Savage Cub", "liveries-savagecub"));
            //aircraftList.Add(new Aircraft("dda40tdi", "Diamond DA40-TDI", ""));
            //aircraftList.Add(new Aircraft("ddv20", "Diamond DV20", ""));
            //aircraftList.Add(new Aircraft("bcbg58", "Beechcraft Baron G58", ""));
            //aircraftList.Add(new Aircraft("c152a", "Cessna 152 Aerobat", ""));
            //aircraftList.Add(new Aircraft("c172s", "Cessna 172 Skyhawk", ""));
            //aircraftList.Add(new Aircraft("b78710d", "Boeing 787-10 Dreamliner", ""));
            //aircraftList.Add(new Aircraft("csr22", "Cirrus SR22", ""));
            //aircraftList.Add(new Aircraft("pvsw121", "Pipistrel Virus SW 121", ""));
            //aircraftList.Add(new Aircraft("ccl", "Cessna Citation Longitude", ""));
            //aircraftList.Add(new Aircraft("zsu", "Zlin Shock Ultra", ""));

           Debug.WriteLine(aircraftList.Count);
        }

        private void GetPossiblePaths() {
            msInstallPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Packages\Microsoft.FlightSimulator_8wekyb3d8bbwe\LocalCache\Packages\Community";
            stFirstInstallPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Microsoft Flight Simulator\Packages\Community";
            stSecondInstallPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft Flight Simulator\Packages\Community";
            stThirdInstallPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Packages\Microsoft Flight Simulator\Packages\Community";
            stForthInstallPath = @"C:\Program Files (x86)\Steam\steamapps\common\Microsoft Flight Simulator\Packages\Community";
            stFifthInstallPath = @"C:\Program Files (x86)\Steam\steamapps\common\Community";
        }

        private void CheckIfInstalled() {
            hasGameInstalled = Directory.Exists(msInstallPath)
                || Directory.Exists(stFirstInstallPath)
                || Directory.Exists(stSecondInstallPath)
                || Directory.Exists(stThirdInstallPath)
                || Directory.Exists(stForthInstallPath)
                || Directory.Exists(stFifthInstallPath);
            hasMSVersionInstalled = Directory.Exists(msInstallPath);
            hasSteamVersionInstalled = Directory.Exists(stFirstInstallPath)
                || Directory.Exists(stSecondInstallPath)
                || Directory.Exists(stThirdInstallPath)
                || Directory.Exists(stForthInstallPath)
                || Directory.Exists(stFifthInstallPath);

            if (hasSteamVersionInstalled)
            {
                isSteamVersionCheckBox.Enabled = true;
            }
            else {
                isSteamVersionCheckBox.Enabled = false;
            }

            Debug.WriteLine("Has Game Installed: " + hasGameInstalled);
            Debug.WriteLine("MS Version Installed: " + hasMSVersionInstalled);
            Debug.WriteLine("Steam Version Installed: " + hasSteamVersionInstalled);
        }

        public void CheckIfMagapackInstalled() {
            if (hasGameInstalled)
            {
                var steamPath = GetSteamContentPath();
                if (hasMSVersionInstalled && !hasSteamVersionInstalled)
                {
                    string[] contentDirs = Directory.GetDirectories(msInstallPath);
                    if (contentDirs.Length > 0)
                    {
                        foreach (string dir in contentDirs)
                        {
                            if (dir.Contains("liveries-"))
                            {
                                hasMegapackInstalled = true;
                            }
                        }
                    }
                    else
                    {
                        hasMegapackInstalled = false;
                    }
                }
                else if (hasMSVersionInstalled && hasSteamVersionInstalled)
                {
                    if (isSteamInstall)
                    {
                        string[] contentDirs = Directory.GetDirectories(steamPath);
                        if (contentDirs.Length > 0)
                        {
                            foreach (string dir in contentDirs)
                            {
                                if (dir.Contains("liveries-"))
                                {
                                    hasMegapackInstalled = true;
                                }
                            }
                        }
                        else
                        {
                            hasMegapackInstalled = false;
                        }
                    }
                    else
                    {
                        string[] contentDirs = Directory.GetDirectories(msInstallPath);
                        if (contentDirs.Length > 0)
                        {
                            foreach (string dir in contentDirs)
                            {
                                if (dir.Contains("liveries-"))
                                {
                                    hasMegapackInstalled = true;
                                }
                            }
                        }
                        else
                        {
                            hasMegapackInstalled = false;
                        }

                    }
                }
                else if (!hasMSVersionInstalled && hasSteamVersionInstalled)
                {
                    string[] contentDirs = Directory.GetDirectories(steamPath);
                    if (contentDirs.Length > 0)
                    {
                        foreach (string dir in contentDirs)
                        {
                            if (dir.Contains("liveries-"))
                            {
                                hasMegapackInstalled = true;
                            }
                        }
                    }
                    else
                    {
                        hasMegapackInstalled = false;
                    }
                }
            }

            if (isCustomContentPath)
            {
                if (contentPath != "")
                {
                    if (Directory.Exists(contentPath))
                    {
                        string[] contentDirs = Directory.GetDirectories(contentPath);
                        if (contentDirs.Length > 0)
                        {
                            foreach (string dir in contentDirs)
                            {
                                if (dir.Contains("liveries-"))
                                {
                                    hasMegapackInstalled = true;
                                }
                            }
                        }
                        else
                        {
                            hasMegapackInstalled = false;
                        }
                    }
                }
            }

            if (hasMegapackInstalled)
            {
                btnImport.Enabled = true;
                btnInstallMegapack.Enabled = false;
            }
            else {
                btnImport.Enabled = false;
                btnInstallMegapack.Enabled = true;
            }
        }

        private string GetSteamContentPath() {
            string value = "";

            if (Directory.Exists(stFirstInstallPath))
            {
                value = stFirstInstallPath;
            }

            if (Directory.Exists(stSecondInstallPath))
            {
                value = stSecondInstallPath;
            }

            if (Directory.Exists(stThirdInstallPath))
            {
                value = stThirdInstallPath;
            }

            if (Directory.Exists(stForthInstallPath))
            {
               value = stForthInstallPath;
            }

            if (Directory.Exists(stFifthInstallPath))
            {
                value = stFifthInstallPath;
            }

            return value;
        }

        private void LoadContentPath() {

            if (hasGameInstalled)
            {
                if (hasMSVersionInstalled && !hasSteamVersionInstalled)
                {
                    contentPath = msInstallPath;
                }
                else if (hasMSVersionInstalled && hasSteamVersionInstalled) {
                    if (isSteamInstall)
                    {
                        contentPath = GetSteamContentPath();
                    }
                    else {
                        contentPath = msInstallPath;
                    }
                }
            }
            else {
                contentPath = GetSteamContentPath();
            }
        }

        private void ImportLivery() {

            UpdateLayoutJsonFile();
        }

        private void UpdateLayoutJsonFile() {
            JsonSerializer serializer = new JsonSerializer();
            var aircraftFolderName = aircraftList.ToArray()[aircraftTypeComboBox.SelectedIndex].FolderName;
            var path = Path.Combine(contentPath, Path.Combine(aircraftFolderName, "layout.json"));
            var sourceJsonContent = File.ReadAllText(path);
            LayoutContentObject sourceContentObject = JsonConvert.DeserializeObject<LayoutContentObject>(sourceJsonContent);

            Debug.WriteLine(sourceJsonContent);
            Debug.WriteLine("Test Data: " + sourceContentObject.content[3].path);


            var liveryLayoutPath = Path.Combine(liveryPath, "layout.json");
            var liveryJsonContent = File.ReadAllText(liveryLayoutPath);
            LayoutContentObject liveryContentObject = JsonConvert.DeserializeObject<LayoutContentObject>(liveryJsonContent);

            Debug.WriteLine(liveryJsonContent);
            Debug.WriteLine("Test Data: " + liveryContentObject.content[3].path);

            foreach (LayoutObject item in liveryContentObject.content)
            {
                sourceContentObject.content.Add(item);
            }

            var outputJsonContent = JsonConvert.SerializeObject(sourceContentObject, Formatting.Indented);

            File.WriteAllText(path, outputJsonContent);
            Debug.WriteLine(path);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Debug.WriteLine("Form1 Loaded");

            aircraftTypeComboBox.DisplayMember = "Name";
            aircraftTypeComboBox.ValueMember = "ID";

            //aircraftTypeComboBox.Items.AddRange((object[])aircraftList.ToArray());

            foreach (Aircraft aircraft in aircraftList)
            {
                aircraftTypeComboBox.Items.Add(aircraft);
                Debug.WriteLine(aircraft.ToString());
            }

            aircraftTypeComboBox.SelectedIndex = 0;
            contentPathComboBox.Text = contentPath;
        }

        private void btnLiveryPathBrowse_Click(object sender, EventArgs e)
        {
            if (liveryPathBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(liveryPathBrowserDialog.SelectedPath))
                {
                    this.liveryPath = liveryPathBrowserDialog.SelectedPath;
                    this.liveryPathComboBox.Text = this.liveryPath;
                }
            }
        }

        private void btnContentPathBrowse_Click(object sender, EventArgs e)
        {
            contentPathBrowserDialog.SelectedPath = this.contentPath;

            if (contentPathBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(contentPathBrowserDialog.SelectedPath))
                {
                    this.contentPath = contentPathBrowserDialog.SelectedPath;
                    this.contentPathComboBox.Text = this.contentPath;
                    this.isCustomContentPath = true;
                    CheckIfMagapackInstalled();
                }
            }
        }

        private void btnResetContentPath_Click(object sender, EventArgs e)
        {
            this.isCustomContentPath = false;
            CheckIfMagapackInstalled();
            this.LoadContentPath();
            contentPathComboBox.Text = contentPath;
        }

        private void isSteamVersionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            isSteamInstall = checkbox.Checked;
            LoadContentPath();
        }

        private void btnInstallMegapack_Click(object sender, EventArgs e)
        {

            MegapackDownloader downloaderView = new MegapackDownloader(contentPathComboBox.Text, this);
            downloaderView.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportLivery();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
