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
    public class CNAuto
    {
        CDAuto objCl = new CDAuto();
        public int Nuevo(CEAuto objC)
        {
            return objCl.Insertar(objC);
        }

        public int Actualizar(CEAuto objC)
        {
            return objCl.Actualizar(objC);
        }

        public int Eliminar(CEAuto objC)
        {
            return objCl.Eliminar(objC);
        }
        public DataSet ListadoModelo()
        {
            return objCl.ListadoModelo();
        }
        public DataSet MostrarTodo()
        {
            return objCl.Mostrar();
        }
        public bool Existe(CEAuto objE)
        {
            return objCl.Existe(objE);
        }
    }
}
