using Newtonsoft.Json;
using sistema_gestion_biblioteca.Modelo;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace sistema_gestion_biblioteca.Controlador
{
    public class LoginController
    {
        private string archivoJson;

        public LoginController()
        {
            // Establecemos la ruta completa para el archivo .json
            string carpetaRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            string carpetaData = Path.Combine(carpetaRoot, "Data");
            archivoJson = Path.Combine(carpetaData, "usuarios.json"); // Asignamos el archivoJson
        }

        public bool ValidarCredenciales(string Usuario, string Clave)
        {
            if (File.Exists(archivoJson))
            {
                string json = File.ReadAllText(archivoJson);

                // Deserializamos el JSON en una lista de usuarioModelo
                var usuarios = JsonConvert.DeserializeObject<List<usuarioModelo>>(json) ?? new List<usuarioModelo>();

                // Verificamos si hay una coincidencia con las credenciales proporcionadas
                foreach (var usuario in usuarios)
                {
                    if (usuario.Usuario == Usuario && usuario.Clave == Clave)
                    {
                        return true; // Credenciales válidas
                    }
                }
            }

            return false; // Credenciales inválidas
        }

    }

    public class usuarioControlador
    {
        private string carpetaData;
        private string archivoJsonUsuarios;

        public usuarioControlador()
        {
            // Establecemos la carpeta root del proyecto
            string carpetaRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            carpetaData = Path.Combine(carpetaRoot, "Data");

            // Creamos la carpeta Data si no existe
            if (!Directory.Exists(carpetaData))
            {
                Directory.CreateDirectory(carpetaData);
            }

            // Establecemos la ruta completa para el archivo .json
            archivoJsonUsuarios = Path.Combine(carpetaData, "usuarios.json");

            // Creamos el archivo JSON si no existe
            if (!File.Exists(archivoJsonUsuarios))
            {
                File.WriteAllText(archivoJsonUsuarios, "[]");
            }
        }

        // Método para validar el login
        public bool ValidarLogin(string usuario, string clave)
        {
            var usuarios = ObtenerUsuarios();
            return usuarios.Any(u => u.Usuario == usuario && u.Clave == clave);
        }

        // Método para registrar nuevas credenciales (opcional)
        public bool RegistrarUsuario(string nombres, string apellidos, string direccion, string telefono, string email, string usuario, string clave)
        {
            try
            {
                var usuarios = ObtenerUsuarios();

                // Validar si el usuario ya existe
                if (usuarios.Any(u => u.Usuario == usuario))
                {
                    return false; // Usuario ya existe
                }

                // Agregar nuevo usuario
                usuarios.Add(new usuarioModelo
                {
                    nombres = nombres,
                    apellidos = apellidos,
                    direccion = direccion,
                    telefono = telefono,
                    email = email,
                    Usuario = usuario,
                    Clave = clave
                });
                GuardarUsuarios(usuarios);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Método para obtener la lista de usuarios desde el archivo JSON
        public List<usuarioModelo> ObtenerUsuarios()
        {
            if (File.Exists(archivoJsonUsuarios))
            {
                string json = File.ReadAllText(archivoJsonUsuarios);
                return JsonConvert.DeserializeObject<List<usuarioModelo>>(json) ?? new List<usuarioModelo>();
            }

            return new List<usuarioModelo>();
        }

        // Método para almacenar un nuevo registro de usuario
        public bool AlmacenarRegistro(usuarioModelo usuario)
        {
            try
            {
                var usuarios = ObtenerUsuarios();
                usuarios.Add(usuario);
                GuardarUsuarios(usuarios);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Método para actualizar un usuario existente
        public bool ActualizarUsuario(int index, usuarioModelo usuarioActualizado)
        {
            try
            {
                var usuarios = ObtenerUsuarios();
                if (index < 0 || index >= usuarios.Count)
                {
                    return false;
                }

                usuarios[index] = usuarioActualizado;
                GuardarUsuarios(usuarios);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Método para eliminar un usuario de la lista
        public bool EliminarUsuario(int index)
        {
            try
            {
                var usuarios = ObtenerUsuarios();
                if (index < 0 || index >= usuarios.Count)
                {
                    return false;
                }

                usuarios.RemoveAt(index);
                GuardarUsuarios(usuarios);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Método para guardar la lista de usuarios en el archivo JSON
        private void GuardarUsuarios(List<usuarioModelo> usuarios)
        {
            var json = JsonConvert.SerializeObject(usuarios, Formatting.Indented);
            File.WriteAllText(archivoJsonUsuarios, json);
        }
    }
}
