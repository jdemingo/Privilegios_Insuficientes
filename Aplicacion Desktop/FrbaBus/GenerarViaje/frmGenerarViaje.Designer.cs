namespace FrbaBus.GenerarViaje
{
    partial class frmGenerarViaje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRecorrido = new System.Windows.Forms.ComboBox();
            this.bttBuscarMicro = new System.Windows.Forms.Button();
            this.bttGenerarViaje = new System.Windows.Forms.Button();
            this.grdMicros = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.timeSalida = new System.Windows.Forms.DateTimePicker();
            this.dateSalida = new System.Windows.Forms.DateTimePicker();
            this.timeLlegada = new System.Windows.Forms.DateTimePicker();
            this.dateLlegada = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMicros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.timeLlegada);
            this.groupBox1.Controls.Add(this.dateLlegada);
            this.groupBox1.Controls.Add(this.timeSalida);
            this.groupBox1.Controls.Add(this.dateSalida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bttGenerarViaje);
            this.groupBox1.Controls.Add(this.bttBuscarMicro);
            this.groupBox1.Controls.Add(this.cmbRecorrido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Recorrido";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha de Salida  :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Recorrido :";
            // 
            // cmbRecorrido
            // 
            this.cmbRecorrido.FormattingEnabled = true;
            this.cmbRecorrido.Location = new System.Drawing.Point(131, 24);
            this.cmbRecorrido.Name = "cmbRecorrido";
            this.cmbRecorrido.Size = new System.Drawing.Size(222, 21);
            this.cmbRecorrido.TabIndex = 9;
            this.cmbRecorrido.SelectedIndexChanged += new System.EventHandler(this.cmbRecorrido_SelectedIndexChanged);
            // 
            // bttBuscarMicro
            // 
            this.bttBuscarMicro.Location = new System.Drawing.Point(131, 128);
            this.bttBuscarMicro.Name = "bttBuscarMicro";
            this.bttBuscarMicro.Size = new System.Drawing.Size(139, 28);
            this.bttBuscarMicro.TabIndex = 10;
            this.bttBuscarMicro.Text = "Buscar Micro";
            this.bttBuscarMicro.UseVisualStyleBackColor = true;
            this.bttBuscarMicro.Click += new System.EventHandler(this.bttBuscarMicro_Click);
            // 
            // bttGenerarViaje
            // 
            this.bttGenerarViaje.Location = new System.Drawing.Point(384, 128);
            this.bttGenerarViaje.Name = "bttGenerarViaje";
            this.bttGenerarViaje.Size = new System.Drawing.Size(133, 27);
            this.bttGenerarViaje.TabIndex = 11;
            this.bttGenerarViaje.Text = "Generar Viaje";
            this.bttGenerarViaje.UseVisualStyleBackColor = true;
            this.bttGenerarViaje.Visible = false;
            this.bttGenerarViaje.Click += new System.EventHandler(this.bttGenerarViaje_Click);
            // 
            // grdMicros
            // 
            this.grdMicros.AllowUserToAddRows = false;
            this.grdMicros.AllowUserToDeleteRows = false;
            this.grdMicros.AllowUserToResizeColumns = false;
            this.grdMicros.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdMicros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.grdMicros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdMicros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMicros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grdMicros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdMicros.Location = new System.Drawing.Point(14, 180);
            this.grdMicros.MultiSelect = false;
            this.grdMicros.Name = "grdMicros";
            this.grdMicros.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMicros.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.grdMicros.RowHeadersVisible = false;
            this.grdMicros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMicros.Size = new System.Drawing.Size(551, 174);
            this.grdMicros.TabIndex = 2;
            this.grdMicros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMicros_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha de Llegada :";
            // 
            // timeSalida
            // 
            this.timeSalida.CustomFormat = "HH:mm";
            this.timeSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeSalida.Location = new System.Drawing.Point(247, 57);
            this.timeSalida.Name = "timeSalida";
            this.timeSalida.ShowUpDown = true;
            this.timeSalida.Size = new System.Drawing.Size(86, 20);
            this.timeSalida.TabIndex = 15;
            this.timeSalida.Value = new System.DateTime(2013, 6, 19, 19, 1, 0, 0);
            // 
            // dateSalida
            // 
            this.dateSalida.CustomFormat = "yyyy-MM-dd";
            this.dateSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSalida.Location = new System.Drawing.Point(133, 57);
            this.dateSalida.Name = "dateSalida";
            this.dateSalida.Size = new System.Drawing.Size(108, 20);
            this.dateSalida.TabIndex = 14;
            this.dateSalida.Value = new System.DateTime(2012, 7, 1, 0, 0, 0, 0);
            // 
            // timeLlegada
            // 
            this.timeLlegada.CustomFormat = "HH:mm";
            this.timeLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeLlegada.Location = new System.Drawing.Point(248, 88);
            this.timeLlegada.Name = "timeLlegada";
            this.timeLlegada.ShowUpDown = true;
            this.timeLlegada.Size = new System.Drawing.Size(86, 20);
            this.timeLlegada.TabIndex = 17;
            this.timeLlegada.Value = new System.DateTime(2013, 6, 19, 19, 1, 0, 0);
            // 
            // dateLlegada
            // 
            this.dateLlegada.CustomFormat = "yyyy-MM-dd";
            this.dateLlegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateLlegada.Location = new System.Drawing.Point(134, 88);
            this.dateLlegada.Name = "dateLlegada";
            this.dateLlegada.Size = new System.Drawing.Size(108, 20);
            this.dateLlegada.TabIndex = 16;
            this.dateLlegada.Value = new System.DateTime(2012, 7, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            // 
            // frmGenerarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 366);
            this.Controls.Add(this.grdMicros);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGenerarViaje";
            this.Text = "Generar Viaje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMicros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRecorrido;
        private System.Windows.Forms.Button bttGenerarViaje;
        private System.Windows.Forms.Button bttBuscarMicro;
        private System.Windows.Forms.DataGridView grdMicros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timeLlegada;
        private System.Windows.Forms.DateTimePicker dateLlegada;
        private System.Windows.Forms.DateTimePicker timeSalida;
        private System.Windows.Forms.DateTimePicker dateSalida;
        private System.Windows.Forms.Label label4;
    }
}