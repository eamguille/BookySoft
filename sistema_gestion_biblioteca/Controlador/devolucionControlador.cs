using Newtonsoft.Json;
using sistema_gestion_biblioteca.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_gestion_biblioteca.Controlador
{
    internal class devolucionControlador
    {
        private string carpetaData;
        private string archivoJson;

        public devolucionModelo obj_modelo = new devolucionModelo();
        public usuarioModelo obj_usuario_modelo = new usuarioModelo();

        public devolucionControlador()
        {
            string carpetaRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));

            carpetaData = Path.Combine(carpetaRoot, "Data");

            if (!Directory.Exists(carpetaData))
            {
                Directory.CreateDirectory(carpetaData);
            }

            archivoJson = Path.Combine(carpetaData, "devolucion.json");
        }

        public List<devolucionModelo> obtenerDevoluciones()
        {
            if (File.Exists(archivoJson))
            {
                string json = File.ReadAllText(archivoJson);
                return JsonConvert.DeserializeObject<List<devolucionModelo>>(json) ?? new List<devolucionModelo>();
            }
            return new List<devolucionModelo>();
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

        public bool agregarDevolucion(string p_libro, string p_email, string p_fechaD, string p_monto, string p_comentario)
        {
            try
            {
                obj_modelo = new devolucionModelo
                {
                    titulo_libro = p_libro,
                    email_usuario = p_email,
                    fecha_devolucion = p_fechaD,
                    monto = p_monto,
                    comentario = p_comentario,
                };

                var guardar = obtenerDevoluciones();
                guardar.Add(obj_modelo);
                guardarDevolucion(guardar);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool actualizarDevolucion(int index, string p_libro, string p_email, string p_fechaD, string p_monto, string p_comentario)
        {
            try
            {
                var actualizar = obtenerDevoluciones();
                if (index < 0 || index >= actualizar.Count)
                {
                    return false;
                }
                else
                {
                    actualizar[index].titulo_libro = p_libro;
                    actualizar[index].email_usuario = p_email;
                    actualizar[index].monto = p_monto;
                    actualizar[index].comentario = p_comentario;
                    guardarDevolucion(actualizar);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool eliminarDevolucion(int index)
        {
            try
            {
                var lista = obtenerDevoluciones();
                if (index < 0 || index >= lista.Count)
                {
                    return false;
                } 
                else
                {
                    lista.RemoveAt(index);
                    guardarDevolucion(lista);
                    return true;
                }
            } catch
            {
                return false;
            }
        }

        public void guardarDevolucion(List<devolucionModelo> p_devoluciones)
        {
            var json = JsonConvert.SerializeObject(p_devoluciones, Formatting.Indented);
            File.WriteAllText(archivoJson, json);
        }
    }
}
