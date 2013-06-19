using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaBus.Canje_de_Ptos
{
    public partial class frmCanjePuntos : Form
    {

        public frmCanjePuntos()
        {
            InitializeComponent();
            cargarGridProductos();
            this.ActiveControl = txtDNI;
        }

        internal void cargarGridProductos()
        {
            using (SqlConnection conn = Common.conectar())
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT stoc_id_premio, stoc_nombre, stoc_puntos FROM PRIVILEGIOS_INSUFICIENTES.Stock_premios", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    grdProductos.DataSource = table;

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

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            actualizarCantidadRequerida();
        }

        private void actualizarCantidadRequerida()
        {
            if (!txtCantidad.Text.Equals(""))
            {
                decimal currentRow_puntos = (decimal)grdProductos.CurrentRow.Cells["stoc_puntos"].Value;
                int cantidad = int.Parse(txtCantidad.Text);
                lblPuntosReq.Text = (currentRow_puntos * cantidad).ToString();
            }
            else
            {
                lblPuntosReq.Text = "";
            }
        }

        private decimal puntosDisponibles(string dni)
        {
            decimal puntosDisp = -1;
            using (SqlConnection conn = Common.conectar())
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT SUM(pasa_puntos) " +
                        "FROM PRIVILEGIOS_INSUFICIENTES.Pasajes, PRIVILEGIOS_INSUFICIENTES.Clientes " +
                        "WHERE clie_dni ='" + dni + "' AND " +
                        "clie_id = pasa_cliente AND " +
                        "DATEDIFF(DAY,pasa_fcompra,GETDATE()) < 365", conn);
                    decimal puntos = (decimal)cmd.ExecuteScalar();

                    cmd = new SqlCommand("SELECT SUM(stoc_puntos) " +
                        "FROM PRIVILEGIOS_INSUFICIENTES.Stock_premios, PRIVILEGIOS_INSUFICIENTES.Premios_canjeados, PRIVILEGIOS_INSUFICIENTES.Clientes " +
                        "WHERE prem_cliente = clie_id AND " +
                        "clie_dni = '" + dni + "' AND " +
                        "DATEDIFF(DAY,prem_fcanje,GETDATE()) < 365 AND " +
                        "prem_id_premio = stoc_id_premio", conn);

                    decimal canjes = (decimal)cmd.ExecuteScalar();
                    puntosDisp = (puntos - canjes) < 0 ? 0 : (puntos - canjes);

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
            return puntosDisp;
        }

        private int cantStockDelPremio(int id_premio)
        {
            int cantStockDelPremio = -1;
            using (SqlConnection conn = Common.conectar())
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT stoc_cantidad " +
                        "FROM PRIVILEGIOS_INSUFICIENTES.Stock_premios " +
                        "WHERE stoc_id_premio =" + id_premio, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    cantStockDelPremio = (int)cmd.ExecuteScalar();
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
            return cantStockDelPremio;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (camposValidados())
            {
                int premioId = (int)grdProductos.CurrentRow.Cells["stoc_id_premio"].Value;
                using (SqlConnection conn = Common.conectar())
                    try
                    {
                        decimal ptsDisp;
                        int cantStock;
                        if ((ptsDisp = puntosDisponibles(txtDNI.Text)) < decimal.Parse(lblPuntosReq.Text))
                        {
                            MessageBox.Show("El cliente tiene " + ptsDisp.ToString() + " puntos, pero requiere " + lblPuntosReq.Text + " puntos");
                        }
                        else if ((cantStock = cantStockDelPremio(premioId)) < int.Parse(txtCantidad.Text))
                        {
                            MessageBox.Show("La cantidad en stock del premio elegido es " + cantStock.ToString() + " pero se desean " + txtCantidad.Text);
                        }
                        else
                        {
                            SqlCommand command = new SqlCommand(
                            "INSERT INTO PRIVILEGIOS_INSUFICIENTES.Premios_canjeados (prem_cliente, prem_id_premio, prem_id_cantidad, prem_fcanje) " +
                            "VALUES ((SELECT clie_id " +
                                     "FROM PRIVILEGIOS_INSUFICIENTES.Clientes " +
                                     "WHERE clie_dni = " + txtDNI.Text + ")," + premioId + "," + txtCantidad.Text + ",@value)", conn);
                            //DateTime.Parse("");
                            //String.Format("{0:DD MM YYYY}",dateTimePicker1);
                            command.Parameters.AddWithValue("@value", DateTime.Today);
                            command.ExecuteNonQuery();
                            command.CommandText = "UPDATE PRIVILEGIOS_INSUFICIENTES.Stock_premios " +
                            "SET stoc_cantidad = stoc_cantidad-" + txtCantidad.Text + " " +
                            "WHERE stoc_id_premio = " + premioId + "";
                            //command.CommandText = "UPDATE Pasajes SET pasa_puntos = pasa_puntos-" + lblPuntosReq.Text + " WHERE pasa_codigo = ";
                            command.ExecuteNonQuery();
                            MessageBox.Show("Canje registrado con éxito.");
                        }

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

        private void grdProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizarCantidadRequerida();

        }

        private bool camposValidados()
        {
            if (txtDNI.Text.Equals(""))
                MessageBox.Show("Falta llenar el campo DNI");
            else if (txtCantidad.Text.Equals(""))
                MessageBox.Show("Faltan llenar el campo Cantidad");
            else return true;
            return false;
        }

        private void grdProductos_CurrentCellChanged(object sender, EventArgs e)
        {
            actualizarCantidadRequerida();
        }

    }
}
