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

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int usuarioId;
            if (!txtUser.Text.Equals("") && !txtPass.Text.Equals(""))
            {
                using (SqlConnection conn = Common.conectar())
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SELECT usua_id FROM Usuarios WHERE usua_nombre ='" + txtUser.Text + "' AND usua_pass = '" + txtPass.Text + "'", conn);
                        usuarioId = (int)cmd.ExecuteScalar();

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
                // new frm(usuarioId)
            }
        }
    }
}
