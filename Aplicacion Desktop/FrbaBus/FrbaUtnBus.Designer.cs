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
            this.label5 = new System.Windows.Forms.Label();
            this.lblKgs = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateSalida = new System.Windows.Forms.DateTimePicker();
            this.chkEncomienda = new System.Windows.Forms.CheckBox();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.txtCantPasajes = new System.Windows.Forms.TextBox();
            this.btnCargarPasajes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpPasajesDisponibles = new System.Windows.Forms.GroupBox();
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
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(16, 27);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(195, 21);
            this.cmbOrigen.TabIndex = 0;
            // 
            // cmbDestino
            // 
            this.cmbDestino.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbDestino.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Items.AddRange(new object[] {
            "Buenos Aires",
            "Cordoba",
            "Rosario",
            "Mendoza"});
            this.cmbDestino.Location = new System.Drawing.Point(16, 76);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(195, 21);
            this.cmbDestino.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblKgs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateSalida);
            this.groupBox1.Controls.Add(this.chkEncomienda);
            this.groupBox1.Controls.Add(this.txtKg);
            this.groupBox1.Controls.Add(this.txtCantPasajes);
            this.groupBox1.Controls.Add(this.btnCargarPasajes);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 149);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Encomienda";
            // 
            // lblKgs
            // 
            this.lblKgs.AutoSize = true;
            this.lblKgs.Enabled = false;
            this.lblKgs.Location = new System.Drawing.Point(430, 80);
            this.lblKgs.Name = "lblKgs";
            this.lblKgs.Size = new System.Drawing.Size(25, 13);
            this.lblKgs.TabIndex = 23;
            this.lblKgs.Text = "Kgs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fecha de salida";
            // 
            // dateSalida
            // 
            this.dateSalida.CustomFormat = "";
            this.dateSalida.Location = new System.Drawing.Point(233, 28);
            this.dateSalida.Name = "dateSalida";
            this.dateSalida.Size = new System.Drawing.Size(222, 20);
            this.dateSalida.TabIndex = 2;
            this.dateSalida.Value = new System.DateTime(2012, 2, 15, 0, 0, 0, 0);
            this.dateSalida.ValueChanged += new System.EventHandler(this.dateSalida_ValueChanged);
            // 
            // chkEncomienda
            // 
            this.chkEncomienda.AutoSize = true;
            this.chkEncomienda.Location = new System.Drawing.Point(355, 80);
            this.chkEncomienda.Name = "chkEncomienda";
            this.chkEncomienda.Size = new System.Drawing.Size(15, 14);
            this.chkEncomienda.TabIndex = 4;
            this.chkEncomienda.UseVisualStyleBackColor = true;
            this.chkEncomienda.CheckedChanged += new System.EventHandler(this.chkEncomienda_ChangeChecked);
            // 
            // txtKg
            // 
            this.txtKg.Enabled = false;
            this.txtKg.Location = new System.Drawing.Point(376, 77);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(54, 20);
            this.txtKg.TabIndex = 5;
            this.txtKg.TextChanged += new System.EventHandler(this.txtKg_TextChanged);
            this.txtKg.Leave += new System.EventHandler(this.txtKg_LostFocus);
            // 
            // txtCantPasajes
            // 
            this.txtCantPasajes.Location = new System.Drawing.Point(233, 77);
            this.txtCantPasajes.Name = "txtCantPasajes";
            this.txtCantPasajes.Size = new System.Drawing.Size(101, 20);
            this.txtCantPasajes.TabIndex = 3;
            this.txtCantPasajes.TextChanged += new System.EventHandler(this.txtCantPasajes_TextChanged);
            this.txtCantPasajes.Leave += new System.EventHandler(this.txtCantPasajes_LostFocus);
            // 
            // btnCargarPasajes
            // 
            this.btnCargarPasajes.Location = new System.Drawing.Point(328, 113);
            this.btnCargarPasajes.Name = "btnCargarPasajes";
            this.btnCargarPasajes.Size = new System.Drawing.Size(127, 23);
            this.btnCargarPasajes.TabIndex = 6;
            this.btnCargarPasajes.Text = "Consultar pasajes";
            this.btnCargarPasajes.UseVisualStyleBackColor = true;
            this.btnCargarPasajes.Click += new System.EventHandler(this.btnCargarPasajes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cantidad de pasajes";
            // 
            // grpPasajesDisponibles
            // 
            this.grpPasajesDisponibles.Controls.Add(this.grdPasajes);
            this.grpPasajesDisponibles.Location = new System.Drawing.Point(13, 185);
            this.grpPasajesDisponibles.Name = "grpPasajesDisponibles";
            this.grpPasajesDisponibles.Size = new System.Drawing.Size(470, 150);
            this.grpPasajesDisponibles.TabIndex = 5;
            this.grpPasajesDisponibles.TabStop = false;
            this.grpPasajesDisponibles.Text = "Pasajes disponibles";
            this.grpPasajesDisponibles.Visible = false;
            // 
            // grdPasajes
            // 
            this.grdPasajes.AllowUserToAddRows = false;
            this.grdPasajes.AllowUserToDeleteRows = false;
            this.grdPasajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPasajes.Location = new System.Drawing.Point(6, 19);
            this.grdPasajes.Name = "grdPasajes";
            this.grdPasajes.ReadOnly = true;
            this.grdPasajes.RowHeadersVisible = false;
            this.grdPasajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPasajes.Size = new System.Drawing.Size(458, 125);
            this.grdPasajes.TabIndex = 22;
            this.grdPasajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(437, 6);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(46, 23);
            this.cmdLogin.TabIndex = 7;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // frmUtnBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 378);
            this.Controls.Add(this.grpPasajesDisponibles);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUtnBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTN Bus";
            this.Load += new System.EventHandler(this.frmUtnBus_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUtnBus_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPasajesDisponibles.ResumeLayout(false);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.TextBox txtCantPasajes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKgs;
        private System.Windows.Forms.CheckBox chkEncomienda;
        private System.Windows.Forms.Label label5;

    }
}

