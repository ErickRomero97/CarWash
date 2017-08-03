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
    public partial class FrmBusquedaServicio : Form
    {
        public FrmBusquedaServicio()
        {
            InitializeComponent();
        }

        private void FrmBusquedaServicio_Load(object sender, EventArgs e)
        {
            txtBuscar.Enabled = false;
            MostrarTodoServicio();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            MostrarTodoServicio();
        }

       
        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Enabled = true;
            btnBuscar.Enabled = true;
            MostrarTodoServicio();
            txtBuscar.Clear();
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscar.Enabled = true;
            btnBuscar.Enabled = true;
            MostrarTodoServicio();
            txtBuscar.Clear();
        }
        private void BuscarServicio(int Codigo)
        {
            CNBusquedaServicio buscarC = new CNBusquedaServicio();
            CEServicio objSer = new CEServicio();
            objSer.IdServicio = Codigo;
            dgvSer.DataSource = buscarC.BuscarPorCodigo(objSer).Tables["MostrarXServicio"];
        }

        private void BuscarNombreCliente(String Nombre)
        {
            CNBusquedaServicio buscarC = new CNBusquedaServicio();
            CEServicio objSer = new CEServicio();
            objSer.Servicio = Nombre;
            dgvSer.DataSource = buscarC.BuscarPorNombre(objSer).Tables["MostrarXNombre"];
        }

        private void MostrarTodoServicio()
        {
            CNBusquedaServicio buscarC = new CNBusquedaServicio();
            dgvSer.DataSource = buscarC.MostrarServicio().Tables["MostrarTodoCliente"];
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
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
                BuscarServicio(Convert.ToInt32(txtBuscar.Text));
            }
            else
            {
                BuscarNombreCliente(txtBuscar.Text);
            }
        }

        private void dgvSer_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
