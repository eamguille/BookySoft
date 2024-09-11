using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_gestion_biblioteca.Modelo
{
    internal class libroModelo
    {
        public string titulo_libro { get; set; }
        public string autor_libro { get; set; }
        public int numero_paginas { get; set; }
        public string genero_libro { get; set; }
        public string fecha_ingreso { get; set; }
        public string fecha_publicacion { get; set; }
        public string descripcion { get; set; }
        public string editorial { get; set; }
        public string ISBN { get; set; }
        public string estado_libro { get; set; }
    }
}
