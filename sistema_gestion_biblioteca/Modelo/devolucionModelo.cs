using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_gestion_biblioteca.Modelo
{
    internal class devolucionModelo
    {
        public string titulo_libro { get; set; }
        public string email_usuario { get; set; }
        public string fecha_devolucion { get; set; }
        public string monto {  get; set; }
        public string comentario { get; set; }
    }
}
