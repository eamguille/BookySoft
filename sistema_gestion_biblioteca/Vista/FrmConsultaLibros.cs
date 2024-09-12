using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_gestion_biblioteca.Controlador;

namespace sistema_gestion_biblioteca.Forms
{
    public partial class FrmConsultaLibros : Form
    {
        public FrmConsultaLibros()
        {
            InitializeComponent();
        }

        libroControlador obj_controlador = new libroControlador();
        private BindingSource enlaceDatos = new BindingSource();

        private void FrmConsultaLibros_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            agregarNombresHeaders();
            dgLibros.DefaultCellStyle.ForeColor = Color.Black;
            dgLibros.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        void ActualizarDataGrid()
        {
            var lista = obj_controlador.obtenerListaLibros();
            enlaceDatos.DataSource = lista;
            dgLibros.DataSource = enlaceDatos;
        }

        void filtrarBuscador(string filtro_buscador)
        {
            var lista = obj_controlador.obtenerListaLibros();
            if (string.IsNullOrEmpty(filtro_buscador))
            {
                enlaceDatos.DataSource = lista;
            }
            else
            {
                var busqueda = filtro_buscador.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var listaFiltrada = lista.Where(ele =>
                    busqueda.All(t =>
                        (ele.titulo_libro != null && ele.titulo_libro.Contains(t, StringComparison.OrdinalIgnoreCase)) ||
                        (ele.genero_libro != null && ele.genero_libro.Contains(t, StringComparison.OrdinalIgnoreCase)) ||
                        (ele.autor_libro != null && ele.autor_libro.Contains(t, StringComparison.OrdinalIgnoreCase))
                    )
                ).ToList();

                if (lista.Any())
                {
                    enlaceDatos.DataSource = listaFiltrada;
                }
            }
            dgLibros.DataSource = enlaceDatos;

        }

        void agregarNombresHeaders()
        {
            dgLibros.Columns[0].HeaderText = "Título del libro";
            dgLibros.Columns[1].HeaderText = "Autor del libro";
            dgLibros.Columns[2].HeaderText = "Número de Páginas";
            dgLibros.Columns[3].HeaderText = "Género Literario";
            dgLibros.Columns[4].HeaderText = "Fecha de ingreso";
            dgLibros.Columns[5].HeaderText = "Fecha de publicación";
            dgLibros.Columns[6].HeaderText = "Descripción";
            dgLibros.Columns[7].HeaderText = "Editorial";
            dgLibros.Columns[8].HeaderText = "ISBN";
            dgLibros.Columns[9].HeaderText = "Estado";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarBuscador(txtBuscar.Text);
        }
    }
}
