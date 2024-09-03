using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using sistema_gestion_biblioteca.Modelo;

namespace sistema_gestion_biblioteca.Controlador
{
    internal class libroControlador
    {
        private string carpetaData;
        private string archivoJson;

        public libroModelo obj_modelo = new libroModelo();

        public libroControlador()
        {
            string carpetaRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));

            carpetaData = Path.Combine(carpetaRoot, "Data");

            if (!Directory.Exists(carpetaData))
            {
                Directory.CreateDirectory(carpetaData);
            }

            archivoJson = Path.Combine(carpetaData, "libros.json");
        }

        public List<libroModelo> obtenerListaLibros()
        {
            if (File.Exists(archivoJson))
            {
                string json = File.ReadAllText(archivoJson);
                return JsonConvert.DeserializeObject<List<libroModelo>>(json) ?? new List<libroModelo>();
            }
            return new List<libroModelo>();
        }



        public void guardarLibros(List<libroModelo> p_libros)
        {
            var json = JsonConvert.SerializeObject(p_libros, Formatting.Indented);
            File.WriteAllText(archivoJson, json);
        }
    }
}
