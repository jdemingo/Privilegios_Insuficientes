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
        public static SqlConnection globalConn;
        private static string user = "", bd = "", server = "", pass = "";
        public static string fecha = "";
        //public static string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        public static string path = Application.StartupPath;

        public static void iniciarConexionGlobal()
        {
            globalConn = conectar();
        }

        private static string buildConnectionURL(string user, string passwd, string server, string db)
        {
            return "user id=" + user + ";password=" + passwd + ";server=" + server + ";database=" + db + "; ";
        }

        private static void obtenerDatosfile()
        {
            int counter = 0;
            string line;
            //string user = "", bd = "", server = "", fecha = "", pass = "";
            // Read the file and display it line by line.
            string pathConfig = path+"\\config.txt";
            System.IO.StreamReader file =
                new System.IO.StreamReader(@pathConfig);
            while ((line = file.ReadLine()) != null)
            {
                string[] word = line.Split(':');
                switch (counter)
                {
                    case 0:
                        user = word[1];
                        break;
                    case 1:
                        bd = word[1];
                        break;
                    case 2:
                        server = word[1];
                        break;
                    case 3:
                        pass = word[1];
                        break;
                    case 4:
                        fecha = word[1];
                        break;
                }
                counter++;
            }
            file.Close();
            //MessageBox.Show("Usuario:" + user + " Bd:" + bd + " Server:" + server + " Pass:" + pass + " Fecha:" + fecha);
        }


        public static SqlConnection conectar()
        {
            //Tomar de archivo !!
            //string user = "gd";
            //string pass = "gd2013";
            //string server = "localhost\\SQLSERVER2008";
            //string bd = "GD1C2013";

            obtenerDatosfile();

            SqlConnection conn = null;
            try
            {
                //MessageBox.Show("info: "+user + " " + pass + " " + server + " " + bd);
                //MessageBox.Show("info: " + Common.user + " " + Common.pass + " " + Common.server + " " + Common.bd);
                conn = new SqlConnection(buildConnectionURL(user, pass, server, bd)); 
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
