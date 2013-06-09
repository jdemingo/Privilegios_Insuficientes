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
      //  SqlConnection conn;
        DataTable tabla;
        SqlCommand cmd;
        SqlDataAdapter adapter;


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
                    string query = "select micr_patente as Patente, micr_modelo as Modelo, marc_nombre as Marca, micr_kg as Kilos, micr_butacas as Butacas ";
                    query+=" from micros, marcas_micros";
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
            llenarCombo(cmbServicios, "tipos", "tipo_porcentaje", "tipo_servicio");
            llenarGrilla();
        }
    }
}
