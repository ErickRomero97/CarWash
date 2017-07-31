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
    public class CDUsuario : Conexion
    {
        public string[] Login(CEUsuario objU)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Sp_Login", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", SqlDbType.NVarChar).Value = objU.Usuario;
                cmd.Parameters.AddWithValue("@Contrasena", SqlDbType.NVarChar).Value = objU.Contrasena;

                ConectarDB();


                SqlDataReader reader = cmd.ExecuteReader();

                int estado;
                int id;


                if (reader.Read())
                {
                    estado = reader.GetInt32(3);
                    id = reader.GetInt32(0);

                    if (estado == 1)
                    {
                        string[] resultado = { id.ToString(), reader.GetString(4), reader.GetString(1) };
                        return resultado;
                    }
                    else
                    {
                        string[] resultado = { "0", "" };
                        return resultado;
                    }
                }
                else
                {
                    string[] resultado = { "-1", "" };
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de ingresar.", ex);
            }
            finally
            {
                CerrarDB();
            }
        }

        public int InsertarUsuario(CEUsuario objU)
        {
            int resultado;

            SqlCommand cmd = new SqlCommand("Sp_InsertarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = objU.Usuario;
            cmd.Parameters.AddWithValue("@Contrasena", SqlDbType.NVarChar).Value = objU.Contrasena;
            cmd.Parameters.AddWithValue("@IdEstado", SqlDbType.Int).Value = objU.IdEstado;
            cmd.Parameters.AddWithValue("@IdEmpleado", SqlDbType.NVarChar).Value = objU.IdEmpleado;
            cmd.Parameters.AddWithValue("@IdTipoUsuario", SqlDbType.Int).Value = objU.IdTipoUsuario;

            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al almacenar usuario", ex);
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }
            return resultado;
        }

        public int ActualizarUsuario(CEUsuario objU)
        {
            int resultado;

            SqlCommand cmd = new SqlCommand("Sp_ActualizarUsuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdUsuario", SqlDbType.NVarChar).Value = objU.IdUsuario;
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = objU.Usuario;
            cmd.Parameters.AddWithValue("@Contrasena", SqlDbType.NVarChar).Value = objU.Contrasena;
            cmd.Parameters.AddWithValue("@IdEstado", SqlDbType.Int).Value = objU.IdEstado;
            cmd.Parameters.AddWithValue("@IdEmpleado", SqlDbType.NVarChar).Value = objU.IdEmpleado;
            cmd.Parameters.AddWithValue("@IdTipoUsuario", SqlDbType.Int).Value = objU.IdTipoUsuario;

            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar usuario", ex);
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet ListadoUsuario()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_MostrarTodoUsuario", cn);
                da.Fill(ds, "Usuarios");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Usuarios", ex);
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }

        public DataSet ListadoEstado()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_ComboboxEstado", cn);
                da.Fill(ds, "Estado");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Estado", ex);
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }

        public DataSet ListadoTipoUsuario()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_ComboboxTipoUsuario", cn);
                da.Fill(ds, "TipoUsuario");
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar Tipo Usuario", ex);
            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
        }
        public int InvestigarCorrelativo()
        {
            int resultado = 0;
            SqlCommand cmd = new SqlCommand("SP_MostrarUsuarioIdentity", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                ConectarDB();

                SqlDataReader ListarProveedores;
                ListarProveedores = cmd.ExecuteReader();

                if (ListarProveedores.Read() == true)
                {
                    if (ListarProveedores["Id"] is DBNull)
                    {
                        resultado = 1;
                    }
                    else
                    {
                        resultado = Convert.ToInt32(ListarProveedores["Id"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            finally
            {
                CerrarDB();
            }
            return resultado;
        }
    }
}
  
