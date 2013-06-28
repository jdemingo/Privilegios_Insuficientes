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
            try
            {
                string query = "SELECT stoc_id_premio, stoc_nombre, stoc_puntos FROM PRIVILEGIOS_INSUFICIENTES.Stock_premios";
                SqlCommand cmd = new SqlCommand(query, Common.globalConn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                grdProductos.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                int currentRow_puntos = Convert.ToInt16(grdProductos.CurrentRow.Cells["stoc_puntos"].Value);
                int cantidad = int.Parse(txtCantidad.Text);
                lblPuntosReq.Text = (currentRow_puntos * cantidad).ToString();
            }
            else
            {
                lblPuntosReq.Text = "";
            }
        }

        private int puntosDisponibles(string dni)
        {
            int puntosDisp = 0;
                try
                {
                    string query = "SELECT SUM(pasa_puntos) " +
                        "FROM PRIVILEGIOS_INSUFICIENTES.Pasajes, PRIVILEGIOS_INSUFICIENTES.Clientes " +
                        "WHERE clie_dni ='" + dni + "' AND " +
                        "clie_id = pasa_cliente AND " +
                        "DATEDIFF(DAY,pasa_fcompra,'"+Common.fechaFuncion+"') < 365";
                    SqlCommand cmd = new SqlCommand(query, Common.globalConn);
                    puntosDisp = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            return puntosDisp;
        }

        private int cantStockDelPremio(int id_premio)
        {
            int cantStockDelPremio = 0;
                try
                {
                    string query = "SELECT stoc_cantidad " +
                        "FROM PRIVILEGIOS_INSUFICIENTES.Stock_premios " +
                        "WHERE stoc_id_premio =" + id_premio;
                    SqlCommand cmd = new SqlCommand(query, Common.globalConn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    cantStockDelPremio = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                        int ptsDisp;
                        int cantStock;
                        if ((ptsDisp = puntosDisponibles(txtDNI.Text)) < int.Parse(lblPuntosReq.Text))
                        {
                            MessageBox.Show("El cliente tiene " + ptsDisp.ToString() + " puntos, pero requiere " + lblPuntosReq.Text + " puntos");
                        }
                        else if ((cantStock = cantStockDelPremio(premioId)) < int.Parse(txtCantidad.Text))
                        {
                            MessageBox.Show("La cantidad en stock del premio elegido es " + cantStock.ToString() + " pero se desean " + txtCantidad.Text);
                        }
                        else
                        {
                            string query="EXECUTE PRIVILEGIOS_INSUFICIENTES.canjearPremios " + premioId + "," + txtDNI.Text + "," + txtCantidad.Text + ",'" + Common.fechaFuncion + "'";
                            SqlCommand cmd = new SqlCommand(query, Common.globalConn);
                            cmd.ExecuteNonQuery();
                            /*                "INSERT INTO PRIVILEGIOS_INSUFICIENTES.Premios_canjeados (prem_cliente, prem_id_premio, prem_id_cantidad, prem_fcanje) " +
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
                                            command.ExecuteNonQuery();*/
                            MessageBox.Show("Canje registrado con éxito.");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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

        private void txtDNI_LostFocus(object sender, EventArgs e)
        {
            Common.validacionNumerica(txtDNI);
        }

    }
}
