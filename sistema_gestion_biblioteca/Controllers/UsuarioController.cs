using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using sistema_gestion_biblioteca.Classes;

namespace sistema_gestion_biblioteca.Controllers
{
    public class UsuarioController
    {
        private string carpetaData;
        private string archivoJson;

        public UsuarioController()
        {
            // Establecemos la carpeta root del proyecto
            string carpetaRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));

            // Establecemos la ruta
            carpetaData = Path.Combine(carpetaRoot, "Data");

            // Establecemos la ruta completa para el archivo .json
            archivoJson = Path.Combine(carpetaData, "usuarios.json");

            // Creamos la carpeta Data si no existe
            if (!Directory.Exists(carpetaData))
            {
                Directory.CreateDirectory(carpetaData);
            }

            Console.WriteLine($"Archivo JSON se guardo en: {archivoJson}");
        }

        public List<Usuario> CargarDatosDesdeArchivo()
        {
            if (File.Exists(archivoJson))
            {
                string json = File.ReadAllText(archivoJson);
                return JsonConvert.DeserializeObject<List<Usuario>>(json) ?? new List<Usuario>();
            }

            return new List<Usuario>();
        }

        public void guardarDatosEnArchivoJson(List<Usuario> p_usuarios)
        {
            string json = JsonConvert.SerializeObject(p_usuarios, Formatting.Indented);
            File.WriteAllText(archivoJson, json);
        }
    }
}
