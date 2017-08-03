using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class CDBusquedaModelo:Conexion
    {
        public DataSet BuscarPorCodigo(CEModelo objC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarXModelo", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdModelo", SqlDbType.Int).Value = objC.IdModelo;
                da.Fill(ds, "MostrarId");
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

        public DataSet BuscarPorNombre(CEModelo objC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarNombreModelo", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Modelo", SqlDbType.NVarChar).Value = objC.Modelo;
                da.Fill(ds, "MostrarNombre");
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

        public DataSet MostrarMarca()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarTodoModelo", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds, "MostrarTodo");
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
