namespace CapaPresentacion
{
    partial class FrmBusquedaServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaServicio));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbId = new System.Windows.Forms.RadioButton();
            this.dgvSer = new System.Windows.Forms.DataGridView();
            this.epBuscar = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(242, 147);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(229, 20);
            this.txtBuscar.TabIndex = 19;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(242, 147);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(229, 20);
            this.txtIdEmpleado.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdbNombre);
            this.groupBox1.Controls.Add(this.rdbId);
            this.groupBox1.Location = new System.Drawing.Point(252, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 39);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(167, 16);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(103, 17);
            this.rdbNombre.TabIndex = 1;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre Servicio";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // rdbId
            // 
            this.rdbId.AutoSize = true;
            this.rdbId.Location = new System.Drawing.Point(21, 16);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(75, 17);
            this.rdbId.TabIndex = 0;
            this.rdbId.TabStop = true;
            this.rdbId.Text = "Id Servicio";
            this.rdbId.UseVisualStyleBackColor = true;
            this.rdbId.CheckedChanged += new System.EventHandler(this.rdbId_CheckedChanged);
            // 
            // dgvSer
            // 
            this.dgvSer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSer.Location = new System.Drawing.Point(53, 182);
            this.dgvSer.Name = "dgvSer";
            this.dgvSer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSer.Size = new System.Drawing.Size(661, 172);
            this.dgvSer.TabIndex = 15;
            this.dgvSer.DoubleClick += new System.EventHandler(this.dgvSer_DoubleClick);
            // 
            // epBuscar
            // 
            this.epBuscar.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnBuscar.Location = new System.Drawing.Point(477, 141);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 29);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(163, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(465, 55);
            this.label13.TabIndex = 54;
            this.label13.Text = "Busqueda Servicio";
            // 
            // FrmBusquedaServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.Imagen2;
            this.ClientSize = new System.Drawing.Size(766, 359);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSer);
            this.Name = "FrmBusquedaServicio";
            this.Text = "FrmBusquedaServicio";
            this.Load += new System.EventHandler(this.FrmBusquedaServicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbId;
        public System.Windows.Forms.DataGridView dgvSer;
        private System.Windows.Forms.ErrorProvider epBuscar;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private System.Windows.Forms.Label label13;
    }
}