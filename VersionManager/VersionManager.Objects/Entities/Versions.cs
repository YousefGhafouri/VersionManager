using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionManager.Objects.Entities
{
    public class Versions
    {
        public int ID { get; set; }
        public string VersionCode { get; set; }
        public string VersionName { get; set; }
        public string DllPath { get; set; }
        public string StructureScriptPath { get; set; }
        public string AlterScriptPath { get; set; }
        public string VersionDescription { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? EditionDate { get; set; }

    }
}
