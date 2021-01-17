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
        public static string ConnectionString = "Server = behinafzarco.com ; Initial Catalog = behinaf1_VersionManager ; User ID = behinaf1_behinaf1 ; Password = 4aiI32gVi!H0D!;";
        public static bool UseSSL = true;
            //ConfigurationManager.ConnectionStrings["Conn1"].ConnectionString;
    }
}
