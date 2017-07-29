using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace CapaDatos
{
    public class CDBusquedaServicio: Conexion
    {
        public DataSet BuscarPorCodigo(CEServicio objC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarXServicio", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdServicio", SqlDbType.VarChar).Value = objC.IdServicio;
                da.Fill(ds, "MostrarXServicio");
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Error al solicitar los datos de la base de datos", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }

        public DataSet BuscarPorNombre(CEServicio objC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarNombreServicio", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Servicio", SqlDbType.NVarChar).Value = objC.Servicio;
                da.Fill(ds, "MostrarXNombre");
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Error al solicitar los datos de la base de datos", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }

        public DataSet MostrarServicio()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarTodoServicio", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds, "MostrarTodoCliente");
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Error al solicitar los datos de la base de datos", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }
    }
}
