using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEServicio
    {
        public int IdServicio { get; set; }
        public string Servicio { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public int IdUsuario { get; set; }
    }
}
