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

        public bool agregarLibro(string p_titulo, string p_autor, int p_numero_pags, string p_genero, string p_fechaI, string p_fechaP, string p_descripcion, string p_editorial, string p_isbn, string p_estado)
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
                    ISBN = p_isbn,
                    estado_libro = p_estado
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

        public bool actualizarLibro(string isbnSeleccionado, string titulo, string autor, int numeroPags, string genero, string fechaIngreso, string fechaPublicacion, string descripcion, string editorial, string nuevoIsbn)
        {
            try
            {
                var libros = obtenerListaLibros();
                var libro = libros.FirstOrDefault(l => l.ISBN == isbnSeleccionado);
                if (libro == null)
                {
                    return false; // No se encontró el libro para actualizar
                }

                // Actualiza los datos del libro
                libro.titulo_libro = titulo;
                libro.autor_libro = autor;
                libro.numero_paginas = numeroPags;
                libro.genero_libro = genero;
                libro.fecha_ingreso = fechaIngreso;
                libro.fecha_publicacion = fechaPublicacion;
                libro.descripcion = descripcion;
                libro.editorial = editorial;
                libro.ISBN = nuevoIsbn; // Si se desea actualizar el ISBN

                // Guarda los cambios en el archivo JSON
                guardarLibros(libros);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarLibro(string isbnSeleccionado)
        {
            try
            {
                var libros = obtenerListaLibros();
                var libro = libros.FirstOrDefault(l => l.ISBN == isbnSeleccionado);
                if (libro == null)
                {
                    return false; // No se encontró el libro para eliminar
                }

                // Elimina el libro de la lista
                libros.Remove(libro);

                // Guarda la lista actualizada en el archivo JSON
                guardarLibros(libros);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool actualizarEstadoLibro(string p_isbn, string p_estado)
        {
            try
            {
                var libros = obtenerListaLibros();
                var libro = libros.FirstOrDefault(l => l.ISBN == p_isbn);
                if (libro == null)
                {
                    return false;
                }

                libro.ISBN = p_isbn;
                libro.estado_libro = p_estado;

                guardarLibros(libros);
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

        // Metodo para cargar cmbUsuario segun estado del libro
        public libroModelo obtenerListaPorLibro(string p_libro)
        {
            var lista = obtenerListaLibros();

            var libroSeleccionado = lista.FirstOrDefault( ele => ele.titulo_libro.Equals(p_libro, StringComparison.OrdinalIgnoreCase));

            return libroSeleccionado;
        }
    }
}
