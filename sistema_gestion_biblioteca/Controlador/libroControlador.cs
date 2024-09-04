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

        public bool agregarLibro(string p_titulo, string p_autor, int p_numero_pags, string p_genero, string p_fechaI, string p_fechaP, string p_descripcion, string p_editorial, string p_isbn)
        {
            try
            {
                obj_modelo = new libroModelo { 
                    titulo_libro = p_titulo,
                    autor_libro = p_autor,
                    numero_paginas = p_numero_pags,
                    genero_libro = p_genero,
                    fecha_ingreso = p_fechaI,
                    fecha_publicacion = p_fechaP,
                    descripcion = p_descripcion,
                    editorial = p_editorial,
                    ISBN = p_isbn
                };
                var guardar = obtenerListaLibros();
                guardar.Add(obj_modelo);
                guardarLibros(guardar);
                return true;
            } catch
            {
                return false;
            }
        }



        public void guardarLibros(List<libroModelo> p_libros)
        {
            var json = JsonConvert.SerializeObject(p_libros, Formatting.Indented);
            File.WriteAllText(archivoJson, json);
        }
    }
}
