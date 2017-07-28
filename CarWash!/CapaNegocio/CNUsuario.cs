using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;
namespace CapaNegocio
{
    public class CNUsuario
    {
        CDUsuario objUsuario = new CDUsuario();

        public string[] ValidarLogin(CEUsuario objU)
        {
            return objUsuario.Login(objU);
        }

        public int NuevoUsuario(CEUsuario objU)
        {
            return objUsuario.InsertarUsuario(objU);
        }

        public int ModificarUsuario(CEUsuario objU)
        {
            return objUsuario.ActualizarUsuario(objU);
        }

        public DataSet ListaUsuarios()
        {
            return objUsuario.ListadoUsuario();
        }

        public DataSet ListaEstado()
        {
            return objUsuario.ListadoEstado();
        }

        public DataSet ListaTipoUsuario()
        {
            return objUsuario.ListadoTipoUsuario();
        }
    }
}
