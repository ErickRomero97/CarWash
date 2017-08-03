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
    public partial class FrmBusquedaModelo : Form
    {
        public FrmBusquedaModelo()
        {
            InitializeComponent();
        }

        private void FrmBusquedaModelo_Load(object sender, EventArgs e)
        {
            txtBuscar.Enabled = false;
            MostrarTodoServicio();
        }
        private void BuscarServicio(int Codigo)
        {
            CNBusquedaModelo buscarC = new CNBusquedaModelo();
            CEModelo objSer = new CEModelo();
            objSer.IdModelo = Codigo;
            dgvSer.DataSource = buscarC.BuscarPorCodigo(objSer).Tables["MostrarId"];
        }

        private void BuscarNombreCliente(String Nombre)
        {
            CNBusquedaModelo buscarC = new CNBusquedaModelo();
            CEModelo objSer = new CEModelo();
            objSer.Modelo = Nombre;
            dgvSer.DataSource = buscarC.BuscarPorNombre(objSer).Tables["MostrarNombre"];
        }

        private void MostrarTodoServicio()
        {
            CNBusquedaModelo buscarC = new CNBusquedaModelo();
            dgvSer.DataSource = buscarC.MostrarServicio().Tables["MostrarTodo"];
        }

        private void rdbNombre_CheckedChanged_1(object sender, EventArgs e)
        {
            txtBuscar.Enabled = true;
            btnBuscar.Enabled = true;
            MostrarTodoServicio();
            txtBuscar.Clear();
        }

        private void rdbId_CheckedChanged_1(object sender, EventArgs e)
        {
            txtBuscar.Enabled = true;
            btnBuscar.Enabled = true;
            MostrarTodoServicio();
            txtBuscar.Clear();
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

        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            MostrarTodoServicio();
        }
    }
}
