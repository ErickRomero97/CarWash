namespace CapaPresentacion
{
    partial class FrmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mtbIdEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.chkLista = new System.Windows.Forms.CheckBox();
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.cmsOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.mtbTelefono);
            this.gbDatos.Controls.Add(this.mtbIdEmpleado);
            this.gbDatos.Controls.Add(this.txtDireccion);
            this.gbDatos.Controls.Add(this.cboSexo);
            this.gbDatos.Controls.Add(this.txtCorreoElectronico);
            this.gbDatos.Controls.Add(this.txtApellidos);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.label7);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(19, 16);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(293, 266);
            this.gbDatos.TabIndex = 103;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Empleado";
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(109, 132);
            this.mtbTelefono.Mask = "0000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.PromptChar = ' ';
            this.mtbTelefono.Size = new System.Drawing.Size(100, 20);
            this.mtbTelefono.TabIndex = 5;
            // 
            // mtbIdEmpleado
            // 
            this.mtbIdEmpleado.Location = new System.Drawing.Point(109, 28);
            this.mtbIdEmpleado.Mask = "0000-0000-00000";
            this.mtbIdEmpleado.Name = "mtbIdEmpleado";
            this.mtbIdEmpleado.PromptChar = ' ';
            this.mtbIdEmpleado.Size = new System.Drawing.Size(100, 20);
            this.mtbIdEmpleado.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(109, 187);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(147, 73);
            this.txtDireccion.TabIndex = 7;
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Location = new System.Drawing.Point(109, 105);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(106, 21);
            this.cboSexo.TabIndex = 4;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(109, 160);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(147, 20);
            this.txtCorreoElectronico.TabIndex = 6;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(109, 79);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(147, 20);
            this.txtApellidos.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(109, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Correo Electronico:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Empleado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(336, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 102;
            this.label12.Text = "Actualizar";
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditar.BackgroundImage")));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Location = new System.Drawing.Point(336, 134);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(55, 49);
            this.BtnEditar.TabIndex = 101;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 99;
            this.label9.Text = "Cancelar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 100;
            this.label8.Text = "Guardar";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(341, 16);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(44, 40);
            this.btnNuevo.TabIndex = 95;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(343, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 98;
            this.label10.Text = "Insertar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(341, 76);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(44, 40);
            this.btnGuardar.TabIndex = 96;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(343, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(44, 38);
            this.btnCancelar.TabIndex = 97;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.ContextMenuStrip = this.cmsOpciones;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 303);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleados.Size = new System.Drawing.Size(450, 216);
            this.dgvEmpleados.TabIndex = 94;
            // 
            // chkLista
            // 
            this.chkLista.AutoSize = true;
            this.chkLista.Location = new System.Drawing.Point(339, 265);
            this.chkLista.Name = "chkLista";
            this.chkLista.Size = new System.Drawing.Size(67, 17);
            this.chkLista.TabIndex = 93;
            this.chkLista.Text = "Ver Lista";
            this.chkLista.UseVisualStyleBackColor = true;
            this.chkLista.CheckedChanged += new System.EventHandler(this.chkLista_CheckedChanged);
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
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // epValidar
            // 
            this.epValidar.ContainerControl = this;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 535);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.chkLista);
            this.Name = "FrmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.cmsOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epValidar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.MaskedTextBox mtbIdEmpleado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.CheckBox chkLista;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider epValidar;
    }
}