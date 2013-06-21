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
            this.ActiveControl = txtDNI;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarGridDelDNI(txtDNI.Text);
            cargarGridCanjesDelDNI(txtDNI.Text);
        }


        private bool camposValidados()
        {
            if (txtDNI.Text.Equals(""))
                MessageBox.Show("Falta llenar el campo DNI");
            else return true;
            return false;
        }

        internal void cargarGridDelDNI(string dni)
        {
            txtDNI.Text = dni;
            if (camposValidados())
            {
                try
                {
                    //"mes, importe, puntos, canjes, total_puntos";
                    SqlCommand cmd = new SqlCommand(
                    "SELECT datepart(year,pasa_fcompra) Año, DATENAME(month,pasa_fcompra) Mes, SUM(pasa_puntos) Puntos, " +
                    "SUM(pasa_precio) Importe " +
                    "FROM PRIVILEGIOS_INSUFICIENTES.Pasajes, PRIVILEGIOS_INSUFICIENTES.Clientes " +
                    "WHERE clie_dni =" + txtDNI.Text + " AND " +
                    "DATEDIFF(DAY,pasa_fcompra,GETDATE())<365 AND " +
                    "clie_id = pasa_cliente " +
                    "GROUP BY datepart(year,pasa_fcompra), DATENAME(month,pasa_fcompra), datepart(month,pasa_fcompra) " +
                    "ORDER BY 1, datepart(month,pasa_fcompra)", Common.globalConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    grdPuntos.DataSource = table;
                    lblTotalPuntos.Text = table.Compute("SUM(Puntos)", "").ToString();

                    if (lblTotalPuntos.Text.Equals(""))
                        lblTotalPuntos.Text = "0";

                    //double resul = grdPuntos.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["Puntos"].Value));
                    //lblTotalPuntos.Text = resul.ToString();

                    //double sumatoria = 0;
                    //foreach (DataGridViewRow row in grdPuntos.Rows)
                    //{
                    //    sumatoria += Convert.ToDouble(row.Cells["Puntos"].Value);
                    //}
                    //lblTotalPuntos.Text = sumatoria.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        internal void cargarGridCanjesDelDNI(string dni)
        {
            txtDNI.Text = dni;
            lblTotalCanjes.Text = "0";
            if (!txtDNI.Text.Equals(""))
            {
                using (SqlConnection conn = Common.conectar())
                    try
                    {
                        //"mes, importe, puntos, canjes, total_puntos";
                        SqlCommand cmd = new SqlCommand(
                        "SELECT datepart(year,prem_fcanje) Año, DATENAME(month,prem_fcanje) Mes, SUM(stoc_puntos*prem_id_cantidad) Puntos " +
                        "FROM PRIVILEGIOS_INSUFICIENTES.Clientes, PRIVILEGIOS_INSUFICIENTES.Stock_premios, PRIVILEGIOS_INSUFICIENTES.Premios_canjeados " +
                        "WHERE clie_dni =" + txtDNI.Text + " AND " +
                        "DATEDIFF(DAY,prem_fcanje,GETDATE())<365 AND " +
                        "prem_cliente = clie_id AND " +
                        "prem_id_premio = stoc_id_premio " +
                        "GROUP BY datepart(year,prem_fcanje), DATENAME(month,prem_fcanje),datepart(month,prem_fcanje) " +
                        "ORDER BY 1,datepart(month,prem_fcanje)", conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        grdCanjes.DataSource = table;
                        lblTotalCanjes.Text = table.Compute("SUM(Puntos)", "").ToString();

                        if (lblTotalCanjes.Text.Equals(""))
                            lblTotalCanjes.Text = "0";

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


    }
}
