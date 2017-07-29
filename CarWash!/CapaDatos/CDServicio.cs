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
    public class CDServicio:Conexion
    {
        #region InsertUpdateDelete

        public int InsertarServicio(CEServicio objP)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_InsertarServicio", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Servicio", SqlDbType.NVarChar).Value = objP.Servicio;
            cmd.Parameters.AddWithValue("@Precio", SqlDbType.Decimal).Value = objP.Precio;
            cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = objP.Descripcion;
            cmd.Parameters.AddWithValue("@IdUsuario", SqlDbType.Int).Value = objP.IdUsuario;
            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show(null, "El Servicio no se almaceno", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }
            return resultado;
        }

        public int ActulizarServicio(CEServicio objE)
        {
            int resultado = 0;
            SqlCommand cmd = new SqlCommand("Sp_ActualizarServicio", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdServicio", SqlDbType.Int).Value = objE.IdServicio;
            cmd.Parameters.AddWithValue("@Servicio", SqlDbType.NVarChar).Value = objE.Servicio;
            cmd.Parameters.AddWithValue("@Precio", SqlDbType.Decimal).Value = objE.Precio;
            cmd.Parameters.AddWithValue("@Descripcion", SqlDbType.NVarChar).Value = objE.Descripcion;
            cmd.Parameters.AddWithValue("@IdUsuario", SqlDbType.Int).Value = objE.IdUsuario;
            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                MessageBox.Show(null, "Error al actualizar registro", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }
            return resultado;
        }


        public int EliminarServicio(CEServicio objP)
        {
            int resultado = 0;
            SqlCommand cmd = new SqlCommand("Sp_EliminarServicio", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdServicio", SqlDbType.Int).Value = objP.IdServicio;
            try
            {
                ConectarDB();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Error al eliminar registro.", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }
            return resultado;
        }

        #endregion

        #region ListarDatos

        public DataSet ListadoServicio()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            try
            {
                da = new SqlDataAdapter("Sp_MostrarTodoServicio", cn);
                ConectarDB();
                da.Fill(ds, "ListadoServicio");
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show(null, "No se pueden mostrar los registros", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
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
            SqlCommand cmd = new SqlCommand("Sp_MostrarServicioId", cn);
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
        #endregion
    }
}