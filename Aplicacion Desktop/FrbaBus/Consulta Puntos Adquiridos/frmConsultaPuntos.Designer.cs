namespace FrbaBus.Consulta_Puntos_Adquiridos
{
    partial class frmConsultaPuntos
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.grdPuntos = new System.Windows.Forms.DataGridView();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.lblInfoTotalPuntos = new System.Windows.Forms.Label();
            this.lblTotalPuntos = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grdCanjes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCanjes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPuntosDisp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPuntos)).BeginInit();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCanjes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(19, 32);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(167, 20);
            this.txtDNI.TabIndex = 0;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(16, 16);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI";
            // 
            // grdPuntos
            // 
            this.grdPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPuntos.Location = new System.Drawing.Point(12, 140);
            this.grdPuntos.Name = "grdPuntos";
            this.grdPuntos.Size = new System.Drawing.Size(463, 198);
            this.grdPuntos.TabIndex = 2;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.lblDNI);
            this.grpFiltros.Controls.Add(this.txtDNI);
            this.grpFiltros.Location = new System.Drawing.Point(15, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(836, 67);
            this.grpFiltros.TabIndex = 3;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros de búsqueda";
            // 
            // lblInfoTotalPuntos
            // 
            this.lblInfoTotalPuntos.AutoSize = true;
            this.lblInfoTotalPuntos.Location = new System.Drawing.Point(12, 345);
            this.lblInfoTotalPuntos.Name = "lblInfoTotalPuntos";
            this.lblInfoTotalPuntos.Size = new System.Drawing.Size(84, 13);
            this.lblInfoTotalPuntos.TabIndex = 4;
            this.lblInfoTotalPuntos.Text = "Total de puntos:";
            // 
            // lblTotalPuntos
            // 
            this.lblTotalPuntos.AutoSize = true;
            this.lblTotalPuntos.Location = new System.Drawing.Point(102, 345);
            this.lblTotalPuntos.Name = "lblTotalPuntos";
            this.lblTotalPuntos.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPuntos.TabIndex = 5;
            this.lblTotalPuntos.Text = "0";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(15, 85);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(776, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grdCanjes
            // 
            this.grdCanjes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCanjes.Location = new System.Drawing.Point(490, 140);
            this.grdCanjes.Name = "grdCanjes";
            this.grdCanjes.Size = new System.Drawing.Size(361, 198);
            this.grdCanjes.TabIndex = 8;
            this.grdCanjes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total de canjes:";
            // 
            // lblTotalCanjes
            // 
            this.lblTotalCanjes.AutoSize = true;
            this.lblTotalCanjes.Location = new System.Drawing.Point(579, 345);
            this.lblTotalCanjes.Name = "lblTotalCanjes";
            this.lblTotalCanjes.Size = new System.Drawing.Size(13, 13);
            this.lblTotalCanjes.TabIndex = 10;
            this.lblTotalCanjes.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total de puntos disponibles:";
            // 
            // lblTotalPuntosDisp
            // 
            this.lblTotalPuntosDisp.AutoSize = true;
            this.lblTotalPuntosDisp.Location = new System.Drawing.Point(158, 377);
            this.lblTotalPuntosDisp.Name = "lblTotalPuntosDisp";
            this.lblTotalPuntosDisp.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPuntosDisp.TabIndex = 12;
            this.lblTotalPuntosDisp.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Listado de puntos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Listado de canjes";
            // 
            // frmConsultaPuntos
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalPuntosDisp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalCanjes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdCanjes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTotalPuntos);
            this.Controls.Add(this.lblInfoTotalPuntos);
            this.Controls.Add(this.grdPuntos);
            this.Controls.Add(this.grpFiltros);
            this.Name = "frmConsultaPuntos";
            this.Text = "Consulta de puntos";
            ((System.ComponentModel.ISupportInitialize)(this.grdPuntos)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCanjes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.DataGridView grdPuntos;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblInfoTotalPuntos;
        private System.Windows.Forms.Label lblTotalPuntos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grdCanjes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCanjes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPuntosDisp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}