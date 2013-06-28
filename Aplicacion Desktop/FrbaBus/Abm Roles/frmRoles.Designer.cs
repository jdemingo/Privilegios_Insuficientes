namespace FrbaBus.Abm_Roles
{
    partial class frmRoles
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
            this.bttNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRolExistenteN = new System.Windows.Forms.Label();
            this.ckbInhabiliNuevo = new System.Windows.Forms.CheckBox();
            this.txtbNuevo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clbFunciones = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.bttModificar = new System.Windows.Forms.Button();
            this.bttEliminar = new System.Windows.Forms.Button();
            this.ckbInhabilitar = new System.Windows.Forms.CheckBox();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bttGuardarCambios = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblRolExistenteMod = new System.Windows.Forms.Label();
            this.txtBoxRolMod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxFunc = new System.Windows.Forms.GroupBox();
            this.clbFunciones_mod = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gboxFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttNuevo
            // 
            this.bttNuevo.Enabled = false;
            this.bttNuevo.Location = new System.Drawing.Point(31, 184);
            this.bttNuevo.Name = "bttNuevo";
            this.bttNuevo.Size = new System.Drawing.Size(75, 23);
            this.bttNuevo.TabIndex = 0;
            this.bttNuevo.Text = "Crear Nuevo";
            this.bttNuevo.UseVisualStyleBackColor = true;
            this.bttNuevo.Click += new System.EventHandler(this.bttNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRolExistenteN);
            this.groupBox1.Controls.Add(this.ckbInhabiliNuevo);
            this.groupBox1.Controls.Add(this.txtbNuevo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // lblRolExistenteN
            // 
            this.lblRolExistenteN.AutoSize = true;
            this.lblRolExistenteN.ForeColor = System.Drawing.Color.Red;
            this.lblRolExistenteN.Location = new System.Drawing.Point(43, 54);
            this.lblRolExistenteN.Name = "lblRolExistenteN";
            this.lblRolExistenteN.Size = new System.Drawing.Size(141, 13);
            this.lblRolExistenteN.TabIndex = 4;
            this.lblRolExistenteN.Text = "*Rol existe! Use otro nombre";
            this.lblRolExistenteN.Visible = false;
            // 
            // ckbInhabiliNuevo
            // 
            this.ckbInhabiliNuevo.AutoSize = true;
            this.ckbInhabiliNuevo.Location = new System.Drawing.Point(85, 72);
            this.ckbInhabiliNuevo.Name = "ckbInhabiliNuevo";
            this.ckbInhabiliNuevo.Size = new System.Drawing.Size(90, 17);
            this.ckbInhabiliNuevo.TabIndex = 7;
            this.ckbInhabiliNuevo.Text = "Inhabilitar Rol";
            this.ckbInhabiliNuevo.UseVisualStyleBackColor = true;
            // 
            // txtbNuevo
            // 
            this.txtbNuevo.Location = new System.Drawing.Point(75, 31);
            this.txtbNuevo.Name = "txtbNuevo";
            this.txtbNuevo.Size = new System.Drawing.Size(100, 20);
            this.txtbNuevo.TabIndex = 6;
            this.txtbNuevo.TextChanged += new System.EventHandler(this.txtbNuevo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "   Rol :";
            // 
            // clbFunciones
            // 
            this.clbFunciones.FormattingEnabled = true;
            this.clbFunciones.Location = new System.Drawing.Point(6, 19);
            this.clbFunciones.Name = "clbFunciones";
            this.clbFunciones.Size = new System.Drawing.Size(120, 139);
            this.clbFunciones.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clbFunciones);
            this.groupBox2.Location = new System.Drawing.Point(226, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 170);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionalidades";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(60, 33);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 21);
            this.cmbRol.TabIndex = 4;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
            // 
            // bttModificar
            // 
            this.bttModificar.Location = new System.Drawing.Point(106, 77);
            this.bttModificar.Name = "bttModificar";
            this.bttModificar.Size = new System.Drawing.Size(75, 23);
            this.bttModificar.TabIndex = 4;
            this.bttModificar.Text = "Modificar";
            this.bttModificar.UseVisualStyleBackColor = true;
            this.bttModificar.Click += new System.EventHandler(this.bttModificar_Click);
            // 
            // bttEliminar
            // 
            this.bttEliminar.Location = new System.Drawing.Point(25, 77);
            this.bttEliminar.Name = "bttEliminar";
            this.bttEliminar.Size = new System.Drawing.Size(75, 23);
            this.bttEliminar.TabIndex = 5;
            this.bttEliminar.Text = "Eliminar";
            this.bttEliminar.UseVisualStyleBackColor = true;
            this.bttEliminar.Click += new System.EventHandler(this.bttEliminar_Click);
            // 
            // ckbInhabilitar
            // 
            this.ckbInhabilitar.AutoSize = true;
            this.ckbInhabilitar.Location = new System.Drawing.Point(124, 156);
            this.ckbInhabilitar.Name = "ckbInhabilitar";
            this.ckbInhabilitar.Size = new System.Drawing.Size(90, 17);
            this.ckbInhabilitar.TabIndex = 6;
            this.ckbInhabilitar.Text = "Inhabilitar Rol";
            this.ckbInhabilitar.UseVisualStyleBackColor = true;
            this.ckbInhabilitar.Visible = false;
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Controls.Add(this.tabPage2);
            this.tbControl.Location = new System.Drawing.Point(12, 12);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(416, 258);
            this.tbControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.bttNuevo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(408, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Rol";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bttGuardarCambios);
            this.tabPage2.Controls.Add(this.ckbInhabilitar);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.gboxFunc);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(408, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar o Eliminar Rol";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bttGuardarCambios
            // 
            this.bttGuardarCambios.Location = new System.Drawing.Point(258, 203);
            this.bttGuardarCambios.Name = "bttGuardarCambios";
            this.bttGuardarCambios.Size = new System.Drawing.Size(117, 23);
            this.bttGuardarCambios.TabIndex = 7;
            this.bttGuardarCambios.Text = "Guardar Cambios";
            this.bttGuardarCambios.UseVisualStyleBackColor = true;
            this.bttGuardarCambios.Visible = false;
            this.bttGuardarCambios.Click += new System.EventHandler(this.bttGuardarCambios_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblRolExistenteMod);
            this.groupBox4.Controls.Add(this.txtBoxRolMod);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.bttEliminar);
            this.groupBox4.Controls.Add(this.cmbRol);
            this.groupBox4.Controls.Add(this.bttModificar);
            this.groupBox4.Location = new System.Drawing.Point(18, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 106);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Roles";
            // 
            // lblRolExistenteMod
            // 
            this.lblRolExistenteMod.AutoSize = true;
            this.lblRolExistenteMod.ForeColor = System.Drawing.Color.Red;
            this.lblRolExistenteMod.Location = new System.Drawing.Point(61, 61);
            this.lblRolExistenteMod.Name = "lblRolExistenteMod";
            this.lblRolExistenteMod.Size = new System.Drawing.Size(141, 13);
            this.lblRolExistenteMod.TabIndex = 8;
            this.lblRolExistenteMod.Text = "*Rol existe! Use otro nombre";
            this.lblRolExistenteMod.Visible = false;
            // 
            // txtBoxRolMod
            // 
            this.txtBoxRolMod.Location = new System.Drawing.Point(60, 33);
            this.txtBoxRolMod.Name = "txtBoxRolMod";
            this.txtBoxRolMod.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRolMod.TabIndex = 6;
            this.txtBoxRolMod.Visible = false;
            this.txtBoxRolMod.TextChanged += new System.EventHandler(this.txtBoxRolMod_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "   Rol :";
            // 
            // gboxFunc
            // 
            this.gboxFunc.Controls.Add(this.clbFunciones_mod);
            this.gboxFunc.Location = new System.Drawing.Point(249, 26);
            this.gboxFunc.Name = "gboxFunc";
            this.gboxFunc.Size = new System.Drawing.Size(153, 170);
            this.gboxFunc.TabIndex = 4;
            this.gboxFunc.TabStop = false;
            this.gboxFunc.Text = "Funcionalidades";
            this.gboxFunc.Visible = false;
            // 
            // clbFunciones_mod
            // 
            this.clbFunciones_mod.FormattingEnabled = true;
            this.clbFunciones_mod.Location = new System.Drawing.Point(6, 19);
            this.clbFunciones_mod.Name = "clbFunciones_mod";
            this.clbFunciones_mod.Size = new System.Drawing.Size(120, 139);
            this.clbFunciones_mod.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 139);
            this.checkedListBox1.TabIndex = 2;
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 272);
            this.Controls.Add(this.tbControl);
            this.Name = "frmRoles";
            this.Text = "ABM Roles";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gboxFunc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbInhabilitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.CheckedListBox clbFunciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttModificar;
        private System.Windows.Forms.Button bttEliminar;
        private System.Windows.Forms.TextBox txtbNuevo;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxFunc;
        private System.Windows.Forms.CheckedListBox clbFunciones_mod;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox ckbInhabiliNuevo;
        private System.Windows.Forms.Button bttGuardarCambios;
        private System.Windows.Forms.TextBox txtBoxRolMod;
        private System.Windows.Forms.Label lblRolExistenteN;
        private System.Windows.Forms.Label lblRolExistenteMod;
    }
}