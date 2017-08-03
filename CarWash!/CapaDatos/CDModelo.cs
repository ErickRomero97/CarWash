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
    public class CDModelo:Conexion
    {
        #region InsertUpdateDelete


        public int InsertarModelo(CEModelo objC)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_InsertarModelo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Modelo", SqlDbType.NVarChar).Value = objC.Modelo;
            cmd.Parameters.AddWithValue("@IdMarca", SqlDbType.Int).Value = objC.IdMarca;
            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Error al ingresar un nuevo reguistro de modelo", ex);

            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }

            return resultado;
        }

        public int ActualizarModelo(CEModelo objC)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_ActualizarModelo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdModelo", SqlDbType.Int).Value = objC.IdModelo;
            cmd.Parameters.AddWithValue("@Modelo", SqlDbType.NVarChar).Value = objC.Modelo;
            cmd.Parameters.AddWithValue("@IdMarca", SqlDbType.Int).Value = objC.IdMarca;
            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el reguistro del modelo", ex);
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }

            return resultado;
        }


        public int EliminarModelo(CEModelo objC)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_EliminarModelo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdModelo", SqlDbType.Int).Value = objC.IdModelo;


            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                if (ex.ToString().Contains("FK_Automovil_Modelo"))
                {
                    MessageBox.Show(null, "Error al eliminar el modelo porque existe una referencia con Automovil", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    throw new Exception("Error al eliminar el reguistro de modelo", ex);
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

        public DataSet ListadoMarca()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da;
            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_LlenarComboMarca", cn);
                da.Fill(ds, "Marca");

            }
            catch (Exception ex)
            {
                throw new Exception("Error al solicitar los datos de la Marca", ex);

            }
            finally
            {
                CerrarDB();
                ds.Dispose();
            }
            return ds;
        }

        public DataSet MostrarModelo()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            try
            {
                da = new SqlDataAdapter("Sp_MostrarTodoModelo", cn);
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
        public int InvestigarCorrelativo()
        {
            int resultado = 0;
            SqlCommand cmd = new SqlCommand("SP_MostrarModeloIdentity", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                ConectarDB();

                SqlDataReader ListarID;
                ListarID = cmd.ExecuteReader();

                if (ListarID.Read() == true)
                {
                    if (ListarID["Id"] is DBNull)
                    {
                        resultado = 1;
                    }
                    else
                    {
                        resultado = Convert.ToInt32(ListarID["Id"].ToString());
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

