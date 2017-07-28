namespace CapaPresentacion
{
    partial class FrmUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.label10 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtbIdEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.cboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkLista = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.epValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidar)).BeginInit();
            this.cmsOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "Actualizar";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(314, 128);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(55, 61);
            this.btnEditar.TabIndex = 93;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.ContextMenuStrip = this.cmsOpciones;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 311);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(378, 176);
            this.dgvUsuarios.TabIndex = 92;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtNombreEmpleado);
            this.gbDatos.Controls.Add(this.label11);
            this.gbDatos.Controls.Add(this.mtbIdEmpleado);
            this.gbDatos.Controls.Add(this.cboTipoUsuario);
            this.gbDatos.Controls.Add(this.btnEmpleado);
            this.gbDatos.Controls.Add(this.cboEstado);
            this.gbDatos.Controls.Add(this.txtContraseña);
            this.gbDatos.Controls.Add(this.txtNombreUsuario);
            this.gbDatos.Controls.Add(this.txtIdUsuario);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(12, 31);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(283, 239);
            this.gbDatos.TabIndex = 91;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Usuario";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(116, 171);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmpleado.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(-2, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Nombre de Empleado:";
            // 
            // mtbIdEmpleado
            // 
            this.mtbIdEmpleado.Location = new System.Drawing.Point(116, 144);
            this.mtbIdEmpleado.Mask = "0000-0000-00000";
            this.mtbIdEmpleado.Name = "mtbIdEmpleado";
            this.mtbIdEmpleado.PromptChar = ' ';
            this.mtbIdEmpleado.Size = new System.Drawing.Size(133, 20);
            this.mtbIdEmpleado.TabIndex = 12;
            // 
            // cboTipoUsuario
            // 
            this.cboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoUsuario.FormattingEnabled = true;
            this.cboTipoUsuario.Location = new System.Drawing.Point(116, 197);
            this.cboTipoUsuario.Name = "cboTipoUsuario";
            this.cboTipoUsuario.Size = new System.Drawing.Size(128, 21);
            this.cboTipoUsuario.TabIndex = 11;
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Location = new System.Drawing.Point(255, 147);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(25, 20);
            this.btnEmpleado.TabIndex = 10;
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(116, 112);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(100, 21);
            this.cboEstado.TabIndex = 8;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(116, 82);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 6;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(116, 51);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUsuario.TabIndex = 5;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(116, 24);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(40, 20);
            this.txtIdUsuario.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tipo de Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Id Empleado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Usuario:";
            // 
            // chkLista
            // 
            this.chkLista.AutoSize = true;
            this.chkLista.Location = new System.Drawing.Point(314, 273);
            this.chkLista.Name = "chkLista";
            this.chkLista.Size = new System.Drawing.Size(67, 17);
            this.chkLista.TabIndex = 90;
            this.chkLista.Text = "Ver Lista";
            this.chkLista.UseVisualStyleBackColor = true;
            this.chkLista.CheckedChanged += new System.EventHandler(this.chkLista_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "Cancelar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(322, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "Guardar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Insertar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(324, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(44, 50);
            this.btnCancelar.TabIndex = 86;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(320, 63);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(44, 52);
            this.btnGuardar.TabIndex = 85;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(320, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(44, 52);
            this.btnNuevo.TabIndex = 84;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // epValidar
            // 
            this.epValidar.ContainerControl = this;
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem});
            this.cmsOpciones.Name = "cmsOpciones";
            this.cmsOpciones.Size = new System.Drawing.Size(105, 26);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click_1);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 499);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.chkLista);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "FrmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidar)).EndInit();
            this.cmsOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.MaskedTextBox mtbIdEmpleado;
        private System.Windows.Forms.ComboBox cboTipoUsuario;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ErrorProvider epValidar;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    }
}