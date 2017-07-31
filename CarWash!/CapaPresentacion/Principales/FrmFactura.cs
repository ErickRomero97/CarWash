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
using System.Data.SqlClient;
using CapaDatos;
namespace CapaPresentacion
{
    public partial class FrmFactura : Form
    {
        public int registro = 0;
        public FrmFactura()
        {
            InitializeComponent();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            Busquedas.FrmBusquedaAuto frm = new Busquedas.FrmBusquedaAuto();
            frm.ShowDialog();
            txtIdAutomovil.Text = Convert.ToString(frm.dgvMostrar.CurrentRow.Cells[0].Value);
            txtDescAuto.Text = Convert.ToString(frm.dgvMostrar.CurrentRow.Cells[1].Value);
            txtAnio.Text = Convert.ToString(frm.dgvMostrar.CurrentRow.Cells[2].Value);
            txtIdCliente.Text = Convert.ToString(frm.dgvMostrar.CurrentRow.Cells[4].Value);
            txtNombreCliente.Text = Convert.ToString(frm.dgvMostrar.CurrentRow.Cells[5].Value);
            txtApellidoCliente.Text = Convert.ToString(frm.dgvMostrar.CurrentRow.Cells[6].Value);
            this.Show();
            
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            FrmBusquedaServicio frm = new FrmBusquedaServicio();
            frm.ShowDialog();
            txtIdServicio.Text = Convert.ToString(frm.dgvSer.CurrentRow.Cells[0].Value);
            txtNombreSer.Text = Convert.ToString(frm.dgvSer.CurrentRow.Cells[1].Value);
            txtPrecio.Text = Convert.ToString(frm.dgvSer.CurrentRow.Cells[2].Value);
            this.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false, true, true, true, true);
            InvestigarCorrelativo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CDFactura dato = new CDFactura();

            #region validaciones

            if (txtIdAutomovil.Text == "")
            {
                epFactu.SetError(txtIdAutomovil, "Debe ingresar un Automovil");
                btnAuto.Focus();
                return;
            }
            else
            {
                epFactu.SetError(txtIdAutomovil, "");
            }

            if (dgvFactu.Rows.Count == 0)
            {
                epFactu.SetError(dgvFactu, "No ha ingresado ningun Automovil a lavar");
                btnAgregar.Focus();
                return;
            }
            else
            {
                epFactu.SetError(dgvFactu, "");
            }


            #endregion

            InsertarFactura();
            AgregarDetalle();
            Limpiar();
            LimpiarArticulos();
            HabilitarBotones(true, false, false, false, false);
            dgvFactu.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (registro == 1)
            {
                Limpiar();
                LimpiarArticulos();
                HabilitarBotones(true, false, false, false, false);
                dgvFactu.Rows.Clear();
                registro = 0;
            }
            else
            {
                Limpiar();
                LimpiarArticulos();
                HabilitarBotones(true, false, false, false, false);
                dgvFactu.Rows.Clear();
            }
        }
        private void HabilitarBotones(bool nuevo, bool guardar, bool cancelar, bool datos, bool articulos)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
            gbDatos.Enabled = datos;
            gbArticulos.Enabled = articulos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            #region Validaciones

            if (txtIdAutomovil.Text == "")
            {
                epFactu.SetError(txtIdAutomovil, "Debe ingresar un automovil a lavar.");
                btnAuto.Focus();
                return;
            }
            else
            {
                epFactu.SetError(txtIdAutomovil, "");
            }

            if (txtPrecio.Text == "")
            {
                epFactu.SetError(txtPrecio, "Debe ingresar el precio de los servicios.");
                txtPrecio.Focus();
                return;
            }
            else
            {
                epFactu.SetError(txtPrecio, "");
            }

            #endregion
            dgvFactu.Rows.Add(txtIdFactura.Text,txtIdServicio.Text, txtIdAutomovil.Text, txtIdCliente.Text, txtNombreCliente.Text, txtApellidoCliente.Text, txtPrecio.Text);
            Calculos();
            registro = 1;
            LimpiarArticulos();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false, false, false, false);
        }
        private void InsertarFactura()
        {
            CNFactura inserF = new CNFactura();
            CEFactura objFactura = new CEFactura();
            objFactura.Fecha = dtpFechaFactura.Value;
            objFactura.IdAutomovil = txtIdAutomovil.Text;
            objFactura.IdUsuario = Convert.ToInt16(10);
            if(inserF.NuevaFactura(objFactura)>0)
            {

                MessageBox.Show(null, "Se Guardo el reguistro de la factura", "CarWash System", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(null, "Error al guardar un nuevo registro de la factura.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void AgregarDetalle()
        {

            for (int i = 0; i < dgvFactu.RowCount; i++)
            {
                CNFactura insertDetalle = new CNFactura();
                CEFactura objFactura = new CEFactura();
                objFactura.IdFactura = Convert.ToInt32(dgvFactu.Rows[i].Cells["IdFactura"].Value);
                objFactura.IdServicio = Convert.ToInt32(dgvFactu.Rows[i].Cells["IdServicio"].Value);
                if (insertDetalle.AgregarDetalle(objFactura) > 0)
                {
                    MessageBox.Show(null, "Se Guardo el reguistro del detalle de la factura", "CarWash System", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(null, "Error al guardar un nuevo registro del detalle de la factura.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Calculos()
        {

            decimal subtotal=0;
            decimal isv;
            decimal total;
            for (int i = 0; i < dgvFactu.RowCount; i++) 
            {
                subtotal = subtotal + Convert.ToDecimal(dgvFactu.Rows[i].Cells[6].Value);

            }
            isv = subtotal * Convert.ToDecimal(0.15);
            total = subtotal + isv;

            txtSub.Text = Convert.ToString(subtotal.ToString("C2"));
            txtISV.Text = Convert.ToString(isv.ToString("C2"));
            txtTotal.Text = Convert.ToString(total.ToString("C2"));
        }

        private void Limpiar()
        {
            txtIdFactura.Clear();
            txtSub.Clear();
            txtISV.Clear();
            txtTotal.Clear();
            txtAnio.Clear();
            txtIdCliente.Clear();
            txtDescAuto.Clear();
            txtApellidoCliente.Clear();
            txtNombreCliente.Clear();
        }

        private void LimpiarArticulos()
        { 
            txtIdServicio.Clear();
            txtNombreSer.Clear();
            txtPrecio.Clear();
        }
        private void InvestigarCorrelativo()
        {
            CNFactura correlativo = new CNFactura();
            txtIdFactura.Text = Convert.ToString(correlativo.InvestigarCorrelativo());
        }
    }
}
