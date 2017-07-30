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
    public partial class FrmBusquedaFactura : Form
    {
        public FrmBusquedaFactura()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rdbFecha.Checked == true)
            {
                BuscarXFecha(dtpFactura.Value);
            }
            if (rdbId.Checked == true)
            {
                if (txtBuscar.Text == "")
                {
                    MostrarTodoFactura();
                }
                else
                {
                    BuscarXFactura(Convert.ToInt32(txtBuscar.Text));
                }
            }
        }

        private void rdbId_CheckedChanged(object sender, EventArgs e)
        {
            dtpFactura.Enabled = false;
            txtBuscar.Visible = true;
            txtBuscar.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarTodoFactura();
        }

        private void FrmBusquedaFactura_Load(object sender, EventArgs e)
        {
            MostrarTodoFactura();
        }
        private void BuscarXFactura(Int32 Codigo)
        {
            CNBusquedaFactura buscarF = new CNBusquedaFactura();
            CEFactura objFactura = new CEFactura();
            objFactura.IdFactura = Codigo;
            dgvMostrar.DataSource = buscarF.BuscarPorCodigo(objFactura).Tables["MostrarXCodigo"];
        }

        private void BuscarXFecha(DateTime Fecha)
        {
            CNBusquedaFactura buscarF = new CNBusquedaFactura();
            CEFactura objFactura = new CEFactura();
            objFactura.Fecha = Fecha;
            dgvMostrar.DataSource = buscarF.BuscarPorFEcha(objFactura).Tables["MostrarXFecha"];
        }

        private void MostrarTodoFactura()
        {
            CNBusquedaFactura buscarF =new CNBusquedaFactura();
            dgvMostrar.DataSource = buscarF.MostrarFactura().Tables["MostrarTodoFactura"];
        }

        private void rdbFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpFactura.Enabled = true;
            txtBuscar.Enabled = false;
            btnBuscar.Enabled = true;
        }
    }
}
