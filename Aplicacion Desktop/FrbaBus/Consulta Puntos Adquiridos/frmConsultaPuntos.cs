using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaBus.Consulta_Puntos_Adquiridos
{
    public partial class frmConsultaPuntos : Form
    {
        public frmConsultaPuntos()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarGridDelDNI(txtDNI.Text);
        }

        internal void cargarGridDelDNI(string dni) 
        {
            txtDNI.Text = dni;
            if(!txtDNI.Text.Equals("")){
            using (SqlConnection conn = Common.conectar())
                try
                {
                    SqlCommand cmd = new SqlCommand(
                    "SELECT pasa_puntos, pasa_precio, pasa_fcompra, pasa_cliente "+
                    "FROM Pasajes, Clientes "+
                    "WHERE clie_dni ='" + txtDNI.Text + "' AND "+
                    "clie_id = pasa_cliente", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    grdPuntos.DataSource = table;
                    lblTotalPuntos.Text = table.Compute("SUM(pasa_puntos)", "").ToString();

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

        private void btnCanjesPrueba_Click(object sender, EventArgs e)
        {
            FrbaBus.Canje_de_Ptos.frmCanjePuntos frmCanjePuntos = new FrbaBus.Canje_de_Ptos.frmCanjePuntos();
            frmCanjePuntos.Show();
        }

        private void btnRegLLegada_Click(object sender, EventArgs e)
        {
            FrbaBus.Registrar_LLegada_Micro.frmRegLLegada frmRegLLegada = new FrbaBus.Registrar_LLegada_Micro.frmRegLLegada();
            frmRegLLegada.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrbaBus.Login.frmLogin frmLogin = new FrbaBus.Login.frmLogin();
            frmLogin.Show();
        }

    }
}
