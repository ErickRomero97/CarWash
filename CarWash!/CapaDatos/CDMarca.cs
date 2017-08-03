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
    public class CDMarca: Conexion
    {
        #region InsertUpdateDelete


        public int InsertarMarca(CEMarca objC)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_InsertarMarca", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Marca", SqlDbType.NVarChar).Value = objC.Marca;
            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception("Error al ingresar un nuevo reguistro de  Marca", ex);

            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }

            return resultado;
        }

        public int ActualizarMarca(CEMarca objC)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_ActualizarMarca", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdMarca", SqlDbType.Int).Value = objC.IdMarca;
            cmd.Parameters.AddWithValue("@Marca", SqlDbType.NVarChar).Value = objC.Marca;
            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el reguistro de Marca", ex);
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }

            return resultado;
        }


        public int EliminarMarca(CEMarca objC)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_EliminarMarca", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdMarca", SqlDbType.Int).Value = objC.IdMarca;
            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                if (ex.ToString().Contains("FK_Modelo_Marca"))
                {
                    MessageBox.Show(null, "Error al eliminar la marca porque existe una referencia con Modelo", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    throw new Exception("Error al eliminar el reguistro de marca", ex);
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

        public DataSet MostrarMarca()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            try
            {
                da = new SqlDataAdapter("Sp_MostrarTodoMarca", cn);
                ConectarDB();
                da.Fill(ds, "MostrarTodoMarca");
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
            SqlCommand cmd = new SqlCommand("SP_MostrarMarcaIdentity", cn);
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

