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
        private decimal kgs;
        private int atrasEnc = 0;
        private int atrasDisc = 0;
        private IList<int> rowIndexs = new List<int>();
        private decimal kg_base = 0;
        private decimal persona_base = 0;
        private string servicio;
        private decimal tipo_porcentaje;

        public frmCompraPasajes(int dest_id, string servicio, string cant_pasajes, string kgs)
        {
            InitializeComponent();
            this.cant_pasajes = cant_pasajes.Equals("") ? 0 : int.Parse(cant_pasajes);
            this.max_cant_pasajes = this.cant_pasajes;
            this.kgs = kgs.Equals("") ? 0 : decimal.Parse(kgs);
            lblCantEnc.Text = "1";
            lblCantPasajes.Text = cant_pasajes;
            if (this.kgs == 0)
            {
                lblCantEnc.Visible = false;
                lblEncText.Visible = false;
                lblAtrasEnc.Visible = false;
                lblAntText.Visible = false;
                chkEncomienda.Visible = false;
            }
            this.dest_id = dest_id;
            this.servicio = servicio;
            grdButacas.Size = new System.Drawing.Size(grdButacas.Size.Width, 260);

            obtenerPrecios();
            obtenerPorcentajes();
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
            grdPasajeros.Columns.Add("proc_disc_jub", "Disc/Jub");
            grdPasajeros.AutoResizeColumns();
            grdPasajeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //if (kgs > 0)
            //{
            //    grdPasajeros.Rows.Add(dest_id, "NULL", "NULL", "NULL", "NULL", kgs, "NULL", "NULL", "NULL", "NULL", "NULL");
            //}

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

                cmd = new SqlCommand(query, Common.globalConn/*conn*/);
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
            //    if (Common.globalConn/*conn*/ != null)
            //        Common.globalConn/*conn*/.Close();
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
                    cmd = new SqlCommand(query, Common.globalConn/*globalConn/*conn*/);

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
                    //reader.Dispose();

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

        private void obtenerPrecios()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT reco_kg_base, reco_persona_base " +
                                                "FROM PRIVILEGIOS_INSUFICIENTES.destinos, PRIVILEGIOS_INSUFICIENTES.recorridos " +
                                                "WHERE reco_viaje_codigo = dest_viaje AND " +
                                                "dest_id = " + dest_id, Common.globalConn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    kg_base = Convert.ToDecimal(dr["reco_kg_base"]);
                    persona_base = Convert.ToDecimal(dr["reco_persona_base"]);
                }
                dr.Close();
                //dr.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void obtenerPorcentajes()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT tipo_porcentaje " +
                                                "FROM PRIVILEGIOS_INSUFICIENTES.tipos "+
                                                "WHERE tipo_servicio = '"+servicio+"'", Common.globalConn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    tipo_porcentaje = Convert.ToDecimal(dr["tipo_porcentaje"]);
                dr.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void btnSigPasaje_Click(object sender, EventArgs e)
        {
            if (txtDNI.Text == "")
                MessageBox.Show("Ingrese sus datos");
            else if (grdButacas.CurrentRow == null && !chkEncomienda.Checked)
                MessageBox.Show("Elija una butaca");
            // Es un pasaje
            else if (cant_pasajes > 0 && !chkEncomienda.Checked)
            {
                cant_pasajes--;
                btnAtras.Visible = true;
                decimal precio = persona_base * tipo_porcentaje;
                
                string discJub = obtenerDiscJub();
                if (discJub.Equals("Discapacitado"))
                    precio = 0;
                else if (discJub.Equals("Jubilado"))
                    precio = precio * (decimal) 0.5;
                grdPasajeros.Rows.Add(dest_id, grdButacas.CurrentRow.Cells["Butaca"].Value, grdButacas.CurrentRow.Cells["Tipo"].Value, grdButacas.CurrentRow.Cells["Piso"].Value, txtDNI.Text, "NULL", precio, "NULL", "NULL", "NULL", "NULL", discJub);
                // Oculto y guardo en rowIndexs la ultima butaca ocultada
                rowIndexs.Add(grdButacas.CurrentRow.Index);
                grdButacas.CurrentCell = null;
                grdButacas.Rows[rowIndexs.Last()].Visible = false;
                limpiarCampos();
                // Actualiza posicion de encomienda
                if (atrasEnc > 0)
                    atrasEnc++;
                // Es el ultimo pasaje
                if (cant_pasajes == 0 && kgs > 0)
                    cambiarObligacionEnc();
            }
            // Es una encomienda
            else if (chkEncomienda.Checked)
            {
                btnAtras.Visible = true;
                grdPasajeros.Rows.Add(dest_id, "NULL", "NULL", "NULL", txtDNI.Text, kgs, kg_base*kgs, "NULL", "NULL", "NULL", "NULL", "NULL");
                limpiarCampos();
                atrasEnc++;
                atrasDisc++;
                cambiarVisibilidadEnc();
            }
            // Es el ultimo pasaje o encomienda
            if ((cant_pasajes == 0 && atrasEnc > 0) || (cant_pasajes == 0 && kgs == 0))
            {
                cambiarModo();
            }
            actualizarDetalles();
        }

        private void cambiarVisibilidadEnc()
        {
            chkEncomienda.Checked = chkEncomienda.Checked? false : true;
            chkEncomienda.Visible = chkEncomienda.Visible? false : true;
        }

        private void cambiarObligacionEnc()
        {
            //chkEncomienda.Checked = true;
            //chkEncomienda.AutoCheck = false;

            //chkEncomienda.Checked = false;
            //chkEncomienda.AutoCheck = true;

            chkEncomienda.Checked = chkEncomienda.Checked ? false : true;
            chkEncomienda.AutoCheck = chkEncomienda.AutoCheck ? false : true;
        }

        private string obtenerDiscJub()
        {
            string discJub = "NULL";
            int edad = 0;
            if (dateNac.Value < DateTime.Today)
                edad = (DateTime.Today.AddTicks(-dateNac.Value.Ticks).Year - 1);
            if (atrasDisc > 0)
                atrasDisc++;
            if (chkDiscapacitado.Checked)
            {
                discJub = "Discapacitado";
                cambiarVisibilidadDisc();
                atrasDisc++;
            }
            else if ((cmbSexo.Text == "Femenino" && edad >= 60) || (cmbSexo.Text == "Masculino" && edad >= 65))
                discJub = "Jubilado";
            return discJub;
        }

        private void cambiarVisibilidadDisc()
        {
            chkDiscapacitado.Checked = chkDiscapacitado.Checked ? false : true;
            chkDiscapacitado.Visible = chkDiscapacitado.Visible ? false : true;
        }

        private void actualizarDetalles()
        {
            lblAtrasEnc.Text = atrasEnc == 1 ? "Encomienda" : "Pasaje";
            lblCantEnc.Text = atrasEnc == 0 ? "1" : "0";
            lblCantPasajes.Text = cant_pasajes.ToString();
            lblDisc.Text = atrasDisc == 0 ? "0" : "1";
            //lblDisc.Text = atrasDisc.ToString();
            if (cant_pasajes == max_cant_pasajes)
                lblAtrasEnc.Text = "-";
        }

        private void cambiarModo()
        {
            groupPasajeros.Text = groupPasajeros.Text == "Comprador" ? "Pasajero" : "Comprador";
            groupComprador.Visible = groupComprador.Visible ? false : true;
            btnPago.Visible = btnPago.Visible ? false : true;
            btnSigPasaje.Visible = btnSigPasaje.Visible ? false : true;
            grdButacas.Visible = grdButacas.Visible ? false : true;
            chkDiscapacitado.Visible = chkDiscapacitado.Visible ? false : (atrasDisc == 1 ? true : false);
        }

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtDNI.Text = "";
            txtApe.Text = "";
            txtDir.Text = "";
            cmbSexo.Text = "";
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
            // Pasajes y encomienda cargado (modo comprador)
            if ((cant_pasajes == 0 && atrasEnc > 0) || (cant_pasajes == 0 && kgs == 0))
                cambiarModo();
            // Obligando a cargar encomienda
            else if (cant_pasajes == 0 && kgs > 0)
                cambiarObligacionEnc();               

            // Siempre que se pulsa atras, elimino una fila del grid pasajeros
            grdPasajeros.Rows.RemoveAt(grdPasajeros.Rows.Count - 1);

            // Si la anterior no es una encomienda
            if (atrasEnc != 1)
            {
                chkEncomienda.Checked = false;
                // Muestro la ultima butaca ocultada y la elimino de rowIndexs para que la ultima sea la anterior 
                grdButacas.Rows[rowIndexs.Last()].Visible = true;
                rowIndexs.RemoveAt(rowIndexs.Count - 1);
                
                if ((++cant_pasajes) == max_cant_pasajes)
                    btnAtras.Visible = false;
            }
            // Si hay encomienda y se cargo
            if (atrasEnc > 0 && kgs > 0)
            {
                // Si la encomienda es la anterior, vuelvo a mostrar el checkbox
                if (atrasEnc == 1)
                {
                    cambiarVisibilidadEnc(); 
                    // Si no hay mas pasajes a cargar, obligo a cargar
                    if (cant_pasajes == 0)
                        chkEncomienda.AutoCheck = false;
                    else
                        chkEncomienda.AutoCheck = true;
                }
                atrasEnc--;
            }
            chkDiscapacitado.Checked = false;
            // Si se cargo un discapacitado
            if (atrasDisc > 0)
            {
                // Si es el anterior, vuelvo a mostrar el checkbox
                if (atrasDisc == 1)
                    cambiarVisibilidadDisc();
                atrasDisc--;
            }
            actualizarDetalles();            
        }
    }
}