using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace CapaDatos
{
    public class Conexion
    {
        public SqlConnection cn;

        //public object ConfigurationManager { get; private set; }

        public Conexion()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
           
        }

        public void ConectarDB()
        {

            try
            {
                if (cn.State == ConnectionState.Broken || cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo establecer la conexion.", ex);
            }
        }

        public void CerrarDB()
        {

            try
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cerrar la conexion.", ex);
            }
        }
    }
}
