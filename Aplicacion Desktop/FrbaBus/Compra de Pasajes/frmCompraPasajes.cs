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
        private int dest_id;
        private int cant_pasajes;
        private int max_cant_pasajes;
        private double kgs;
        private int lastRowIndex;
        private SqlConnection globalConn;

        public frmCompraPasajes(SqlConnection globalConn, int dest_id, string cant_pasajes, string kgs)
        {
            InitializeComponent();
            this.globalConn = globalConn;
            this.cant_pasajes = cant_pasajes.Equals("") ? 0 : int.Parse(cant_pasajes);
            this.max_cant_pasajes = this.cant_pasajes;
            this.kgs = kgs.Equals("") ? 0 : double.Parse(kgs);
            this.dest_id = dest_id;
            grdButacas.Size = new System.Drawing.Size(grdButacas.Size.Width, 260);
            cargarButacas2();
            //cargarButacas();
            crearGridPasajeros();
            //MessageBox.Show(this.id_viaje + " - " + this.cant_pasajes + " - " + this.kgs);
        }

        private void crearGridPasajeros()
        {
            grdPasajeros.Columns.Add("proc_id_viaje", "Viaje");
            //grdPasajeros.Columns["dest_viaje"].Visible = false;
            grdPasajeros.Columns.Add("proc_butaca", "Butaca");
            grdPasajeros.Columns.Add("proc_tipo", "Tipo");
            grdPasajeros.Columns.Add("proc_piso", "Piso");
            grdPasajeros.Columns.Add("proc_dni_pasajero", "DNI Pasajero");
            grdPasajeros.Columns.Add("proc_kg_encomienda", "Encomienda (Kg)");
            grdPasajeros.Columns.Add("proc_precio", "Precio");
            grdPasajeros.Columns.Add("proc_dni_paga", "DNI Comprador");
            grdPasajeros.Columns.Add("proc_nro_tarj", "Tarjeta");
            grdPasajeros.Columns.Add("proc_nro_seg", "Codigo Seguridad");
            grdPasajeros.Columns.Add("proc_cuotas", "Cuotas");
            grdPasajeros.AutoResizeColumns();
            grdPasajeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if (kgs > 0)
            {
                grdPasajeros.Rows.Add(dest_id, "NULL", "NULL", "NULL", "NULL", kgs, "NULL", "NULL", "NULL", "NULL", "NULL");
            }

        }

        private void cargarButacas2()
        {
            //using (globalConn/*SqlConnection conn = Common.conectar()*/)
            //{
                try
                {
                    string query = "select buta_numero Butaca, buta_piso Piso, buta_tipo Tipo"
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
                                  + " and dest_id    = '" + dest_id + "'";

                    cmd = new SqlCommand(query, globalConn/*conn*/);
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
                //finally
                //{
                //    if (globalConn/*conn*/ != null)
                //        globalConn/*conn*/.Close();
                //}


            //}
        }


        private void frmComprarPasajes_Load(object sender, EventArgs e)
        {

        }

        private void txtDNI_LostFocus(object sender, EventArgs e)
        {
            if (txtDNI.Text != "")
            {
                //using (globalConn/*SqlConnection conn = Common.conectar()*/)
                //{
                    try
                    {
                        string query = "select * from PRIVILEGIOS_INSUFICIENTES.clientes where clie_dni = '" + txtDNI.Text + "'";
                        cmd = new SqlCommand(query, globalConn/*conn*/);

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
                        reader.Close();

                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message);
                        MessageBox.Show(ex.Message);
                    }
                    //finally
                    //{
                    //    if (conn != null)
                    //        conn.Close();
                    //}
                //}
            }
        }

        private void btnSigPasaje_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
                MessageBox.Show("Ingrese sus datos");
            else if (grdButacas.CurrentRow == null)
                MessageBox.Show("Elija una butaca");
            else if (cant_pasajes > 0)
            {
                cant_pasajes--;
                btnAtras.Visible = true;
                grdPasajeros.Rows.Add(dest_id, grdButacas.CurrentRow.Cells["Butaca"].Value, grdButacas.CurrentRow.Cells["Tipo"].Value, grdButacas.CurrentRow.Cells["Piso"].Value, txtDNI.Text, "NULL", "NULL", "NULL", "NULL", "NULL", "NULL");
                lastRowIndex = grdButacas.CurrentRow.Index;
                grdButacas.CurrentCell = null;
                grdButacas.Rows[lastRowIndex].Visible = false;
                limpiarCampos();
            }
            if (cant_pasajes == 0)
            {
                groupPasajeros.Text = "Comprador";
                //groupPasajeros.Left = 5;
                groupComprador.Visible = true;
                btnPago.Visible = true;
                btnSigPasaje.Visible = false;
                chkDiscapacitado.Visible = false;
                grdButacas.Visible = false;
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
            if (txtDNI.Text == "")
                MessageBox.Show("Ingrese sus datos");
            else if ((txtTarjeta.Text == "" || txtCodSeg.Text == "" || txtCuotas.Text == "") && !chkEfectivo.Checked)
                MessageBox.Show("Ingrese los datos de la tarjeta");
            else
            {
                btnFinalizar.Visible = true;
                for (int i = 0; i < grdPasajeros.Rows.Count; i++)
                {
                    grdPasajeros.Rows[i].Cells["proc_dni_paga"].Value = txtDNI.Text;
                    if (groupTarjeta.Enabled)
                    {
                        grdPasajeros.Rows[i].Cells["proc_nro_tarj"].Value = txtTarjeta.Text;
                        grdPasajeros.Rows[i].Cells["proc_nro_seg"].Value = txtCodSeg.Text;
                        grdPasajeros.Rows[i].Cells["proc_cuotas"].Value = txtCuotas.Text;
                    }
                    else
                    {
                        grdPasajeros.Rows[i].Cells["proc_nro_tarj"].Value = "NULL";
                        grdPasajeros.Rows[i].Cells["proc_nro_seg"].Value = "NULL";
                        grdPasajeros.Rows[i].Cells["proc_cuotas"].Value = "NULL";
                    }

                }
            }
        }

        private void chkEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            groupTarjeta.Enabled = false;
        }
        private void chkTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            groupTarjeta.Enabled = true;
        }


        private void grdButacas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (cant_pasajes == 0)
            {
                groupComprador.Visible = false;
                groupPasajeros.Text = "Pasajero";
                //groupPasajeros.Left = 350;
                btnPago.Visible = false;
                btnSigPasaje.Visible = true;
                grdButacas.Visible = true;
            }
            grdPasajeros.Rows.RemoveAt(grdPasajeros.Rows.Count - 1);
            grdButacas.Rows[lastRowIndex].Visible = true;
            if ((++cant_pasajes) == max_cant_pasajes)
                btnAtras.Visible = false;
        }
    }
}
