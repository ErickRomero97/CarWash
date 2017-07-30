using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos.Busqueda
{
    public class CDBusquedaAuto:Conexion
    {
        public DataSet BuscarPorCodigo(CEAuto objC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarAutomovilId", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdAutomovil", SqlDbType.VarChar).Value = objC.IdAutomovil;
                da.Fill(ds, "MostrarXCodigo");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la base de datos", ex);
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }

        public DataSet BuscarPorNombre(CEAuto objC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarAutomovilAnio", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Año", SqlDbType.Int).Value = objC.Anio;
                da.Fill(ds, "MostrarXNombre");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la base de datos", ex);
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }

        public DataSet MostrarAuto()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarTodoAutomovil", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds, "MostrarTodoCliente");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la base de datos", ex);
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }
    }
}
