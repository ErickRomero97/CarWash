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
    public class CNServicio
    {
        CDServicio objPd = new CDServicio();

        public int NuevoServicio(CEServicio objP)
        {
            return objPd.InsertarServicio(objP);
        }

        public int ActualizarServicio(CEServicio objp)
        {
            return objPd.ActulizarServicio(objp);
        }

        public int EliminarServicio(CEServicio objp)
        {
            return objPd.EliminarServicio(objp);
        }

        public DataSet ListadoServicio()
        {
            return objPd.ListadoServicio();
        }

        public int InvestigarCorrelativo()
        {
            return objPd.InvestigarCorrelativo();
        }

    }
}
