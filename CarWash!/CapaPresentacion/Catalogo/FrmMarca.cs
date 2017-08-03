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
namespace CapaPresentacion.Formularios
{
    public partial class FrmMarca : Form
    {
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false, true, false, false);
            CargarMarca();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false, true, true, false, true);
            investigarCorrelativo();
            chkLista.Enabled = false;
            chkLista.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region Validacion
            CNMarca objC = new CNMarca();
            CEMarca objDatos = new CEMarca();
                if (txtMarca.Text == "")
                {
                    errorProvider1.SetError(txtMarca, "El Nombre de la marca es requerido");
                    txtMarca.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtMarca, "");
                }
               
                #endregion

                InsertarCliente();
                CargarMarca();
                Limpiar();
                HabilitarBotones(true, false, true, false, false);
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            #region Validacion

            if (txtMarca.Text == "")
            {
                errorProvider1.SetError(txtMarca, "El Nombre de la marca es requerido");
                txtMarca.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtMarca, "");
            }
            #endregion
            ActuralizarUsuario();
            CargarMarca();
            Limpiar();
            HabilitarBotones(true, false, true, false, false);
            Height = 550;
            CenterToScreen();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarBotones(true, false, true, false, false);
            Limpiar();
        }
        private void CargarMarca()
        {
            CNMarca objC = new CNMarca();
            dgvMarca.DataSource = objC.MostrarTodoCliente().Tables["MostrarTodoMarca"];
        }
        private void FilaSeleccionada()
        {
            txtIdMarca.Text = dgvMarca.CurrentRow.Cells[0].Value.ToString();
            txtMarca.Text = dgvMarca.CurrentRow.Cells[1].Value.ToString();
            HabilitarBotones(true, true, true, true, true);
        }

        private void Limpiar()
        {
            txtIdMarca.Clear();
            txtMarca.Clear();
            chkLista.Enabled = true;
            chkLista.Checked = false;
        }

        private void chkLista_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLista.Checked == true)
            {
                Height = 430;
                CenterToScreen();

            }
            else
            {
                Height = 306;
                CenterToScreen();
            }
        }

        private void editarMenuItem_Click(object sender, EventArgs e)
        {
            FilaSeleccionada();
        }

        private void eliminarMenuItem_Click(object sender, EventArgs e)
        {
            int IdMarca = Convert.ToInt16(dgvMarca.CurrentRow.Cells[0].Value.ToString());
            EliminarMarca(IdMarca);
            CargarMarca();
        }
        #region insertUpdateDelete

        private void InsertarCliente()
        {
            CNMarca insertC = new CNMarca();
            CEMarca objM = new CEMarca();
            objM.Marca = txtMarca.Text;
            if (insertC.NuevaMarca(objM) > 0)
            {
                MessageBox.Show(null, "Se Guardo bien el nuevo registro de Marca", "CarWash System", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(null, "Error al guardar un nuevo registro de Marca.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ActuralizarUsuario()
        {
            CNMarca actualizarC = new CNMarca();
            CEMarca objM = new CEMarca();
            objM.IdMarca = Convert.ToInt16(txtIdMarca.Text);
            objM.Marca = txtMarca.Text;
            if (actualizarC.ActualizarMarca(objM) > 0)
            {
                MessageBox.Show(null, "Se ha Actualizado la Marca", "CarWash System", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(null, "Error al Actualizar el registro.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EliminarMarca(int IdMarca)
        {
            CNMarca eliminarC = new CNMarca();
            CEMarca objMarca = new CEMarca();
            objMarca.IdMarca = IdMarca;
            if (eliminarC.EliminarMarca(objMarca) > 0)
            {
                MessageBox.Show(null, "Se ha eliminado el registro de Marca", "CarWash System", MessageBoxButtons.OK);
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
            grpMarca.Enabled = datos;
        }
        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FilaSeleccionada();
            grpMarca.Enabled = true;
            HabilitarBotones(false, true, false, true, true);
        }
        #endregion
        private void investigarCorrelativo()
        {
            CNMarca correlativo = new CNMarca();
            txtIdMarca.Text = Convert.ToString(correlativo.InvestigarCorrelativo());
        }
    }
}
