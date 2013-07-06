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


namespace FrbaBus.Abm_Recorrido
{
    public partial class frmAbm_reco : Form
    {

        DataTable tablaOrigen;
        DataTable tablaDestino;
        DataTable tablaTiposServicios;
        DataTable tablaPrecios;
        DataTable tablaverificar_codigo;
        bool existe_reco=false;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        //SqlCommand cmd2;
        //SqlDataAdapter adapter2;
              

        public frmAbm_reco()
        {
            InitializeComponent();
           // Common.conectar();
        }


        private void verificar_codigo()
        {

                    string id_orig = cmbOrigen.SelectedValue.ToString();
                    string id_dest = cmbDestino.SelectedValue.ToString();
                    try
                    {

                        if (tablaverificar_codigo != null && txtbCodigo.Text != "" && Convert.ToDecimal(txtbCodigo.Text) > 0)
                        {


                            int resultado = tablaverificar_codigo.Select("reco_viaje_codigo = " + Convert.ToDecimal(txtbCodigo.Text) + "  and (reco_id_origen <> '" + id_orig + "' or reco_id_destino <> '" + id_dest + "')").Count();

                            //int resultado = tablaverificar_codigo.Select(" convert(varchar(25),reco_viaje_codigo) =isnull('" + txtbCodigo.Text + "','00') and (reco_id_origen !='" + id_orig + "' or reco_id_destino != '" + id_dest + "')").Count();

                            if (resultado > 0)
                            {
                                lblEstadoCodigo.Visible = true;
                         
                            }
                            else
                            {
                                lblEstadoCodigo.Visible = false;
                               // bttCrear.Enabled = true;
                            
                            }
                        }

                    }
                    catch {                     
                    }

        }



        private void crearCombos()
        {
                try
                {
                    string query = "select * from privilegios_insuficientes.ciudades";
                    cmd = new SqlCommand(query, Common.globalConn);
                    adapter = new SqlDataAdapter(cmd);
                    tablaOrigen = new DataTable();
                    tablaDestino = new DataTable();
                    adapter.Fill(tablaOrigen);
                    adapter.Fill(tablaDestino);
                    cmbOrigen.DisplayMember = "ciud_nombre";
                    cmbOrigen.ValueMember = "ciud_id";
                    cmbOrigen.DataSource = tablaOrigen;
                    cmbDestino.DisplayMember = "ciud_nombre";
                    cmbDestino.ValueMember = "ciud_id";
                    cmbDestino.DataSource = tablaDestino;
                    query = "select * from privilegios_insuficientes.tipos";
                    cmd = new SqlCommand(query, Common.globalConn);
                    adapter = new SqlDataAdapter(cmd);
                    tablaTiposServicios = new DataTable();
                    adapter.Fill(tablaTiposServicios);
                    clbServicios.DataSource = tablaTiposServicios;
                    clbServicios.DisplayMember = "tipo_servicio";
                    clbServicios.ValueMember = "tipo_servicio";
                    cargar_verificar_Codigo();

                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }

              
        }



        private void cargar_verificar_Codigo()
        {
            
                try
                {
                    
                    string query = "select * from privilegios_insuficientes.recorridos";
                    cmd = new SqlCommand(query, Common.globalConn);
                    adapter = new SqlDataAdapter(cmd);
                    tablaverificar_codigo = new DataTable();
                    adapter.Fill(tablaverificar_codigo);

                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }

               
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

            crearCombos();

        }

