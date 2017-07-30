using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocio
{
    public class CNBusquedaCliente
    {
        CDBusquedaCliente objCl = new CDBusquedaCliente();

        public DataSet BuscarPorCodigo(CECliente objC)
        {
            return objCl.BuscarPorCodigo(objC);
        }

        public DataSet BuscarPorNombre(CECliente objC)
        {
            return objCl.BuscarPorNombre(objC);
        }

        public DataSet MostrarClientes()
        {
            return objCl.MostrarClientes();
        }
    }
}
