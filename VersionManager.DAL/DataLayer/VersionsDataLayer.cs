using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VersionManager.Objects.Entities;

namespace VersionManager.DAL.DataLayer
{
    public class VersionsDataLayer : _Base.CoreBase
    {
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "Versions_SELECTALL"
            };
            dt = ExecuteDataTable(cmd);

            return dt;
        }

        public void Insert(Versions version)
        {
            SqlCommand cmd = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "Versions_INSERT"
            };
            cmd.Parameters.AddWithValue("@VersionCode", version.VersionCode);
            cmd.Parameters.AddWithValue("@VersionName", version.VersionName);
            cmd.Parameters.AddWithValue("@DllPath", version.DllPath);
            cmd.Parameters.AddWithValue("@StructureScriptPath", version.StructureScriptPath);
            cmd.Parameters.AddWithValue("@AlterScriptPath", version.AlterScriptPath);
            cmd.Parameters.AddWithValue("@VersionDescription", version.VersionDescription);

            ExecuteNoneQuery(cmd);
        }
    }
}
