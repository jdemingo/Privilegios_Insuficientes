﻿namespace FrbaBus.Abm_Micro
{
    partial class frmMicros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxMicros = new System.Windows.Forms.GroupBox();
            this.dateAlta = new System.Windows.Forms.DateTimePicker();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.lblKilos = new System.Windows.Forms.Label();
            this.btnDistri = new System.Windows.Forms.Button();
            this.txtButacas = new System.Windows.Forms.TextBox();
            this.lblButacas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.cmbServicios = new System.Windows.Forms.ComboBox();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.txtMicroId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.cmbMarcas = new System.Windows.Forms.ComboBox();
            this.grdMicros = new System.Windows.Forms.DataGridView();
            this.boxMicros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMicros)).BeginInit();
            this.SuspendLayout();
            // 
            // boxMicros
            // 
            this.boxMicros.Controls.Add(this.dateAlta);
            this.boxMicros.Controls.Add(this.txtKilos);
            this.boxMicros.Controls.Add(this.lblKilos);
            this.boxMicros.Controls.Add(this.btnDistri);
            this.boxMicros.Controls.Add(this.txtButacas);
            this.boxMicros.Controls.Add(this.lblButacas);
            this.boxMicros.Controls.Add(this.button1);
            this.boxMicros.Controls.Add(this.lblTipoServicio);
            this.boxMicros.Controls.Add(this.cmbServicios);
            this.boxMicros.Controls.Add(this.btnMarcas);
            this.boxMicros.Controls.Add(this.lblFechaAlta);
            this.boxMicros.Controls.Add(this.txtMicroId);
            this.boxMicros.Controls.Add(this.label1);
            this.boxMicros.Controls.Add(this.txtModelo);
            this.boxMicros.Controls.Add(this.lblModelo);
            this.boxMicros.Controls.Add(this.lblMarca);
            this.boxMicros.Controls.Add(this.lblPatente);
            this.boxMicros.Controls.Add(this.txtPatente);
            this.boxMicros.Controls.Add(this.cmbMarcas);
            this.boxMicros.Location = new System.Drawing.Point(34, 12);
            this.boxMicros.Name = "boxMicros";
            this.boxMicros.Size = new System.Drawing.Size(688, 188);
            this.boxMicros.TabIndex = 0;
            this.boxMicros.TabStop = false;
            // 
            // dateAlta
            // 
            this.dateAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAlta.Location = new System.Drawing.Point(134, 15);
            this.dateAlta.Name = "dateAlta";
            this.dateAlta.Size = new System.Drawing.Size(103, 20);
            this.dateAlta.TabIndex = 19;
            this.dateAlta.Value = new System.DateTime(2013, 5, 21, 0, 0, 0, 0);
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(175, 155);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(62, 20);
            this.txtKilos.TabIndex = 18;
            // 
            // lblKilos
            // 
            this.lblKilos.AutoSize = true;
            this.lblKilos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilos.Location = new System.Drawing.Point(31, 155);
            this.lblKilos.Name = "lblKilos";
            this.lblKilos.Size = new System.Drawing.Size(78, 16);
            this.lblKilos.TabIndex = 17;
            this.lblKilos.Text = "Cant. Kilos";
            // 
            // btnDistri
            // 
            this.btnDistri.Location = new System.Drawing.Point(420, 120);
            this.btnDistri.Name = "btnDistri";
            this.btnDistri.Size = new System.Drawing.Size(102, 25);
            this.btnDistri.TabIndex = 16;
            this.btnDistri.Text = "Ver Distribucion";
            this.btnDistri.UseVisualStyleBackColor = true;
            // 
            // txtButacas
            // 
            this.txtButacas.Location = new System.Drawing.Point(175, 119);
            this.txtButacas.Name = "txtButacas";
            this.txtButacas.Size = new System.Drawing.Size(62, 20);
            this.txtButacas.TabIndex = 15;
            // 
            // lblButacas
            // 
            this.lblButacas.AutoSize = true;
            this.lblButacas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButacas.Location = new System.Drawing.Point(31, 120);
            this.lblButacas.Name = "lblButacas";
            this.lblButacas.Size = new System.Drawing.Size(102, 16);
            this.lblButacas.TabIndex = 14;
            this.lblButacas.Text = "Cant. Butacas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 18);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServicio.Location = new System.Drawing.Point(288, 78);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(114, 16);
            this.lblTipoServicio.TabIndex = 12;
            this.lblTipoServicio.Text = "Tipo de Servicio";
            // 
            // cmbServicios
            // 
            this.cmbServicios.FormattingEnabled = true;
            this.cmbServicios.Location = new System.Drawing.Point(420, 77);
            this.cmbServicios.Name = "cmbServicios";
            this.cmbServicios.Size = new System.Drawing.Size(152, 21);
            this.cmbServicios.TabIndex = 11;
            // 
            // btnMarcas
            // 
            this.btnMarcas.Location = new System.Drawing.Point(578, 51);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(32, 18);
            this.btnMarcas.TabIndex = 10;
            this.btnMarcas.Text = "button1";
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.Location = new System.Drawing.Point(25, 15);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(102, 16);
            this.lblFechaAlta.TabIndex = 8;
            this.lblFechaAlta.Text = "Fecha Ingreso";
            // 
            // txtMicroId
            // 
            this.txtMicroId.Location = new System.Drawing.Point(418, 11);
            this.txtMicroId.Name = "txtMicroId";
            this.txtMicroId.Size = new System.Drawing.Size(108, 20);
            this.txtMicroId.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nro.  Micro";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(120, 81);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(117, 20);
            this.txtModelo.TabIndex = 5;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(31, 85);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 16);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(288, 48);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 16);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatente.Location = new System.Drawing.Point(31, 53);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(60, 16);
            this.lblPatente.TabIndex = 2;
            this.lblPatente.Text = "Patente";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(120, 48);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(117, 20);
            this.txtPatente.TabIndex = 1;
            // 
            // cmbMarcas
            // 
            this.cmbMarcas.FormattingEnabled = true;
            this.cmbMarcas.Location = new System.Drawing.Point(420, 48);
            this.cmbMarcas.Name = "cmbMarcas";
            this.cmbMarcas.Size = new System.Drawing.Size(152, 21);
            this.cmbMarcas.TabIndex = 0;
            // 
            // grdMicros
            // 
            this.grdMicros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMicros.Location = new System.Drawing.Point(34, 206);
            this.grdMicros.Name = "grdMicros";
            this.grdMicros.Size = new System.Drawing.Size(683, 237);
            this.grdMicros.TabIndex = 1;
            // 
            // frmMicros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 468);
            this.Controls.Add(this.grdMicros);
            this.Controls.Add(this.boxMicros);
            this.Name = "frmMicros";
            this.Text = "Alta Modificacion y Consulta de Micros";
            this.Load += new System.EventHandler(this.frmMicros_Load);
            this.boxMicros.ResumeLayout(false);
            this.boxMicros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMicros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxMicros;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.ComboBox cmbMarcas;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtMicroId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label lblKilos;
        private System.Windows.Forms.Button btnDistri;
        private System.Windows.Forms.TextBox txtButacas;
        private System.Windows.Forms.Label lblButacas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.ComboBox cmbServicios;
        private System.Windows.Forms.DataGridView grdMicros;
        private System.Windows.Forms.DateTimePicker dateAlta;
    }
}