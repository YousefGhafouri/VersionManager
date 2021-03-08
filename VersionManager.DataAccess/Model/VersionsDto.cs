using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VersionManager.Utilities;

namespace VersionManager.Model
{
    public class VersionsDto
    {
        public int ID { get; set; }
        public string VersionCode { get; set; }
        public VersionStatus VersionStatus { get; set; } = VersionStatus.Exists;
        public string VersionName { get; set; }
        public string DllPath { get; set; }
        public string StructureScriptPath { get; set; }
        public string AlterScriptPath { get; set; }
        public string VersionDescription { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? EditionDateTime { get; set; }
        public bool IsSelect { get; set; }
        public int VersionCodeInt
        {
            get
            {
                return VersionCode.ToInteger();
            }
        }
        public string CreationDateTime_Persian
        {
            get
            {
                return CreationDateTime.ToPersianDate();
            }
        }
    }
    public enum VersionStatus
    {
        None = 0,
        Exists = 1,
        NotExists = 2,
        Error = 3
    }
}
