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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModelo));
            this.chkLista = new System.Windows.Forms.CheckBox();
            this.grpModelo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.txtIdModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMarca = new System.Windows.Forms.Button();
            this.grpModelo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkLista
            // 
            this.chkLista.AutoSize = true;
            this.chkLista.Location = new System.Drawing.Point(246, 134);
            this.chkLista.Name = "chkLista";
            this.chkLista.Size = new System.Drawing.Size(67, 17);
            this.chkLista.TabIndex = 36;
            this.chkLista.Text = "Ver Lista";
            this.chkLista.UseVisualStyleBackColor = true;
            // 
            // grpModelo
            // 
            this.grpModelo.Controls.Add(this.btnMarca);
            this.grpModelo.Controls.Add(this.label3);
            this.grpModelo.Controls.Add(this.label1);
            this.grpModelo.Controls.Add(this.txtIdModelo);
            this.grpModelo.Controls.Add(this.label2);
            this.grpModelo.Controls.Add(this.txtIdMarca);
            this.grpModelo.Controls.Add(this.txtModelo);
            this.grpModelo.Location = new System.Drawing.Point(12, 12);
            this.grpModelo.Name = "grpModelo";
            this.grpModelo.Size = new System.Drawing.Size(279, 129);
            this.grpModelo.TabIndex = 35;
            this.grpModelo.TabStop = false;
            this.grpModelo.Text = "Datos Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdMarca:";
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
            // txtIdMarca
            // 
            this.txtIdMarca.Location = new System.Drawing.Point(74, 71);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(61, 20);
            this.txtIdMarca.TabIndex = 1;
            this.txtIdMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(74, 45);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(113, 20);
            this.txtModelo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(279, 93);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnCancelar.Location = new System.Drawing.Point(331, 126);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 29);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnModificar.Location = new System.Drawing.Point(331, 91);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 29);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGuardar.Location = new System.Drawing.Point(331, 56);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 29);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnNuevo.Location = new System.Drawing.Point(331, 21);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 29);
            this.btnNuevo.TabIndex = 34;
            this.btnNuevo.Text = "Nuevo";
            // 
            // txtIdModelo
            // 
            this.txtIdModelo.Location = new System.Drawing.Point(74, 19);
            this.txtIdModelo.Name = "txtIdModelo";
            this.txtIdModelo.Size = new System.Drawing.Size(61, 20);
            this.txtIdModelo.TabIndex = 1;
            this.txtIdModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // btnMarca
            // 
            this.btnMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMarca.BackgroundImage")));
            this.btnMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarca.FlatAppearance.BorderSize = 0;
            this.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarca.Location = new System.Drawing.Point(140, 72);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(25, 20);
            this.btnMarca.TabIndex = 13;
            this.btnMarca.UseVisualStyleBackColor = true;
            // 
            // FrmModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 261);
            this.Controls.Add(this.chkLista);
            this.Controls.Add(this.grpModelo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmModelo";
            this.Text = "Modelo";
            this.grpModelo.ResumeLayout(false);
            this.grpModelo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkLista;
        private System.Windows.Forms.GroupBox grpModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdModelo;
        private System.Windows.Forms.Button btnMarca;
    }
}