using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaBus
{
    public partial class frmMicroDistri : Form
    {
        public frmMicroDistri()
        {
            InitializeComponent();
        }
        DataTable tabla;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        int controlOpe = 0;
        SqlConnection conn = Common.conectar();


        private void llenarCombo(System.Windows.Forms.ComboBox combo, string tablaorigen, string campo, string id)
        {
            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "select " + id + "," + campo + " from " + tablaorigen;
                    cmd = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    tabla = new DataTable();
                    adapter.Fill(tabla);
                    combo.DisplayMember = campo;
                    combo.ValueMember = id;
                    combo.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn != null)
                        conn.Close();
                }
            }
        }


    }
}
