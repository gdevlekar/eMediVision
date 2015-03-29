using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace eMediVision
{
   public static class SQLHelper
    {
     
       static SqlConnection conn = new SqlConnection(@"Server=BUNTY-PC\MSSQLSERVERR2;Database=EmediCure;User Id=sa;Password=pass@word1");
      static  string SQL = "";

      public static SqlConnection CreateConnection()
       {
           //conn = new SqlConnection(@"Data Source=E:\eMediVision\eMediVision\DB\eMedivisionDB");
           //conn.SetPassword("ganeshemedivision");

           if (conn.State==ConnectionState.Open)
           {
               
           }
           else
           {
               conn = new SqlConnection(@"Server=BUNTY-PC\MSSQLSERVERR2;Database=EmediCure;User Id=sa;Password=pass@word1");
               conn.Open();
           }
           
           return conn;

       
       }
    }
}
