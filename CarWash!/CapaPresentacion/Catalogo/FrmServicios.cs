using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FrmServicios : Form
    {
        public FrmServicios()
        {
            InitializeComponent();
        }
        public int idUsuarioActual;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            gbDatos.Enabled = true;
            HabilitarBotones(false, true, true, false, true);
            chkLista.Enabled = false;
            chkLista.Checked = false;
            investigarCorrelativo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            chkLista.Checked = false;
            chkLista.Enabled = true;
            HabilitarBotones(true, false, false, false, false);
        }

        private void chkLista_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLista.CheckState == CheckState.Checked)
            {
                Height = 499;
                CenterToScreen();
            }
            else
            {
                Height = 329;
                CenterToScreen();
            }

        }

        private void FrmServicios_Load(object sender, EventArgs e)
        {
            CargarServicio();
            HabilitarBotones(true, false, false, false, false);
        }
        #region InsertUpdateDelete

        private void InsertarServicio()
        {
            CNServicio inserP = new CNServicio();
            CEServicio objSer = new CEServicio();
            objSer.Servicio = txtNS.Text;
            objSer.Precio = Convert.ToDecimal(txtPrecio.Text);
            objSer.Descripcion = txtDesc.Text;
            objSer.IdUsuario = 10;
            if (inserP.NuevoServicio(objSer) > 0)
            {
                MessageBox.Show(null, "Se ingreso un nuevo registro de Servicio", "CarWash System", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(null, "Error al guardar un nuevo registro de Servicio.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarServicio()
        {
            CNServicio inserP = new CNServicio();
            CEServicio objSer = new CEServicio();
            objSer.IdServicio = Convert.ToInt32(txtIdSer.Text);
            objSer.Servicio = txtNS.Text;
            objSer.Precio = Convert.ToDecimal(txtPrecio.Text);
            objSer.Descripcion = txtDesc.Text;
            objSer.IdUsuario = 10;
            if (inserP.ActualizarServicio(objSer) > 0)
            {
                MessageBox.Show(null, "Se Actualizo el registro de Servicio", "CarWash System", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(null, "Error al actualizar el registro de Servicio.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarServicio(int Cod)
        {
          

            CNServicio deleteP = new CNServicio();
            CEServicio objP = new CEServicio();
            objP.IdServicio = Cod;
        
            if (deleteP.EliminarServicio(objP) > 0)
            {
                MessageBox.Show(null, "Se elimino un registro de Servicio", "CarWash System", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(null, "Error al eliminar un registro de Servicio.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Botones

        private void HabilitarBotones(bool nuevo, bool guardar, bool cancelar, bool modificar, bool datos)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
            btnModificar.Enabled = modificar;
            gbDatos.Enabled = datos;
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void CargarServicio()
        {
            CNServicio objP = new CNServicio();
            dgvServicios.DataSource = objP.ListadoServicio().Tables["ListadoServicio"];
            this.dgvServicios.Columns["IdUsuario"].Visible = false;
        }

        private void investigarCorrelativo()
        {
            CNServicio correlativo = new CNServicio();
            txtIdSer.Text = Convert.ToString(correlativo.InvestigarCorrelativo());
        }

        private void fila()
        {
            txtIdSer.Text = dgvServicios.CurrentRow.Cells[0].Value.ToString();
            txtNS.Text = dgvServicios.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvServicios.CurrentRow.Cells[2].Value.ToString();
            txtDesc.Text = dgvServicios.CurrentRow.Cells[3].Value.ToString();
        }

       

        private void Limpiar()
        {
            txtIdSer.Text = "";
            txtNS.Text = "";
            txtPrecio.Text = "";
            txtDesc.Text = "";
        }

        private void editarMenuItem_Click(object sender, EventArgs e)
        {
            fila();
            gbDatos.Enabled = true;
            HabilitarBotones(false, false, true,  true, true);
        }

        private void eliminarMenuItem_Click(object sender, EventArgs e)
        {

            int Cod = Convert.ToInt32(dgvServicios.CurrentRow.Cells[0].Value.ToString());
            EliminarServicio(Cod);
            CargarServicio();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            gbDatos.Enabled = true;
            HabilitarBotones(false, true, true, false, true);
            chkLista.Enabled = false;
            chkLista.Checked = false;
            investigarCorrelativo();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            #region Validacion
            if (txtNS.Text == "")
            {
                epSer.SetError(txtNS, "Ingrese el nombre del Servicio");
                txtNS.Focus();
                return;
            }
            else
            {
                epSer.SetError(txtNS, "");
            }

            if (txtPrecio.Text == "")
            {
                epSer.SetError(txtPrecio, "Ingrese el  precio del servicio");
                txtPrecio.Focus();
                return;
            }
            else
            {
                epSer.SetError(txtPrecio, "");
            }

            if (txtDesc.Text == "")
            {
                epSer.SetError(txtDesc, "Ingrese la descripcion del servicio");
                txtDesc.Focus();
                return;
            }
            else
            {
                epSer.SetError(txtDesc, "");
            }


            #endregion

            InsertarServicio();
            CargarServicio();
            HabilitarBotones(true, false, false, false, false);
            chkLista.Enabled = true;
            chkLista.Checked = false;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            #region Validacion
            if (txtNS.Text == "")
            {
                epSer.SetError(txtNS, "Ingrese el nombre del Servicio");
                txtNS.Focus();
                return;
            }
            else
            {
                epSer.SetError(txtNS, "");
            }

            if (txtPrecio.Text == "")
            {
                epSer.SetError(txtPrecio, "Ingrese el  precio del servicio");
                txtPrecio.Focus();
                return;
            }
            else
            {
                epSer.SetError(txtPrecio, "");
            }

            if (txtDesc.Text == "")
            {
                epSer.SetError(txtDesc, "Ingrese la descripcion del servicio");
                txtDesc.Focus();
                return;
            }
            else
            {
                epSer.SetError(txtDesc, "");
            }


            #endregion
            ActualizarServicio();
            CargarServicio();
            Limpiar();
            HabilitarBotones(true, false, false, false, false);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            chkLista.Checked = false;
            chkLista.Enabled = true;
            HabilitarBotones(true, false, false, false, false);
        }
    }
}
