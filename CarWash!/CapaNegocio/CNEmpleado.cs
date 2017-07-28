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
    public class CNEmpleado
    {
        CDEmpleado objEmpleado = new CDEmpleado();

        public int NuevoEmpleado(CEEmpleado objE)
        {
            return objEmpleado.InsertarEmpleado(objE);
        }
        public int ModificarEmpleado(CEEmpleado objE)
        {
            return objEmpleado.ActualizarEmpleado(objE);
        }
        public DataSet ListarEmpleados()
        {
            return objEmpleado.ListarEmpleados();
        }

        public DataSet ListarEmpleados1()
        {
            return objEmpleado.ListarEmpleados1();
        }

        public DataSet ListarSexo()
        {
            return objEmpleado.ListarSexo();
        }

        public bool ExisteEmpleado(CEEmpleado objE)
        {
            return objEmpleado.Existe(objE);
        }

        public DataSet BuscarEmpleadoId(CEEmpleado objE)
        {
            return objEmpleado.BuscarPorId(objE);
        }

        public DataSet BuscarEmpleadoNombre(CEEmpleado objE)
        {
            return objEmpleado.BuscarPorNombre(objE);
        }
    }
}
