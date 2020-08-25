using System;
using System.Collections.Generic;
using System.Text;

namespace MSFS_Livery_Importer
{
    public class Aircraft
    {
        public string _Id;
        public string _name;
        public string _folderName;
        public string _configDir;

        public Aircraft(string id, string name, string folderName, string configDir) {
            this._Id = id;
            this._name = name;
            this._folderName = folderName;
            this._configDir = configDir;
        }

        public string ID {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string FolderName
        {
            get { return _folderName; }
            set { _folderName = value; }
        }

        public string ConfigDir
        {
            get { return _configDir; }
            set { _configDir = value; }
        }

        public string ToString() {
            return "ID: " + this.ID + " Name: " + this.Name + " FolderName: " + this.FolderName + " ConfigDir: " + this.ConfigDir;
        }
    }
}
