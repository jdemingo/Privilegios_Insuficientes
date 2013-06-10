using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FrbaBus.Cancelar_Viaje
{
    public partial class frmCancelarPasajes : Form
    {
        DataTable tablaPasajes;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public frmCancelarPasajes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "select pasa_codigo, pers_codigo, pers_butaca, pers_piso, pers_posicion, enco_kg, pasa_precio"
                                  +" from Voucher, Pasajes, Personas, Encomiendas"
                                  +" where vouc_id = " + txtVoucher.Text
                                  +" and vouc_id = pasa_voucher"
                                  +" and (pasa_codigo = pers_codigo or pasa_codigo = enco_codigo)";
                    cmd = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    tablaPasajes = new DataTable();
                    adapter.Fill(tablaPasajes);

                    dataGridView1.DataSource = tablaPasajes;
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "PRIVILEGIOS_INSUFICIENTES.cancelar_pasajes ('"+ textBox2.Text +"','"+ textBox1.Text +"')";
                    cmd = new SqlCommand(query, conn);

                    dataGridView1.DataSource = tablaPasajes;
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
