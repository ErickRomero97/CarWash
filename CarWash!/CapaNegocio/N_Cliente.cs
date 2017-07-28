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
    public class N_Cliente
    {
        D_Cliente objCl = new D_Cliente();
        public int NuevoCliente(E_Cliente objC)
        {
            return objCl.InsertarCliente(objC);
        }

        public int ActualizarCliente(E_Cliente objC)
        {
            return objCl.ActualizarCliente(objC);
        }

        public int EliminarCliente(E_Cliente objC)
        {
            return objCl.EliminarCliente(objC);
        }
        public DataSet ListadoSexo()
        {
            return objCl.ListadoSexo();
        }
        public DataSet MostrarTodoCliente()
        {
            return objCl.MostrarXCliente();
        }
    }
}
