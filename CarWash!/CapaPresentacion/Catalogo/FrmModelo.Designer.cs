namespace CapaPresentacion.Formularios
{
    partial class FrmModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModelo));
            this.chkLista = new System.Windows.Forms.CheckBox();
            this.grpModelo = new System.Windows.Forms.GroupBox();
            this.btnMarcaA = new System.Windows.Forms.Button();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.btnMarcaFormu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.dgvModelo = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.CmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).BeginInit();
            this.CmsOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkLista
            // 
            this.chkLista.AutoSize = true;
            this.chkLista.BackColor = System.Drawing.Color.Transparent;
            this.chkLista.Location = new System.Drawing.Point(281, 248);
            this.chkLista.Name = "chkLista";
            this.chkLista.Size = new System.Drawing.Size(67, 17);
            this.chkLista.TabIndex = 36;
            this.chkLista.Text = "Ver Lista";
            this.chkLista.UseVisualStyleBackColor = false;
            this.chkLista.CheckedChanged += new System.EventHandler(this.chkLista_CheckedChanged);
            // 
            // grpModelo
            // 
            this.grpModelo.BackColor = System.Drawing.Color.Transparent;
            this.grpModelo.Controls.Add(this.btnMarcaA);
            this.grpModelo.Controls.Add(this.cboMarca);
            this.grpModelo.Controls.Add(this.btnMarcaFormu);
            this.grpModelo.Controls.Add(this.label3);
            this.grpModelo.Controls.Add(this.label1);
            this.grpModelo.Controls.Add(this.txtIdModelo);
            this.grpModelo.Controls.Add(this.label2);
            this.grpModelo.Controls.Add(this.txtModelo);
            this.grpModelo.Location = new System.Drawing.Point(47, 109);
            this.grpModelo.Name = "grpModelo";
            this.grpModelo.Size = new System.Drawing.Size(279, 129);
            this.grpModelo.TabIndex = 35;
            this.grpModelo.TabStop = false;
            this.grpModelo.Text = "Datos Modelo";
            // 
            // btnMarcaA
            // 
            this.btnMarcaA.Location = new System.Drawing.Point(193, 70);
            this.btnMarcaA.Name = "btnMarcaA";
            this.btnMarcaA.Size = new System.Drawing.Size(33, 23);
            this.btnMarcaA.TabIndex = 55;
            this.btnMarcaA.Text = "...";
            this.btnMarcaA.UseVisualStyleBackColor = true;
            this.btnMarcaA.Click += new System.EventHandler(this.btnMarcaA_Click);
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(73, 70);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(114, 21);
            this.cboMarca.TabIndex = 14;
            // 
            // btnMarcaFormu
            // 
            this.btnMarcaFormu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarcaFormu.BackgroundImage")));
            this.btnMarcaFormu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarcaFormu.FlatAppearance.BorderSize = 0;
            this.btnMarcaFormu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcaFormu.Location = new System.Drawing.Point(234, 74);
            this.btnMarcaFormu.Name = "btnMarcaFormu";
            this.btnMarcaFormu.Size = new System.Drawing.Size(25, 20);
            this.btnMarcaFormu.TabIndex = 13;
            this.btnMarcaFormu.UseVisualStyleBackColor = true;
            this.btnMarcaFormu.Click += new System.EventHandler(this.btnMarcaFormu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "IdModelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // txtIdModelo
            // 
            this.txtIdModelo.Location = new System.Drawing.Point(74, 19);
            this.txtIdModelo.Name = "txtIdModelo";
            this.txtIdModelo.Size = new System.Drawing.Size(61, 20);
            this.txtIdModelo.TabIndex = 1;
            this.txtIdModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(74, 45);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(113, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // dgvModelo
            // 
            this.dgvModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelo.ContextMenuStrip = this.CmsOpciones;
            this.dgvModelo.Location = new System.Drawing.Point(47, 272);
            this.dgvModelo.Name = "dgvModelo";
            this.dgvModelo.Size = new System.Drawing.Size(405, 93);
            this.dgvModelo.TabIndex = 30;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancelar.Location = new System.Drawing.Point(366, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnModificar.Location = new System.Drawing.Point(366, 196);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 29);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGuardar.Location = new System.Drawing.Point(366, 161);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 29);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNuevo.Location = new System.Drawing.Point(366, 126);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 29);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(141, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 55);
            this.label13.TabIndex = 54;
            this.label13.Text = "Modelo";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.frm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 436);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chkLista);
            this.Controls.Add(this.grpModelo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvModelo);
            this.DoubleBuffered = true;
            this.Name = "FrmModelo";
            this.Text = "Modelo";
            this.Load += new System.EventHandler(this.FrmModelo_Load);
            this.grpModelo.ResumeLayout(false);
            this.grpModelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).EndInit();
            this.CmsOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLista;
        private System.Windows.Forms.GroupBox grpModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private System.Windows.Forms.DataGridView dgvModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdModelo;
        private System.Windows.Forms.Button btnMarcaFormu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Button btnMarcaA;
        internal System.Windows.Forms.ContextMenuStrip CmsOpciones;
        internal System.Windows.Forms.ToolStripMenuItem editarMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem eliminarMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}