using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEFactura
    {
        public int IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public string IdAutomovil { get; set; }
        public decimal Cantidad { get; set; }
        public int IdServicio { get; set; }
        public int IdUsuario { get; set; }
    }
}
