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
    public class CNModelo
    {
        CDModelo objCl = new CDModelo();
        public int NuevaMarca(CEModelo objC)
        {
            return objCl.InsertarModelo(objC);
        }

        public int ActualizarModelo(CEModelo objC)
        {
            return objCl.ActualizarModelo(objC);
        }

        public int EliminarModelo(CEModelo objC)
        {
            return objCl.EliminarModelo(objC);
        }
        public DataSet MostrarTodo()
        {
            return objCl.MostrarModelo();
        }
        public int InvestigarCorrelativo()
        {
            return objCl.InvestigarCorrelativo();
        }
        public DataSet ListadoMarca()
        {
            return objCl.ListadoMarca();
        }
    }
}
