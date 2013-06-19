using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaBus.Registrar_LLegada_Micro
{
    public partial class frmRegLLegada : Form
    {
        public frmRegLLegada()
        {
            InitializeComponent();
            cargarCombosOrigenYDestino();
            this.ActiveControl = txtPatente;
            crearGridMicros();
        }


        //No iria
        internal void cargarGridDelMicro(string patente)
        {
            using (SqlConnection conn = Common.conectar())
                try
                {
                    SqlCommand cmd = new SqlCommand(
                    "SELECT micr_modelo, marc_nombre, micr_kg, micr_butacas, micr_tipo_servicio " +
                    "FROM PRIVILEGIOS_INSUFICIENTES.Micros, PRIVILEGIOS_INSUFICIENTES.Marcas_micros " +
                    "WHERE micr_patente = '" + txtPatente.Text + "' AND " +
                    "micr_id_marca = marc_id", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    grdMicros.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (conn != null)
                        conn.Close();
                }
        }

        private void cargarCombosOrigenYDestino()
        {
            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM PRIVILEGIOS_INSUFICIENTES.ciudades", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tablaOrigen = new DataTable();
                    DataTable tablaDestino = new DataTable();
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
                finally
                {
                    if (conn != null)
                        conn.Close();
                }
            }
        }

        private void txtPatente_Leave(object sender, EventArgs e)
        {
            //cargarGridDelMicro(txtPatente.Text);

        }

        private bool camposValidados()
        {
            if (txtPatente.Text.Equals(""))
                MessageBox.Show("Falta llenar el campo Patente");
            else return true;
            return false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (grdMicros.Rows.Count == 0)
                MessageBox.Show("No hay micros agregados para registrar");
            else foreach (DataRow dr in grdMicros.Rows)
                {
                    SqlCommand cmd = new SqlCommand(
                            "UPDATE PRIVILEGIOS_INSUFICIENTES.destinos " +
                            "SET dest_fecha_llegada = '" + dr["micr_fllegada"] + "'" +
                            "WHERE dest_id = " + dr["micr_id_viaje"], Common.globalConn);
                }
            //if (camposValidados())
            //{
            //    using (SqlConnection conn = Common.conectar())
            //        try
            //        {
            //            DateTime dtLLegada = new DateTime(dateLLegada.Value.Year, dateLLegada.Value.Month, dateLLegada.Value.Day, timeLLegada.Value.Hour, timeLLegada.Value.Minute, 0, 0);
            //            SqlCommand cmd = new SqlCommand(
            //            "UPDATE PRIVILEGIOS_INSUFICIENTES.destinos " +
            //            "SET dest_fecha_llegada = '" + dtLLegada + "'" +
            //            "WHERE dest_id = (SELECT TOP (1) dest_id " +
            //                             "FROM PRIVILEGIOS_INSUFICIENTES.Destinos, PRIVILEGIOS_INSUFICIENTES.Micros, PRIVILEGIOS_INSUFICIENTES.Recorridos " +
            //                             "WHERE micr_patente = '" + txtPatente.Text + "' AND " +
            //                             "micr_id = dest_id_micro AND " +
            //                             "dest_viaje = reco_viaje_codigo AND " +
            //                             "reco_id_destino = " + cmbDestino.SelectedValue.ToString() + " AND " +
            //                             "reco_id_origen = " + cmbOrigen.SelectedValue.ToString() + " AND " +
            //                             "dest_fecha_salida < '" + dtLLegada + "' AND " +
            //                             "DATEDIFF(hh, dest_fecha_salida, '" + dtLLegada + "') < 24 " +
            //                             "ORDER BY DATEDIFF(hh, dest_fecha_salida, '" + dtLLegada + "'))", conn);


            //            if (cmd.ExecuteNonQuery() == 0)
            //                MessageBox.Show("Los datos a ingresar no cumplen las restricciones del sistema");
            //            else
            //                MessageBox.Show("La llegada se ha registrado correctamente.");
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //        finally
            //        {
            //            if (conn != null)
            //                conn.Close();
            //        }
            //}
        }
        private void crearGridMicros()
        {
            grdMicros.Columns.Add("micr_patente", "Patente");
            grdMicros.Columns.Add("micr_origen", "Origen");
            grdMicros.Columns.Add("micr_origen_id", "ID Origen");
            grdMicros.Columns["micr_origen_id"].Visible = false;
            grdMicros.Columns.Add("micr_destino", "Destino");
            grdMicros.Columns.Add("micr_destino_id", "ID Destino");
            grdMicros.Columns["micr_destino_id"].Visible = false;
            grdMicros.Columns.Add("micr_fllegada", "Fecha de llegada");
            grdMicros.Columns.Add("micr_id_viaje", "ID Viaje");
            //grdMicros.Columns["micr_id_viaje"].Visible = false;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int dest_id = 0;
            bool error = false;
            if (camposValidados())
            {
                using (SqlConnection conn = Common.conectar())
                    try
                    {
                        SqlCommand cmd = new SqlCommand(
                "SELECT TOP (1) dest_id " +
                "FROM PRIVILEGIOS_INSUFICIENTES.Destinos, PRIVILEGIOS_INSUFICIENTES.Micros, PRIVILEGIOS_INSUFICIENTES.Recorridos " +
                "WHERE micr_patente = '" + txtPatente.Text + "' AND " +
                "micr_id = dest_id_micro AND " +
                "dest_viaje = reco_viaje_codigo AND " +
                "reco_id_destino = " + cmbDestino.SelectedValue.ToString() + " AND " +
                "reco_id_origen = " + cmbOrigen.SelectedValue.ToString() + " AND " +
                "dest_fecha_salida < '" + Common.fechaytiempoSQL(dateLLegada) + "' AND " +
                "DATEDIFF(hh, dest_fecha_salida, '" + Common.fechaytiempoSQL(dateLLegada) + "') < 24 " +
                "ORDER BY DATEDIFF(hh, dest_fecha_salida, '" + Common.fechaytiempoSQL(dateLLegada) + "')", conn);
                        DataTable dt = new DataTable();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("El micro con patente " + txtPatente.Text + " no existe o no debia ir de " + cmbOrigen.Text + " a " + cmbDestino.Text + " y/o en la fecha " + dateLLegada.Text);
                            error = true;
                        }
                        else
                        {
                            dest_id = (int)cmd.ExecuteScalar();
                            MessageBox.Show("La llegada se ha agregado correctamente.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (conn != null)
                            conn.Close();
                    }
                if (!error)
                {
                    grdMicros.Rows.Add(
                        txtPatente.Text,
                        cmbOrigen.Text,
                        cmbOrigen.ValueMember,
                        cmbDestino.Text,
                        cmbDestino.ValueMember,
                        Common.fechaSQL(dateLLegada) + " " + Common.tiempoSQL(timeLLegada),
                        dest_id);
                }
            }
        }

    }



}
