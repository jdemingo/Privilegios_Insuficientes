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
            crearMenu(1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form frmMicros;
            frmMicros = new FrbaBus.Abm_Micro.frmMicros();
            frmMicros.Visible = true;

        }
        internal void crearMenu(int rol)
        {
            MainMenu mainMenu = new MainMenu();
            this.Menu = mainMenu;
            MenuItem menuConsultaPuntos = new MenuItem("&Consulta de puntos");
            MenuItem menuCompraPasajes = new MenuItem("&Compra de pasajes");
            MenuItem menuABM = new MenuItem("&ABMs");
            MenuItem menuABMMicros = new MenuItem("&Micros");
            MenuItem menuABMRecorridos = new MenuItem("&Recorridos");
            MenuItem menuCanjePuntos = new MenuItem("&Canje de puntos");
            MenuItem menuRegLLegada = new MenuItem("&Registros de llegada");
            MenuItem menuCancelarPasajes = new MenuItem("&Cancelar pasajes");
            mainMenu.MenuItems.Add(menuCompraPasajes);
            //menuCompraPasajes.Click += new System.EventHandler(this.menuCompraPasajes_Click);
            mainMenu.MenuItems.Add(menuConsultaPuntos);
            menuConsultaPuntos.Click += new System.EventHandler(this.menuConsultaPuntos_Click);

            // Opciones extras exclusivas del administrador
            if (rol == 2)
            {             
                mainMenu.MenuItems.Add(menuABM);
                menuABM.MenuItems.Add(menuABMMicros);
                menuABM.MenuItems.Add(menuABMRecorridos);
                menuABM.MenuItems.Add(menuCanjePuntos);
                menuABM.MenuItems.Add(menuCancelarPasajes);
                mainMenu.MenuItems.Add(menuRegLLegada);
                menuCancelarPasajes.Click += new System.EventHandler(this.menuCancelarPasajes_Click);
                menuRegLLegada.Click += new System.EventHandler(this.menuRegLLegada_Click);
                menuABMMicros.Click += new System.EventHandler(this.menuABMMicros_Click);
                menuABMRecorridos.Click += new System.EventHandler(this.menuABMRecorridos_Click);
                menuCanjePuntos.Click += new System.EventHandler(this.menuCanjePuntos_Click);
            }
           

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

        private void menuCanjePuntos_Click(object sender, EventArgs e)
        {
            Form frmCanjePuntos = new FrbaBus.Canje_de_Ptos.frmCanjePuntos();
            frmCanjePuntos.Visible = true;
        }
        private void menuCancelarPasajes_Click(object sender, EventArgs e)
        {
            Form frmCancelarPasajes = new FrbaBus.Cancelar_Viaje.frmCancelarPasajes();
            frmCancelarPasajes.Visible = true;
        }

       // private void menuCompraPasajes_Click(object sender, EventArgs e)
       // {
       //     Form frmCompraPasajes = new FrbaBus.Compra_de_Pasajes.frmComprarPasajes();
       //     frmCompraPasajes.Visible = true;
       // }

        private void menuRegLLegada_Click(object sender, EventArgs e)
        {
            Form frmRegLLegada = new FrbaBus.Registrar_LLegada_Micro.frmRegLLegada();
            frmRegLLegada.Visible = true;
        }

        private void menuConsultaPuntos_Click(object sender, EventArgs e)
        {
            Form frmConsultaPuntos = new FrbaBus.Consulta_Puntos_Adquiridos.frmConsultaPuntos();
            frmConsultaPuntos.Visible = true;
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Cuando presionan este boton debe pedir el login y Crea el Menu");
            FrbaBus.Login.frmLogin frmLogin = new FrbaBus.Login.frmLogin();
            frmLogin.Show();
            this.Visible = false;
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
                    string query = "SELECT dest_viaje,"
                                    + "       dest_fecha_llegada_estimada,"
                                    + "       dest_butacas_libres,"
                                    + "       dest_peso_libre,"
                                    + "       serv_servicio "
                                    + "FROM Destinos,"
                                    + "     Recorridos,"
                                    + "     Servicios_Recorridos"
                        //  +"WHERE dest_fecha_salida   = "+dateSalida.Text    //problema al comparar fechas
                                    + "  WHERE (dest_butacas_libres > 0 or dest_peso_libre > 0)"
                                    +"  and dest_viaje          = reco_viaje_codigo"
                                    +"  and reco_id_origen      = "+cmbOrigHide.Text
                                    +"  and reco_id_destino     = "+cmbDestHide.Text
                                    +"  and reco_viaje_codigo   = serv_viaje_codigo";
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
           // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            Form frmAbm_nuevos_pasajes;
            frmAbm_nuevos_pasajes = new FrbaBus.Compra_de_Pasajes.frmComprarPasajes( dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() );
            frmAbm_nuevos_pasajes.Visible = true;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form frmAbm_cancelar;
            frmAbm_cancelar = new FrbaBus.Cancelar_Viaje.frmCancelarPasajes();
            frmAbm_cancelar.Visible = true;
        }




    }
}
