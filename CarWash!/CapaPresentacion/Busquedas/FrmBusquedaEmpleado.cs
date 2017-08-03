using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class FrmBusquedaEmpleado : Form
    {
        public FrmBusquedaEmpleado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEmpleadoId(txtIdEmpleado.Text);
        }

        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            txtIdEmpleado.Visible = true;
            txtNombre.Visible = false;
            btnBuscar.Enabled = true;
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtIdEmpleado.Visible = false;
            txtNombre.Visible = true;
            btnBuscar.Enabled = false;
        }

        private void FrmBusquedaEmpleado_Load(object sender, EventArgs e)
        {
            CargarEmpleado();
        }
        public void CargarEmpleado()
        {
            CNEmpleado objEmpleado = new CNEmpleado();
            dgvEmpleado.DataSource = objEmpleado.ListarEmpleados1().Tables["Empleados"];
        }
        public void BuscarEmpleadoId(string Id)
        {
            CNEmpleado objEmpleado = new CNEmpleado();
            CEEmpleado objE = new CEEmpleado();
            objE.IdEmpleado = Id;
            dgvEmpleado.DataSource = objEmpleado.BuscarEmpleadoId(objE).Tables["BuscarId"];
        }

        public void BuscarEmpleadoNombre(string nombre)
        {
            CNEmpleado objEmpleado = new CNEmpleado();
            CEEmpleado objE = new CEEmpleado();
            objE.Nombres = nombre;
            dgvEmpleado.DataSource = objEmpleado.BuscarEmpleadoNombre(objE).Tables["BuscarNombre"];
        }

       

        private void dgvEmpleado_DoubleClick(object sender, EventArgs e)
        {
            FrmUsuarios.idEmpleado = dgvEmpleado.SelectedRows[0].Cells[0].Value.ToString();
            FrmUsuarios.nombre = dgvEmpleado.SelectedRows[0].Cells[1].Value.ToString();
            Hide();
        }

        private void txtIdEmpleado_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            BuscarEmpleadoNombre(txtNombre.Text);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            BuscarEmpleadoId(txtIdEmpleado.Text);
        }

        private void dgvEmpleado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
