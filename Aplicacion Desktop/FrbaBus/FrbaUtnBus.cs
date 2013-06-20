﻿using System;
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
        private DataTable tablaOrigen;
        private DataTable tablaDestino;
        private DataTable tablaPasajes;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        public SqlConnection globalConn;
        public frmUtnBus()
        {
            InitializeComponent();
            globalConn = Common.conectar();
            Common.iniciarConexionGlobal();
            //crearMenu(1);
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

            //using (globalConn/*SqlConnection conn = Common.conectar()*/)
            //{
                try
                {
                    SqlCommand cmd = new SqlCommand(
                    "SELECT func_nombre " +
                    "FROM PRIVILEGIOS_INSUFICIENTES.funciones " +
                    "WHERE func_role_id = " + rol, Common.globalConn/*globalConn/*conn*/);
                    adapter = new SqlDataAdapter(cmd);
                    DataTable tablaFunciones = new DataTable();
                    adapter.Fill(tablaFunciones);
                    DataColumn[] columns = new DataColumn[1];
                    columns[0] = tablaFunciones.Columns["func_nombre"];
                    tablaFunciones.PrimaryKey = columns;

                    mostrarMenus(mainMenu, tablaFunciones);

                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }
                //finally
                //{
                //    if (globalConn/*conn*/ != null)
                //        globalConn/*conn*/.Close();
                //}
            //}
        }

        private void mostrarMenus(MainMenu mainMenu, DataTable tablaFunciones)
        {
            MenuItem menuRoles, menuMicros, menuRecorridos, menuCanjes, menuCancelarPasajes, menuConsultaPuntos, menuRegLLegadas, menuGenerarViaje, menuTopDest, menuTopCli;
            MenuItem menuABM = new MenuItem("&ABMs");

            if (tablaFunciones.Rows.Contains("Roles"))
            {
                menuABM.MenuItems.Add(menuRoles = new MenuItem("&Roles"));
                menuRoles.Click += new System.EventHandler(this.menuABMRoles_Click);
            }
            if (tablaFunciones.Rows.Contains("Micros"))
            {
                menuABM.MenuItems.Add(menuMicros = new MenuItem("&Micros"));
                menuMicros.Click += new System.EventHandler(this.menuABMMicros_Click);
            }
            if (tablaFunciones.Rows.Contains("Recorridos"))
            {
                menuABM.MenuItems.Add(menuRecorridos = new MenuItem("&Recorridos"));
                menuRecorridos.Click += new System.EventHandler(this.menuABMRecorridos_Click);
            }
            if (tablaFunciones.Rows.Contains("Canje de puntos"))
            {
                menuABM.MenuItems.Add(menuCanjes = new MenuItem("&Canje de puntos"));
                menuCanjes.Click += new System.EventHandler(this.menuCanjePuntos_Click);
            }
            if (tablaFunciones.Rows.Contains("Cancelar pasajes"))
            {
                menuABM.MenuItems.Add(menuCancelarPasajes = new MenuItem("&Cancelar pasajes"));
                menuCancelarPasajes.Click += new System.EventHandler(this.menuCancelarPasajes_Click);
            }
            if (tablaFunciones.Rows.Contains("Generar viaje"))
            {
                menuABM.MenuItems.Add(menuGenerarViaje = new MenuItem("&Generar viaje"));
                menuGenerarViaje.Click += new System.EventHandler(this.menuCancelarPasajes_Click);
            }

            if (menuABM.MenuItems.Count > 0)
                mainMenu.MenuItems.Add(menuABM);

            if (tablaFunciones.Rows.Contains("Consulta de puntos"))
            {
                mainMenu.MenuItems.Add(menuConsultaPuntos = new MenuItem("&Consulta de puntos"));
                menuConsultaPuntos.Click += new System.EventHandler(this.menuConsultaPuntos_Click);
            }
            if (tablaFunciones.Rows.Contains("Registro de llegadas"))
            {
                mainMenu.MenuItems.Add(menuRegLLegadas = new MenuItem("&Registro de llegadas"));
                menuRegLLegadas.Click += new System.EventHandler(this.menuRegLLegada_Click);
            }
            if (tablaFunciones.Rows.Contains("Top destinos"))
            {
                mainMenu.MenuItems.Add(menuTopDest = new MenuItem("&Top destinos"));
                menuTopDest.Click += new System.EventHandler(this.menuTopDest_Click);
            }

            if (tablaFunciones.Rows.Contains("Top clientes"))
            {
                mainMenu.MenuItems.Add(menuTopCli = new MenuItem("&Top clientes"));
                menuTopCli.Click += new System.EventHandler(this.menuTopCli_Click);
            }

        }

        private void crearCombos()
        {
            //using (globalConn/*SqlConnection conn = Common.conectar()*/)
            //{
                try
                {
                    string query = "select * from PRIVILEGIOS_INSUFICIENTES.ciudades";
                    cmd = new SqlCommand(query, Common.globalConn/*globalConn/*conn*/);
                    adapter = new SqlDataAdapter(cmd);
                    tablaOrigen = new DataTable();
                    tablaDestino = new DataTable();
                    adapter.Fill(tablaOrigen);
                    adapter.Fill(tablaDestino);

                    cmbOrigen.DisplayMember = "ciud_nombre";
                    cmbOrigen.DataSource = tablaOrigen;
                    cmbOrigen.ValueMember = "ciud_id";

                    cmbDestino.DisplayMember = "ciud_nombre";
                    cmbDestino.DataSource = tablaDestino;
                    cmbDestino.ValueMember = "ciud_id";
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }
                //finally
                //{
                //    if (globalConn/*conn*/ != null)
                //        globalConn/*conn*/.Close();
                //}
            //}
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

        private void menuABMRoles_Click(object sender, EventArgs e)
        {
            Form frmRoles;
            frmRoles = new FrbaBus.Abm_Roles.frmRoles();
            frmRoles.Visible = true;
        }
        private void menuABMRecorridos_Click(object sender, EventArgs e)
        {
            Form frmRecorridos;
            frmRecorridos = new FrbaBus.Abm_Recorrido.frmAbm_reco();
            frmRecorridos.Visible = true;
        }

        private void menuCanjePuntos_Click(object sender, EventArgs e)
        {
            Form frmCanjePuntos = new FrbaBus.Canje_de_Ptos.frmCanjePuntos();
            frmCanjePuntos.Visible = true;
        }
        private void menuCancelarPasajes_Click(object sender, EventArgs e)
        {
            Form frmCancelarPasaje = new FrbaBus.Cancelar_Viaje.frmCancelarPasaje();
            frmCancelarPasaje.Visible = true;
        }

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


        private void menuTopDest_Click(object sender, EventArgs e)
        {
            Form frmStats = new FrbaBus.Top_Destinos.frmStats();
            frmStats.Visible = true;
        }


        private void menuTopCli_Click(object sender, EventArgs e)
        {
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            FrbaBus.Login.frmLogin frmLogin = new FrbaBus.Login.frmLogin(this);
            frmLogin.Show();
            //this.Visible = false;

        }

        private static string buildConnectionURL(string user, string passwd, string server, string db)
        {
            return "user id=" + user + ";password=" + passwd + ";server=" + server + ";database=" + db + "; ";
        }

        private void dateSalida_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(String.Format("{0:yyyy-dd-MM HH:mm:ss.mms}", dateSalida.Value));
            //MessageBox.Show(Common.fechaSQL(dateSalida));
            //MessageBox.Show(Common.fechayhoraSQL(dateSalida));
        }



        private void btnCargarPasajes_Click(object sender, EventArgs e)
        {
            //using (globalConn/*SqlConnection conn = Common.conectar()*/)
            //{
                try
                {
                    string query = "SELECT dest_id,"
                                    + "       dest_fecha_salida Salida,"
                                    + "       dest_fecha_llegada_estimada LLegada,"
                                    + "       dest_butacas_libres Butacas,"
                                    + "       dest_peso_libre Kgs,"
                                    + "       serv_servicio Servicio "
                                    + "FROM PRIVILEGIOS_INSUFICIENTES.Destinos,"
                                    + "     PRIVILEGIOS_INSUFICIENTES.Recorridos,"
                                    + "     PRIVILEGIOS_INSUFICIENTES.Servicios_Recorridos"
                                    + "  WHERE (dest_butacas_libres > 0 or dest_peso_libre > 0)"
                        //  +"WHERE dest_fecha_salida   = "+dateSalida.Text    //problema al comparar fechas
                                    + " and DATEADD(dd, 0, DATEDIFF(dd, 0, dest_fecha_salida)) = '" + Common.fechaSQL(dateSalida) + "'"
                                    + "  and dest_viaje          = reco_viaje_codigo"
                                    + "  and reco_id_origen      = " + cmbOrigen.SelectedValue
                                    + "  and reco_id_destino     = " + cmbDestino.SelectedValue
                                    + "  and reco_viaje_codigo   = serv_viaje_codigo";
                    cmd = new SqlCommand(query, Common.globalConn/*globalConn/*conn*/);
                    adapter = new SqlDataAdapter(cmd);
                    tablaPasajes = new DataTable();
                    adapter.Fill(tablaPasajes);
                    if (tablaPasajes.Rows.Count == 0)
                    {
                        MessageBox.Show("No hay pasajes disponibles de " + cmbOrigen.Text + " a " + cmbDestino.Text + " el dia " + dateSalida.Text);
                    }
                    else
                    {
                        
                        grdPasajes.DataSource = tablaPasajes;
                        grdPasajes.AutoResizeColumns();
                        grdPasajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        grdPasajes.Columns["dest_id"].Visible = false;
                        grpPasajesDisponibles.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }
                //finally
                //{
                //    if (globalConn/*conn*/ != null)
                //        globalConn/*conn*/.Close();
                //}


            //}

        }
        private void chkEncomienda_ChangeChecked(object sender, EventArgs e)
        {
            lblKgs.Enabled = chkEncomienda.Checked ? true : false;
            //txtKg.Text = "";
            txtKg.Enabled = chkEncomienda.Checked ? true : false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show(grdPasajes.Rows[e.RowIndex].Cells[0].Value.ToString());

            Form frmAbm_compra;
            //frmAbm_compra = new FrbaBus.Compra_de_Pasajes.frmCompraPasajes(int.Parse(grdPasajes.Rows[e.RowIndex].Cells[0].Value.ToString()), txtCantPasajes.Text, txtKg.Text);
            frmAbm_compra = new FrbaBus.Compra_de_Pasajes.frmCompraPasajes((int)grdPasajes.CurrentRow.Cells["dest_id"].Value, grdPasajes.CurrentRow.Cells["Servicio"].Value.ToString(), txtCantPasajes.Text, txtKg.Enabled ? txtKg.Text : "");
            frmAbm_compra.Visible = true;
        }

 
        private void cmbOrigHide_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantPasajes_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUtnBus_FormClosing(object sender, FormClosingEventArgs e)
        {
            Common.globalConn/*globalConn*/.Close();
            MessageBox.Show("Sesión finalizada");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form frmMicros;
            frmMicros = new FrbaBus.Abm_Micro.frmMicros();
            frmMicros.Visible = true;
        }




    }
}
