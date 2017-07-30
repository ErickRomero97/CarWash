namespace CapaPresentacion
{
    partial class FrmPrincipal
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIdUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNombreUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTipoUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslIdUsuario,
            this.tsslNombreUsuario,
            this.tsslTipoUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel1.Text = "IdUsuario:";
            // 
            // tsslIdUsuario
            // 
            this.tsslIdUsuario.Name = "tsslIdUsuario";
            this.tsslIdUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslNombreUsuario
            // 
            this.tsslNombreUsuario.Name = "tsslNombreUsuario";
            this.tsslNombreUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslTipoUsuario
            // 
            this.tsslTipoUsuario.Name = "tsslTipoUsuario";
            this.tsslTipoUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel tsslIdUsuario;
        public System.Windows.Forms.ToolStripStatusLabel tsslNombreUsuario;
        public System.Windows.Forms.ToolStripStatusLabel tsslTipoUsuario;
    }
}