using System;
using System.Collections.Generic;
using System.Text;

namespace MSFS_Livery_Importer
{
    public class JSONModel
    {
        public class LayoutContentObject
        {
            public List<LayoutObject> content { get; set; }
        }

        public class LayoutObject
        {
            public string path { get; set; }
            public string size { get; set; }
            public string date { get; set; }
        }
    }
}
