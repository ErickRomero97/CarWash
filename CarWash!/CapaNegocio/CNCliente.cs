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
    public class CNCliente
    {
        CDCliente objCl = new CDCliente();
        public int NuevoCliente(CECliente objC)
        {
            return objCl.InsertarCliente(objC);
        }

        public int ActualizarCliente(CECliente objC)
        {
            return objCl.ActualizarCliente(objC);
        }

        public int EliminarCliente(CECliente objC)
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
