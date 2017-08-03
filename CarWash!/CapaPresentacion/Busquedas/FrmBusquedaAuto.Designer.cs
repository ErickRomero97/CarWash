namespace CapaPresentacion.Busquedas
{
    partial class FrmBusquedaAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaAuto));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbId = new System.Windows.Forms.RadioButton();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.epBuscar = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(195, 170);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(229, 20);
            this.txtBuscar.TabIndex = 24;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(195, 170);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(229, 20);
            this.txtIdEmpleado.TabIndex = 23;
            // 
            // gbBuscar
            // 
            this.gbBuscar.BackColor = System.Drawing.Color.Transparent;
            this.gbBuscar.Controls.Add(this.rdbNombre);
            this.gbBuscar.Controls.Add(this.rdbId);
            this.gbBuscar.Location = new System.Drawing.Point(205, 122);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(297, 39);
            this.gbBuscar.TabIndex = 22;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar por";
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(167, 16);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(44, 17);
            this.rdbNombre.TabIndex = 1;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Año";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // rdbId
            // 
            this.rdbId.AutoSize = true;
            this.rdbId.Location = new System.Drawing.Point(21, 16);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(59, 17);
            this.rdbId.TabIndex = 0;
            this.rdbId.TabStop = true;
            this.rdbId.Text = "Id Auto";
            this.rdbId.UseVisualStyleBackColor = true;
            this.rdbId.CheckedChanged += new System.EventHandler(this.rdbId_CheckedChanged);
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(6, 205);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMostrar.Size = new System.Drawing.Size(661, 156);
            this.dgvMostrar.TabIndex = 21;
            this.dgvMostrar.DoubleClick += new System.EventHandler(this.dgvMostrar_DoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnBuscar.Location = new System.Drawing.Point(430, 164);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 29);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // epBuscar
            // 
            this.epBuscar.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(189, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(315, 55);
            this.label13.TabIndex = 54;
            this.label13.Text = "Buscar Auto";
            // 
            // FrmBusquedaAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Imagen2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(673, 370);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.dgvMostrar);
            this.DoubleBuffered = true;
            this.Name = "FrmBusquedaAuto";
            this.Text = "FrmBusquedaAuto";
            this.Load += new System.EventHandler(this.FrmBusquedaAuto_Load);
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbId;
        public System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.ErrorProvider epBuscar;
        private System.Windows.Forms.Label label13;
    }
}