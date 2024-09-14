using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sistema_gestion_biblioteca.Controlador;
using sistema_gestion_biblioteca.Modelo;

namespace sistema_gestion_biblioteca.Controlador
{
    internal class graficasControlador
    {
        // Objetos para mandar a llamar a los metodos en otros controladores
        usuarioControlador obj_usuario_controlador = new usuarioControlador();
        prestamoControlador obj_prestamo_controlador = new prestamoControlador();
        libroControlador obj_libro_controlador = new libroControlador();

        // METODO PARA LA GRAFICA
        public List<usuarioModelo> obtenerUsuariosUltimoMes()
        {
            var usuarios = obj_usuario_controlador.obtenerUsuarios();
            DateTime fecha_max = DateTime.Now.AddMonths(-1);

            var usuariosDelUltimoMes = usuarios.Where(ele =>
            {
                DateTime fechaRegistro;
                // Intentamos parsear la fecha de registro del usuario con el formato dd/MM/yyyy
                if (DateTime.TryParseExact(ele.fechaRegistro.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaRegistro))
                {
                    return fechaRegistro >= fecha_max; // Si la fecha de registro es mayor o igual a la fecha límite
                }
                return false;
            }
            ).ToList();

            return usuariosDelUltimoMes;
        }


        // Metodo para grafica de usuarios con mas prestamos hechos
        public List<KeyValuePair<string, int>> obtenerUsuariosConMasPrestamos()
        {
            var prestamos = obj_prestamo_controlador.obtenerPrestamos();

            var prestamosPorUsuario = prestamos.GroupBy(p => p.email_usuario)
                .Select(ele => new KeyValuePair<string, int>(ele.Key, ele.Count()))
                .OrderByDescending(k => k.Value)
                .Take(5)
                .ToList();
            return prestamosPorUsuario;
        }


        // Metodo para mostrar los libros con mas prestamos
        public List<KeyValuePair<string, int>> obtenerLibrosConMasPrestamos()
        {
            var prestamos = obj_prestamo_controlador.obtenerPrestamos();

            var librosPrestados = prestamos.GroupBy(p => p.titulo_libro)
                .Select(ele => new KeyValuePair<string, int>(ele.Key, ele.Count()))
                .OrderByDescending(k => k.Value)
                .Take(8)
                .ToList();
            return librosPrestados;
        }
    }
}
