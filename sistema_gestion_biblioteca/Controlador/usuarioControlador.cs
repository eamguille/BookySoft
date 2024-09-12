using sistema_gestion_biblioteca.Modelo;
using Newtonsoft.Json;

namespace sistema_gestion_biblioteca.Controlador
{
    public class usuarioControlador
    {
        // Definimos las variables para encontrar el archivo json
        private string carpetaData;
        private string archivoJson;

        // Objeto para acceder a cualquier elemento de la clase
        public usuarioModelo obj_modelo = new usuarioModelo();

        public usuarioControlador()
        {
            // Establecemos la carpeta root del proyecto
            string carpetaRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));

            // Establecemos la ruta
            carpetaData = Path.Combine(carpetaRoot, "Data");

            // Creamos la carpeta Data si no existe
            if (!Directory.Exists(carpetaData))
            {
                Directory.CreateDirectory(carpetaData);
            }

            // Establecemos la ruta completa para el archivo .json
            archivoJson = Path.Combine(carpetaData, "usuarios.json");
        }

        // Metodo que me devuelve la lista desde el archivo json
        public List<usuarioModelo> obtenerUsuarios()
        {
            // Verificamos que el archivo JSON exista
            if (File.Exists(archivoJson))
            {
                string json = File.ReadAllText(archivoJson);
                return JsonConvert.DeserializeObject<List<usuarioModelo>>(json) ?? new List<usuarioModelo>();
            }

            return new List<usuarioModelo>();
        }

        // METODO PARA ALMACENAR LOS CAMPOS DESDE MODELO A ESTE CONTROLADOR PARA DESPUES USARLO EN LAS VISTAS
        public bool almacenarRegistro(string p_nombres, string p_apellidos, string p_direccion, string p_telefono, string p_email)
        {
            try
            {
                obj_modelo = new usuarioModelo
                {
                    nombres = p_nombres,
                    apellidos = p_apellidos,
                    direccion = p_direccion,
                    telefono = p_telefono,
                    email = p_email
                };

                return agregarUsuario(obj_modelo);

            } 
            catch
            {
                return false;
            }
        }

        // Metodo con el cual agregamos un nuevo usuario a la lista
        public bool agregarUsuario(usuarioModelo p_usuario)
        {
            try
            {
                var guardar = obtenerUsuarios();
                guardar.Add(p_usuario); // Aqui agregamos los datos recogidos a la lista
                guardarUsuarios(guardar); // Aqui guardamos la lista dentro del JSON
                return true;
            } 
            catch
            {
                return false;
            }
        }

        // Metodo para actualizar el usuario y agregamos dicha lista modificada
        public bool actualizarUsuario(int index, string p_nombres, string p_apellidos, string p_direccion, string p_telefono, string p_email)
        {
            try
            {
                var actualizar = obtenerUsuarios();
                if (index < 0 || index >= actualizar.Count)
                {
                    return false;
                }
                else
                {
                    actualizar[index].nombres = p_nombres;
                    actualizar[index].apellidos = p_apellidos;
                    actualizar[index].direccion = p_direccion;
                    actualizar[index].telefono = p_telefono;
                    actualizar[index].email = p_email;
                    guardarUsuarios(actualizar); // Guardamos la nueva lista modificada y la agregamos directamente al archivo JSON
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Metodo para eliminar un usuario de la lista
        public bool eliminarUsuario(int index)
        {
            try
            {
                var eliminar = obtenerUsuarios();
                if (index < 0 || index >= eliminar.Count)
                {
                    return false;
                }
                else
                {
                    eliminar.RemoveAt(index);
                    guardarUsuarios(eliminar); // Agregamos la nueva lista ya modificada
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        // Metodo para Guardar los usuarios finalmente en el archivo JSON
        private void guardarUsuarios(List<usuarioModelo> p_usuarios)
        {
            var json = JsonConvert.SerializeObject(p_usuarios, Formatting.Indented);
            File.WriteAllText(archivoJson, json);
        }
    }
}
