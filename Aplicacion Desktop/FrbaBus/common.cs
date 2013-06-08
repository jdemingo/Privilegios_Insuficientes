using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace FrbaBus
{
    public class Common
    {
        private static string buildConnectionURL(string user, string passwd, string server, string db)
        {
            return "user id=" + user + ";password=" + passwd + ";server=" + server + ";database=" + db + "; ";
        }
        public static SqlConnection conectar()
        {
            //Tomar de archivo !!
            string user = "gd";
            string passwd = "gd2013";
            string server = "localhost\\SQLSERVER2008";
            string db = "GD1C2013";

            SqlConnection conn = new SqlConnection(buildConnectionURL(user, passwd, server, db));
            conn.Open();
            return conn;
        }
    }
}
