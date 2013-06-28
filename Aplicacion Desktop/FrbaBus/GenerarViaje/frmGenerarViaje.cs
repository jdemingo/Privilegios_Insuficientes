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

namespace FrbaBus.GenerarViaje
{
    public partial class frmGenerarViaje : Form
    {

        DataTable tablaRecorridos;
        DataTable tabla;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        //SqlCommand cmd2;
        //SqlDataAdapter adapter2;

        

        public frmGenerarViaje()
        {
            InitializeComponent();
        }


        private void crearCombos()
        {
            try
            {
                string query = "select reco_viaje_codigo,a.ciud_nombre+' - '+b.ciud_nombre recorrido "
                + "from privilegios_insuficientes.recorridos , privilegios_insuficientes.ciudades a, privilegios_insuficientes.ciudades b "
                + "where a.ciud_id = reco_id_origen and b.ciud_id = reco_id_destino "
                + "order by recorrido";
                
                cmd = new SqlCommand(query, Common.globalConn);
                adapter = new SqlDataAdapter(cmd);
                tablaRecorridos = new DataTable();
                adapter.Fill(tablaRecorridos);
            
                cmbRecorrido.DisplayMember = "recorrido";
                cmbRecorrido.ValueMember = "reco_viaje_codigo";
                cmbRecorrido.DataSource = tablaRecorridos;
                
            
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show(ex.Message);
            }


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            crearCombos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbRecorrido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdMicros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void llenarGrilla()
        {
            try
            {   
                string id_recorrido = cmbRecorrido.SelectedValue.ToString();
/*                string query = "select micr_id as nroMicro, micr_patente as Patente, micr_modelo as Modelo, marc_nombre as Marca, ";
                query += "micr_kg as Kilos, micr_butacas as Butacas, micr_tipo_servicio as Tipo ";
                query += " from PRIVILEGIOS_INSUFICIENTES.micros, PRIVILEGIOS_INSUFICIENTES.marcas_micros";
                query += " where micr_id_marca = marc_id";
  */

                string query = "SELECT micr_id as nroMicro, micr_patente as Patente, micr_modelo as Modelo, marc_nombre as Marca, ";
                query += "micr_kg as Kilos, micr_butacas as Butacas, micr_tipo_servicio as Tipo ";
                query += "FROM PRIVILEGIOS_INSUFICIENTES.micros, PRIVILEGIOS_INSUFICIENTES.marcas_micros ";
                query += "WHERE  not exists ( select 1 from privilegios_insuficientes.fallas where (fall_ffin is null or " + Common.fechaSQL(dateSalida) + " BETWEEN fall_finicio and fall_ffin ) and fall_id_micro = micr_id )";
                query += "and micr_tipo_servicio in (select serv_servicio from privilegios_insuficientes.servicios_recorridos where serv_viaje_codigo = " + id_recorrido + ") and micr_id_marca = marc_id";
                
                cmd = new SqlCommand(query, Common.globalConn);
                adapter = new SqlDataAdapter(cmd);
                tabla = new DataTable();
                adapter.Fill(tabla);
                grdMicros.DataSource = tabla;

                if (tabla.Rows.Count >= 1)
                {
                    bttGenerarViaje.Enabled=true;

                }else{
                bttGenerarViaje.Enabled=false;
                }

            
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void bttBuscarMicro_Click(object sender, EventArgs e)
        {
            llenarGrilla();
            bttGenerarViaje.Visible = true;

        }

        private void bttGenerarViaje_Click(object sender, EventArgs e)
        {


            int micro_seleccionado = Convert.ToInt16(grdMicros.CurrentRow.Cells[0].Value);
            int micro_butacas = Convert.ToInt16(grdMicros.CurrentRow.Cells[5].Value);
            int micro_kg = Convert.ToInt16(grdMicros.CurrentRow.Cells[4].Value);
            
            
            try
            {
                string query = "insert into privilegios_insuficientes.destinos(dest_id_micro,dest_fecha_salida,dest_fecha_llegada_estimada,dest_viaje,dest_butacas_libres,dest_peso_libre) "+
                               "values (" + micro_seleccionado + ",'" + Common.fechaSQL(dateSalida) + " " + Common.tiempoSQL(timeSalida) + "','" + Common.fechaSQL(dateLlegada) + " " + Common.tiempoSQL(timeLlegada) + "'," + cmbRecorrido.SelectedValue + "," + micro_butacas + "," + micro_kg + ") ";
                
                cmd = new SqlCommand(query, Common.globalConn);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Viaje generado con éxito");


                cerrar_ventana();

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show(ex.Message);
            }
                


             

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cerrar_ventana() {
            this.Visible = false;

        }
    }
}

