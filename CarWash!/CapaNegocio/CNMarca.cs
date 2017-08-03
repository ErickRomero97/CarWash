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
    public class CNMarca
    {
        CDMarca objCl = new CDMarca();
        public int NuevaMarca(CEMarca objC)
        {
            return objCl.InsertarMarca(objC);
        }

        public int ActualizarMarca(CEMarca objC)
        {
            return objCl.ActualizarMarca(objC);
        }

        public int EliminarMarca(CEMarca objC)
        {
            return objCl.EliminarMarca(objC);
        }
        public DataSet MostrarTodoCliente()
        {
            return objCl.MostrarMarca();
        }
        public int InvestigarCorrelativo()
        {
            return objCl.InvestigarCorrelativo();
        }
    }
}
