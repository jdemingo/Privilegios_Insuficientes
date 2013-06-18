namespace FrbaBus
{
    partial class frmUtnBus
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
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateSalida = new System.Windows.Forms.DateTimePicker();
            this.btnCargarPasajes = new System.Windows.Forms.Button();
            this.grpPasajesDisponibles = new System.Windows.Forms.GroupBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.txtCantPasajes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarPasajes = new System.Windows.Forms.Button();
            this.grdPasajes = new System.Windows.Forms.DataGridView();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpPasajesDisponibles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPasajes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbOrigen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(96, 33);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(138, 21);
            this.cmbOrigen.TabIndex = 0;
            // 
            // cmbDestino
            // 
            this.cmbDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Items.AddRange(new object[] {
            "Buenos Aires",
            "Cordoba",
            "Rosario",
            "Mendoza"});
            this.cmbDestino.Location = new System.Drawing.Point(96, 60);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(138, 21);
            this.cmbDestino.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateSalida);
            this.groupBox1.Controls.Add(this.btnCargarPasajes);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 129);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha";
            // 
            // dateSalida
            // 
            this.dateSalida.CustomFormat = "";
            this.dateSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSalida.Location = new System.Drawing.Point(434, 33);
            this.dateSalida.Name = "dateSalida";
            this.dateSalida.Size = new System.Drawing.Size(104, 20);
            this.dateSalida.TabIndex = 2;
            this.dateSalida.Value = new System.DateTime(2012, 2, 15, 0, 0, 0, 0);
            this.dateSalida.ValueChanged += new System.EventHandler(this.dateSalida_ValueChanged);
            // 
            // btnCargarPasajes
            // 
            this.btnCargarPasajes.Location = new System.Drawing.Point(371, 100);
            this.btnCargarPasajes.Name = "btnCargarPasajes";
            this.btnCargarPasajes.Size = new System.Drawing.Size(167, 23);
            this.btnCargarPasajes.TabIndex = 3;
            this.btnCargarPasajes.Text = "Consultar Pasajes Disponibles";
            this.btnCargarPasajes.UseVisualStyleBackColor = true;
            this.btnCargarPasajes.Click += new System.EventHandler(this.btnCargarPasajes_Click);
            // 
            // grpPasajesDisponibles
            // 
            this.grpPasajesDisponibles.Controls.Add(this.btnComprar);
            this.grpPasajesDisponibles.Controls.Add(this.txtKg);
            this.grpPasajesDisponibles.Controls.Add(this.txtCantPasajes);
            this.grpPasajesDisponibles.Controls.Add(this.label5);
            this.grpPasajesDisponibles.Controls.Add(this.label4);
            this.grpPasajesDisponibles.Controls.Add(this.btnCancelarPasajes);
            this.grpPasajesDisponibles.Controls.Add(this.grdPasajes);
            this.grpPasajesDisponibles.Location = new System.Drawing.Point(13, 169);
            this.grpPasajesDisponibles.Name = "grpPasajesDisponibles";
            this.grpPasajesDisponibles.Size = new System.Drawing.Size(546, 269);
            this.grpPasajesDisponibles.TabIndex = 5;
            this.grpPasajesDisponibles.TabStop = false;
            this.grpPasajesDisponibles.Text = "Pasajes disponibles";
            this.grpPasajesDisponibles.Visible = false;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(405, 187);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(282, 189);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(87, 20);
            this.txtKg.TabIndex = 5;
            // 
            // txtCantPasajes
            // 
            this.txtCantPasajes.Location = new System.Drawing.Point(119, 189);
            this.txtCantPasajes.Name = "txtCantPasajes";
            this.txtCantPasajes.Size = new System.Drawing.Size(87, 20);
            this.txtCantPasajes.TabIndex = 4;
            this.txtCantPasajes.TextChanged += new System.EventHandler(this.txtCantPasajes_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Kg a enviar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Pasajes a comprar:";
            // 
            // btnCancelarPasajes
            // 
            this.btnCancelarPasajes.Location = new System.Drawing.Point(17, 240);
            this.btnCancelarPasajes.Name = "btnCancelarPasajes";
            this.btnCancelarPasajes.Size = new System.Drawing.Size(133, 23);
            this.btnCancelarPasajes.TabIndex = 8;
            this.btnCancelarPasajes.Text = "abmCancelarPasajes";
            this.btnCancelarPasajes.UseVisualStyleBackColor = true;
            this.btnCancelarPasajes.Click += new System.EventHandler(this.btnCancelarPasajes_Click);
            // 
            // grdPasajes
            // 
            this.grdPasajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPasajes.Location = new System.Drawing.Point(6, 19);
            this.grdPasajes.Name = "grdPasajes";
            this.grdPasajes.Size = new System.Drawing.Size(531, 159);
            this.grdPasajes.TabIndex = 22;
            this.grdPasajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(522, 2);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(46, 25);
            this.cmdLogin.TabIndex = 7;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // frmUtnBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.grpPasajesDisponibles);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUtnBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTN Bus";
            this.Load += new System.EventHandler(this.frmUtnBus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPasajesDisponibles.ResumeLayout(false);
            this.grpPasajesDisponibles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPasajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCargarPasajes;
        private System.Windows.Forms.GroupBox grpPasajesDisponibles;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.DataGridView grdPasajes;
        private System.Windows.Forms.DateTimePicker dateSalida;
        private System.Windows.Forms.Button btnCancelarPasajes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.TextBox txtCantPasajes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label3;

    }
}

