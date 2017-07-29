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
    public class CDBusquedaCliente:Conexion
    {
        public DataSet BuscarPorCodigo(E_Cliente objC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarXCliente", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@IdCliente", SqlDbType.VarChar).Value = objC.IdCliente;
                da.Fill(ds, "MostrarXCodigo");
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

        public DataSet BuscarPorNombre(E_Cliente objC)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarNombreCliente", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = objC.Nombre;
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

        public DataSet MostrarClientes()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarTodoCliente", cn);
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
