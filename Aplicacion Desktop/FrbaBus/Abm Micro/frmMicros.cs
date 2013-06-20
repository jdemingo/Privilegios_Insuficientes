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
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }
        }
    
        private void llenarGrilla()
        {
                try
                {
                    string query = "select micr_id as nroMicro, micr_patente as Patente, micr_modelo as Modelo, marc_nombre as Marca, ";
                    query += "micr_kg as Kilos, micr_butacas as Butacas, micr_tipo_servicio as Tipo ";
                    query += " from PRIVILEGIOS_INSUFICIENTES.micros, PRIVILEGIOS_INSUFICIENTES.marcas_micros";
                    query += " where micr_id_marca = marc_id";
                    cmd = new SqlCommand(query, Common.globalConn);
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
                string query;
                switch (controlOpe)
                {
                    case 1:
                        query = "INSERT INTO PRIVILEGIOS_INSUFICIENTES.micros(micr_f_alta, micr_patente, micr_modelo, micr_id_marca, micr_kg, micr_butacas, micr_tipo_servicio) ";
                        query += "VALUES ('" + dateAlta.Text + "','" + txtPatente.Text + "','" + txtModelo.Text + "',";
                        query += cmbMarcas.SelectedValue + "," + txtKilos.Text + ",";
                        query += txtButacas.Text + ",'" + cmbServicios.SelectedValue + "') ";
                        MessageBox.Show(query);
                        cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Hacer un trigger que me inserte las butacas");
                        break;
                    case 2:
                        if (checkButacas())
                        {
                            MessageBox.Show("Imposible eliminar las butacas, pasajes vendidos!");
                            break;
                        }
                        if (checkKilos()) { break;}

                            query = "UPDATE PRIVILEGIOS_INSUFICIENTES.micros SET ";
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
        private bool checkKilos()
        {
            return true;
        }
        private bool checkButacas()
        {
            if (Convert.ToInt16(txtButacas.Text) < (int)grdMicros.CurrentRow.Cells[5].Value)
            {
                MessageBox.Show("chequear si existen butacas vendidas");
                return false;
            }
            else
            {
                if (Convert.ToInt16(txtButacas.Text) > (int)grdMicros.CurrentRow.Cells[5].Value)
                {
                    MessageBox.Show("Insertar nuevas butacas");
                }
            }
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ocultarBtnAcep();
            mostrarBtnOpe();
            desactivar();
        }

        private bool llenarComboDelete() {

            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string HOY = "2013-19-06";
                    string query = "SELECT a.micr_id as id, a.micr_patente as Patente FROM  PRIVILEGIOS_INSUFICIENTES.micros a, PRIVILEGIOS_INSUFICIENTES.micros b ";
                    query += "WHERE NOT exists ";
                    query += "(SELECT 1 FROM PRIVILEGIOS_INSUFICIENTES.destinos ";
                    query += "WHERE dest_fecha_salida BETWEEN '" + HOY + "' AND '" + HOY + "' ";
                    query += "AND dest_id_micro = a.micr_id)AND a.micr_tipo_servicio = b.micr_tipo_servicio AND a.micr_kg = b.micr_kg ";
                    query += "AND a.micr_butacas = b.micr_butacas AND a.micr_modelo = b.micr_modelo AND b.micr_id != " + Convert.ToInt16(txtMicroId.Text);
                    cmd = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    tabla = new DataTable();
                    adapter.Fill(tabla);
                    cmbMicros.DisplayMember = "Patente";
                    cmbMicros.ValueMember = "id";
                    cmbMicros.DataSource = tabla;
                    MessageBox.Show("Verificar que si este vacia devuelva false");
                    return true;
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMicroId.Text != "")
            {
                grdMicros.Enabled = false;
                txtMicroMsg.Text = "El micro " + txtPatente.Text + " posee pasajes pendientes puede cancelarlos o reemplazar por otro micro con las mismas caracteristicas";
                if (!(llenarComboDelete()))
                {
                    txtMicroMsg.Text = "El micro " + txtPatente.Text + " tiene pasajes pendientes y NO hay micros disponibles.";
                    btnReempl.Enabled = false;
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
        }

        private void btnDistri_Click(object sender, EventArgs e)
        {
            Form frmMicroDistri;
            frmMicroDistri = new FrbaBus.frmMicroDistri(Convert.ToInt16(txtMicroId.Text));
            frmMicroDistri.Visible = true;
        }

        private void btnReempl_Click(object sender, EventArgs e)
        {

        }
    }
}