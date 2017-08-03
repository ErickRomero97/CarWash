namespace CapaPresentacion.Formularios
{
    partial class FrmMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMarca));
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.CmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMarca = new System.Windows.Forms.GroupBox();
            this.chkLista = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.CmsOpciones.SuspendLayout();
            this.grpMarca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdMarca:";
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Location = new System.Drawing.Point(74, 22);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(61, 20);
            this.txtIdMarca.TabIndex = 1;
            this.txtIdMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(74, 53);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(113, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.ContextMenuStrip = this.CmsOpciones;
            this.dgvMarca.Location = new System.Drawing.Point(28, 289);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.Size = new System.Drawing.Size(279, 93);
            this.dgvMarca.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marca:";
            // 
            // grpMarca
            // 
            this.grpMarca.BackColor = System.Drawing.Color.Transparent;
            this.grpMarca.Controls.Add(this.label1);
            this.grpMarca.Controls.Add(this.label2);
            this.grpMarca.Controls.Add(this.txtIdMarca);
            this.grpMarca.Controls.Add(this.txtMarca);
            this.grpMarca.Location = new System.Drawing.Point(28, 138);
            this.grpMarca.Name = "grpMarca";
            this.grpMarca.Size = new System.Drawing.Size(279, 90);
            this.grpMarca.TabIndex = 28;
            this.grpMarca.TabStop = false;
            this.grpMarca.Text = "Datos Marca";
            // 
            // chkLista
            // 
            this.chkLista.AutoSize = true;
            this.chkLista.BackColor = System.Drawing.Color.Transparent;
            this.chkLista.Location = new System.Drawing.Point(240, 251);
            this.chkLista.Name = "chkLista";
            this.chkLista.Size = new System.Drawing.Size(67, 17);
            this.chkLista.TabIndex = 29;
            this.chkLista.Text = "Ver Lista";
            this.chkLista.UseVisualStyleBackColor = false;
            this.chkLista.CheckedChanged += new System.EventHandler(this.chkLista_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancelar.Location = new System.Drawing.Point(338, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnModificar.Location = new System.Drawing.Point(338, 208);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 29);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGuardar.Location = new System.Drawing.Point(338, 173);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 29);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNuevo.Location = new System.Drawing.Point(338, 138);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 29);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(139, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 55);
            this.label13.TabIndex = 54;
            this.label13.Text = "Marca";
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.frm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 420);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chkLista);
            this.Controls.Add(this.grpMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvMarca);
            this.Name = "FrmMarca";
            this.Text = "Marca";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.CmsOpciones.ResumeLayout(false);
            this.grpMarca.ResumeLayout(false);
            this.grpMarca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.DataGridView dgvMarca;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpMarca;
        private System.Windows.Forms.CheckBox chkLista;
        internal System.Windows.Forms.ContextMenuStrip CmsOpciones;
        internal System.Windows.Forms.ToolStripMenuItem editarMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem eliminarMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label13;
    }
}