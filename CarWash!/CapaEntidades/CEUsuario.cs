using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CEUsuario
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public int IdEstado { get; set; }
        public string IdEmpleado { get; set; }
        public int IdTipoUsuario { get; set; }
    }
}
