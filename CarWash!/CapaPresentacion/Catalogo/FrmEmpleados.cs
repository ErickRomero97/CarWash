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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false, true, false, true, true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarBotones(true, false, false, false, false);
        }

        private void chkLista_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLista.Checked == true)
            {
                Height = 576;
            }
            else
            {
                Height = 344;
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mtbIdEmpleado.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellidos.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            mtbTelefono.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtCorreoElectronico.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            cboSexo.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtDireccion.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
            HabilitarBotones(false, false, true, true, true);
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            CargarEmpleado();
            CargarComboSexo();
            HabilitarBotones(true, false, false, false, false);
            cboSexo.SelectedIndex = -1;
        }

        public void CargarEmpleado()
        {
            CNEmpleado objEmpleado = new CNEmpleado();
            dgvEmpleados.DataSource = objEmpleado.ListarEmpleados().Tables["Empleados"];
        }

        public void CargarComboSexo()
        {
            CNEmpleado objEmleado = new CNEmpleado();
            cboSexo.DataSource = objEmleado.ListarSexo().Tables["Sexo"];
            cboSexo.DisplayMember = "Sexo";
            cboSexo.ValueMember = "IdSexo";
        }

        public void Limpiar()
        {
            mtbIdEmpleado.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            mtbTelefono.Clear();
            txtCorreoElectronico.Clear();
            cboSexo.SelectedIndex = -1;
            txtDireccion.Clear();
        }

        public void HabilitarBotones(bool insertar, bool guardar, bool actualizar, bool cancelar, bool groupbox)
        {
            btnNuevo.Enabled = insertar;
            btnGuardar.Enabled = guardar;
            btnModificar.Enabled = actualizar;
            btnCancelar.Enabled = cancelar;
            gbDatos.Enabled = groupbox;
        }


        public void InsertarEmpleado()
        {
            CNEmpleado objEmpleado = new CNEmpleado();
            CEEmpleado objInsertEmpleado = new CEEmpleado();

            objInsertEmpleado.IdEmpleado = mtbIdEmpleado.Text;
            objInsertEmpleado.Nombres = txtNombre.Text;
            objInsertEmpleado.Apellidos = txtApellidos.Text;
            objInsertEmpleado.Telefono = mtbTelefono.Text;
            objInsertEmpleado.Correo = txtCorreoElectronico.Text;
            objInsertEmpleado.IdSexo = Convert.ToInt32(cboSexo.SelectedValue);
            objInsertEmpleado.Direccion = txtDireccion.Text;


            if (objEmpleado.NuevoEmpleado(objInsertEmpleado) > 0)
            {
                MessageBox.Show("Empleado registrado satisfactoriamente", "CarWash", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al registrar Empleado", "CarWash", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void ModificarEmpleado()
        {
            CNEmpleado objEmpleado = new CNEmpleado();
            CEEmpleado objModiEmpleado = new CEEmpleado();

            objModiEmpleado.IdEmpleado = mtbIdEmpleado.Text;
            objModiEmpleado.Nombres = txtNombre.Text;
            objModiEmpleado.Apellidos = txtApellidos.Text;
            objModiEmpleado.Telefono = mtbTelefono.Text;
            objModiEmpleado.Correo = txtCorreoElectronico.Text;
            objModiEmpleado.IdSexo = Convert.ToInt32(cboSexo.SelectedValue);
            objModiEmpleado.Direccion = txtDireccion.Text;

            if (objEmpleado.ModificarEmpleado(objModiEmpleado) > 0)
            {
                MessageBox.Show("Empleado actualizado satisfactoriamente", "CarWash", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empleado actualizado satisfactoriamente", "CarWash", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            HabilitarBotones(false, true, false, true, true);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            CNEmpleado objEmpleado = new CNEmpleado();
            CEEmpleado objDatos = new CEEmpleado();
            objDatos.IdEmpleado = mtbIdEmpleado.Text;

            if (objEmpleado.ExisteEmpleado(objDatos))
            {
                MessageBox.Show("Este Empleado ya Existe");
            }
            else
            {
                if (mtbIdEmpleado.MaskFull == false)
                {
                    epValidar.SetError(mtbIdEmpleado, "Ingrese Id del empleado");
                    mtbIdEmpleado.Focus();
                    return;
                }
                else
                {
                    epValidar.SetError(mtbIdEmpleado, "");
                }

                if (txtNombre.Text == "")
                {
                    epValidar.SetError(txtNombre, "Ingrese el nombre del empleado");
                    txtNombre.Focus();
                    return;
                }
                else
                {
                    epValidar.SetError(txtNombre, "");
                }

                if (txtApellidos.Text == "")
                {
                    epValidar.SetError(txtApellidos, "Ingrese el apellido del empleado");
                    txtApellidos.Focus();
                    return;
                }
                else
                {
                    epValidar.SetError(txtApellidos, "");
                }

                if (mtbTelefono.MaskFull == false)
                {
                    epValidar.SetError(mtbTelefono, "Ingrese el teléfono del empleado");
                    mtbTelefono.Focus();
                    return;
                }
                else
                {
                    epValidar.SetError(mtbTelefono, "");
                }

                if (txtCorreoElectronico.Text == "")
                {
                    epValidar.SetError(txtCorreoElectronico, "Ingrese el correo del empleado");
                    txtCorreoElectronico.Focus();
                    return;
                }
                else
                {
                    epValidar.SetError(txtCorreoElectronico, "");
                }

                if (txtDireccion.Text == "")
                {
                    epValidar.SetError(txtDireccion, "Ingrese la dirección del empleado");
                    txtDireccion.Focus();
                    return;
                }
                else
                {
                    epValidar.SetError(txtDireccion, "");
                }
                InsertarEmpleado();
                CargarEmpleado();
                Limpiar();
                HabilitarBotones(true, false, false, false, false);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarBotones(true, false, false, false, false);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (mtbIdEmpleado.MaskFull == false)
            {
                epValidar.SetError(mtbIdEmpleado, "Ingrese Id del empleado");
                mtbIdEmpleado.Focus();
                return;
            }
            else
            {
                epValidar.SetError(mtbIdEmpleado, "");
            }

            if (txtNombre.Text == "")
            {
                epValidar.SetError(txtNombre, "Ingrese el nombre del empleado");
                txtNombre.Focus();
                return;
            }
            else
            {
                epValidar.SetError(txtNombre, "");
            }

            if (txtApellidos.Text == "")
            {
                epValidar.SetError(txtApellidos, "Ingrese el apellido del empleado");
                txtApellidos.Focus();
                return;
            }
            else
            {
                epValidar.SetError(txtApellidos, "");
            }

            if (mtbTelefono.MaskFull == false)
            {
                epValidar.SetError(mtbTelefono, "Ingrese el teléfono del empleado");
                mtbTelefono.Focus();
                return;
            }
            else
            {
                epValidar.SetError(mtbTelefono, "");
            }

            if (txtCorreoElectronico.Text == "")
            {
                epValidar.SetError(txtCorreoElectronico, "Ingrese el correo del empleado");
                txtCorreoElectronico.Focus();
                return;
            }
            else
            {
                epValidar.SetError(txtCorreoElectronico, "");
            }

            if (txtDireccion.Text == "")
            {
                epValidar.SetError(txtDireccion, "Ingrese la dirección del empleado");
                txtDireccion.Focus();
                return;
            }
            else
            {
                epValidar.SetError(txtDireccion, "");
            }
            ModificarEmpleado();
            CargarEmpleado();
            Limpiar();
            HabilitarBotones(true, false, false, false, false);
        }
    }
}
