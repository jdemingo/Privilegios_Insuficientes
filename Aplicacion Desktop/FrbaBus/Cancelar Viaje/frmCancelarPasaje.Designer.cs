namespace FrbaBus.Cancelar_Viaje
{
    partial class frmCancelarPasajes
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
            this.txtVoucher = new System.Windows.Forms.TextBox();
            this.nroVoucher = new System.Windows.Forms.Label();
            this.bttConsultar = new System.Windows.Forms.Button();
            this.bttDarDeBaja = new System.Windows.Forms.Button();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cklbPasajes = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasaje = new System.Windows.Forms.TextBox();
            this.nroPasaje = new System.Windows.Forms.Label();
            this.rdbPorPasaje = new System.Windows.Forms.RadioButton();
            this.rdbPorVoucher = new System.Windows.Forms.RadioButton();
            this.groupPasaje = new System.Windows.Forms.GroupBox();
            this.groupVoucher = new System.Windows.Forms.GroupBox();
            this.bttBajaPasaje = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupPasaje.SuspendLayout();
            this.groupVoucher.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVoucher
            // 
            this.txtVoucher.Location = new System.Drawing.Point(76, 22);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(100, 20);
            this.txtVoucher.TabIndex = 0;
            this.txtVoucher.TextChanged += new System.EventHandler(this.txtVoucher_TextChanged);
            // 
            // nroVoucher
            // 
            this.nroVoucher.AutoSize = true;
            this.nroVoucher.Location = new System.Drawing.Point(20, 25);
            this.nroVoucher.Name = "nroVoucher";
            this.nroVoucher.Size = new System.Drawing.Size(50, 13);
            this.nroVoucher.TabIndex = 1;
            this.nroVoucher.Text = "Voucher:";
            // 
            // bttConsultar
            // 
            this.bttConsultar.Location = new System.Drawing.Point(183, 19);
            this.bttConsultar.Name = "bttConsultar";
            this.bttConsultar.Size = new System.Drawing.Size(75, 23);
            this.bttConsultar.TabIndex = 5;
            this.bttConsultar.Text = "Consultar";
            this.bttConsultar.UseVisualStyleBackColor = true;
            this.bttConsultar.Click += new System.EventHandler(this.bttConsultar_Click_1);
            // 
            // bttDarDeBaja
            // 
            this.bttDarDeBaja.Location = new System.Drawing.Point(401, 276);
            this.bttDarDeBaja.Name = "bttDarDeBaja";
            this.bttDarDeBaja.Size = new System.Drawing.Size(142, 23);
            this.bttDarDeBaja.TabIndex = 6;
            this.bttDarDeBaja.Text = "Dar de baja pasajes";
            this.bttDarDeBaja.UseVisualStyleBackColor = true;
            this.bttDarDeBaja.Click += new System.EventHandler(this.bttDarDeBaja_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(96, 243);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(447, 20);
            this.txtMotivo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Motivos:";
            // 
            // cklbPasajes
            // 
            this.cklbPasajes.FormattingEnabled = true;
            this.cklbPasajes.Location = new System.Drawing.Point(76, 48);
            this.cklbPasajes.Name = "cklbPasajes";
            this.cklbPasajes.Size = new System.Drawing.Size(143, 139);
            this.cklbPasajes.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pasajes :";
            // 
            // txtPasaje
            // 
            this.txtPasaje.Location = new System.Drawing.Point(114, 25);
            this.txtPasaje.Name = "txtPasaje";
            this.txtPasaje.Size = new System.Drawing.Size(125, 20);
            this.txtPasaje.TabIndex = 12;
            // 
            // nroPasaje
            // 
            this.nroPasaje.AutoSize = true;
            this.nroPasaje.Location = new System.Drawing.Point(56, 29);
            this.nroPasaje.Name = "nroPasaje";
            this.nroPasaje.Size = new System.Drawing.Size(42, 13);
            this.nroPasaje.TabIndex = 13;
            this.nroPasaje.Text = "Pasaje:";
            // 
            // rdbPorPasaje
            // 
            this.rdbPorPasaje.AutoSize = true;
            this.rdbPorPasaje.Location = new System.Drawing.Point(13, 3);
            this.rdbPorPasaje.Name = "rdbPorPasaje";
            this.rdbPorPasaje.Size = new System.Drawing.Size(76, 17);
            this.rdbPorPasaje.TabIndex = 14;
            this.rdbPorPasaje.TabStop = true;
            this.rdbPorPasaje.Text = "Por Pasaje";
            this.rdbPorPasaje.UseVisualStyleBackColor = true;
            this.rdbPorPasaje.CheckedChanged += new System.EventHandler(this.rdbPorPasaje_CheckedChanged);
            // 
            // rdbPorVoucher
            // 
            this.rdbPorVoucher.AutoSize = true;
            this.rdbPorVoucher.Location = new System.Drawing.Point(116, 3);
            this.rdbPorVoucher.Name = "rdbPorVoucher";
            this.rdbPorVoucher.Size = new System.Drawing.Size(84, 17);
            this.rdbPorVoucher.TabIndex = 15;
            this.rdbPorVoucher.TabStop = true;
            this.rdbPorVoucher.Text = "Por Voucher";
            this.rdbPorVoucher.UseVisualStyleBackColor = true;
            this.rdbPorVoucher.CheckedChanged += new System.EventHandler(this.rdbPorVoucher_CheckedChanged);
            // 
            // groupPasaje
            // 
            this.groupPasaje.Controls.Add(this.txtPasaje);
            this.groupPasaje.Controls.Add(this.nroPasaje);
            this.groupPasaje.Location = new System.Drawing.Point(25, 35);
            this.groupPasaje.Name = "groupPasaje";
            this.groupPasaje.Size = new System.Drawing.Size(282, 190);
            this.groupPasaje.TabIndex = 16;
            this.groupPasaje.TabStop = false;
            this.groupPasaje.Text = "Por Pasaje";
            // 
            // groupVoucher
            // 
            this.groupVoucher.Controls.Add(this.bttConsultar);
            this.groupVoucher.Controls.Add(this.txtVoucher);
            this.groupVoucher.Controls.Add(this.nroVoucher);
            this.groupVoucher.Controls.Add(this.label4);
            this.groupVoucher.Controls.Add(this.cklbPasajes);
            this.groupVoucher.Location = new System.Drawing.Point(325, 35);
            this.groupVoucher.Name = "groupVoucher";
            this.groupVoucher.Size = new System.Drawing.Size(264, 190);
            this.groupVoucher.TabIndex = 17;
            this.groupVoucher.TabStop = false;
            this.groupVoucher.Text = "Por Voucher";
            this.groupVoucher.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // bttBajaPasaje
            // 
            this.bttBajaPasaje.Location = new System.Drawing.Point(253, 276);
            this.bttBajaPasaje.Name = "bttBajaPasaje";
            this.bttBajaPasaje.Size = new System.Drawing.Size(142, 23);
            this.bttBajaPasaje.TabIndex = 18;
            this.bttBajaPasaje.Text = "Dar de baja pasaje";
            this.bttBajaPasaje.UseVisualStyleBackColor = true;
            this.bttBajaPasaje.Click += new System.EventHandler(this.bttBajaPasaje_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbPorVoucher);
            this.panel1.Controls.Add(this.rdbPorPasaje);
            this.panel1.Location = new System.Drawing.Point(209, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 28);
            this.panel1.TabIndex = 19;
            // 
            // frmCancelarPasajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttBajaPasaje);
            this.Controls.Add(this.groupVoucher);
            this.Controls.Add(this.groupPasaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.bttDarDeBaja);
            this.Name = "frmCancelarPasajes";
            this.Text = "Cancelar Pasajes";
            this.groupPasaje.ResumeLayout(false);
            this.groupPasaje.PerformLayout();
            this.groupVoucher.ResumeLayout(false);
            this.groupVoucher.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVoucher;
        private System.Windows.Forms.Label nroVoucher;
        private System.Windows.Forms.Button bttConsultar;
        private System.Windows.Forms.Button bttDarDeBaja;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox cklbPasajes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasaje;
        private System.Windows.Forms.Label nroPasaje;
        private System.Windows.Forms.RadioButton rdbPorPasaje;
        private System.Windows.Forms.RadioButton rdbPorVoucher;
        private System.Windows.Forms.GroupBox groupPasaje;
        private System.Windows.Forms.GroupBox groupVoucher;
        private System.Windows.Forms.Button bttBajaPasaje;
        private System.Windows.Forms.Panel panel1;
    }
}