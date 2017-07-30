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
using CapaNegocio.Busqueda;

namespace CapaPresentacion.Busquedas
{
    public partial class FrmBusquedaAuto : Form
    {
        public FrmBusquedaAuto()
        {
            InitializeComponent();
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Enabled = true;
            btnBuscar.Enabled = true;
            MostrarTodoCliente();
            txtBuscar.Clear();
        }

        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Enabled = true;
            btnBuscar.Enabled = true;
            MostrarTodoCliente();
            txtBuscar.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                epBuscar.SetError(txtBuscar, "El campo de busqueda está vacío");
                txtBuscar.Focus();
                return;
            }
            else
            {
                epBuscar.SetError(txtBuscar, "");
            }


            if (rdbId.Checked == true)
            {
                BuscarXCliente(txtBuscar.Text);
            }
            else
            {
                BuscarNombreCliente(Convert.ToInt16(txtBuscar.Text));
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarTodoCliente();
        }

        private void FrmBusquedaAuto_Load(object sender, EventArgs e)
        {
            txtBuscar.Enabled = false;
            MostrarTodoCliente();
        }
        private void BuscarXCliente(String Codigo)
        {
            CNBusquedaAuto buscarC = new CNBusquedaAuto();
            CEAuto objCliente = new CEAuto();
            objCliente.IdAutomovil = Codigo;
            dgvMostrar.DataSource = buscarC.BuscarPorCodigo(objCliente).Tables["MostrarXCodigo"];
        }

        private void BuscarNombreCliente(int Nombre)
        {
            CNBusquedaAuto buscarC = new CNBusquedaAuto();
            CEAuto objCliente = new CEAuto();
            objCliente.Anio = Nombre;
            dgvMostrar.DataSource = buscarC.BuscarPorNombre(objCliente).Tables["MostrarXNombre"];
        }
        private void MostrarTodoCliente()
        {
            CNBusquedaAuto buscarC = new CNBusquedaAuto();
            dgvMostrar.DataSource = buscarC.MostrarAuto().Tables["MostrarTodoCliente"];
        }
    }
}
