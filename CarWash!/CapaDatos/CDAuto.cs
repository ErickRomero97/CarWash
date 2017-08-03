using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using System.Windows.Forms;
namespace CapaDatos
{
    public class CDAuto:Conexion
    {
        #region InsertUpdateDelete


        public int Insertar(CEAuto objC)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_InsertarAuto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdAutomovil", SqlDbType.NVarChar).Value = objC.IdAutomovil;
            cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = objC.Descripcion;
            cmd.Parameters.AddWithValue("@IdModelo", SqlDbType.Int).Value = objC.IdModelo;
            cmd.Parameters.AddWithValue("@Año", SqlDbType.Int).Value = objC.Anio;
            cmd.Parameters.AddWithValue("@Idcliente", SqlDbType.NVarChar).Value = objC.IdCliente;
            cmd.Parameters.AddWithValue("@IdUsuario", SqlDbType.Int).Value = objC.IdUsuario;
            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Error al ingresar un nuevo reguistro del Automovil", ex);

            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }

            return resultado;
        }

        public int Actualizar(CEAuto objC)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_ActualizarAuto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdAutomovil", SqlDbType.NVarChar).Value = objC.IdAutomovil;
            cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = objC.Descripcion;
            cmd.Parameters.AddWithValue("@IdModelo", SqlDbType.Int).Value = objC.IdModelo;
            cmd.Parameters.AddWithValue("@Año", SqlDbType.Int).Value = objC.Anio;
            cmd.Parameters.AddWithValue("@Idcliente", SqlDbType.NVarChar).Value = objC.IdCliente;
            cmd.Parameters.AddWithValue("@IdUsuario", SqlDbType.Int).Value = objC.IdUsuario;
            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el reguistro del Auto", ex);
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }

            return resultado;
        }


        public int Eliminar(CEAuto objC)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_EliminarAuto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdAutomovil", SqlDbType.NVarChar).Value = objC.IdAutomovil;
            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                if (ex.ToString().Contains("FK_Factura_Automovil"))
                {
                    MessageBox.Show(null, "Error al eliminar el Automovil porque existe una referencia con Factura", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    throw new Exception("Error al eliminar el reguistro del Auto", ex);
                }
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }
            return resultado;
        }

        #endregion

        public DataSet ListadoModelo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_LlenarComboMaodelo", cn);
                da.Fill(ds, "Modelo");

            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos del Modelo", ex);

            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
            return ds;
        }

        public DataSet Mostrar()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            try
            {
                da = new SqlDataAdapter("Sp_MostrarTodoAutomovil", cn);
                ConectarDB();
                da.Fill(ds, "MostrarTodo");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error  no se pudo realizar la consulta", ex);

            }

            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }
        public bool Existe(CEAuto objE)
        {
            SqlCommand cmd = new SqlCommand("Sp_ExisteAuto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdAutomovil", SqlDbType.NVarChar).Value = objE.IdAutomovil;

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
                throw new Exception("Error al verificar al Auto", ex);
            }
            finally
            {
                CerrarDB();
            }
        }

    }
}
