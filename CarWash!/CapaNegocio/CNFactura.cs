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
    public class CNFactura
    {
        CDFactura objF = new CDFactura();

        public int NuevaFactura(CEFactura objA)
        {
            return objF.InsertarFactura(objA);
        }

        public int AgregarDetalle(CEFactura objA)
        {
            return objF.InsertarDetalleFactura(objA);
        }

        public int InvestigarCorrelativo()
        {
            return objF.InvestigarCorrelativo();
        }
    }
}
