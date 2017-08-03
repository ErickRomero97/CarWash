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
    public class CNBusquedaModelo
    {
        CDBusquedaModelo objCl = new CDBusquedaModelo();

        public DataSet BuscarPorCodigo(CEModelo objC)
        {
            return objCl.BuscarPorCodigo(objC);
        }

        public DataSet BuscarPorNombre(CEModelo objC)
        {
            return objCl.BuscarPorNombre(objC);
        }

        public DataSet MostrarServicio()
        {
            return objCl.MostrarMarca();
        }
    }
}