        private void actualizar_estado()
        {
            if (cmbOrigen.SelectedValue != null && cmbDestino.SelectedValue != null)
            {
                verificar_codigo();

                if (cmbOrigen.SelectedValue.ToString() == cmbDestino.SelectedValue.ToString())
                {
                    lblEstado.Text = "Mismo Destino y Origen";
                    bttCrear.Enabled = false;
                    bttEliminar.Enabled = false;
                }
                else
                {
                    
                        try
                        {
                            string id_orig = cmbOrigen.SelectedValue.ToString();
                            string id_dest = cmbDestino.SelectedValue.ToString();
                            string query = "select * from privilegios_insuficientes.recorridos where reco_id_origen = " + id_orig + " and reco_id_destino = " + id_dest;
                            cmd = new SqlCommand(query, Common.globalConn);
                            adapter = new SqlDataAdapter(cmd);
                            tablaPrecios = new DataTable();
                            adapter.Fill(tablaPrecios);

                            if (tablaPrecios.Rows.Count == 0)
                            {
                                existe_reco = false;
                                lblEstado.Text = "Nuevo Recorrido";
                                if (lblEstadoCodigo.Visible== false) { bttCrear.Enabled = true; } else { bttCrear.Enabled = false; }
                                bttEliminar.Enabled = false;

                            }
                            else
                            {
                                    bttCrear.Enabled = true;
                                    bttEliminar.Enabled = true;
                                
                                query = "select SERV_SERVICIO from privilegios_insuficientes.servicios_recorridos where SERV_viaje_codigo =" + tablaPrecios.Rows[0]["reco_viaje_codigo"].ToString();
                                cmd = new SqlCommand(query, Common.globalConn);
                                adapter = new SqlDataAdapter(cmd);
                                DataTable tablaServicios_Recorridos;
                                tablaServicios_Recorridos = new DataTable();
                                adapter.Fill(tablaServicios_Recorridos);

                                lblEstado.Text = "Recorrido existente. Se puede modificar o eliminar.";
                                existe_reco = true;
                                txtbCodigo.Text = tablaPrecios.Rows[0]["reco_viaje_codigo"].ToString();
                                txtbPasaje.Text = tablaPrecios.Rows[0]["reco_persona_base"].ToString();
                                txtbKg.Text = tablaPrecios.Rows[0]["reco_kg_base"].ToString();

                                String tipo_serv;

                                for (int i = 0; i < clbServicios.Items.Count; i++)
                                {

                                    tipo_serv = tablaTiposServicios.Rows[i][0].ToString();

                                    if ((tablaServicios_Recorridos.Select("SERV_SERVICIO = '" + tipo_serv + "'")).Count() >= 1)
                                    {
                                        clbServicios.SetItemChecked(i, true);
                                    }
                                    else
                                    {
                                        clbServicios.SetItemChecked(i, false);

                                    }
                                }
                                ;

                             
                            }


                        }

                        catch (Exception ex)
                        {
                            Console.Write(ex.Message);
                            MessageBox.Show(ex.Message);
                        }

                     
                }
            }
        }
        
        
        

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizar_estado();
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizar_estado();
        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void txtbCodigo_TextChanged(object sender, EventArgs e)
        {
            //verificar_codigo();

            actualizar_estado();
        }

