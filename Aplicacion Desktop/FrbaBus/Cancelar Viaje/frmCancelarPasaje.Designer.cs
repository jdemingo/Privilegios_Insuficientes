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
            this.SuspendLayout();
            // 
            // txtVoucher
            // 
            this.txtVoucher.Location = new System.Drawing.Point(96, 36);
            this.txtVoucher.Name = "txtVoucher";
            this.txtVoucher.Size = new System.Drawing.Size(100, 20);
            this.txtVoucher.TabIndex = 0;
            this.txtVoucher.TextChanged += new System.EventHandler(this.txtVoucher_TextChanged);
            // 
            // nroVoucher
            // 
            this.nroVoucher.AutoSize = true;
            this.nroVoucher.Location = new System.Drawing.Point(38, 43);
            this.nroVoucher.Name = "nroVoucher";
            this.nroVoucher.Size = new System.Drawing.Size(50, 13);
            this.nroVoucher.TabIndex = 1;
            this.nroVoucher.Text = "Voucher:";
            // 
            // bttConsultar
            // 
            this.bttConsultar.Location = new System.Drawing.Point(232, 36);
            this.bttConsultar.Name = "bttConsultar";
            this.bttConsultar.Size = new System.Drawing.Size(75, 23);
            this.bttConsultar.TabIndex = 5;
            this.bttConsultar.Text = "Consultar";
            this.bttConsultar.UseVisualStyleBackColor = true;
            this.bttConsultar.Click += new System.EventHandler(this.bttConsultar_Click_1);
            // 
            // bttDarDeBaja
            // 
            this.bttDarDeBaja.Location = new System.Drawing.Point(209, 269);
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
            this.txtMotivo.Size = new System.Drawing.Size(255, 20);
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
            this.cklbPasajes.Location = new System.Drawing.Point(164, 76);
            this.cklbPasajes.Name = "cklbPasajes";
            this.cklbPasajes.Size = new System.Drawing.Size(143, 154);
            this.cklbPasajes.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Listado de pasajes :";
            // 
            // frmCancelarPasajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 324);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cklbPasajes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.bttDarDeBaja);
            this.Controls.Add(this.bttConsultar);
            this.Controls.Add(this.nroVoucher);
            this.Controls.Add(this.txtVoucher);
            this.Name = "frmCancelarPasajes";
            this.Text = "Cancelar Pasajes";
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
    }
}