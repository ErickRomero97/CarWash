using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CDAudiLog:Conexion
    {
        public DataSet MostrarAuditoria()
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();

            try
            {
                ConectarDB();
                da = new SqlDataAdapter("Sp_LlenarAuditoriaLog", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(ds, "MostrarTodoAuditoria");
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Error al solicitar los datos de la base de datos", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
