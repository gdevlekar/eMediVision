using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.IO;
using System.Data.SQLite;

namespace eMediVision
{
   public static class SQLHelper
    {
//       static SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location), "eMedivisionDB"));
       static SQLiteConnection conn = new SQLiteConnection(@"Data Source=E:\eMediVision\eMediVision\DB\eMedivisionDB");
      static  string SQL = "";

        public static SQLiteConnection CreateConnection()
       {
                conn = new SQLiteConnection(@"Data Source=E:\eMediVision\eMediVision\DB\eMedivisionDB");
           //conn.SetPassword("ganeshemedivision");
           conn.Open();
           
           return conn;

       
       }
    }
}
