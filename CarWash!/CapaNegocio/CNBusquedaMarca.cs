using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using System.Data;
using CapaDatos.Busqueda;

namespace CapaNegocio
{
    public class CNBusquedaMarca
    {
        CDBusquedaMarca objCl = new CDBusquedaMarca();

        public DataSet BuscarPorCodigo(CEMarca objC)
        {
            return objCl.BuscarPorCodigo(objC);
        }

        public DataSet BuscarPorNombre(CEMarca objC)
        {
            return objCl.BuscarPorNombre(objC);
        }

        public DataSet MostrarServicio()
        {
            return objCl.MostrarMarca();
        }
    }
}
