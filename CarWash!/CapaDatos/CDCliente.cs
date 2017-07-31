using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CDCliente: Conexion
    {
        #region InsertUpdateDelete


        public int InsertarCliente(CECliente objC)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_InsertarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCliente", SqlDbType.NVarChar).Value = objC.IdCliente;
            cmd.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar).Value = objC.Nombre;
            cmd.Parameters.AddWithValue("@Apellidos", SqlDbType.NVarChar).Value = objC.Apellidos;
            cmd.Parameters.AddWithValue("@FechaNac", SqlDbType.Date).Value = objC.FechaNac;
            cmd.Parameters.AddWithValue("@Direccion", SqlDbType.NVarChar).Value = objC.Direccion;
            cmd.Parameters.AddWithValue("@IdSexo", SqlDbType.Int).Value = objC.IdSexo;
           

            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {

                throw new Exception("Error al ingresar un nuevo reguistro de clientes", ex);
               
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }

            return resultado;
        }

        public int ActualizarCliente(CECliente objC)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_ActualizarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCliente", SqlDbType.NVarChar).Value = objC.IdCliente;
            cmd.Parameters.AddWithValue("@Nombre", SqlDbType.NVarChar).Value = objC.Nombre;
            cmd.Parameters.AddWithValue("@Apellidos", SqlDbType.NVarChar).Value = objC.Apellidos;
            cmd.Parameters.AddWithValue("@FechaNac", SqlDbType.Date).Value = objC.FechaNac;
            cmd.Parameters.AddWithValue("@Direccion", SqlDbType.NVarChar).Value = objC.Direccion;
            cmd.Parameters.AddWithValue("@IdSexo", SqlDbType.Int).Value = objC.IdSexo;
            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex )
            {
                throw new Exception("Error al actualizar el reguistro del cliente", ex);
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }

            return resultado;
        }


        public int EliminarCliente(CECliente objC)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_EliminarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCliente", SqlDbType.Int).Value = objC.IdCliente;


            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {

                if (ex.ToString().Contains("FK_Factura_Cliente"))
                {
                    MessageBox.Show(null, "Error al eliminar el cliente porque existe una referencia con Factura", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    throw new Exception("Error al eliminar el reguistro del cliente", ex);
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

        public DataSet ListadoSexo()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_LlenarComboSexo", cn);
                da.Fill(ds, "Sexo");
               
            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de los clientes", ex);

            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
            return ds;
        }

        public DataSet MostrarXCliente()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            try
            {
                da = new SqlDataAdapter("Sp_MostrarTodoCliente", cn);
                ConectarDB();
                da.Fill(ds, "MostrarTodoCliente");
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
        public bool Existe(CECliente objE)
        {
            SqlCommand cmd = new SqlCommand("Sp_ExisteCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCliente", SqlDbType.NVarChar).Value = objE.IdCliente;

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
                throw new Exception("Error al verificar al Cliente", ex);
            }
            finally
            {
                CerrarDB();
            }
        }
    }
}
