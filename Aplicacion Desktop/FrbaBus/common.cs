using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public static string fechaSQL(DateTimePicker dtp)
        {
            return String.Format("{0:yyyy-dd-MM}", dtp.Value);
        }
        public static string fechaytiempoSQL(DateTimePicker dtp)
        {
            return String.Format("{0:yyyy-dd-MM HH:mm:ss.000}", dtp.Value);
        }
        public static string fechaFuncionSQL(DateTimePicker dtp)
        {
            return String.Format("{0:yyyy-MM-dd}", dtp.Value);
        }
        public static string fechaytiempoFuncionSQL(DateTimePicker dtp)
        {
            return String.Format("{0:yyyy-MM-dd HH:mm:ss.000}", dtp.Value);
        }


        public static string tiempoSQL(DateTimePicker dtp)
        {
            return String.Format("{0:HH:mm:ss.000}", dtp.Value);
        }

    }
}
