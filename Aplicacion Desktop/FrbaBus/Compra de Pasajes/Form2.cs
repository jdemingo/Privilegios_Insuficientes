using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus.Compra_de_Pasajes
{
    public partial class Form2 : Form
    {

        //private Form frmCompraPasajes;
        private DataGridView grdPasajeros;

        public Form2(DataGridView grdPasajeros)
        {
            InitializeComponent();
            //this.frmCompraPasajes = (FrbaBus.Compra_de_Pasajes.frmCompraPasajes) frmCompraPasajes;
            this.grdPasajeros = grdPasajeros;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grdPasajeros.Rows.Count; i++)
            {
                grdPasajeros.Rows[i].Cells["vouc_dni"].Value = txtDNI.Text;
                grdPasajeros.Rows[i].Cells["vouc_id_tarjeta"].Value = txtTarjeta.Text;
                grdPasajeros.Rows[i].Cells["vouc_cuotas"].Value = txtCuotas.Text;
            }
        }

        private void chkEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            groupPago.Enabled = false;
        }
        private void chkTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            groupPago.Enabled = true;
        }
    }
}
