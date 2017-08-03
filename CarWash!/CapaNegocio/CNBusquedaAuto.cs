using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using System.Data;
using CapaDatos.Busqueda;

namespace CapaNegocio.Busqueda
{
    public class CNBusquedaAuto
    {
        CDBusquedaAuto objCl = new CDBusquedaAuto();

        public DataSet BuscarPorCodigo(CEAuto objC)
        {
            return objCl.BuscarPorCodigo(objC);
        }

        public DataSet BuscarPorNombre(CEAuto objC)
        {
            return objCl.BuscarPorNombre(objC);
        }

        public DataSet MostrarAuto()
        {
            return objCl.MostrarAuto();
        }
    }
}
