using System;
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
            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "select " + id + "," + campo + " from " + tablaorigen;
                    cmd = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    tabla = new DataTable();
                    adapter.Fill(tabla);
                    combo.DisplayMember = campo;
                    combo.ValueMember = id;
                    combo.DataSource = tabla;
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

        private void llenarGrilla()
        {
            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "select micr_id as nroMicro, micr_patente as Patente, micr_modelo as Modelo, marc_nombre as Marca, ";
                    query += "micr_kg as Kilos, micr_butacas as Butacas, micr_tipo_servicio as Tipo ";
                    query += " from micros, marcas_micros";
                    query += " where micr_id_marca = marc_id";
                    cmd = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    tabla = new DataTable();
                    adapter.Fill(tabla);
                    grdMicros.DataSource = tabla;
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
        private void frmMicros_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbMarcas, "marcas_micros", "marc_nombre", "marc_id");
            llenarCombo(cmbServicios, "tipos", "tipo_servicio", "tipo_servicio");
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
        private bool validarCampos() {
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
                string query;
                switch (controlOpe)
                {
                    case 1:
                        query = "INSERT INTO micros(micr_f_alta, micr_patente, micr_modelo, micr_id_marca, micr_kg, micr_butacas, micr_tipo_servicio) ";
                        query += "VALUES ('" + dateAlta.Text + "','" + txtPatente.Text + "','" + txtModelo.Text + "',";
                        query += cmbMarcas.SelectedValue + "," + txtKilos.Text + ",";
                        query += txtButacas.Text + ",'" + cmbServicios.SelectedValue + "') ";
                        MessageBox.Show(query);
                        cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        break;
                    case 2:
                        query = "UPDATE micros SET ";
                        query += "micr_f_alta='" + dateAlta.Text + "',micr_patente='" + txtPatente.Text + "',";
                        query += "micr_modelo='" + txtModelo.Text + "',micr_id_marca=" + cmbMarcas.SelectedValue + ",";
                        query += "micr_kg=" + txtKilos.Text + ",micr_butacas=" + txtButacas.Text + ",";
                        query += "micr_tipo_servicio='" + cmbServicios.SelectedValue + "' ";
                        query += "WHERE micr_id=" + Convert.ToInt16(txtMicroId.Text);
                        MessageBox.Show(query);
                        cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        break;
                }
                llenarGrilla();
                ocultarBtnAcep();
                mostrarBtnOpe();
                desactivar();
            }
            else MessageBox.Show("Todos los campos deben estar completos, verificar");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ocultarBtnAcep();
            mostrarBtnOpe();
            desactivar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMicroId.Text != "")
            {
                using (SqlConnection conn = Common.conectar())
                {
                    try
                    {
                        string query = "DELETE * FROM micros WHERE micr_id=" + Convert.ToInt16(txtMicroId);
                        cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                    }
                }
            }
            else MessageBox.Show("Debe seleccionar un Micro para eliminar", "ATENCION");
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            ocultarBtnOpe();
            ActivarCampos(true);
            mostarBtnAcep();
            controlOpe = 1;
        }

        private void btnDistri_Click(object sender, EventArgs e)
        {
            Form frmMicroDistri;
            frmMicroDistri = new FrbaBus.frmMicroDistri();
            frmMicroDistri.Visible = true;
        }

        private void grdMicros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}