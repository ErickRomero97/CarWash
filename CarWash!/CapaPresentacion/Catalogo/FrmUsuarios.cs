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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            CargarComboEstado();
            CargarComboTipoUsuario();
            HabilitarBotones(true, false, false, false, false);
            cboEstado.SelectedIndex = -1;
            cboTipoUsuario.SelectedIndex = -1;
        }
        public void CargarUsuarios()
        {
            CNUsuario objU = new CNUsuario();
            dgvUsuarios.DataSource = objU.ListaUsuarios().Tables["Usuarios"];
        }

        public void CargarComboEstado()
        {
            CNUsuario objU = new CNUsuario();
            cboEstado.DataSource = objU.ListaEstado().Tables["Estado"];
            cboEstado.DisplayMember = "Estado";
            cboEstado.ValueMember = "IdEstado";
        }

        public void CargarComboTipoUsuario()
        {
            CNUsuario objU = new CNUsuario();
            cboTipoUsuario.DataSource = objU.ListaTipoUsuario().Tables["TipoUsuario"];
            cboTipoUsuario.DisplayMember = "Usuario";
            cboTipoUsuario.ValueMember = "IdTipoUsuario";
        }

        public void HabilitarBotones(bool insertar, bool guardar, bool actualizar, bool cancelar, bool groupbox)
        {
            btnNuevo.Enabled = insertar;
            btnGuardar.Enabled = guardar;
            btnModificar.Enabled = actualizar;
            btnCancelar.Enabled = cancelar;
            gbDatos.Enabled = groupbox;
        }

        public void Limpiar()
        {
            txtIdUsuario.Clear();
            txtNombreUsuario.Clear();
            txtContraseña.Clear();
            cboEstado.SelectedValue = -1;
            mtbIdEmpleado.Clear();
            txtNombreEmpleado.Clear();
            cboTipoUsuario.SelectedValue = -1;
        }

        public void Validar()
        {
            if (txtNombreUsuario.Text == "")
            {
                epValidar.SetError(txtNombreUsuario, "Ingrese el nombre de usuario");
                txtNombreUsuario.Focus();
                return;
            }
            else
            {
                epValidar.SetError(txtNombreUsuario, "");
            }

            if (txtContraseña.Text == "")
            {
                epValidar.SetError(txtContraseña, "Ingrese la contraseña");
                txtContraseña.Focus();
                return;
            }
            else
            {
                epValidar.SetError(txtContraseña, "");
            }

            if (mtbIdEmpleado.MaskFull == false)
            {
                epValidar.SetError(txtNombreUsuario, "Ingrese Id del empleado");
                mtbIdEmpleado.Focus();
                return;
            }
            else
            {
                epValidar.SetError(mtbIdEmpleado, "");
            }
            InsertarUsuario();
            CargarUsuarios();
            Limpiar();
            HabilitarBotones(true, false, false, false, false);
        }

        public void InsertarUsuario()
        {
            CNUsuario objUsuario = new CNUsuario();
            CEUsuario objU = new CEUsuario();
            objU.Usuario = txtNombreUsuario.Text;
            objU.Contrasena = txtContraseña.Text;
            objU.IdEstado = Convert.ToInt32(cboEstado.SelectedValue);
            objU.IdEmpleado = mtbIdEmpleado.Text;
            objU.IdTipoUsuario = Convert.ToInt32(cboTipoUsuario.SelectedValue);

            if (objUsuario.NuevoUsuario(objU) > 0)
            {
                MessageBox.Show("Usuario almacenado satisfactoriamente", "Car Wash", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al almacenar usuario", "Car Wash", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ActualizarUsuario()
        {
            CNUsuario objUsuario = new CNUsuario();
            CEUsuario objU = new CEUsuario();
            objU.IdUsuario = Convert.ToInt32(txtIdUsuario.Text);
            objU.Usuario = txtNombreUsuario.Text;
            objU.Contrasena = txtContraseña.Text;
            objU.IdEstado = Convert.ToInt32(cboEstado.SelectedValue);
            objU.IdEmpleado = mtbIdEmpleado.Text;
            objU.IdTipoUsuario = Convert.ToInt32(cboTipoUsuario.SelectedValue);

            if (objUsuario.ModificarUsuario(objU) > 0)
            {
                MessageBox.Show("Usuario actualizado satisfactoriamente", "Car Wash", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar usuario", "Car Wash", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public static string idEmpleado;
        public static string nombre;

       
        private void FrmUsuarios_Activated(object sender, EventArgs e)
        {
            mtbIdEmpleado.Text = idEmpleado;
            txtNombreEmpleado.Text = nombre;
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            HabilitarBotones(false, true, false, true, true);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Validar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarBotones(true, false, false, false, false);
        }

        private void chkLista_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLista.Checked == true)
            {
                Height = 563;
            }
            else
            {
                Height = 433;
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            FrmBusquedaEmpleado frmbuscar = new FrmBusquedaEmpleado();
            frmbuscar.Show();
        }

        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false, true, false, true, true);
            InvestigarCorrelativo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text == "")
            {
                epValidar.SetError(txtNombreUsuario, "Ingrese el nombre de usuario");
                txtNombreUsuario.Focus();
                return;
            }
            else
            {
                epValidar.SetError(txtNombreUsuario, "");
            }

            if (txtContraseña.Text == "")
            {
                epValidar.SetError(txtContraseña, "Ingrese la contraseña");
                txtContraseña.Focus();
                return;
            }
            else
            {
                epValidar.SetError(txtContraseña, "");
            }

            if (mtbIdEmpleado.MaskFull == false)
            {
                epValidar.SetError(txtNombreUsuario, "Ingrese Id del empleado");
                mtbIdEmpleado.Focus();
                return;
            }
            else
            {
                epValidar.SetError(mtbIdEmpleado, "");
            }

            ActualizarUsuario();
            CargarUsuarios();
            Limpiar();
            HabilitarBotones(true, false, false, false, false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabilitarBotones(true, false, false, false, false);
        }
        private void InvestigarCorrelativo()
        {
            CNUsuario correlativo = new CNUsuario();
            txtIdUsuario.Text = Convert.ToString(correlativo.InvestigarCorrelativo());
        }

        private void editarMenuItem_Click(object sender, EventArgs e)
        {
            txtIdUsuario.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtNombreUsuario.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtContraseña.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            cboEstado.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            mtbIdEmpleado.Text = dgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtNombreEmpleado.Text = dgvUsuarios.CurrentRow.Cells[5].Value.ToString();
            cboTipoUsuario.Text = dgvUsuarios.CurrentRow.Cells[6].Value.ToString();
            HabilitarBotones(false, false, true, true, true);
        }
    }
}
