using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_gestion_biblioteca.Modelo
{
    internal class prestamoModelo
    {
        public string titulo_libro { get; set; }
        public string email_usuario { get; set; }
        public string fecha_prestamo { get; set; }
        public string fecha_devolucion_estimada { get; set; }
        public string estado_prestamo { get; set; }
    }
}
