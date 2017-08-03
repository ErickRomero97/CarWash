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
    public partial class FrmModelo : Form
    {
        public FrmModelo()
        {
            InitializeComponent();
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
            if (txtModelo.Text == "")
            {
                errorProvider1.SetError(txtModelo, "El Nombre del modelo es requerido");
                txtModelo.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtModelo, "");
            }

            #endregion

            InsertarCliente();
            CargarModelo();
            Limpiar();
            HabilitarBotones(true, false, true, false, false);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            #region Validacion

            if (txtModelo.Text == "")
            {
                errorProvider1.SetError(txtModelo, "El Nombre del modelo es requerido");
                txtModelo.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtModelo, "");
            }
            #endregion
            ActuralizarUsuario();
            CargarModelo();
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

        private void chkLista_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLista.Checked == true)
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
        private void FilaSeleccionada()
        {
            txtIdModelo.Text = dgvModelo.CurrentRow.Cells[0].Value.ToString();
            txtModelo.Text = dgvModelo.CurrentRow.Cells[1].Value.ToString();
            cboMarca.Text = dgvModelo.CurrentRow.Cells[2].Value.ToString();
            HabilitarBotones(true, true, true, true, true);
        }
        private void CargarModelo()
        {
            CNModelo objC = new CNModelo();
            dgvModelo.DataSource = objC.MostrarTodo().Tables["MostrarTodo"];
        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false, true, false, false);
            CargarModelo();
            CargarCombo();
            cboMarca.SelectedIndex = -1;
        }
        private void Limpiar()
        {
            txtIdModelo.Clear();
            txtModelo.Clear();
            cboMarca.SelectedIndex = -1;
            chkLista.Enabled = true;
            chkLista.Checked = false;
        }

        private void editarMenuItem_Click(object sender, EventArgs e)
        {
            FilaSeleccionada();
        }

        private void eliminarMenuItem_Click(object sender, EventArgs e)
        {
            int IdModelo = Convert.ToInt16(dgvModelo.CurrentRow.Cells[0].Value.ToString());
            EliminarMarca(IdModelo);
            CargarModelo();
        }
        #region insertUpdateDelete

        private void InsertarCliente()
        {
            CNModelo insertC = new CNModelo();
            CEModelo objM = new CEModelo();
            objM.Modelo = txtModelo.Text;
            objM.IdMarca = Convert.ToInt32(cboMarca.SelectedValue);
            if (insertC.NuevaMarca(objM) > 0)
            {
                MessageBox.Show(null, "Se Guardo bien el nuevo registro de Modelo", "CarWash System", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(null, "Error al guardar un nuevo registro de Modelo.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ActuralizarUsuario()
        {
            CNModelo actualizarC = new CNModelo();
            CEModelo objM = new CEModelo();
            objM.IdModelo= Convert.ToInt32(txtIdModelo.Text);
            objM.Modelo = txtModelo.Text;
            objM.IdMarca = Convert.ToInt32(cboMarca.SelectedValue);
            if (actualizarC.ActualizarModelo(objM) > 0)
            {
                MessageBox.Show(null, "Se ha Actualizado la Modelo", "CarWash System", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(null, "Error al Actualizar el registro.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EliminarMarca(int IdModelo)
        {
            CNModelo eliminarC = new CNModelo();
            CEModelo objMarca = new CEModelo();
            objMarca.IdModelo = IdModelo;
            if (eliminarC.EliminarModelo(objMarca) > 0)
            {
                MessageBox.Show(null, "Se ha eliminado el registro de Modelo", "CarWash System", MessageBoxButtons.OK);
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
            grpModelo.Enabled = datos;
        }
        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FilaSeleccionada();
            grpModelo.Enabled = true;
            HabilitarBotones(false, true, false, true, true);
        }
        #endregion
        private void investigarCorrelativo()
        {
            CNModelo correlativo = new CNModelo();
            txtIdModelo.Text = Convert.ToString(correlativo.InvestigarCorrelativo());
        }
        private void CargarCombo()
        {
            CNModelo objC = new CNModelo();
            cboMarca.DataSource = objC.ListadoMarca().Tables["Marca"];
            cboMarca.DisplayMember = "Marca";
            cboMarca.ValueMember = "IdMarca";

        }

        private void btnMarcaA_Click(object sender, EventArgs e)
        {
            CargarCombo();
            cboMarca.SelectedIndex = -1;
        }

        private void btnMarcaFormu_Click(object sender, EventArgs e)
        {
            FrmMarca frm = new FrmMarca();
            frm.ShowDialog();
            this.Show();
        }
    }
}
