using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace FrbaBus.Login
{
    public partial class frmLogin : Form
    {
        private static int intentosFallidos;
        private int userRole = 0;
        private frmUtnBus frmUtnBus;
        public frmLogin(Form frmUtnBus)
        {
            InitializeComponent();
            if (intentosFallidos == 3)
                deshabilitar();
            this.frmUtnBus = (frmUtnBus)frmUtnBus;
        }

        public static string sha256encrypt(string phrase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(phrase));
            return byteArrayToString(hashedDataBytes);
        }

        public static string byteArrayToString(byte[] inputArray)
        {
            StringBuilder output = new StringBuilder("");
            for (int i = 0; i < inputArray.Length; i++)
            {
                output.Append(inputArray[i].ToString("X2"));


            }
            return output.ToString();
        }


        private bool camposValidados()
        {

            if (txtUser.ReadOnly)
                MessageBox.Show("Ha sido deshabilitado por realizar 3 intentos fallidos");
            else if (txtUser.Text.Equals(""))
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
                //using (SqlConnection conn = Common.conectar())
                try
                {



                    SqlCommand cmd2 = new SqlCommand(
                                        "SELECT count(*) " +
                                        "FROM PRIVILEGIOS_INSUFICIENTES.Intentos " +
                                        "WHERE inte_usuario ='" + txtUser.Text + "'", Common.globalConn/*conn*/);
                    int intentosUser = (int)cmd2.ExecuteScalar();
                    

                    if (intentosUser > 2)
                        MessageBox.Show("El usuario " + txtUser.Text + " está inhabilitado por haber realizado al menos 3 intentos fallidos de login.");
                    else
                    {
                        SqlCommand cmd = new SqlCommand(
                        "SELECT usua_role " +
                        "FROM PRIVILEGIOS_INSUFICIENTES.Usuarios " +
                        "WHERE usua_nombre ='" + txtUser.Text + "' AND " +
                        "usua_pass = '" + sha256encrypt(txtPass.Text) + "'", Common.globalConn/*conn*/);

                        using (var myReader = cmd.ExecuteReader())
                        {
                            if (myReader.Read())
                            {
                                myReader.Close();
                                userRole = (int)cmd.ExecuteScalar();                                
                                string query = "DELETE FROM PRIVILEGIOS_INSUFICIENTES.Intentos " +
                                               "WHERE inte_usuario = '" + txtUser.Text + "'";
                                SqlCommand cmd3 = new SqlCommand(query, Common.globalConn);
                                cmd3.ExecuteNonQuery();
                                MessageBox.Show("Ha ingresado con éxito.");
                                //intentosFallidos = 0;
                                ingresoExitoso = true;
                                frmUtnBus.modoLogueado();
                                
                            }
                            else
                            {
                                myReader.Close();
                                SqlCommand cmd3 = new SqlCommand(
                                "SELECT count(*) " +
                                "FROM PRIVILEGIOS_INSUFICIENTES.Usuarios " +
                                "WHERE usua_nombre ='" + txtUser.Text + "'", Common.globalConn/*conn*/);
                                int existeUsuario = (int) cmd3.ExecuteScalar();
                                if (existeUsuario == 0)
                                {
                                    MessageBox.Show("El usuario no existe");
                                }
                                else
                                {

                                    string query = "INSERT INTO PRIVILEGIOS_INSUFICIENTES.Intentos (inte_usuario, inte_fecha) " +
                                                   "VALUES ('" + txtUser.Text + "','" + Common.fecha + "')";
                                    SqlCommand cmd4 = new SqlCommand(query, Common.globalConn);
                                    cmd4.ExecuteNonQuery();

                                    if (intentosUser == 2)
                                    {
                                        //intentosFallidos++;
                                        MessageBox.Show("Ha sido deshabilitado por realizar 3 intentos fallidos");

                                        //deshabilitar();
                                    }
                                    else
                                    {
                                        //intentosFallidos++;
                                        MessageBox.Show("Login incorrecto, intentos fallidos: " + (intentosUser + 1) + ". A los 3 intentos fallidos será inhabilitado");
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //finally
                //{
                //    if (conn != null)
                //        conn.Close();
                //}
                if (ingresoExitoso)
                {

                    this.Close();
                    frmUtnBus.crearMenusAdmin(userRole);
                    //frmUtnBus.Visible = true;
                }
            }
        }

        private void deshabilitar()
        {
            txtPass.Text = "";
            txtUser.Text = "";
            txtUser.ReadOnly = true;
            txtPass.ReadOnly = true;
        }
    }
}
