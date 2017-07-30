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
    public class CNBusquedaServicio
    {
        CDBusquedaServicio objCl = new CDBusquedaServicio();

        public DataSet BuscarPorCodigo(CEServicio objC)
        {
            return objCl.BuscarPorCodigo(objC);
        }

        public DataSet BuscarPorNombre(CEServicio objC)
        {
            return objCl.BuscarPorNombre(objC);
        }

        public DataSet MostrarServicio()
        {
            return objCl.MostrarServicio();
        }
    }
}
