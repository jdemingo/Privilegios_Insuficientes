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

namespace FrbaBus.Abm_Roles
{
    public partial class frmRoles : Form
    {
        DataTable tablaFunciones;
        DataTable tablaRoles;
        DataTable tablaFuncionesRol; 
        SqlCommand cmd;
        SqlDataAdapter adapter;
       // string nombreRolActual;
        //SqlCommand cmd2;
        //SqlDataAdapter adapter2;
              

        public frmRoles()
        {
            InitializeComponent();
        }

        private void actualizar_estados(int indice ) {


             using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "select * from privilegios_insuficientes.funciones where func_role_id="+indice;
                    cmd = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    tablaFuncionesRol = new DataTable();
                    adapter.Fill(tablaFuncionesRol);
                    txtBoxRolMod.Text = cmbRol.Text;
                    

                    if ((tablaRoles.Select("ROLE_INHABILITADO = 'S' and ROLE_ID =" + indice)).Count() >= 1) ckbInhabilitar.Checked = true; else ckbInhabilitar.Checked = false;

            String tipo_func;



            for (int i = 0; i < clbFunciones.Items.Count; i++)
            {

                tipo_func = tablaFunciones.Rows[i][0].ToString();

                if ((tablaFuncionesRol.Select("FUNC_NOMBRE = '" + tipo_func + "'")).Count() >= 1)
                {
                    clbFunciones_mod.SetItemChecked(i, true);
                }
                else
                {
                    clbFunciones_mod.SetItemChecked(i, false);

                }
            }
            ;

                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    if (conn != null)
                        conn.Close();
                }

            }

        
        }

        private int obtenerUltimoRol()
        {

            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "select max(role_id) role_id_m from privilegios_insuficientes.roles";

                    cmd = new SqlCommand(query, conn);
                    DataTable ult_rol;
                    ult_rol = new DataTable();
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ult_rol);

                    return Convert.ToInt16(ult_rol.Rows[0][0]);

                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    if (conn != null)
                        conn.Close();
                }

                return 0;
            }
        
        
        
        }


        private void crearCombos()
        {
            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "select * from privilegios_insuficientes.FUNCIONES_existentes";
                    cmd = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    tablaFunciones = new DataTable();
                    adapter.Fill(tablaFunciones);
                    clbFunciones.DataSource = tablaFunciones;
                    clbFunciones.DisplayMember = "func_nombre";
                    clbFunciones_mod.DataSource = tablaFunciones;
                    clbFunciones_mod.DisplayMember = "func_nombre";

                    query = "select * from privilegios_insuficientes.roles";
                    cmd = new SqlCommand(query, conn);
                    adapter = new SqlDataAdapter(cmd);
                    tablaRoles = new DataTable();
                    adapter.Fill(tablaRoles);
                    cmbRol.DisplayMember = "role_nombre";
                    cmbRol.ValueMember = "role_id";
                    cmbRol.DataSource = tablaRoles;

                  
                
                
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    if (conn != null)
                        conn.Close();

                }
            }
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {

            crearCombos();

        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( cmbRol.ValueMember != null ) 
            actualizar_estados(Convert.ToInt16(cmbRol.SelectedValue));

        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {



            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query = "delete from privilegios_insuficientes.roles where role_id="+cmbRol.SelectedValue;
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    if (conn != null)
                        conn.Close();
                }

            }



            crearCombos();


        }

        private void bttModificar_Click(object sender, EventArgs e)
        {
            bttEliminar.Visible = false;
            bttModificar.Visible = false;
            cmbRol.Visible = false;
            txtBoxRolMod.Visible = true;
            bttGuardarCambios.Visible = true;
            gboxFunc.Visible = true;
            ckbInhabilitar.Visible = true;
            actualizar_estados(Convert.ToInt16(cmbRol.SelectedValue));
        }

        private void bttGuardarCambios_Click(object sender, EventArgs e)
        {
            ///UPDATE Y PISO EL NOMBRE Y LA HABILITACION.
            ///TRIGER FOR UPDATE, DONDE SI INHABILITO, UPDATEO USUARIOS.
            ///

            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    string query;
                    if (ckbInhabilitar.Checked)
                    {
                         query = "update privilegios_insuficientes.roles set role_inhabilitado = 'S' , role_nombre='"+txtBoxRolMod.Text+"' where role_id="+Convert.ToInt16(cmbRol.SelectedValue);
                    }
                    else
                    {
                        query = "update privilegios_insuficientes.roles set role_inhabilitado = null , role_nombre ='" + txtBoxRolMod.Text + "' where role_id ="+Convert.ToInt16(cmbRol.SelectedValue);
                    }
                    
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();






                    for (int i = 0; i < clbFunciones_mod.Items.Count; i++)
                    {

                        string tipo_serv = tablaFunciones.Rows[i][0].ToString();
                        if (clbFunciones_mod.GetItemChecked(i))
                        {
                            //si existe, lo inseto. sino, lo borro.

                            if ((tablaFuncionesRol.Select("FUNC_NOMBRE = '" + tipo_serv + "'")).Count() >= 1)
                            {
                                //NADA
                            }
                            else
                            {
                                ////INSERTO.
                                query = "insert into privilegios_insuficientes.FUNCIONES values( " + Convert.ToInt16(cmbRol.SelectedValue) + ", '" + tipo_serv + "')";
                                cmd = new SqlCommand(query, conn);
                                cmd.ExecuteNonQuery();
                            }


                        }
                        else
                        {
                            //si existe, lo borro

                            if ((tablaFuncionesRol.Select("FUNC_NOMBRE = '" + tipo_serv + "'")).Count() >= 1)
                            {
                                /// LO BORRO

                                query = "DELETE FROM  privilegios_insuficientes.FUNCIONES where func_role_id =" + Convert.ToInt16(cmbRol.SelectedValue) + " and func_nombre='" + tipo_serv + "'";
                                cmd = new SqlCommand(query, conn);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                //NADA
                            }


                        }
                    }
                    ;












                
                
                
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    if (conn != null)
                        conn.Close();
                }

            }


          
                    
        }

        private void bttNuevo_Click(object sender, EventArgs e)
        {


            using (SqlConnection conn = Common.conectar())
            {
                try
                {
                    
                      string query;
                      if (ckbInhabiliNuevo.Checked)
                    {
                        query = "insert into privilegios_insuficientes.roles (role_nombre,role_inhabilitado) values ('" + txtbNuevo.Text + "','S')";
                    }
                    else
                    {
                        query = "insert into privilegios_insuficientes.roles (role_nombre) values ('" + txtbNuevo.Text + "')";  
                    }
                    
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();








                    for (int i = 0; i < clbFunciones_mod.Items.Count; i++)
                    {

                        string tipo_serv = tablaFunciones.Rows[i][0].ToString();
                        if (clbFunciones_mod.GetItemChecked(i))
                        {
                            //si existe, lo inseto. sino, lo borro.

                            int ultimo_rol = obtenerUltimoRol();
                           
                                query = "insert into privilegios_insuficientes.FUNCIONES values( " + ultimo_rol + ", '" + tipo_serv + "')";
                                cmd = new SqlCommand(query, conn);
                                cmd.ExecuteNonQuery();
                            }



                        
                    }
                    ;



                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    if (conn != null)
                        conn.Close();
                }

            }




            crearCombos();
            verificarExistenciaRol();
        }

        private void txtbNuevo_TextChanged(object sender, EventArgs e)
        {
            //compruebo la existencia del nombre.
            verificarExistenciaRol();
        }

        private void verificarExistenciaRol()
        {

            if (((tablaRoles.Select("ROLE_NOMBRE = '" + txtbNuevo.Text.ToString() + "'")).Count() >= 1) || (txtbNuevo.Text.ToString() == ""))
            {

                lblRolExistenteN.Visible = true;
                bttNuevo.Enabled = false;
            }
            else
            {
                lblRolExistenteN.Visible = false;
                bttNuevo.Enabled = true;
            }


        }

        private void verificarExistenciaRolMod()
        {
            
          string  nombreRolActual = cmbRol.Text;
          //
          if (((tablaRoles.Select("ROLE_NOMBRE <> '"+nombreRolActual+"' and ROLE_NOMBRE = '" + txtBoxRolMod.Text.ToString() + "'")).Count() >= 1) || (txtBoxRolMod.Text.ToString() == ""))
            {

                lblRolExistenteMod.Visible = true;
                bttGuardarCambios.Enabled = false;
            }
            else
            {
                lblRolExistenteMod.Visible = false;
                bttGuardarCambios.Enabled = true;
            }


        }

        private void txtBoxRolMod_TextChanged(object sender, EventArgs e)
        {
            verificarExistenciaRolMod();
        }
    }
}


