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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool ValidarDatos()
        {
            bool estado;
            estado = true;
            if (txtUserName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña", "Car Wash", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado = false;
            }
            else if (txtUserName.Text == "")
            {
                MessageBox.Show("Ingrese el usuario", "Car Wash", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado = false;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Ingrese la contraseña", "Car Wash", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado = false;
            }
            else
            {
                estado = true;
            }
            return estado;
        }

        private void Login()
        {
            CNUsuario validar = new CNUsuario();
            CEUsuario objDatos = new CEUsuario();
            objDatos.Usuario = txtUserName.Text;
            objDatos.Contrasena = txtPassword.Text;

            if (!validar.ValidarLogin(objDatos)[0].Equals("0") && !validar.ValidarLogin(objDatos)[0].Equals("-1"))
            {
                FrmPrincipal frm = new FrmPrincipal();
                FrmPrincipal.id = Convert.ToInt32(validar.ValidarLogin(objDatos)[0].ToString());
                frm.tsslIdUsuario.Text = validar.ValidarLogin(objDatos)[0].ToString();
                frm.tsslNombreUsuario.Text = validar.ValidarLogin(objDatos)[2].ToString();
                frm.tsslTipoUsuario.Text = validar.ValidarLogin(objDatos)[1].ToString();

                if (validar.ValidarLogin(objDatos)[1].Equals("Admin"))
                {
                    //FrmPrincipal.buttom = true;
                }
                else
                {
                    frm.logAuditoriaToolStripMenuItem.Enabled = false;
                    frm.usuariosToolStripMenuItem.Enabled = false;
                    frm.btnFactura.Enabled = false;
                 
                }
                frm.Show();
                this.Hide();
            }
            else if (validar.ValidarLogin(objDatos)[0].Equals("0"))
            {
                MessageBox.Show("Usuario inactivo");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                Login();
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
