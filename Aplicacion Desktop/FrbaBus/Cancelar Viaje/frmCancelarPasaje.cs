﻿using System;
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
                
                string query = "select pasa_codigo,'ENCOMIENDA' tipo "
                                + "from privilegios_insuficientes.Pasajes, privilegios_insuficientes.Encomiendas "
                                + "where enco_codigo = pasa_codigo "
                                + "and pasa_voucher =" + Convert.ToInt16(txtVoucher.Text)
                                + "union "
                                + "select pasa_codigo, 'butaca nro: ' + cast(pers_codigo as varchar)   "
                                + "from privilegios_insuficientes.Pasajes, privilegios_insuficientes.Personas "
                                + "where pasa_codigo = pers_codigo "
                                + "and pasa_voucher =" + Convert.ToInt16(txtVoucher.Text);

                cmd = new SqlCommand(query, Common.globalConn);
                adapter = new SqlDataAdapter(cmd);
                tablaPasajes = new DataTable();
                adapter.Fill(tablaPasajes);
                cklbPasajes.DataSource = tablaPasajes;
                cklbPasajes.DisplayMember = "tipo";
                cklbPasajes.ValueMember = "pasa_codigo";


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



        }




    }
}
