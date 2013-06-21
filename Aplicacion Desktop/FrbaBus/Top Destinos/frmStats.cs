using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaBus.Top_Destinos
{
    public partial class frmStats : Form
    {
        public frmStats()
        {
            InitializeComponent();
        }
        DataTable tabla;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlConnection conn = Common.conectar();
        private void frmStats_Load(object sender, EventArgs e)
        {
            llenarCombo(cmbAno, "PRIVILEGIOS_INSUFICIENTES.destinos", "YEAR(dest_fecha_salida) as Ano", "");
        }
        private void llenarCombo(System.Windows.Forms.ComboBox combo, string tablaorigen, string campo, string id)
        {
            try
            {
                string query = "select " + campo + " from " + tablaorigen + " group by YEAR(dest_fecha_salida)";
                cmd = new SqlCommand(query, Common.globalConn);
                adapter = new SqlDataAdapter(cmd);
                tabla = new DataTable();
                adapter.Fill(tabla);
                combo.DisplayMember = "Ano";
                combo.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void genStats(int tipo)
        {
            string query = "";
            int semMax = 6, semMin = 1;

            switch (tipo)
            {
                case 1:
                    if (Convert.ToInt16(cmbSemestre.Text) == 2) { semMax = 12; semMin = 7; }
                    query = "select top 5 c.ciud_nombre as CIUDAD, COUNT(*) as CANTIDAD from PRIVILEGIOS_INSUFICIENTES.destinos d, PRIVILEGIOS_INSUFICIENTES.pasajes p, PRIVILEGIOS_INSUFICIENTES.recorridos r, PRIVILEGIOS_INSUFICIENTES.Ciudades c ";
                    query += "WHERE r.reco_id_destino = c.ciud_id and p.pasa_dest_id=d.dest_id AND d.dest_viaje = r.reco_viaje_codigo AND ";
                    query += "YEAR(pasa_fcompra)=" + cmbAno.Text + " AND MONTH(pasa_fcompra)<=" + semMax + " AND MONTH(pasa_fcompra)>=" + semMin;
                    query += " GROUP BY c.ciud_nombre order by COUNT(*) desc";
                    cmd = new SqlCommand(query, Common.globalConn);
                    adapter = new SqlDataAdapter(cmd);
                    tabla = new DataTable();
                    adapter.Fill(tabla);
                    lstStats.DisplayMember = "CIUDAD";
                    lstStats.DataSource = tabla;
                    break;
                case 2:
                    query = "select top 5 c.ciud_nombre as CIUDAD, SUM(d.dest_butacas_libres) as CANTIDAD FROM PRIVILEGIOS_INSUFICIENTES.destinos d, PRIVILEGIOS_INSUFICIENTES.recorridos r, PRIVILEGIOS_INSUFICIENTES.ciudades c ";
                    query += "WHERE r.reco_id_destino = c.ciud_id and d.dest_viaje = r.reco_viaje_codigo AND ";
                    query += "YEAR(dest_fecha_salida)=" + cmbAno.Text + " AND MONTH(dest_fecha_salida)<=" + semMax + " AND MONTH(dest_fecha_salida)>=" + semMin;
                    query += "GROUP BY c.ciud_nombre ORDER BY COUNT(*) desc";
                    cmd = new SqlCommand(query, Common.globalConn);
                    adapter = new SqlDataAdapter(cmd);
                    tabla = new DataTable();
                    adapter.Fill(tabla);
                    lstStats.DisplayMember = "CIUDAD";
                    lstStats.DataSource = tabla;
                    break;
                case 3:
                    query = "SELECT TOP 5 c.ciud_nombre as CIUDAD, SUM(d.dest_butacas_libres) as CANTIDAD FROM PRIVILEGIOS_INSUFICIENTES.destinos d, PRIVILEGIOS_INSUFICIENTES.recorridos r, PRIVILEGIOS_INSUFICIENTES.ciudades c ";
                    query += "WHERE r.reco_id_destino = c.ciud_id and d.dest_viaje = r.reco_viaje_codigo AND ";
                    query += "YEAR(dest_fecha_salida)=" + cmbAno.Text + " AND MONTH(dest_fecha_salida)<=" + semMax + " AND MONTH(dest_fecha_salida)>=" + semMin;
                    query += "GROUP BY c.ciud_nombre ORDER BY COUNT(*) desc";
                    cmd = new SqlCommand(query, Common.globalConn);
                    adapter = new SqlDataAdapter(cmd);
                    tabla = new DataTable();
                    adapter.Fill(tabla);
                    lstStats.DisplayMember = "CIUDAD";
                    lstStats.DataSource = tabla;
                    break;
                case 4:
                    query = "select top 5 count(*) cant , dfg.ciud_nombre as CIUDAD from privilegios_insuficientes.viajes_cancelados asd , privilegios_insuficientes.destinos qwe , privilegios_insuficientes.recorridos rty , privilegios_insuficientes.ciudades dfg ";
                    query += "where dfg.ciud_id = rty.reco_id_destino and rty.reco_viaje_codigo = qwe.dest_viaje and  qwe.dest_id = asd.viaj_dest_id and ";
                    query += "YEAR(viaj_fcompra)=" + cmbAno.Text + " AND MONTH(viaj_fcompra)<=" + semMax + " AND MONTH(viaj_fcompra)>=" + semMin;
                    query += "group by ciud_nombre order by count(*) desc";
                    cmd = new SqlCommand(query, Common.globalConn);
                    adapter = new SqlDataAdapter(cmd);
                    tabla = new DataTable();
                    adapter.Fill(tabla);
                    lstStats.DisplayMember = "CIUDAD";
                    lstStats.DataSource = tabla;
                    break;
                case 5:
                    query = "select top 5 micr_id, sum(DATEDIFF(Day, fall_finicio, fall_ffin) ) dias from privilegios_insuficientes.fallas , privilegios_insuficientes.micros ";
                    query += "where micr_id = fall_id_micro and fall_ffin is not null and ";
                    query += "YEAR(fall_finicio)=" + cmbAno.Text + " AND MONTH(fall_finicio)<=" + semMax + " AND MONTH(fall_finicio)>=" + semMin;
                    query += "group by micr_id order by sum(DATEDIFF(Day, fall_finicio, fall_ffin)) desc";
                    cmd = new SqlCommand(query, Common.globalConn);
                    adapter = new SqlDataAdapter(cmd);
                    tabla = new DataTable();
                    adapter.Fill(tabla);
                    lstStats.DisplayMember = "CIUDAD";
                    lstStats.DataSource = tabla;
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) genStats(1);
            if (radioButton2.Checked) genStats(2);
            if (radioButton3.Checked) genStats(3);
            if (radioButton4.Checked) genStats(4);
            if (radioButton5.Checked) genStats(5);


        }
    }
}
