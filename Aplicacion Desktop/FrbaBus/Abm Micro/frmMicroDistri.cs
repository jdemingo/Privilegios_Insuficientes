using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaBus
{
    public partial class frmMicroDistri : Form
    {
        private int microId = 0;
        public frmMicroDistri(int micro)
        {
            InitializeComponent();
            microId = micro;
        }
        DataTable tabla;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlConnection conn = Common.conectar();
        

        public void llenarGrilla(int microId, int piso, DataGridView grilla)
        {
            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "select buta_numero as Butaca, buta_piso as Piso, buta_tipo as Tipo ";
                    query += " from PRIVILEGIOS_INSUFICIENTES.butacas";
                    query += " where buta_piso=" + piso + "and buta_micro = " + microId;
                    query += " order by buta_numero";
                    cmd = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    tabla = new DataTable();
                    adapter.Fill(tabla);
                    grilla.DataSource = tabla;
                    grilla.Columns[0].Width = 50;
                    grilla.Columns[1].Width = 30;
                    grilla.Columns[2].Width = 70;
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

        private void frmMicroDistri_Load(object sender, EventArgs e)
        {
            llenarGrilla(microId, 1, grdPiso1);
            llenarGrilla(microId, 2, grdPiso2);
        }

        private void grdPiso2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void traerDatos(DataGridView grilla)
        {
            txtButaca.Text = Convert.ToString(grilla.CurrentRow.Cells[0].Value);
            cmbPiso.Text = Convert.ToString(grilla.CurrentRow.Cells[1].Value);
            cmbTipo.Text = (string)grilla.CurrentRow.Cells[2].Value;
         }
        private void grdPiso1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            traerDatos(grdPiso1);
        }
        private void grdPiso2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            traerDatos(grdPiso2);
        }
        private void updButaca(int butaca, int piso, int microId) {
            MessageBox.Show("Actualizar butaca tener en cuenta si cambia de piso");
        }
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarGrilla(microId, 1, grdPiso1);
            llenarGrilla(microId, 2, grdPiso2);
        }
        private void cmdUpd_Click(object sender, EventArgs e)
        {
            updButaca(Convert.ToInt16(txtButaca.Text), Convert.ToInt16(cmbPiso.Text), microId);
        }

    }
}
