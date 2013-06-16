using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaBus.Login
{
    public partial class frmLogin : Form
    {
        int intentosFallidos = 0;
        int userRole = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private bool camposValidados()
        {

            if (txtUser.Text.Equals(""))
                MessageBox.Show("Falta llenar el campo Usuario");
            else if (txtPass.Text.Equals(""))
                MessageBox.Show("Faltan llenar el campo Contraseña");
            else return true;
            return false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (camposValidados())
            {
                bool ingresoExitoso = false;
                using (SqlConnection conn = Common.conectar())
                    try
                    {

                        SqlCommand cmd = new SqlCommand(
                        "SELECT usua_role " +
                        "FROM PRIVILEGIOS_INSUFICIENTES.Usuarios " +
                        "WHERE usua_nombre ='" + txtUser.Text + "' AND " +
                        "usua_pass = '" + txtPass.Text + "'", conn);
                        using (var myReader = cmd.ExecuteReader())
                        {
                            if (myReader.Read())
                            {
                                myReader.Close();
                                userRole = (int)cmd.ExecuteScalar();
                                MessageBox.Show("Ha ingresado con éxito.");
                                ingresoExitoso = true;
                            }
                            else if (intentosFallidos == 2)
                            {
                                MessageBox.Show("Ha sido deshabilitado por realizar 3 intentos fallidos");
                                intentosFallidos = 0;
                                txtPass.Text = "";
                                txtUser.Text = "";
                                txtUser.ReadOnly = true;
                                txtPass.ReadOnly = true;
                            }
                            else
                            {
                                intentosFallidos++;
                                MessageBox.Show("Login incorrecto, intentos fallidos: " + intentosFallidos.ToString() + ". A los 3 intentos fallidos sera deshabilitado");
                            }
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
                if (ingresoExitoso)
                {

                    frmUtnBus frmUtnBus = new frmUtnBus();
                    frmUtnBus.crearMenu(userRole);
                    frmUtnBus.Show();
                    this.Visible = false;
                }
            }
        }
    }
}
