namespace FrbaBus
{
    partial class frmMicroDistri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMicroDistri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdUpd = new System.Windows.Forms.Button();
            this.cmbPiso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtButaca = new System.Windows.Forms.TextBox();
            this.grdPiso2 = new System.Windows.Forms.DataGridView();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.grdPiso1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPiso2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPiso1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdUpd);
            this.groupBox1.Controls.Add(this.cmbPiso);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtButaca);
            this.groupBox1.Controls.Add(this.grdPiso2);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.grdPiso1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distribucion de Butacas";
            // 
            // cmdUpd
            // 
            this.cmdUpd.Image = ((System.Drawing.Image)(resources.GetObject("cmdUpd.Image")));
            this.cmdUpd.Location = new System.Drawing.Point(259, 255);
            this.cmdUpd.Name = "cmdUpd";
            this.cmdUpd.Size = new System.Drawing.Size(46, 56);
            this.cmdUpd.TabIndex = 10;
            this.cmdUpd.UseVisualStyleBackColor = true;
            this.cmdUpd.Click += new System.EventHandler(this.cmdUpd_Click);
            // 
            // cmbPiso
            // 
            this.cmbPiso.DisplayMember = "id";
            this.cmbPiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPiso.FormattingEnabled = true;
            this.cmbPiso.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbPiso.Location = new System.Drawing.Point(187, 257);
            this.cmbPiso.Name = "cmbPiso";
            this.cmbPiso.Size = new System.Drawing.Size(42, 21);
            this.cmbPiso.TabIndex = 9;
            this.cmbPiso.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Piso";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Butaca";
            // 
            // txtButaca
            // 
            this.txtButaca.Location = new System.Drawing.Point(88, 260);
            this.txtButaca.Name = "txtButaca";
            this.txtButaca.Size = new System.Drawing.Size(44, 20);
            this.txtButaca.TabIndex = 4;
            // 
            // grdPiso2
            // 
            this.grdPiso2.AllowUserToAddRows = false;
            this.grdPiso2.AllowUserToDeleteRows = false;
            this.grdPiso2.AllowUserToResizeColumns = false;
            this.grdPiso2.AllowUserToResizeRows = false;
            this.grdPiso2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPiso2.Location = new System.Drawing.Point(185, 29);
            this.grdPiso2.Name = "grdPiso2";
            this.grdPiso2.ReadOnly = true;
            this.grdPiso2.RowHeadersVisible = false;
            this.grdPiso2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPiso2.Size = new System.Drawing.Size(170, 220);
            this.grdPiso2.TabIndex = 3;
            this.grdPiso2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPiso2_CellDoubleClick);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Ventanilla",
            "Pasillo"});
            this.cmbTipo.Location = new System.Drawing.Point(88, 290);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(141, 21);
            this.cmbTipo.TabIndex = 2;
            // 
            // grdPiso1
            // 
            this.grdPiso1.AllowUserToAddRows = false;
            this.grdPiso1.AllowUserToDeleteRows = false;
            this.grdPiso1.AllowUserToResizeColumns = false;
            this.grdPiso1.AllowUserToResizeRows = false;
            this.grdPiso1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPiso1.Location = new System.Drawing.Point(9, 29);
            this.grdPiso1.Name = "grdPiso1";
            this.grdPiso1.ReadOnly = true;
            this.grdPiso1.RowHeadersVisible = false;
            this.grdPiso1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPiso1.Size = new System.Drawing.Size(170, 220);
            this.grdPiso1.TabIndex = 0;
            this.grdPiso1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPiso1_CellDoubleClick);
            // 
            // frmMicroDistri
            // 
            this.AcceptButton = this.cmdUpd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 335);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMicroDistri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMicroDistri";
            this.Load += new System.EventHandler(this.frmMicroDistri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPiso2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPiso1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdPiso1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtButaca;
        private System.Windows.Forms.DataGridView grdPiso2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPiso;
        private System.Windows.Forms.Button cmdUpd;
    }
}