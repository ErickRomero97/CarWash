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
using CapaPresentacion.Formularios;

namespace CapaPresentacion
{
    public partial class FrmAutomoviles : Form
    {
        public FrmAutomoviles()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarBotones(false, true, true, false, true);
            chkLista.Enabled = false;
            chkLista.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region Validacion
            CNAuto objC = new CNAuto();
            CEAuto objDatos = new CEAuto();
            objDatos.IdAutomovil = txtPlaca.Text;
            if (objC.Existe(objDatos))
            {
                MessageBox.Show("Este Auto ya Existe dentro de la base de datos");
            }
            else
            {
                if (txtPlaca.Text == "")
                {
                    errorProvider1.SetError(txtPlaca, "La Placa del Auto es requerido");
                    txtPlaca.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtPlaca, "");
                }
                if (txtDescripcion.Text == "")
                {
                    errorProvider1.SetError(txtDescripcion, "La Descripcion del Auto es requerido");
                    txtPlaca.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtDescripcion, "");
                }
                if (txtAño.Text == "")
                {
                    errorProvider1.SetError(txtAño, "La Placa del Auto es requerido");
                    txtPlaca.Focus();
                    return;
                }
                else
                {
                    errorProvider1.SetError(txtAño, "");
                }
                #endregion

                Insertar();
                CargarAuto();
                Limpiar();
                HabilitarBotones(true, false, true, false, false);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            #region Validacion

            if (txtPlaca.Text == "")
            {
                errorProvider1.SetError(txtPlaca, "La Placa del Auto es requerido");
                txtPlaca.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtPlaca, "");
            }
            if (txtDescripcion.Text == "")
            {
                errorProvider1.SetError(txtDescripcion, "La Descripcion del Auto es requerido");
                txtPlaca.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtDescripcion, "");
            }
            if (txtAño.Text == "")
            {
                errorProvider1.SetError(txtAño, "La Placa del Auto es requerido");
                txtPlaca.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtAño, "");
            }
            #endregion
            Acturalizar();
            CargarAuto();
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
                Height = 564;
                CenterToScreen();

            }
            else
            {
                Height = 422;
                CenterToScreen();
            }
        }

        private void btnMarcaA_Click(object sender, EventArgs e)
        {
            CargarCombo();
            cboModelo.SelectedIndex = -1;
        }

        private void btnMarcaFormu_Click(object sender, EventArgs e)
        {
            FrmModelo frm = new FrmModelo();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmBusquedaCliente frm = new FrmBusquedaCliente();
            frm.ShowDialog();
            txtIdCliente.Text = Convert.ToString(frm.dgvMostrar.CurrentRow.Cells[0].Value);
            this.Show();
        }
        private void FilaSeleccionada()
        {
            txtPlaca.Text = dgvAuto.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dgvAuto.CurrentRow.Cells[1].Value.ToString();
            cboModelo.Text = dgvAuto.CurrentRow.Cells[3].Value.ToString();
            txtAño.Text = dgvAuto.CurrentRow.Cells[2].Value.ToString();
            txtIdCliente.Text = dgvAuto.CurrentRow.Cells[4].Value.ToString();
            HabilitarBotones(true, true, true, true, true);
        }
        private void CargarAuto()
        {
            CNAuto objC = new CNAuto();
            dgvAuto.DataSource = objC.MostrarTodo().Tables["MostrarTodo"];
        }

        private void FrmAutomoviles_Load(object sender, EventArgs e)
        {
            HabilitarBotones(true, false, true, false, false);
            CargarAuto();
            CargarCombo();
            cboModelo.SelectedIndex = -1;
        }
        private void Limpiar()
        {
            txtIdCliente.Clear();
            txtPlaca.Clear();
            cboModelo.SelectedIndex = -1;
            txtAño.Clear();
            txtDescripcion.Clear();
            chkLista.Enabled = true;
            chkLista.Checked = false;
        }

        private void editarMenuItem_Click(object sender, EventArgs e)
        {
            FilaSeleccionada();
        }

        private void eliminarMenuItem_Click(object sender, EventArgs e)
        {
            string IdAuto =dgvAuto.CurrentRow.Cells[0].Value.ToString();
            EliminarAuto(IdAuto);
            CargarAuto();
        }
        #region insertUpdateDelete

        private void Insertar()
        {
            CNAuto insertC = new CNAuto();
            CEAuto objM = new  CEAuto();
            objM.IdAutomovil = txtPlaca.Text;
            objM.Descripcion = txtDescripcion.Text;
            objM.IdModelo = Convert.ToInt32(cboModelo.SelectedValue);
            objM.Anio = Convert.ToInt16(txtAño.Text);
            objM.IdCliente = txtIdCliente.Text;
            objM.IdUsuario =FrmPrincipal.id ;
            if (insertC.Nuevo(objM) > 0)
            {
                MessageBox.Show(null, "Se Guardo bien el nuevo registro de Auto", "CarWash System", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(null, "Error al guardar un nuevo registro de Auto.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Acturalizar()
        {
            CNAuto actualizarC = new CNAuto();
            CEAuto objM = new CEAuto();
            objM.IdAutomovil = txtPlaca.Text;
            objM.Descripcion = txtDescripcion.Text;
            objM.IdModelo = Convert.ToInt32(cboModelo.SelectedValue);
            objM.Anio = Convert.ToInt16(txtAño.Text);
            objM.IdCliente = txtIdCliente.Text;
            objM.IdUsuario = FrmPrincipal.id;
            if (actualizarC.Actualizar(objM) > 0)
            {
                MessageBox.Show(null, "Se ha Actualizado el Auto", "CarWash System", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(null, "Error al Actualizar el registro.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EliminarAuto(string IdAuto)
        {
            CNAuto eliminarC = new CNAuto();
            CEAuto objMarca = new  CEAuto();
            objMarca.IdAutomovil = IdAuto;
            if (eliminarC.Eliminar(objMarca) > 0)
            {
                MessageBox.Show(null, "Se ha eliminado el registro de Auto", "CarWash System", MessageBoxButtons.OK);
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
            grpAuto.Enabled = datos;
        }
        private void editarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FilaSeleccionada();
            grpAuto.Enabled = true;
            HabilitarBotones(false, true, false, true, true);
        }
        #endregion
       
        private void CargarCombo()
        {
            CNAuto objC = new CNAuto();
            cboModelo.DataSource = objC.ListadoModelo().Tables["Modelo"];
            cboModelo.DisplayMember = "Modelo";
            cboModelo.ValueMember = "IdModelo";

        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDescripcion.Text.Length == 0)
            {
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            }
            else if (txtDescripcion.Text.Length > 0)
            {
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
            }
        }
    }
}
