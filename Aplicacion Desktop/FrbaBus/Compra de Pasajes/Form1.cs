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

namespace FrbaBus.Compra_de_Pasajes
{
    public partial class frmComprarPasajes : Form
    {

        
        DataTable tablaButacas;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public frmComprarPasajes(string v_viaje)
        {
            InitializeComponent();

            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "SELECT dest_id,"
                                    + "       dest_fecha_llegada_estimada,"
                                    + "       dest_butacas_libres,"
                                    + "       dest_peso_libre,"
                                    + "       serv_servicio "
                                    + "FROM Destinos,"
                                    + "     Recorridos,"
                                    + "     Servicios_Recorridos"
                        //  +"WHERE dest_fecha_salida   = "+dateSalida.Text    //problema al comparar fechas
                                    + "  WHERE (dest_butacas_libres > 0 or dest_peso_libre > 0)"
                                    + "  and dest_viaje          = reco_viaje_codigo"
                                    + "  and reco_viaje_codigo   = serv_viaje_codigo";
                    cmd = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    tablaButacas = new DataTable();
                    adapter.Fill(tablaButacas);

                    dataGridView1.DataSource = tablaButacas;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_LostFocus(object sender, EventArgs e)
        {


 using (SqlConnection conn = Common.conectar())
            {
                try
                {
            string query = "select * from clientes where clie_dni = '"+ textDni.Text +"'";
            cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("DNI", textDni.Text);

               //    conn.Open();

                   SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                    textNombre.Text = Convert.ToString(reader["clie_nombre"]);
                    textApellido.Text = Convert.ToString(reader["clie_apellido"]);
                    textDirec.Text = Convert.ToString(reader["clie_dir"]);
                    textTel.Text = Convert.ToString(reader["clie_telefono"]);
                    textEmail.Text = Convert.ToString(reader["clie_mail"]);
                    }

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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmComprarPasajes_Load(object sender, EventArgs e)
        {

        }
    }
}
