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


namespace FrbaBus
{
    public partial class frmUtnBus : Form
    {
        DataTable tablaOrigen;
        DataTable tablaDestino;
        DataTable tablaPasajes;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public frmUtnBus()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form frmMicros;
            frmMicros = new FrbaBus.Abm_Micro.frmMicros();
            frmMicros.Visible = true;

        }
        private void crearMenu(int rol)
        {
            MainMenu mainMenu = new MainMenu();
            this.Menu = mainMenu;
            MenuItem menuABM = new MenuItem("&ABMs");
            MenuItem menuABMMicros = new MenuItem("&Micros");
            MenuItem menuABMRecorridos = new MenuItem("&Recorridos");
            mainMenu.MenuItems.Add(menuABM);
            menuABM.MenuItems.Add(menuABMMicros);
            menuABM.MenuItems.Add(menuABMRecorridos);
            menuABMMicros.Click += new System.EventHandler(this.menuABMMicros_Click);
            menuABMRecorridos.Click += new System.EventHandler(this.menuABMRecorridos_Click);
        }
        private void crearCombos()
        {
            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "select * from ciudades";
                    cmd = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    tablaOrigen = new DataTable();
                    tablaDestino = new DataTable();
                    adapter.Fill(tablaOrigen);
                    adapter.Fill(tablaDestino);
                    cmbOrigen.DisplayMember = "ciud_nombre";
                    cmbOrigen.DataSource = tablaOrigen;
                    cmbOrigHide.DisplayMember = "ciud_id";
                    cmbOrigHide.DataSource = tablaOrigen;
                    cmbDestino.DisplayMember = "ciud_nombre";
                    cmbDestino.DataSource = tablaDestino;
                    cmbDestHide.DisplayMember = "ciud_id";
                    cmbDestHide.DataSource = tablaDestino;
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
        private void frmUtnBus_Load(object sender, EventArgs e)
        {
            crearCombos();
            crearMenu(1);
        }
        private void menuABMMicros_Click(object sender, EventArgs e)
        {
            Form frmMicros;
            frmMicros = new FrbaBus.Abm_Micro.frmMicros();
            frmMicros.Visible = true;
        }
        private void menuABMRecorridos_Click(object sender, EventArgs e)
        {
            Form frmMicros;
            frmMicros = new FrbaBus.Abm_Micro.frmMicros();
            frmMicros.Visible = true;
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cuando presionan este boton debe pedir el login y Crea el Menu");
 
        }

        private static string buildConnectionURL(string user, string passwd, string server, string db) {
            return "user id=" + user + ";password=" + passwd + ";server=" + server + ";database=" + db + "; ";
        }

        //private void Conectar()
        //{

        //    //Tomar de archivo !!
        //    string user = "gd";
        //    string passwd = "gd2013";
        //    string server = "localhost\\SQLSERVER2008";
        //    string db ="GD1C2013";
 
        //    SqlConnection conexion = new SqlConnection(buildConnectionURL(user, passwd, server, db));

        //    conexion.Close();
        //}

        private void dateSalida_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0:MM DD YYYY}", dateSalida.Text));
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrbaBus.Consulta_Puntos_Adquiridos.frmConsultaPuntos frmConsultaPuntos = new FrbaBus.Consulta_Puntos_Adquiridos.frmConsultaPuntos();
            frmConsultaPuntos.cargarGridDelDNI(txtDNI.Text);
            frmConsultaPuntos.Show();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "SELECT dest_id,"
                                    + "       dest_fecha_llegada_estimada,"
                                    + "       dest_butacas_libres,"
                                    + "       dest_peso_libre,"
                                    + "       micr_tipo_servicio "
                                    + "FROM Destinos,"
                                    + "     Precios,"
                                    + "     Micros"
                        //  +"WHERE dest_fecha_salida   = "+dateSalida.Text    //problema al comparar fechas
                                    + "  WHERE (dest_butacas_libres > 0 or dest_peso_libre > 0)"
                                    +"  and dest_viaje          = prec_viaje_codigo"
                                    +"  and prec_id_origen      = "+cmbOrigHide.Text
                                    +"  and prec_id_destino     = "+cmbDestHide.Text
                                    +"  and dest_id_micro       = micr_id";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form frmAbm_cancelar;
            frmAbm_cancelar = new FrbaBus.Cancelar_Viaje.frmCancelarPasajes();
            frmAbm_cancelar.Visible = true;
        }




    }
}
