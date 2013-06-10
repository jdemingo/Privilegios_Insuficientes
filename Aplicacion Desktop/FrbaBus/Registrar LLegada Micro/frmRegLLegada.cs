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
        }

        internal void cargarGridDelMicro(string patente)
        {
            using (SqlConnection conn = Common.conectar())
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT micr_id, micr_patente, micr_modelo, micr_kg, micr_tipo_servicio FROM Micros WHERE micr_patente ='" + txtPatente.Text + "'", conn);
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

        private void txtPatente_Leave(object sender, EventArgs e)
        {
            cargarGridDelMicro(txtPatente.Text);

        }

        // -1: error en try-catch, 0 no existe ese origen y destino, >0 origen y destino encontrado
        private bool origenYDestinoOk(string patente)
        {
            int coincidencias = -1;
            using (SqlConnection conn = Common.conectar())
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(1)" +
                    "FROM Micros, Destinos, Precios, Ciudades" +
                    "WHERE micr_patente = '" + patente + "' AND" +
                    "dest_id_micro = micr_id  AND" +
                    "dest_viaje = prec_viaje_codigo AND" +
                    "dest_fecha_llegada_estimada = '"+dateLLegada.Value.Date+"'"+
                    "prec_id_origen = " + cmbOrigen.SelectedValue.ToString() + " AND" +
                    "prec_id_destino =" + cmbDestino.SelectedValue.ToString(), conn);
                    coincidencias = (int) cmd.ExecuteScalar();               
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
            return ((coincidencias > 0) ? true : false);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (origenYDestinoOk(txtPatente.Text))
            {
                using (SqlConnection conn = Common.conectar())
                    try
                    {
                        //SqlCommand cmd = new SqlCommand("UPDATE Destinos SET dest_fecha_llegada = '"+dateLLegada.Value.Date+"' WHERE ", conn);
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
            else
            {
                MessageBox.Show("No se pudo registrar la llegada");
            }
        }

    }



}
