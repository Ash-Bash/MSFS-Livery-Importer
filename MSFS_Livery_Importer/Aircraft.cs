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

        public Aircraft(string id, string name, string folderName) {
            this._Id = id;
            this._name = name;
            this._folderName = folderName;
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

        public string ToString() {
            return "ID: " + this.ID + " Name: " + this.Name + " FolderName: " + this.FolderName;
        }
    }
}
