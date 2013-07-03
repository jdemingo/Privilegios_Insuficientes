using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FrbaBus.Cancelar_Viaje
{
    public partial class frmCancelarPasajes : Form
    {
        DataTable tablaPasajes;
        SqlCommand cmd;
        SqlDataAdapter adapter;

        public frmCancelarPasajes()
        {
            InitializeComponent();
        }

        private void bttConsultar_Click(object sender, EventArgs e)
        {
              
            
        }

      
        private void txtVoucher_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttConsultar_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                string query = "select vent_codigo,'ENCOMIENDA' tipo "
                                + "from privilegios_insuficientes.ventas, privilegios_insuficientes.Encomiendas "
                                + "where enco_codigo = vent_codigo "
                                + "and vent_voucher =" + Convert.ToInt16(txtVoucher.Text)
                                + "union "
                                + "select vent_codigo, 'butaca nro: ' + cast(pasa_codigo as varchar)   "
                                + "from privilegios_insuficientes.ventas, privilegios_insuficientes.pasajes "
                                + "where vent_codigo = pasa_codigo "
                                + "and vent_voucher =" + Convert.ToInt16(txtVoucher.Text);

                cmd = new SqlCommand(query, Common.globalConn);
                adapter = new SqlDataAdapter(cmd);
                tablaPasajes = new DataTable();
                adapter.Fill(tablaPasajes);
                cklbPasajes.DataSource = tablaPasajes;
                cklbPasajes.DisplayMember = "tipo";
                cklbPasajes.ValueMember = "vent_codigo";


            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void bttDarDeBaja_Click(object sender, EventArgs e)
        {



            for (int i = 0; i < cklbPasajes.Items.Count; i++)
            {


                Int32 pasaje = Convert.ToInt32(tablaPasajes.Rows[i][0]);

                if (cklbPasajes.GetItemChecked(i))
                {

                   string query = "insert into privilegios_insuficientes.tmp_pasajes_cancelar values(" + pasaje + ",'" + txtMotivo.Text + "')";
                    cmd = new SqlCommand(query, Common.globalConn);
                    cmd.ExecuteNonQuery();

                    //inserto


                }
            }
            ;

            //////delete

            try
            {

                string query = "delete from privilegios_insuficientes.ventas "
                                + "where vent_codigo in ( select canc_cod_pasaje "
                                + "from privilegios_insuficientes.tmp_pasajes_cancelar ) ";

                cmd = new SqlCommand(query, Common.globalConn);
                adapter = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show(ex.Message);
            }


            MessageBox.Show("Baja de pasajes realizada con éxito");
            this.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void bttBajaPasaje_Click(object sender, EventArgs e)
        {

            string query = "insert into privilegios_insuficientes.tmp_pasajes_cancelar values(" + txtPasaje.Text + ",'" + txtMotivo.Text + "')";
            cmd = new SqlCommand(query, Common.globalConn);
            cmd.ExecuteNonQuery();


            try
            {

                string queryB = "delete from privilegios_insuficientes.ventas "
                                + "where vent_codigo in ( select canc_cod_pasaje "
                                + "from privilegios_insuficientes.tmp_pasajes_cancelar ) ";

                cmd = new SqlCommand(queryB, Common.globalConn);
                adapter = new SqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show(ex.Message);
            }


            MessageBox.Show("Baja de pasaje realizada con éxito");
            this.Close();


        }

        private void rdbPorPasaje_CheckedChanged(object sender, EventArgs e)
        {
            groupPasaje.Enabled = true;
            groupVoucher.Enabled = false;
            bttBajaPasaje.Enabled = true;
            bttDarDeBaja.Enabled = false;
        }

        private void rdbPorVoucher_CheckedChanged(object sender, EventArgs e)
        {
            groupPasaje.Enabled = false;
            groupVoucher.Enabled = true;
            bttBajaPasaje.Enabled = false;
            bttDarDeBaja.Enabled = true;
        }




    }
}
