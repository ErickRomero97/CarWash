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
using CapaPresentacion;
using CapaEntidades;
using CapaDatos;

namespace CapaPresentacion
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
          
            HabilitarBotones(true, false, true, false, false);
            CargarComboSexo();
            cboSexo.SelectedIndex = -1;
            CargarCliente();
            
        }
        #region insertUpdateDelete

        private void InsertarCliente()
        {
            CNCliente insertC = new CNCliente();
            CECliente objCliente = new CECliente();
            objCliente.IdCliente = mtbIdCliente.Text;
            objCliente.Nombre = txtNombre.Text;
            objCliente.Apellidos = txtApellidos.Text;
            objCliente.FechaNac = dtpFechaNac.Value;
            objCliente.Direccion = txtDireccion.Text;
            objCliente.IdSexo = Convert.ToInt32(cboSexo.SelectedValue);
  
            if(insertC.NuevoCliente(objCliente) > 0)
            {
                MessageBox.Show(null, "Se Guardo bien el nuevo registro de Cliente", "CarWash System", MessageBoxButtons.OK);
            }else
            {
                MessageBox.Show(null, "Error al guardar un nuevo registro de cliente.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ActuralizarUsuario()
        {
            CNCliente actualizarC = new CNCliente();
            CECliente objCliente = new CECliente();
            objCliente.IdCliente = mtbIdCliente.Text;
            objCliente.Nombre = txtNombre.Text;
            objCliente.Apellidos = txtApellidos.Text;
            objCliente.FechaNac = dtpFechaNac.Value;
            objCliente.Direccion = txtDireccion.Text;
            objCliente.IdSexo = Convert.ToInt32(cboSexo.SelectedValue);
            
            if(actualizarC.ActualizarCliente(objCliente)>0)
            {
                MessageBox.Show(null, "Se ha Actualizado el Cliente", "CarWash System", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(null, "Error al Actualizar el registro.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EliminarCliente(string IdCliente)
        {
            CNCliente eliminarC = new CNCliente();
            CECliente objCliente = new CECliente();
            objCliente.IdCliente = IdCliente;
            if (eliminarC.EliminarCliente(objCliente) > 0)
            {
                MessageBox.Show(null, "Se ha eliminado el registro del Cliente", "CarWash System", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(null, "Error al eliminar el registro.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region botones

        private void HabilitarBotones(bool nuevo, bool guardar, bool cancelar, bool modificar, bool datos)
        {
            btnNuevo.Enabled = nuevo;
            btnGuardar.Enabled = guardar;
            btnCancelar.Enabled = cancelar;
            btnModificar.Enabled = modificar;
            gbDatos.Enabled = datos;
        }

       

        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FilaSeleccionada();
            gbDatos.Enabled = true;
            HabilitarBotones(false, true, false, true, true);
        }

     
      

        #endregion

        private void CargarCliente()
        {
            CNCliente objC = new CNCliente();
            dgvClientes.DataSource = objC.MostrarTodoCliente().Tables["MostrarTodoCliente"];
        }

        private void FilaSeleccionada()
        {
            mtbIdCliente.Text = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
            txtNombre.Text = dgvClientes.SelectedRows[0].Cells[1].Value.ToString();
            txtApellidos.Text = dgvClientes.SelectedRows[0].Cells[2].Value.ToString();
            dtpFechaNac.Text = dgvClientes.SelectedRows[0].Cells[3].Value.ToString();
            txtDireccion.Text = dgvClientes.SelectedRows[0].Cells[4].Value.ToString();
            cboSexo.Text = dgvClientes.SelectedRows[0].Cells[5].Value.ToString();
            
            HabilitarBotones(true, true, true, true, true);
        }

        private void Limpiar()
        {
            mtbIdCliente.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            chkVer.Enabled = true;
            chkVer.Checked = false;
        }

        private void txtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void CargarComboSexo()
        {
            CNCliente objC = new CNCliente();
            cboSexo.DataSource = objC.ListadoSexo().Tables["Sexo"];
            cboSexo.DisplayMember = "Sexo";
            cboSexo.ValueMember = "IdSexo";

        }
        

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            HabilitarBotones(false, true, true, false, true);
            chkVer.Enabled = false;
            chkVer.Checked = false;
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, false, true, false, false);
            Limpiar();
           
        }
        private void chkVer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVer.Checked == true)
            {
                Height = 550;
                CenterToScreen();

            }
            else
            {
                Height = 310;
                CenterToScreen();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FilaSeleccionada();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string IdCliente = dgvClientes.SelectedRows[0].Cells[0].Value.ToString();
            EliminarCliente(IdCliente);
            CargarCliente();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false, true, true, false, true);
            chkVer.Enabled = false;
            chkVer.Checked = false;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            #region Validacion

            if (mtbIdCliente.MaskFull == false)
            {
                errorProvider1.SetError(mtbIdCliente, "El codigo del cliente es requerido");
                mtbIdCliente.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(mtbIdCliente, "");
            }
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "El nombre del cliente es requerido");
                txtNombre.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "el apellido del cliente es requerido");
                txtApellidos.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellidos, "");
            }
            if (txtDireccion.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "la Direccion del cliente es requerida");
                txtDireccion.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtDireccion, "");
            }
            #endregion

            InsertarCliente();
            CargarCliente();
            Limpiar();
            HabilitarBotones(true, false, true, false, false);
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            #region Validacion

            if (mtbIdCliente.MaskFull == false)
            {
                errorProvider1.SetError(mtbIdCliente, "El codigo del cliente es requerido");
                mtbIdCliente.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(mtbIdCliente, "");
            }
            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "El nombre del cliente es requerido");
                txtNombre.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }

            if (txtApellidos.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "el apellido del cliente es requerido");
                txtApellidos.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtApellidos, "");
            }
            if (txtDireccion.Text == "")
            {
                errorProvider1.SetError(txtApellidos, "la Direccion del cliente es requerida");
                txtDireccion.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtDireccion, "");
            }
            #endregion
            ActuralizarUsuario();
            CargarCliente();
            Limpiar();
            HabilitarBotones(true, false, true, false, false);
            Height = 550;
            CenterToScreen();

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            HabilitarBotones(true, false, true, false, false);
            Limpiar();
        }
    }
}
