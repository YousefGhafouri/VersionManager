using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionManager.Utilities
{
    public static class AppConfig
    {
        public static string ConnectionString = "Server = . ; Initial Catalog = VersionManager ; User ID = sa ; Password = 123";
        public static bool UseSSL = true;
            //ConfigurationManager.ConnectionStrings["Conn1"].ConnectionString;
    }
}
