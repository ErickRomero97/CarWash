using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
namespace CapaDatos
{
    public class CDBusquedaFactura:Conexion
    {
        public DataSet BuscarPorCodigo(CEFactura objF)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarXFactura", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdFactura", SqlDbType.Int).Value = objF.IdFactura;
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

        public DataSet BuscarPorFecha(CEFactura objF)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarXFecha", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Fecha", SqlDbType.Date).Value = objF.Fecha;
                da.Fill(ds, "MostrarXFecha");
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

        public DataSet MostrarFactura()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarTodoFactura", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds, "MostrarTodoFactura");
                return ds;
            }
            catch (Exception ex )
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
