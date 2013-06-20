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
            this.btnPago = new System.Windows.Forms.Button();
            this.chkEfectivo = new System.Windows.Forms.RadioButton();
            this.chkTarjeta = new System.Windows.Forms.RadioButton();
            this.groupTarjeta = new System.Windows.Forms.GroupBox();
            this.cmbCuotas = new System.Windows.Forms.ComboBox();
            this.dateVenc = new System.Windows.Forms.DateTimePicker();
            this.txtTarjeta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodSeg = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbTipoTarj = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSigPasaje = new System.Windows.Forms.Button();
            this.grdPasajeros = new System.Windows.Forms.DataGridView();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.chkEncomienda = new System.Windows.Forms.CheckBox();
            this.lblAtrasEnc = new System.Windows.Forms.Label();
            this.lblCantPasajes = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblAntText = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblCantEnc = new System.Windows.Forms.Label();
            this.lblEncText = new System.Windows.Forms.Label();
            this.lblDisc = new System.Windows.Forms.Label();
            this.lblDiscText = new System.Windows.Forms.Label();
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
            this.groupPasajeros.Size = new System.Drawing.Size(274, 262);
            this.groupPasajeros.TabIndex = 26;
            this.groupPasajeros.TabStop = false;
            this.groupPasajeros.Text = "Pasaje";
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
            // groupTarjeta
            // 
            this.groupTarjeta.Controls.Add(this.cmbCuotas);
            this.groupTarjeta.Controls.Add(this.dateVenc);
            this.groupTarjeta.Controls.Add(this.txtTarjeta);
            this.groupTarjeta.Controls.Add(this.label12);
            this.groupTarjeta.Controls.Add(this.label13);
            this.groupTarjeta.Controls.Add(this.txtCodSeg);
            this.groupTarjeta.Controls.Add(this.label15);
            this.groupTarjeta.Controls.Add(this.cmbTipoTarj);
            this.groupTarjeta.Controls.Add(this.label16);
            this.groupTarjeta.Controls.Add(this.label17);
            this.groupTarjeta.Location = new System.Drawing.Point(8, 27);
            this.groupTarjeta.Name = "groupTarjeta";
            this.groupTarjeta.Size = new System.Drawing.Size(286, 150);
            this.groupTarjeta.TabIndex = 40;
            this.groupTarjeta.TabStop = false;
            // 
            // cmbCuotas
            // 
            this.cmbCuotas.FormattingEnabled = true;
            this.cmbCuotas.Location = new System.Drawing.Point(126, 121);
            this.cmbCuotas.Name = "cmbCuotas";
            this.cmbCuotas.Size = new System.Drawing.Size(67, 21);
            this.cmbCuotas.TabIndex = 44;
            // 
            // dateVenc
            // 
            this.dateVenc.CustomFormat = "MM-yy";
            this.dateVenc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVenc.Location = new System.Drawing.Point(126, 69);
            this.dateVenc.Name = "dateVenc";
            this.dateVenc.Size = new System.Drawing.Size(67, 20);
            this.dateVenc.TabIndex = 43;
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Location = new System.Drawing.Point(126, 14);
            this.txtTarjeta.Name = "txtTarjeta";
            this.txtTarjeta.Size = new System.Drawing.Size(153, 20);
            this.txtTarjeta.TabIndex = 33;
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
            // cmbTipoTarj
            // 
            this.cmbTipoTarj.DisplayMember = "S";
            this.cmbTipoTarj.FormattingEnabled = true;
            this.cmbTipoTarj.Location = new System.Drawing.Point(126, 95);
            this.cmbTipoTarj.Name = "cmbTipoTarj";
            this.cmbTipoTarj.Size = new System.Drawing.Size(67, 21);
            this.cmbTipoTarj.TabIndex = 39;
            this.cmbTipoTarj.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTarj_SelectedIndexChanged);
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
            // btnSigPasaje
            // 
            this.btnSigPasaje.Location = new System.Drawing.Point(166, 280);
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
            this.grdPasajeros.Location = new System.Drawing.Point(12, 333);
            this.grdPasajeros.Name = "grdPasajeros";
            this.grdPasajeros.ReadOnly = true;
            this.grdPasajeros.Size = new System.Drawing.Size(636, 145);
            this.grdPasajeros.TabIndex = 27;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(517, 484);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(131, 23);
            this.btnFinalizar.TabIndex = 46;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Visible = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 280);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 57;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Visible = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // chkEncomienda
            // 
            this.chkEncomienda.AutoSize = true;
            this.chkEncomienda.Location = new System.Drawing.Point(25, 247);
            this.chkEncomienda.Name = "chkEncomienda";
            this.chkEncomienda.Size = new System.Drawing.Size(85, 17);
            this.chkEncomienda.TabIndex = 71;
            this.chkEncomienda.Text = "Encomienda";
            this.chkEncomienda.UseVisualStyleBackColor = true;
            this.chkEncomienda.CheckedChanged += new System.EventHandler(this.chkEncomienda_CheckedChanged);
            // 
            // lblAtrasEnc
            // 
            this.lblAtrasEnc.AutoSize = true;
            this.lblAtrasEnc.Location = new System.Drawing.Point(60, 310);
            this.lblAtrasEnc.Name = "lblAtrasEnc";
            this.lblAtrasEnc.Size = new System.Drawing.Size(10, 13);
            this.lblAtrasEnc.TabIndex = 72;
            this.lblAtrasEnc.Text = "-";
            // 
            // lblCantPasajes
            // 
            this.lblCantPasajes.AutoSize = true;
            this.lblCantPasajes.Location = new System.Drawing.Point(216, 310);
            this.lblCantPasajes.Name = "lblCantPasajes";
            this.lblCantPasajes.Size = new System.Drawing.Size(13, 13);
            this.lblCantPasajes.TabIndex = 73;
            this.lblCantPasajes.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(160, 310);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 74;
            this.label18.Text = "A cargar:";
            // 
            // lblAntText
            // 
            this.lblAntText.AutoSize = true;
            this.lblAntText.Location = new System.Drawing.Point(13, 310);
            this.lblAntText.Name = "lblAntText";
            this.lblAntText.Size = new System.Drawing.Size(46, 13);
            this.lblAntText.TabIndex = 75;
            this.lblAntText.Text = "Anterior:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(230, 310);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 76;
            this.label19.Text = "Pasajes";
            // 
            // lblCantEnc
            // 
            this.lblCantEnc.AutoSize = true;
            this.lblCantEnc.Location = new System.Drawing.Point(280, 310);
            this.lblCantEnc.Name = "lblCantEnc";
            this.lblCantEnc.Size = new System.Drawing.Size(13, 13);
            this.lblCantEnc.TabIndex = 77;
            this.lblCantEnc.Text = "0";
            // 
            // lblEncText
            // 
            this.lblEncText.AutoSize = true;
            this.lblEncText.Location = new System.Drawing.Point(294, 310);
            this.lblEncText.Name = "lblEncText";
            this.lblEncText.Size = new System.Drawing.Size(76, 13);
            this.lblEncText.TabIndex = 78;
            this.lblEncText.Text = "Encomienda/s";
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Location = new System.Drawing.Point(635, 310);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(13, 13);
            this.lblDisc.TabIndex = 79;
            this.lblDisc.Text = "0";
            // 
            // lblDiscText
            // 
            this.lblDiscText.AutoSize = true;
            this.lblDiscText.Location = new System.Drawing.Point(435, 310);
            this.lblDiscText.Name = "lblDiscText";
            this.lblDiscText.Size = new System.Drawing.Size(194, 13);
            this.lblDiscText.TabIndex = 80;
            this.lblDiscText.Text = "Cantidad de discapacitados agregados:";
            // 
            // frmCompraPasajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 518);
            this.Controls.Add(this.lblDiscText);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.lblEncText);
            this.Controls.Add(this.lblCantEnc);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblAntText);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblCantPasajes);
            this.Controls.Add(this.lblAtrasEnc);
            this.Controls.Add(this.chkEncomienda);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodSeg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbTipoTarj;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateVenc;
        private System.Windows.Forms.GroupBox groupComprador;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.CheckBox chkEncomienda;
        private System.Windows.Forms.Label lblAtrasEnc;
        private System.Windows.Forms.Label lblCantPasajes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblAntText;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblCantEnc;
        private System.Windows.Forms.Label lblEncText;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.Label lblDiscText;
        private System.Windows.Forms.ComboBox cmbCuotas;
    }
}