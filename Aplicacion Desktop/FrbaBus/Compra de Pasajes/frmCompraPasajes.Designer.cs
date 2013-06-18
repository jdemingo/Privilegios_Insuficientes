namespace FrbaBus.Compra_de_Pasajes
{
    partial class frmCompraPasajes
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
            this.grdButacas = new System.Windows.Forms.DataGridView();
            this.groupPasajeros = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDiscapacitado = new System.Windows.Forms.CheckBox();
            this.dateNac = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupComprador = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupTarjeta = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodSeg = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.chkEfectivo = new System.Windows.Forms.RadioButton();
            this.chkTarjeta = new System.Windows.Forms.RadioButton();
            this.btnPago = new System.Windows.Forms.Button();
            this.btnSigPasaje = new System.Windows.Forms.Button();
            this.grdPasajeros = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdButacas)).BeginInit();
            this.groupPasajeros.SuspendLayout();
            this.groupComprador.SuspendLayout();
            this.groupTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // grdButacas
            // 
            this.grdButacas.AllowUserToAddRows = false;
            this.grdButacas.AllowUserToDeleteRows = false;
            this.grdButacas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdButacas.Location = new System.Drawing.Point(297, 9);
            this.grdButacas.Name = "grdButacas";
            this.grdButacas.ReadOnly = true;
            this.grdButacas.Size = new System.Drawing.Size(351, 10);
            this.grdButacas.TabIndex = 70;
            this.grdButacas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdButacas_CellContentClick);
            // 
            // groupPasajeros
            // 
            this.groupPasajeros.Controls.Add(this.label11);
            this.groupPasajeros.Controls.Add(this.txtDNI);
            this.groupPasajeros.Controls.Add(this.label10);
            this.groupPasajeros.Controls.Add(this.label9);
            this.groupPasajeros.Controls.Add(this.txtNombre);
            this.groupPasajeros.Controls.Add(this.label3);
            this.groupPasajeros.Controls.Add(this.chkDiscapacitado);
            this.groupPasajeros.Controls.Add(this.dateNac);
            this.groupPasajeros.Controls.Add(this.cmbSexo);
            this.groupPasajeros.Controls.Add(this.txtMail);
            this.groupPasajeros.Controls.Add(this.txtTel);
            this.groupPasajeros.Controls.Add(this.txtDir);
            this.groupPasajeros.Controls.Add(this.txtApe);
            this.groupPasajeros.Controls.Add(this.label8);
            this.groupPasajeros.Controls.Add(this.label7);
            this.groupPasajeros.Controls.Add(this.label6);
            this.groupPasajeros.Controls.Add(this.label5);
            this.groupPasajeros.Controls.Add(this.label4);
            this.groupPasajeros.Controls.Add(this.label2);
            this.groupPasajeros.Controls.Add(this.label1);
            this.groupPasajeros.Location = new System.Drawing.Point(12, 12);
            this.groupPasajeros.Name = "groupPasajeros";
            this.groupPasajeros.Size = new System.Drawing.Size(274, 228);
            this.groupPasajeros.TabIndex = 26;
            this.groupPasajeros.TabStop = false;
            this.groupPasajeros.Text = "Pasajero";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(73, 19);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(180, 20);
            this.txtDNI.TabIndex = 48;
            this.txtDNI.Leave += new System.EventHandler(this.txtDNI_LostFocus);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Sexo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-92, -7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "DNI:";
            // 
            // chkDiscapacitado
            // 
            this.chkDiscapacitado.AutoSize = true;
            this.chkDiscapacitado.Location = new System.Drawing.Point(159, 126);
            this.chkDiscapacitado.Name = "chkDiscapacitado";
            this.chkDiscapacitado.Size = new System.Drawing.Size(94, 17);
            this.chkDiscapacitado.TabIndex = 42;
            this.chkDiscapacitado.Text = "Discapacitado";
            this.chkDiscapacitado.UseVisualStyleBackColor = true;
            // 
            // dateNac
            // 
            this.dateNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNac.Location = new System.Drawing.Point(127, 202);
            this.dateNac.Name = "dateNac";
            this.dateNac.Size = new System.Drawing.Size(88, 20);
            this.dateNac.TabIndex = 39;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DisplayMember = "S";
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbSexo.Location = new System.Drawing.Point(73, 124);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(72, 21);
            this.cmbSexo.TabIndex = 38;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(73, 177);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(180, 20);
            this.txtMail.TabIndex = 36;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(73, 151);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(180, 20);
            this.txtTel.TabIndex = 35;
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(73, 98);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(180, 20);
            this.txtDir.TabIndex = 34;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(73, 72);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(180, 20);
            this.txtApe.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Fecha de Nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-92, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-92, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nombre:";
            // 
            // groupComprador
            // 
            this.groupComprador.Controls.Add(this.label14);
            this.groupComprador.Controls.Add(this.btnPago);
            this.groupComprador.Controls.Add(this.chkEfectivo);
            this.groupComprador.Controls.Add(this.chkTarjeta);
            this.groupComprador.Controls.Add(this.groupTarjeta);
            this.groupComprador.Location = new System.Drawing.Point(297, 12);
            this.groupComprador.Name = "groupComprador";
            this.groupComprador.Size = new System.Drawing.Size(301, 228);
            this.groupComprador.TabIndex = 55;
            this.groupComprador.TabStop = false;
            this.groupComprador.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Forma de pago:";
            // 
            // groupTarjeta
            // 
            this.groupTarjeta.Controls.Add(this.dateTimePicker1);
            this.groupTarjeta.Controls.Add(this.txtTarjeta);
            this.groupTarjeta.Controls.Add(this.txtCuotas);
            this.groupTarjeta.Controls.Add(this.label12);
            this.groupTarjeta.Controls.Add(this.label13);
            this.groupTarjeta.Controls.Add(this.txtCodSeg);
            this.groupTarjeta.Controls.Add(this.label15);
            this.groupTarjeta.Controls.Add(this.comboBox1);
            this.groupTarjeta.Controls.Add(this.label16);
            this.groupTarjeta.Controls.Add(this.label17);
            this.groupTarjeta.Location = new System.Drawing.Point(8, 27);
            this.groupTarjeta.Name = "groupTarjeta";
            this.groupTarjeta.Size = new System.Drawing.Size(286, 150);
            this.groupTarjeta.TabIndex = 40;
            this.groupTarjeta.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-yy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(67, 20);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(126, 14);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(153, 20);
            this.txtTarjeta.TabIndex = 33;
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(126, 122);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(67, 20);
            this.txtCuotas.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Numero de tarjeta:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Cantidad de cuotas:";
            // 
            // txtCodSeg
            // 
            this.txtCodSeg.Location = new System.Drawing.Point(126, 43);
            this.txtCodSeg.Name = "txtCodSeg";
            this.txtCodSeg.Size = new System.Drawing.Size(153, 20);
            this.txtCodSeg.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Tipo de tarjeta:";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "S";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 21);
            this.comboBox1.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Codigo de Seguridad:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Fecha de Vencimiento:";
            // 
            // chkEfectivo
            // 
            this.chkEfectivo.AutoSize = true;
            this.chkEfectivo.Location = new System.Drawing.Point(223, 10);
            this.chkEfectivo.Name = "chkEfectivo";
            this.chkEfectivo.Size = new System.Drawing.Size(64, 17);
            this.chkEfectivo.TabIndex = 53;
            this.chkEfectivo.Text = "Efectivo";
            this.chkEfectivo.UseVisualStyleBackColor = true;
            this.chkEfectivo.CheckedChanged += new System.EventHandler(this.chkEfectivo_CheckedChanged);
            // 
            // chkTarjeta
            // 
            this.chkTarjeta.AutoSize = true;
            this.chkTarjeta.Checked = true;
            this.chkTarjeta.Location = new System.Drawing.Point(115, 10);
            this.chkTarjeta.Name = "chkTarjeta";
            this.chkTarjeta.Size = new System.Drawing.Size(109, 17);
            this.chkTarjeta.TabIndex = 51;
            this.chkTarjeta.TabStop = true;
            this.chkTarjeta.Text = "Tarjeta de Credito";
            this.chkTarjeta.UseVisualStyleBackColor = true;
            this.chkTarjeta.CheckedChanged += new System.EventHandler(this.chkTarjeta_CheckedChanged);
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(181, 196);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(115, 23);
            this.btnPago.TabIndex = 56;
            this.btnPago.Text = "Efectuar pago";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Visible = false;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // btnSigPasaje
            // 
            this.btnSigPasaje.Location = new System.Drawing.Point(166, 246);
            this.btnSigPasaje.Name = "btnSigPasaje";
            this.btnSigPasaje.Size = new System.Drawing.Size(120, 23);
            this.btnSigPasaje.TabIndex = 45;
            this.btnSigPasaje.Text = "Siguiente Pasaje";
            this.btnSigPasaje.UseVisualStyleBackColor = true;
            this.btnSigPasaje.Click += new System.EventHandler(this.btnSigPasaje_Click);
            // 
            // grdPasajeros
            // 
            this.grdPasajeros.AllowUserToAddRows = false;
            this.grdPasajeros.AllowUserToDeleteRows = false;
            this.grdPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPasajeros.Location = new System.Drawing.Point(12, 279);
            this.grdPasajeros.Name = "grdPasajeros";
            this.grdPasajeros.ReadOnly = true;
            this.grdPasajeros.Size = new System.Drawing.Size(636, 145);
            this.grdPasajeros.TabIndex = 27;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(517, 430);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(131, 23);
            this.btnFinalizar.TabIndex = 46;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Visible = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 246);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 57;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Visible = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmCompraPasajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 465);
            this.Controls.Add(this.grdButacas);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.grdPasajeros);
            this.Controls.Add(this.groupPasajeros);
            this.Controls.Add(this.btnSigPasaje);
            this.Controls.Add(this.groupComprador);
            this.Name = "frmCompraPasajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompraPasajes";
            this.Load += new System.EventHandler(this.frmComprarPasajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdButacas)).EndInit();
            this.groupPasajeros.ResumeLayout(false);
            this.groupPasajeros.PerformLayout();
            this.groupComprador.ResumeLayout(false);
            this.groupComprador.PerformLayout();
            this.groupTarjeta.ResumeLayout(false);
            this.groupTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdButacas;
        private System.Windows.Forms.GroupBox groupPasajeros;
        private System.Windows.Forms.Button btnSigPasaje;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkDiscapacitado;
        private System.Windows.Forms.DateTimePicker dateNac;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdPasajeros;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton chkEfectivo;
        private System.Windows.Forms.RadioButton chkTarjeta;
        private System.Windows.Forms.GroupBox groupTarjeta;
        private System.Windows.Forms.TextBox txtTarjeta;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodSeg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupComprador;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Button btnAtras;
    }
}