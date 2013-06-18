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
    public partial class frmCompraPasajes : Form
    {
        private DataTable tablaButacas;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private decimal codigo_viaje;
        private int cant_pasajes;
        private double kgs;

        public frmCompraPasajes(decimal codigo_viaje, string cant_pasajes, string kgs)
        {
            InitializeComponent();
            this.cant_pasajes = cant_pasajes.Equals("") ? 0 : int.Parse(cant_pasajes);
            this.kgs = kgs.Equals("") ? 0 : double.Parse(kgs);
            this.codigo_viaje = codigo_viaje;
            cargarButacas2();
            //cargarButacas();
            crearGridPasajeros();
            //MessageBox.Show(this.id_viaje + " - " + this.cant_pasajes + " - " + this.kgs);
        }

        private void crearGridPasajeros()
        {
            grdPasajeros.Columns.Add("codigo_viaje", "Viaje");
            grdPasajeros.Columns["codigo_viaje"].Visible = false;
            grdPasajeros.Columns.Add("pers_butaca", "Butaca");
            grdPasajeros.Columns.Add("pers_piso", "Piso");
            grdPasajeros.Columns.Add("pers_posicion", "Posicion");
            grdPasajeros.Columns.Add("clie_dni", "DNI Persona");
            grdPasajeros.Columns.Add("enco_codigo", "Kg");
            grdPasajeros.Columns.Add("pasa_precio", "Precio");
            grdPasajeros.Columns.Add("vouc_dni", "DNI Comprador");
            grdPasajeros.Columns.Add("vouc_id_tarjeta", "Tarjeta");
            grdPasajeros.Columns.Add("vouc_cuotas", "Cuotas");

        }

        private void cargarButacas2()
        {
            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "select buta_numero, buta_piso, buta_tipo"
                                  + " from PRIVILEGIOS_INSUFICIENTES.Butacas,"
                                  + "     PRIVILEGIOS_INSUFICIENTES.destinos d1"
                                  + " where buta_numero not in("
                                  + "                        select pers_butaca"
                                  + "                        from PRIVILEGIOS_INSUFICIENTES.pasajes,"
                                  + "                             PRIVILEGIOS_INSUFICIENTES.personas,"
                                  + "                             PRIVILEGIOS_INSUFICIENTES.destinos"
                                  + "                        where pasa_codigo = pers_codigo"
                                  + "                            and pasa_dest_id = dest_id"
                                  + "                            and dest_id = d1.dest_id)"
                                  + " and buta_micro = dest_id_micro"
                                  + " and dest_id    = '"+ codigo_viaje +"'";

                    cmd = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    tablaButacas = new DataTable();
                    adapter.Fill(tablaButacas);

                    grdButacas.DataSource = tablaButacas;
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
        private void cargarButacas()
        {
            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "SELECT pers_codigo,"
                                    + "       pers_butaca,"
                                    + "       pers_piso,"
                                    + "       pers_posicion "
                                    + "FROM PRIVILEGIOS_INSUFICIENTES.personas "
                                    + "WHERE pers_codigo = " + codigo_viaje;
                    cmd = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    tablaButacas = new DataTable();
                    adapter.Fill(tablaButacas);

                    grdButacas.DataSource = tablaButacas;
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtDNI_LostFocus(object sender, EventArgs e)
        {
            if (txtDNI.Text != "")
            {
                using (SqlConnection conn = Common.conectar())
                {
                    try
                    {
                        string query = "select * from PRIVILEGIOS_INSUFICIENTES.clientes where clie_dni = '" + txtDNI.Text + "'";
                        cmd = new SqlCommand(query, conn);

                        //cmd.Parameters.AddWithValue("DNI", txtDNI.Text);

                        //    conn.Open();

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtNombre.Text = Convert.ToString(reader["clie_nombre"]);
                            txtApe.Text = Convert.ToString(reader["clie_apellido"]);
                            txtDir.Text = Convert.ToString(reader["clie_dir"]);
                            txtTel.Text = Convert.ToString(reader["clie_telefono"]);
                            txtMail.Text = Convert.ToString(reader["clie_mail"]);
                            dateNac.Value = Convert.ToDateTime(reader["clie_fnac"]);
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
        }

        private void btnSigPasaje_Click(object sender, EventArgs e)
        {

            if (cant_pasajes > 0)
            {         
                cant_pasajes--;                
                //decimal butaca = (decimal)grdButacas.CurrentRow.Cells["pers_butaca"].Value;            
                grdPasajeros.Rows.Add(codigo_viaje, "-", "-", "-", txtDNI.Text, kgs, "-", "-", "-");
                limpiarCampos();
                if (cant_pasajes == 1)
                    groupPasajeros.Text = "Encomienda";
            }
            if(cant_pasajes==0)
            {
                groupPasajeros.Text = "Comprador";
                groupComprador.Visible = true;
                btnFinalizar.Visible = true;
                btnSigPasaje.Visible = false;
                chkDiscapacitado.Visible = false;
                chkEncomienda.Visible = false;
                grdButacas.Enabled = false;
            }
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtDNI.Text = "";
            txtApe.Text = "";
            txtDir.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            dateNac.Value = DateTime.Today;
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdPasajeros.Rows.Count-1; i++)
            {
                grdPasajeros.Rows[i].Cells["vouc_dni"].Value = txtDNI.Text;
                grdPasajeros.Rows[i].Cells["vouc_id_tarjeta"].Value = txtTarjeta.Text;
                grdPasajeros.Rows[i].Cells["vouc_cuotas"].Value = txtCuotas.Text;
            }
        }

        private void chkEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            groupPago.Enabled = false;
        }
        private void chkTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            groupPago.Enabled = true;
        }

        private void chkEncomienda_CheckedChanged(object sender, EventArgs e)
        {
            groupPasajeros.Enabled = chkEncomienda.Checked ? false : true;
        }

        private void grdButacas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
