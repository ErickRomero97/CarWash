using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;
namespace CapaDatos
{
    public class CDEmpleado: Conexion
    {
        public int InsertarEmpleado(CEEmpleado objE)
        {
            int resultado;

            SqlCommand cmd = new SqlCommand("Sp_InsertarEmpleado", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", SqlDbType.NVarChar).Value = objE.IdEmpleado;
            cmd.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar).Value = objE.Nombres;
            cmd.Parameters.AddWithValue("@Apellidos", SqlDbType.NVarChar).Value = objE.Apellidos;
            cmd.Parameters.AddWithValue("@Telefono", SqlDbType.NVarChar).Value = objE.Telefono;
            cmd.Parameters.AddWithValue("@Correo", SqlDbType.NVarChar).Value = objE.Correo;
            cmd.Parameters.AddWithValue("@IdSexo", SqlDbType.Int).Value = objE.IdSexo;
            cmd.Parameters.AddWithValue("@Direccion", SqlDbType.NVarChar).Value = objE.Direccion;

            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de almacenar empleado", ex);
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }
            return resultado;
        }

        public int ActualizarEmpleado(CEEmpleado objE)
        {
            int resultado;

            SqlCommand cmd = new SqlCommand("Sp_ActualizarEmpleado", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", SqlDbType.NVarChar).Value = objE.IdEmpleado;
            cmd.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar).Value = objE.Nombres;
            cmd.Parameters.AddWithValue("@Apellidos", SqlDbType.NVarChar).Value = objE.Apellidos;
            cmd.Parameters.AddWithValue("@Telefono", SqlDbType.NVarChar).Value = objE.Telefono;
            cmd.Parameters.AddWithValue("@Correo", SqlDbType.NVarChar).Value = objE.Correo;
            cmd.Parameters.AddWithValue("@IdSexo", SqlDbType.Int).Value = objE.IdSexo;
            cmd.Parameters.AddWithValue("@Direccion", SqlDbType.NVarChar).Value = objE.Direccion;

            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de actualizar empleado", ex);
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet ListarEmpleados()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarEmpleado", cn);
                da.Fill(ds, "Empleados");

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los empleados", ex);
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }

        public DataSet ListarEmpleados1()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarEmpleado1", cn);
                da.Fill(ds, "Empleados");

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los empleados", ex);
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }

        public DataSet ListarSexo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_ComboboxSexo", cn);
                da.Fill(ds, "Sexo");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar sexo", ex);
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }

        public bool Existe(CEEmpleado objE)
        {
            SqlCommand cmd = new SqlCommand("Sp_ExisteEmpleado", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdEmpleado", SqlDbType.NVarChar).Value = objE.IdEmpleado;

            try
            {
                ConectarDB();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar Empleado", ex);
            }
            finally
            {
                CerrarDB();
            }
        }

        public DataSet BuscarPorId(CEEmpleado objE)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_BuscarEmpleadoPorId", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdEmpledo", SqlDbType.NVarChar).Value = objE.IdEmpleado;
                da.Fill(ds, "BuscarId");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar empleado", ex);
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }

        public DataSet BuscarPorNombre(CEEmpleado objE)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_BuscarEmpleadoPorNombre", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = objE.Nombres;
                da.Fill(ds, "BuscarNombre");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar empleado", ex);
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }
    }
}
