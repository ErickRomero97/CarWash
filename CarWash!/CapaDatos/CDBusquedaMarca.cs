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
    public class CDBusquedaMarca:Conexion
    {
        public DataSet BuscarPorCodigo(CEMarca objC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarXMarca", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdMarca", SqlDbType.VarChar).Value = objC.IdMarca;
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

        public DataSet BuscarPorNombre(CEMarca objC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarNombreMarca", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Marca", SqlDbType.NVarChar).Value = objC.Marca;
                da.Fill(ds, "MostrarNombreMarca");
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
                da = new SqlDataAdapter("Sp_MostrarTodoMarca", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds, "MostrarTodoMarca");
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