        private void clbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttCrear_Click(object sender, EventArgs e)
        {
            string tipo_serv;
            /// Verifico si existe o no
            /// 
            if (txtbCodigo.Text == "" | txtbPasaje.Text == "" | txtbKg.Text == "")
            {
                MessageBox.Show("Debe completar TODOS los campos.");
                return;
            }
try
{
                if (existe_reco == false)
                {


                    //  INSERTAR EN VIAJES.             
                    

                     
                    string id_orig = cmbOrigen.SelectedValue.ToString();
                    string id_dest = cmbDestino.SelectedValue.ToString();
                    string query = "insert into privilegios_insuficientes.recorridos values(" + txtbCodigo.Text + "," + id_orig + "," + id_dest + ", replace('" + txtbPasaje.Text + "',',','.'), replace( '" + txtbKg.Text + "',',','.'))";
                    cmd = new SqlCommand(query, Common.globalConn);
                    cmd.ExecuteNonQuery();



                     for (int i = 0; i < clbServicios.Items.Count; i++)
                                   {

                                      
                                    tipo_serv = tablaTiposServicios.Rows[i][0].ToString();

                                       if (clbServicios.GetItemChecked(i))
                                       {

                                           query = "insert into privilegios_insuficientes.servicios_recorridos values(" + txtbCodigo.Text + ",'" + tipo_serv + "')";
                                                   cmd = new SqlCommand(query, Common.globalConn);
                                                   cmd.ExecuteNonQuery();
                                                                    
                                           //inserto


                                       }
                                   }
                                   ;
                   
                }
                else { 
               ////updateo 

                    string id_orig = cmbOrigen.SelectedValue.ToString();
                    string id_dest = cmbDestino.SelectedValue.ToString();
                    /* con un trigger, update el id_codigo en las otras tablas si cambio*/
                    string query = "update privilegios_insuficientes.recorridos set reco_viaje_codigo = '" + txtbCodigo.Text + "' , reco_kg_base= replace('" + txtbKg.Text + "',',','.') , reco_persona_base= replace('" + txtbPasaje.Text + "',',','.') where reco_id_destino=" + Convert.ToInt16(id_dest) + " and reco_id_origen=" + Convert.ToInt16(id_orig);
                    cmd = new SqlCommand(query, Common.globalConn);
                    cmd.ExecuteNonQuery();
                    
                    
                    query = "select SERV_SERVICIO from privilegios_insuficientes.servicios_recorridos where SERV_viaje_codigo =" + txtbCodigo.Text;
                                cmd = new SqlCommand(query, Common.globalConn);
                                adapter = new SqlDataAdapter(cmd);
                                DataTable tablaServicios_Recorridos;
                                tablaServicios_Recorridos = new DataTable();
                                adapter.Fill(tablaServicios_Recorridos);

                    
                    for (int i = 0; i < clbServicios.Items.Count; i++)
                                   {

                                       tipo_serv = tablaTiposServicios.Rows[i][0].ToString();
                        if(clbServicios.GetItemChecked(i)){
                        //si existe, lo inseto. sino, lo borro.
                        
                            if ((tablaServicios_Recorridos.Select("SERV_SERVICIO = '" + tipo_serv + "'")).Count() >= 1)
                            {
                                //NADA
                            }
                            else
                            {
                                ////INSERTO.
                                query = "insert into privilegios_insuficientes.servicios_recorridos values( " + txtbCodigo.Text + ", '" + tipo_serv + "')";
                                cmd = new SqlCommand(query, Common.globalConn);
                                cmd.ExecuteNonQuery();
                            }
                        

                        }else{
                        //si existe, lo borro

                            if ((tablaServicios_Recorridos.Select("SERV_SERVICIO = '" + tipo_serv + "'")).Count() >= 1)
                            {
                                /// LO BORRO

                                query = "DELETE FROM  privilegios_insuficientes.servicios_recorridos where serv_viaje_codigo =" + txtbCodigo.Text + " and serv_servicio='" + tipo_serv + "'";
                                cmd = new SqlCommand(query, Common.globalConn);
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

            }

           
                                               catch (Exception ex)
                                               {
                                                   Console.Write(ex.Message);
                                                   MessageBox.Show(ex.Message);
                                               }

                                             


            cargar_verificar_Codigo();
            //verificar_codigo();
            actualizar_estado();

            MessageBox.Show("Ha creado el recorrido con éxito");
            cerrar_ventana();

        }

        private void bttEliminar_Click(object sender, EventArgs e)
        {

            
                try
                {

                    string query = "DELETE FROM  privilegios_insuficientes.recorridos where reco_viaje_codigo =" + txtbCodigo.Text;
                    cmd = new SqlCommand(query, Common.globalConn);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                    MessageBox.Show(ex.Message);
                }

              

            crearCombos();
            cargar_verificar_Codigo();
            actualizar_estado();
            MessageBox.Show("Ha eliminado el recorrido con éxito");
            cerrar_ventana();

        }

        private void cerrar_ventana()
        {
            this.Visible = false;

        }

        
    }
}
