namespace CapaPresentacion
{
    partial class FrmBusquedaEmpleado
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbId = new System.Windows.Forms.RadioButton();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(244, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 20);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(493, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(244, 79);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(229, 20);
            this.txtIdEmpleado.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNombre);
            this.groupBox1.Controls.Add(this.rdbId);
            this.groupBox1.Location = new System.Drawing.Point(254, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 39);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(167, 16);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(62, 17);
            this.rdbNombre.TabIndex = 1;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
            // 
            // rdbId
            // 
            this.rdbId.AutoSize = true;
            this.rdbId.Location = new System.Drawing.Point(21, 16);
            this.rdbId.Name = "rdbId";
            this.rdbId.Size = new System.Drawing.Size(84, 17);
            this.rdbId.TabIndex = 0;
            this.rdbId.TabStop = true;
            this.rdbId.Text = "Id Empleado";
            this.rdbId.UseVisualStyleBackColor = true;
            this.rdbId.CheckedChanged += new System.EventHandler(this.rdbId_CheckedChanged);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(55, 114);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleado.Size = new System.Drawing.Size(661, 227);
            this.dgvEmpleado.TabIndex = 10;
            // 
            // FrmBusquedaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 373);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvEmpleado);
            this.Name = "FrmBusquedaEmpleado";
            this.Text = "FrmBusquedaEmpleado";
            this.Load += new System.EventHandler(this.FrmBusquedaEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbId;
        public System.Windows.Forms.DataGridView dgvEmpleado;
    }
}