using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaBus
{
    public partial class frmUtnBus : Form
    {
        public frmUtnBus()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmMicros;
            frmMicros = new FrbaBus.Abm_Micro.frmMicros();
            frmMicros.Visible = true;
        }

        private void frmUtnBus_Load(object sender, EventArgs e)
        {
        }
        private void frmUtnBus_Key(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.Control) textBox1.Text = "prueba";
        }
        private void menuABMMicros_Click(object sender, EventArgs e)
        {
            Form frmMicros;
            frmMicros = new FrbaBus.Abm_Micro.frmMicros();
            frmMicros.Visible = true;
        }
        private void menuABMRecorridos_Click(object sender, EventArgs e)
        {
            Form frmMicros;
            frmMicros = new FrbaBus.Abm_Micro.frmMicros();
            frmMicros.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cuando presionan este boton debe pedir el login y Crea el Menu");

            MainMenu mainMenu = new MainMenu();
            this.Menu = mainMenu;
            MenuItem menuABM = new MenuItem("&ABMs");
            MenuItem menuABMMicros = new MenuItem("&Micros");
            MenuItem menuABMRecorridos = new MenuItem("&Recorridos");
            mainMenu.MenuItems.Add(menuABM);
            menuABM.MenuItems.Add(menuABMMicros);
            menuABM.MenuItems.Add(menuABMRecorridos);
            menuABMMicros.Click += new System.EventHandler(this.menuABMMicros_Click);
            menuABMRecorridos.Click += new System.EventHandler(this.menuABMRecorridos_Click);

        }
    }
}
