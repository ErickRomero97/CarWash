using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class CNAudiLog
    {
        CDAudiLog objA = new CDAudiLog();

        public DataSet MostrarAuditoria()
        {
            return objA.MostrarAuditoria();
        }
    }
}
