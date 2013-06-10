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
        }

        internal void cargarGridDelMicro(string patente)
        {
            using (SqlConnection conn = Common.conectar())
                try
                {
                    SqlCommand cmd = new SqlCommand(
                    "SELECT micr_modelo, marc_nombre, micr_kg, micr_butacas, micr_tipo_servicio " +
                    "FROM Micros, Marcas_micros " +
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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM ciudades", conn);
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
            cargarGridDelMicro(txtPatente.Text);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Common.conectar())
                try
                {
                    SqlCommand cmd = new SqlCommand(
                    "UPDATE destinos "+
                    "SET dest_fecha_llegada = '"+dateLLegada.Value+"'"+
                    "WHERE dest_id = (SELECT TOP (1) dest_id "+
                                     "FROM Destinos, Micros, Precios "+
                                     "WHERE micr_patente = '"+txtPatente.Text+"' AND "+
                                     "micr_id = dest_id_micro AND "+
                                     "dest_viaje = prec_viaje_codigo AND "+
                                     "prec_id_destino = "+cmbDestino.SelectedValue.ToString()+" AND "+
                                     "prec_id_origen = "+cmbOrigen.SelectedValue.ToString()+" AND "+
                                     "dest_fecha_salida < '"+dateLLegada.Value+"' AND "+
                                     "DATEDIFF(hh, dest_fecha_salida, '"+dateLLegada.Value+"') < 24 "+
                                     "ORDER BY DATEDIFF(hh, dest_fecha_salida, '"+dateLLegada.Value+"'))", conn);
                    if(cmd.ExecuteNonQuery()==0)
                        MessageBox.Show("Los datos a ingresar no cumplen las restricciones del sistema");
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

    }



}
