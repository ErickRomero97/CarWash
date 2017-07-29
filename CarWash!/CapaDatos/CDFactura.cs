using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaEntidades;
namespace CapaDatos
{
    public class CDFactura: Conexion
    {
        #region InsertUpdateDelete

        public int InsertarFactura(CEFactura objA)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_InsertarFactura", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Fecha", SqlDbType.DateTime).Value = objA.Fecha;
            cmd.Parameters.AddWithValue("@IdAutomovil", SqlDbType.Int).Value = objA.IdAutomovil;
            cmd.Parameters.AddWithValue("@IdUsuario", SqlDbType.Int).Value = objA.IdUsuario;
            cmd.Parameters.AddWithValue("@Cantidad", SqlDbType.Bit).Value = objA.Cantidad;

            try
            {
                ConectarDB();
                cmd.ExecuteNonQuery();
                MessageBox.Show(null, "Factura almacenada satisfactoriamente", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                if (ex.ToString().Contains("FK_Factura_Cliente"))
                {
                    MessageBox.Show(null, "El cliente no se encuentra registrado", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show(null, "No se pudo registrar la factura", "CarWash System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }

            return resultado;
        }

        public int InsertarDetalleFactura(CEFactura objF)
        {
            int resultado = 0;

            SqlCommand cmd = new SqlCommand("Sp_InsertarDetalleFactura", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdFactura", SqlDbType.Int).Value = objF.IdFactura;
            cmd.Parameters.AddWithValue("@IdServicio", SqlDbType.Int).Value = objF.IdServicio;

            try
            {
                ConectarDB();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                CerrarDB();
                cmd.Dispose();
            }

            return resultado;
        }



        #endregion

        #region Llenar





        public int InvestigarCorrelativo()
        {
            int resultado = 0;
            SqlCommand cmd = new SqlCommand("SP_MostrarFacturaIdentity", cn);
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

        #endregion
    }
}
