using CapaPresentacion.Busquedas;
using CapaPresentacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        public static int id;

        private void button7_Click(object sender, EventArgs e)
        {
            FrmServicios MiMarca = new FrmServicios();
            MiMarca.Show();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAutomoviles MiAuto = new FrmAutomoviles();
            MiAuto.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmClientes MiCliente = new FrmClientes();
            MiCliente.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpledos_Click(object sender, EventArgs e)
        {
            FrmEmpleados MiEmpleados = new FrmEmpleados();
            MiEmpleados.Show();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            FrmMarca MiMarca = new FrmMarca();
            MiMarca.Show();
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            FrmModelo MiModelo = new FrmModelo();
            MiModelo.Show();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            FrmFactura MiFactura = new FrmFactura();
            MiFactura.Show();
        }

        private void automovilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAutomoviles MiAuto = new FrmAutomoviles();
            MiAuto.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes MiCliente = new FrmClientes();
            MiCliente.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleados MiEmpleados = new FrmEmpleados();
            MiEmpleados.Show();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca MiMarca = new FrmMarca();
            MiMarca.Show();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModelo MiModelo = new FrmModelo();
            MiModelo.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios MiUsuario = new FrmUsuarios();
            MiUsuario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBusquedaCliente MiBusquedaCliente = new FrmBusquedaCliente();
            MiBusquedaCliente.Show();
        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaAuto MiBusquedaAuto = new FrmBusquedaAuto();
            MiBusquedaAuto.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaEmpleado MiBusquedaEmpleado = new FrmBusquedaEmpleado();
            MiBusquedaEmpleado.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaFactura MiBusquedaFactura = new FrmBusquedaFactura();
            MiBusquedaFactura.Show();
        }

        private void marcaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBusquedaMarca MiBusquedaMarca = new FrmBusquedaMarca();
            MiBusquedaMarca.Show();
        }

        private void modeloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmBusquedaModelo MiBusquedaModelo = new FrmBusquedaModelo();
            MiBusquedaModelo.Show();
        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaServicio MiBusquedaServicio = new FrmBusquedaServicio();
            MiBusquedaServicio.Show();
        }

        private void logAuditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogAuditoria MiLog = new FrmLogAuditoria();
            MiLog.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
