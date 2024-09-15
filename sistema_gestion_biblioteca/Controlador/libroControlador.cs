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

        public bool actualizarLibro(int index, string p_titulo, string p_autor, int p_numeroPags, string p_genero, string p_fechaIngreso, string p_fechaPublicacion, string p_descripcion, string p_editorial, string p_isbn)
        {
            try
            {
                var libros = obtenerListaLibros();
                if (index < 0 || index >= libros.Count)
                {
                    return false;
                } else
                {
                    libros[index].titulo_libro = p_titulo;
                    libros[index].autor_libro = p_autor;
                    libros[index].numero_paginas = p_numeroPags;
                    libros[index].genero_libro = p_genero;
                    libros[index].fecha_ingreso = p_fechaIngreso;
                    libros[index].fecha_publicacion= p_fechaPublicacion;
                    libros[index].descripcion = p_descripcion;
                    libros[index].editorial = p_editorial;
                    libros[index].ISBN = p_isbn;

                    // Guarda los cambios en el archivo JSON
                    guardarLibros(libros);
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }

        public bool eliminarLibro(int index)
        {
            try
            {
                var libros = obtenerListaLibros();
                if (index < 0 || index >= libros.Count)
                {
                    return false;
                } else
                {
                    // Elimina el libro de la lista
                    libros.RemoveAt(index);

                    // Guarda la lista actualizada en el archivo JSON
                    guardarLibros(libros);
                    return true;
                }

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

        // Metodo para validar que no existan valores duplicados
        public bool validarLibrosDuplicados(string isbn)
        {
            var lista = obtenerListaLibros();
            return lista.Any( ele => ele.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase));
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
