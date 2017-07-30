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
    public partial class FrmBusquedaCliente : Form
    {
        public FrmBusquedaCliente()
        {
            InitializeComponent();
        }

        private void BusquedaCliente_Load(object sender, EventArgs e)
        {
            txtBuscar.Enabled = false;
            MostrarTodoCliente();
        }


        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Enabled = true;
            btnBuscar.Enabled = true;
            MostrarTodoCliente();
            txtBuscar.Clear();
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Enabled = true;
            btnBuscar.Enabled = true;
            MostrarTodoCliente();
            txtBuscar.Clear();
        }
        private void BuscarXCliente(String Codigo)
        {
            CNBusquedaCliente buscarC = new CNBusquedaCliente();
            CECliente objCliente = new CECliente();
            objCliente.IdCliente = Codigo;
            dgvMostrar.DataSource = buscarC.BuscarPorCodigo(objCliente).Tables["MostrarXCodigo"];
        }

        private void BuscarNombreCliente(String Nombre)
        {
            CNBusquedaCliente buscarC = new CNBusquedaCliente();
            CECliente objCliente = new CECliente();
            objCliente.Nombre = Nombre;
            dgvMostrar.DataSource = buscarC.BuscarPorNombre(objCliente).Tables["MostrarXNombre"];
        }

        private void MostrarTodoCliente()
        {
            CNBusquedaCliente buscarC = new CNBusquedaCliente();
            dgvMostrar.DataSource = buscarC.MostrarClientes().Tables["MostrarTodoCliente"];
            //this.dgvMostrar.Columns["CodUsuario"].Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarTodoCliente();
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
                BuscarNombreCliente(txtBuscar.Text);
            }
        }
    }
}
