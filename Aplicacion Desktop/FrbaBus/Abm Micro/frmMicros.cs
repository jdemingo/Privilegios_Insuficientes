﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaBus.Abm_Micro
{
    public partial class frmMicros : Form
    {
        public frmMicros()
        {
            InitializeComponent();
        }
        DataTable tabla;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        int controlOpe = 0;
        SqlConnection conn = Common.conectar();


        private void llenarCombo(System.Windows.Forms.ComboBox combo, string tablaorigen, string campo, string id)
        {
            try
            {
                string query = "select " + id + "," + campo + " from " + tablaorigen;
                cmd = new SqlCommand(query, Common.globalConn);
                adapter = new SqlDataAdapter(cmd);
                tabla = new DataTable();
                adapter.Fill(tabla);
                combo.DisplayMember = campo;
                combo.ValueMember = id;
                combo.DataSource = tabla;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void llenarGrilla()
        {
            try
            {
                string query = "SELECT micr_id as nroMicro, micr_patente as Patente, micr_modelo as Modelo, marc_nombre as Marca, ";
                query += "micr_kg as Kilos, micr_butacas as Butacas, micr_tipo_servicio as Tipo, isnull((Select CASE WHEN fall_ffin is null THEN 'B' ";
                query += "WHEN " + Common.fecha + " BETWEEN fall_finicio AND fall_ffin THEN 'R' ELSE 'D' END FROM PRIVILEGIOS_INSUFICIENTES.fallas WHERE fall_id_micro=micr_id),'D') as Estado ";
                query += "FROM PRIVILEGIOS_INSUFICIENTES.micros, PRIVILEGIOS_INSUFICIENTES.marcas_micros ";
                query += "WHERE micr_id_marca = marc_id";
                cmd = new SqlCommand(query, Common.globalConn);
                adapter = new SqlDataAdapter(cmd);
                tabla = new DataTable();
                adapter.Fill(tabla);
                grdMicros.DataSource = tabla;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmMicros_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbMarcas, "PRIVILEGIOS_INSUFICIENTES.marcas_micros", "marc_nombre", "marc_id");
            llenarCombo(cmbServicios, "PRIVILEGIOS_INSUFICIENTES.tipos", "tipo_servicio", "tipo_servicio");
            llenarGrilla();
        }

        private void grdMicros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMicroId.Text = Convert.ToString(grdMicros.CurrentRow.Cells[0].Value);
            txtPatente.Text = (string)grdMicros.CurrentRow.Cells[1].Value;
            txtModelo.Text = (string)grdMicros.CurrentRow.Cells[2].Value;
            cmbMarcas.Text = (string)grdMicros.CurrentRow.Cells[3].Value;
            txtKilos.Text = Convert.ToString(grdMicros.CurrentRow.Cells[4].Value);
            txtButacas.Text = Convert.ToString(grdMicros.CurrentRow.Cells[5].Value);
            cmbServicios.Text = (string)grdMicros.CurrentRow.Cells[6].Value;
        }
        private void ocultarBtnOpe()
        {
            btnAlta.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }
        private void mostrarBtnOpe()
        {
            btnAlta.Visible = true;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
        }
        private void ocultarBtnAcep()
        {
            btnAceptar.Visible = false;
            btnCancel.Visible = false;
        }

        private void mostarBtnAcep()
        {
            btnAceptar.Visible = true;
            btnCancel.Visible = true;
        }
        private void ActivarCampos(bool nuevo)
        {
            txtPatente.Enabled = true;
            txtModelo.Enabled = true;
            cmbMarcas.Enabled = true;
            txtKilos.Enabled = true;
            txtButacas.Enabled = true;
            cmbServicios.Enabled = true;
            txtPatente.Focus();

            if (nuevo)
            {

                txtMicroId.Text = "";
                txtPatente.Text = "";
                txtModelo.Text = "";
                cmbMarcas.Text = "";
                txtKilos.Text = "";
                txtButacas.Text = "";
                cmbServicios.Text = "";
            }
        }
        private void desactivar()
        {
            txtPatente.Enabled = false;
            txtModelo.Enabled = false;
            cmbMarcas.Enabled = false;
            txtKilos.Enabled = false;
            txtButacas.Enabled = false;
            cmbServicios.Enabled = false;
            grdMicros.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMicroId.Text != "")
            {
                ActivarCampos(false);
                ocultarBtnOpe();
                mostarBtnAcep();
                controlOpe = 2;
            }
            else MessageBox.Show("Debe seleccionar un Micro para poder modificar", "ATENCION");
        }
        private bool validarCampos()
        {
            if (txtButacas.Text == "") return false;
            if (txtKilos.Text == "") return false;
            if (txtPatente.Text == "") return false;
            if (cmbMarcas.Text == "") return false;
            if (txtModelo.Text == "") return false;
            if (cmbServicios.Text == "") return false;
            return true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                try
                {
                    string query;
                    switch (controlOpe)
                    {
                        case 1:
                            query = "INSERT INTO PRIVILEGIOS_INSUFICIENTES.micros(micr_f_alta, micr_patente, micr_modelo, micr_id_marca, micr_kg, micr_butacas, micr_tipo_servicio) ";
                            query += "VALUES ('" + dateAlta.Text + "','" + txtPatente.Text + "','" + txtModelo.Text + "',";
                            query += cmbMarcas.SelectedValue + "," + txtKilos.Text + ",";
                            query += txtButacas.Text + ",'" + cmbServicios.SelectedValue + "') ";
                            cmd = new SqlCommand(query, Common.globalConn);
                            cmd.ExecuteNonQuery();
                            query = "SELECT TOP 1 micr_id FROM PRIVILEGIOS_INSUFICIENTES.micros ORDER by micr_id DESC";
                            cmd = new SqlCommand(query, Common.globalConn);
                            txtMicroId.Text = Convert.ToString((int) cmd.ExecuteScalar());
                            btnDistri.Enabled = true;
                            break;
                        case 2:
                            if (checkButacas())
                            {
                                MessageBox.Show("Imposible eliminar las butacas, pasajes vendidos!");
                                break;
                            }
                            if (checkKilos()) { break; }
                            query = "UPDATE PRIVILEGIOS_INSUFICIENTES.micros SET ";
                            query += "micr_f_alta='" + dateAlta.Text + "',micr_patente='" + txtPatente.Text + "',";
                            query += "micr_modelo='" + txtModelo.Text + "',micr_id_marca=" + cmbMarcas.SelectedValue + ",";
                            query += "micr_kg=" + txtKilos.Text + ",micr_butacas=" + txtButacas.Text + ",";
                            query += "micr_tipo_servicio='" + cmbServicios.SelectedValue + "' ";
                            query += "WHERE micr_id=" + Convert.ToInt16(txtMicroId.Text);
                            cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                llenarGrilla();
                ocultarBtnAcep();
                mostrarBtnOpe();
                desactivar();
            }
            else MessageBox.Show("Todos los campos deben estar completos, verificar");
        }
        private bool checkKilos()
        {
            return true;
        }
        private bool checkButacas()
        {
            if (Convert.ToInt16(txtButacas.Text) < (int)grdMicros.CurrentRow.Cells[5].Value)
            {
                //Verificar si existen pasajes vendidos.
                return false;
            }
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ocultarBtnAcep();
            mostrarBtnOpe();
            desactivar();
            btnDistri.Enabled = true;
        }

        private bool llenarComboDelete()
        {

            try
            {
                string query = "SELECT a.micr_id as id, a.micr_patente as Patente FROM  PRIVILEGIOS_INSUFICIENTES.micros a, PRIVILEGIOS_INSUFICIENTES.micros b ";
                query += "WHERE a.micr_id <> " + Convert.ToInt16(txtMicroId.Text) + " AND a.micr_tipo_servicio=b.micr_tipo_servicio AND a.micr_modelo=b.micr_modelo AND ";
                query += "a.micr_id_marca=b.micr_id_marca AND b.micr_kg <= a.micr_kg AND b.micr_butacas <= a.micr_butacas AND a.micr_tipo_servicio=b.micr_tipo_servicio ";
                query += "EXCEPT ";
                query += "(SELECT dest_id_micro, micr_patente ";
                query += "FROM PRIVILEGIOS_INSUFICIENTES.destinos, PRIVILEGIOS_INSUFICIENTES.micros ";
                query += "WHERE dest_id_micro=micr_id AND dest_fecha_salida IN ( SELECT dest_fecha_salida FROM PRIVILEGIOS_INSUFICIENTES.destinos ";
                query += "WHERE dest_fecha_salida > '" + Common.fecha + "' AND dest_id_micro = " + Convert.ToInt16(txtMicroId.Text) + " ))";
                cmd = new SqlCommand(query, Common.globalConn);
                adapter = new SqlDataAdapter(cmd);
                tabla = new DataTable();
                //if (tabla.Rows.Count == 0) { return false; }
                adapter.Fill(tabla);
                cmbMicros.DisplayMember = "Patente";
                cmbMicros.ValueMember = "id";
                cmbMicros.DataSource = tabla;
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private bool checkPasajes(string fechaSalida)
        {
            try
            {
                string query = "SELECT dest_id FROM PRIVILEGIOS_INSUFICIENTES.destinos WHERE ";
                query += "dest_id_micro = " + txtMicroId.Text + " AND dest_fecha_salida >='" + fechaSalida + "'";
                cmd = new SqlCommand(query, Common.globalConn);
                adapter = new SqlDataAdapter(cmd);
                tabla = new DataTable();
                adapter.Fill(tabla);
                if (tabla.Rows.Count == 0) { return true; } else { return false; }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMicroId.Text != "")
            {
                grdMicros.Enabled = false;
                if (!checkPasajes(Common.fecha))
                {
                    txtMicroMsg.Text = "El micro " + txtPatente.Text + " posee pasajes pendientes puede cancelarlos o reemplazar por otro micro con las mismas caracteristicas";
                }
                if (!(llenarComboDelete()))
                {
                    txtMicroMsg.Text = "El micro " + txtPatente.Text + " tiene pasajes pendientes y NO hay micros disponibles.";
                    btnReempl.Enabled = false;
                    cmbMicros.Enabled = false;
                }
                grpDelete.Visible = true;
            }
            else MessageBox.Show("Debe seleccionar un Micro para eliminar", "ATENCION");
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            ocultarBtnOpe();
            ActivarCampos(true);
            mostarBtnAcep();
            controlOpe = 1;
            btnDistri.Enabled = false;
        }

        private void btnDistri_Click(object sender, EventArgs e)
        {
            Form frmMicroDistri;
            frmMicroDistri = new FrbaBus.frmMicroDistri(Convert.ToInt16(txtMicroId.Text));
            frmMicroDistri.Visible = true;
            btnReempl.Enabled = true;
            cmbMicros.Enabled = true;
        }
        private void btnReempl_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE PRIVILEGIOS_INSUFICIENTES.destinos SET dest_id_micro=" + cmbMicros.ValueMember + " WHERE ";
                query += " dest_id_micros =" + txtMicroId.Text;
                cmd = new SqlCommand(query, Common.globalConn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grpDelete.Visible = false;
            grdMicros.Enabled = true;
        }
        private void insertFalla(string fechaInicio, string fechaFin, bool repair)
        {
            try
            {
                if (repair) { fechaFin = "'" + fechaFin + "'"; }
                string query = "INSERT INTO PRIVILEGIOS_INSUFICIENTES.fallas VALUES (" + txtMicroId.Text + ",'" + Common.fecha + "'," + fechaFin + ")";
                cmd = new SqlCommand(query, Common.globalConn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string query = "DELETE FROM PRIVILEGIOS_INSUFICIENTES.destinos WHERE ";
                    query += " dest_id_micros =" + txtMicroId.Text;
                    cmd = new SqlCommand(query, Common.globalConn);
                    cmd.ExecuteNonQuery();
                    insertFalla(Common.fecha, "", false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void btnRepairOk_Click(object sender, EventArgs e)
        {
            if (datFechaInicio.Value < Convert.ToDateTime(Common.fecha))
            {
                MessageBox.Show("Debe seleccionar una fecha superior al dia de hoy");
            }
            else
            {
                if (!checkRepair())
                {
                    MessageBox.Show("Este micro ya tiene programada una reparación en esa fecha");
                }
                else
                {
                    if (!checkPasajes(Common.fechaSQL(datFechaInicio)))
                    {
                        grpDelete.Visible = true;
                        llenarComboDelete();
                        btnDel.Enabled = false;
                    }
                    else
                    {
                        insertFalla(Common.fechaSQL(datFechaInicio), Common.fechaSQL(datFechaFin), true);
                        MessageBox.Show("Se ha calendarizado la reparación solicitada");
                        grdRepair.Visible = false;
                        grdMicros.Enabled = true;
                        llenarGrilla();
                    }
                }
            }
        }
        private bool checkRepair()
        {
            try
            {
                string query = "SELECT fall_id_micro FROM PRIVILEGIOS_INSUFICIENTES.fallas ";
                query += "WHERE '" + Common.fecha + "' BETWEEN fall_finicio AND fall_ffin AND fall_id_micro=" + txtMicroId.Text;
                cmd = new SqlCommand(query, Common.globalConn);
                adapter = new SqlDataAdapter(cmd);
                tabla = new DataTable();
                adapter.Fill(tabla);
                if (tabla.Rows.Count == 0) { return true; } else { return false; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        private void cmbRepair_Click(object sender, EventArgs e)
        {
            if (txtMicroId.Text != "")
            {

                grdRepair.Visible = true;
                grdMicros.Enabled = false;
                datFechaInicio.Focus();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un micro para enviar a reparacion !");
            }
        }

        private void btnCancelRepair_Click(object sender, EventArgs e)
        {
            grdRepair.Visible = false;
            grdMicros.Enabled = true;
        }

        private void txtMicroId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}