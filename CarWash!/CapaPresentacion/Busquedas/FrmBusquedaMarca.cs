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

namespace CapaPresentacion.Busquedas
{
    public partial class FrmBusquedaMarca : Form
    {
        public FrmBusquedaMarca()
        {
            InitializeComponent();
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
                BuscarServicio(Convert.ToInt32(txtBuscar.Text));
            }
            else
            {
                BuscarNombreCliente(txtBuscar.Text);
            }
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarTodoServicio();
        }

        private void FrmBusquedaMarca_Load(object sender, EventArgs e)
        {
            txtBuscar.Enabled = false;
            MostrarTodoServicio();
        }
        private void BuscarServicio(int Codigo)
        {
            CNBusquedaMarca buscarC = new CNBusquedaMarca();
            CEMarca objSer = new CEMarca();
            objSer.IdMarca = Codigo;
            dgvSer.DataSource = buscarC.BuscarPorCodigo(objSer).Tables["MostrarId"];
        }

        private void BuscarNombreCliente(String Nombre)
        {
            CNBusquedaMarca buscarC = new CNBusquedaMarca();
            CEMarca objSer = new CEMarca();
            objSer.Marca = Nombre;
            dgvSer.DataSource = buscarC.BuscarPorNombre(objSer).Tables["MostrarNombreMarca"];
        }

        private void MostrarTodoServicio()
        {
            CNBusquedaMarca buscarC = new CNBusquedaMarca();
            dgvSer.DataSource = buscarC.MostrarServicio().Tables["MostrarTodoMarca"];
        }

    }
}
