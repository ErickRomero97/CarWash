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
    public class CNBusquedaFactura
    {
        CDBusquedaFactura objFa = new CDBusquedaFactura();

        public DataSet BuscarPorCodigo(CEFactura objF)
        {
            return objFa.BuscarPorCodigo(objF);
        }

        public DataSet BuscarPorFEcha(CEFactura objF)
        {
            return objFa.BuscarPorFecha(objF);
        }

        public DataSet MostrarFactura()
        {
            return objFa.MostrarFactura();
        }
    }
}
