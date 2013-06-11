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
            ((System.ComponentModel.ISupportInitialize)(this.grdPuntos)).BeginInit();
            this.grpFiltros.SuspendLayout();
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
            this.grdPuntos.Location = new System.Drawing.Point(12, 132);
            this.grdPuntos.Name = "grdPuntos";
            this.grdPuntos.Size = new System.Drawing.Size(538, 198);
            this.grdPuntos.TabIndex = 2;
            // 
            // grpFiltros
            // 
            this.grpFiltros.Controls.Add(this.lblDNI);
            this.grpFiltros.Controls.Add(this.txtDNI);
            this.grpFiltros.Location = new System.Drawing.Point(15, 12);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Size = new System.Drawing.Size(535, 67);
            this.grpFiltros.TabIndex = 3;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros de búsqueda";
            // 
            // lblInfoTotalPuntos
            // 
            this.lblInfoTotalPuntos.AutoSize = true;
            this.lblInfoTotalPuntos.Location = new System.Drawing.Point(12, 337);
            this.lblInfoTotalPuntos.Name = "lblInfoTotalPuntos";
            this.lblInfoTotalPuntos.Size = new System.Drawing.Size(84, 13);
            this.lblInfoTotalPuntos.TabIndex = 4;
            this.lblInfoTotalPuntos.Text = "Total de puntos:";
            // 
            // lblTotalPuntos
            // 
            this.lblTotalPuntos.AutoSize = true;
            this.lblTotalPuntos.Location = new System.Drawing.Point(102, 337);
            this.lblTotalPuntos.Name = "lblTotalPuntos";
            this.lblTotalPuntos.Size = new System.Drawing.Size(37, 13);
            this.lblTotalPuntos.TabIndex = 5;
            this.lblTotalPuntos.Text = "99999";
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
            this.btnBuscar.Location = new System.Drawing.Point(475, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmConsultaPuntos
            // 
            this.AcceptButton = this.btnBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 374);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTotalPuntos);
            this.Controls.Add(this.lblInfoTotalPuntos);
            this.Controls.Add(this.grdPuntos);
            this.Controls.Add(this.grpFiltros);
            this.Name = "frmConsultaPuntos";
            this.Text = "frmConsultaPuntos";
            ((System.ComponentModel.ISupportInitialize)(this.grdPuntos)).EndInit();
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
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
    }
}