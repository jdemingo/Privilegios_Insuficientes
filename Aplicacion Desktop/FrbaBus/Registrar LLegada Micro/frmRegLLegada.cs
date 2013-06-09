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

    }

    

}
