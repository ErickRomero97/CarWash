namespace CapaPresentacion
{
    partial class FrmAutomoviles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAutomoviles));
            this.dgvAuto = new System.Windows.Forms.DataGridView();
            this.CmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkLista = new System.Windows.Forms.CheckBox();
            this.grpAuto = new System.Windows.Forms.GroupBox();
            this.btnMarcaFormu = new System.Windows.Forms.Button();
            this.btnMarcaA = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).BeginInit();
            this.CmsOpciones.SuspendLayout();
            this.grpAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuto
            // 
            this.dgvAuto.AllowUserToAddRows = false;
            this.dgvAuto.AllowUserToDeleteRows = false;
            this.dgvAuto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuto.ContextMenuStrip = this.CmsOpciones;
            this.dgvAuto.Location = new System.Drawing.Point(22, 385);
            this.dgvAuto.Name = "dgvAuto";
            this.dgvAuto.ReadOnly = true;
            this.dgvAuto.RowHeadersVisible = false;
            this.dgvAuto.Size = new System.Drawing.Size(497, 133);
            this.dgvAuto.TabIndex = 22;
            // 
            // CmsOpciones
            // 
            this.CmsOpciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarMenuItem,
            this.eliminarMenuItem});
            this.CmsOpciones.Name = "CmsOpciones";
            this.CmsOpciones.Size = new System.Drawing.Size(122, 56);
            // 
            // editarMenuItem
            // 
            this.editarMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarMenuItem.Image")));
            this.editarMenuItem.Name = "editarMenuItem";
            this.editarMenuItem.Size = new System.Drawing.Size(121, 26);
            this.editarMenuItem.Text = "Editar";
            this.editarMenuItem.Click += new System.EventHandler(this.editarMenuItem_Click);
            // 
            // eliminarMenuItem
            // 
            this.eliminarMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarMenuItem.Image")));
            this.eliminarMenuItem.Name = "eliminarMenuItem";
            this.eliminarMenuItem.Size = new System.Drawing.Size(121, 26);
            this.eliminarMenuItem.Text = "Eliminar";
            this.eliminarMenuItem.Click += new System.EventHandler(this.eliminarMenuItem_Click);
            // 
            // chkLista
            // 
            this.chkLista.AutoSize = true;
            this.chkLista.BackColor = System.Drawing.Color.Transparent;
            this.chkLista.Location = new System.Drawing.Point(360, 341);
            this.chkLista.Name = "chkLista";
            this.chkLista.Size = new System.Drawing.Size(67, 17);
            this.chkLista.TabIndex = 21;
            this.chkLista.Text = "Ver Lista";
            this.chkLista.UseVisualStyleBackColor = false;
            this.chkLista.CheckedChanged += new System.EventHandler(this.chkLista_CheckedChanged);
            // 
            // grpAuto
            // 
            this.grpAuto.BackColor = System.Drawing.Color.Transparent;
            this.grpAuto.Controls.Add(this.btnMarcaFormu);
            this.grpAuto.Controls.Add(this.btnMarcaA);
            this.grpAuto.Controls.Add(this.btnCliente);
            this.grpAuto.Controls.Add(this.cboModelo);
            this.grpAuto.Controls.Add(this.txtIdCliente);
            this.grpAuto.Controls.Add(this.txtAño);
            this.grpAuto.Controls.Add(this.txtDescripcion);
            this.grpAuto.Controls.Add(this.txtPlaca);
            this.grpAuto.Controls.Add(this.label10);
            this.grpAuto.Controls.Add(this.label6);
            this.grpAuto.Controls.Add(this.label5);
            this.grpAuto.Controls.Add(this.label2);
            this.grpAuto.Controls.Add(this.label1);
            this.grpAuto.Location = new System.Drawing.Point(22, 145);
            this.grpAuto.Name = "grpAuto";
            this.grpAuto.Size = new System.Drawing.Size(332, 230);
            this.grpAuto.TabIndex = 14;
            this.grpAuto.TabStop = false;
            this.grpAuto.Text = "Datos de Automóvil";
            // 
            // btnMarcaFormu
            // 
            this.btnMarcaFormu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarcaFormu.BackgroundImage")));
            this.btnMarcaFormu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarcaFormu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcaFormu.FlatAppearance.BorderSize = 0;
            this.btnMarcaFormu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcaFormu.Location = new System.Drawing.Point(294, 137);
            this.btnMarcaFormu.Name = "btnMarcaFormu";
            this.btnMarcaFormu.Size = new System.Drawing.Size(25, 20);
            this.btnMarcaFormu.TabIndex = 57;
            this.btnMarcaFormu.UseVisualStyleBackColor = true;
            this.btnMarcaFormu.Click += new System.EventHandler(this.btnMarcaFormu_Click);
            // 
            // btnMarcaA
            // 
            this.btnMarcaA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarcaA.BackgroundImage")));
            this.btnMarcaA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarcaA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcaA.FlatAppearance.BorderSize = 0;
            this.btnMarcaA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcaA.Location = new System.Drawing.Point(261, 136);
            this.btnMarcaA.Name = "btnMarcaA";
            this.btnMarcaA.Size = new System.Drawing.Size(25, 20);
            this.btnMarcaA.TabIndex = 56;
            this.btnMarcaA.UseVisualStyleBackColor = true;
            this.btnMarcaA.Click += new System.EventHandler(this.btnMarcaA_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCliente.BackgroundImage")));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Location = new System.Drawing.Point(262, 188);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(25, 20);
            this.btnCliente.TabIndex = 12;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // cboModelo
            // 
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(135, 135);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(121, 21);
            this.cboModelo.TabIndex = 9;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(135, 188);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(121, 20);
            this.txtIdCliente.TabIndex = 8;
            this.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(135, 162);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(54, 20);
            this.txtAño.TabIndex = 6;
            this.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(135, 65);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(178, 64);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(135, 39);
            this.txtPlaca.MaxLength = 7;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(121, 20);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Id Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Año:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa Automóvil:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNuevo.Location = new System.Drawing.Point(388, 182);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 29);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGuardar.Location = new System.Drawing.Point(388, 217);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 29);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnModificar.Location = new System.Drawing.Point(388, 252);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 29);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancelar.Location = new System.Drawing.Point(388, 287);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(129, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(312, 55);
            this.label13.TabIndex = 54;
            this.label13.Text = "Automoviles";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAutomoviles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.frm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 383);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvAuto);
            this.Controls.Add(this.chkLista);
            this.Controls.Add(this.grpAuto);
            this.DoubleBuffered = true;
            this.Name = "FrmAutomoviles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automoviles";
            this.Load += new System.EventHandler(this.FrmAutomoviles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuto)).EndInit();
            this.CmsOpciones.ResumeLayout(false);
            this.grpAuto.ResumeLayout(false);
            this.grpAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuto;
        private System.Windows.Forms.CheckBox chkLista;
        private System.Windows.Forms.GroupBox grpAuto;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboModelo;
        private System.Windows.Forms.Button btnCliente;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnMarcaA;
        private System.Windows.Forms.Button btnMarcaFormu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        internal System.Windows.Forms.ContextMenuStrip CmsOpciones;
        internal System.Windows.Forms.ToolStripMenuItem editarMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem eliminarMenuItem;
    }
}