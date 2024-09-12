using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using sistema_gestion_biblioteca.Modelo;

namespace sistema_gestion_biblioteca.Controlador
{
    internal class credencialesControlador
    {
        credencialesModelo obj_controlador = new credencialesModelo();

        // Definimos las variables para encontrar el archivo json
        private string carpetaData;
        private string archivoJson;

        public credencialesControlador()
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
            archivoJson = Path.Combine(carpetaData, "credenciales.json");

            File.SetAttributes(archivoJson, File.GetAttributes(archivoJson) | FileAttributes.Hidden);
        }

        public List<credencialesModelo> obtenerCredenciales()
        {
            if (File.Exists(archivoJson))
            {
                string json = File.ReadAllText(archivoJson);
                return JsonConvert.DeserializeObject<List<credencialesModelo>>(json) ?? new List<credencialesModelo>();
            }
            return new List<credencialesModelo>();
        }

        public bool validarLogin(string p_usuario, string p_clave)
        {
            var credenciales = obtenerCredenciales();
            return credenciales.Any( c => c.usuario == p_usuario && c.clave == p_clave );
        }
    }
}
