using System;
using System.Collections.Generic;
using System.Text;

namespace MSFS_Livery_Importer
{

    public class AircraftList {
        public List<Aircraft> supportedlist { get; set; }
    }

    public class Aircraft
    {

        public string id { get; set; }
        public string name { get; set; }
        public string folderName { get; set; }
        public string textureDir { get; set; }

        public Aircraft(string id, string name, string folderName, string configDir) {
            this.id = id;
            this.name = name;
            this.folderName = folderName;
            this.textureDir = configDir;
        }

        public string ID {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string FolderName
        {
            get { return folderName; }
            set { folderName = value; }
        }

        public string ConfigDir
        {
            get { return textureDir; }
            set { textureDir = value; }
        }

        public string ToString() {
            return "ID: " + this.ID + " Name: " + this.Name + " FolderName: " + this.FolderName + " ConfigDir: " + this.ConfigDir;
        }
    }
}
