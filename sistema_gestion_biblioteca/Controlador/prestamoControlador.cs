using sistema_gestion_biblioteca.Modelo;
using Newtonsoft.Json;

namespace sistema_gestion_biblioteca.Controlador
{
    internal class prestamoControlador
    {
        private string carpetaData;
        private string archivoJson;

        public prestamoModelo obj_modelo = new prestamoModelo();
        public usuarioModelo obj_usuario_modelo = new usuarioModelo();

        public prestamoControlador()
        {
            string carpetaRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));

            carpetaData = Path.Combine(carpetaRoot, "Data");

            if(!Directory.Exists(carpetaData))
            {
                Directory.CreateDirectory(carpetaData);
            }

            archivoJson = Path.Combine(carpetaData, "prestamos.json");
        }

        public List<prestamoModelo> obtenerPrestamos()
        {
            if (File.Exists(archivoJson))
            {
                string json = File.ReadAllText(archivoJson);
                return JsonConvert.DeserializeObject<List<prestamoModelo>>(json) ?? new List<prestamoModelo>();
            }
            return new List<prestamoModelo>();
        }

        public List<usuarioModelo> obtenerUsuarios()
        {
            if (File.Exists(archivoJson))
            {
                string json = File.ReadAllText(archivoJson);
                return JsonConvert.DeserializeObject<List<usuarioModelo>>(json) ?? new List<usuarioModelo>();
            }
            return new List<usuarioModelo>();
        }

        public bool agregarPrestamo(string p_libro, string p_email, string p_fechaP, string p_fechaD, string p_estado)
        {
            try
            {
                obj_modelo = new prestamoModelo{
                    titulo_libro = p_libro,
                    email_usuario = p_email,
                    fecha_prestamo = p_fechaP,
                    fecha_devolucion_estimada = p_fechaD,
                    estado_prestamo = p_estado
                };

                var guardar = obtenerPrestamos();
                guardar.Add(obj_modelo);
                guardarPrestamos(guardar);
                return true;
            }catch
            {
                return false;
            }
        }

        public bool actualizarPrestamo(int index, string p_libro, string p_email, string p_fechaP, string p_fechaD, string p_estado)
        {
            try
            {
                var actualizar = obtenerPrestamos();
                if (index < 0 || index >= actualizar.Count)
                {
                    return false;
                } else
                {
                    actualizar[index].titulo_libro = p_libro;
                    actualizar[index].email_usuario= p_email;
                    actualizar[index].fecha_prestamo = p_fechaP;
                    actualizar[index].fecha_devolucion_estimada = p_fechaD;
                    actualizar[index].estado_prestamo= p_estado;
                    guardarPrestamos(actualizar);
                    return true;
                }
            } catch
            {
                return false;
            }
        }

        public bool eliminarPrestamo(int index)
        {
            try
            {
                var eliminar = obtenerPrestamos();
                if (index < 0 || index >= eliminar.Count)
                {
                    return false;
                } else
                {
                    eliminar.RemoveAt(index);
                    guardarPrestamos(eliminar);
                    return true;
                }
            } catch
            {
                return false;
            }
        }



        public void guardarPrestamos(List<prestamoModelo> p_prestamos)
        {
            var json = JsonConvert.SerializeObject(p_prestamos, Formatting.Indented);
            File.WriteAllText(archivoJson, json);
        }
    }
}
