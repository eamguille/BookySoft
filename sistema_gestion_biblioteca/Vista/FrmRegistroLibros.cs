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
    public partial class FrmRegistroLibros : Form
    {
        libroControlador obj_controlador;

        public FrmRegistroLibros()
        {
            InitializeComponent();
            obj_controlador = new libroControlador();
        }

        private void FrmRegistroLibros_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        void ActualizarDataGrid()
        {
            var lista = obj_controlador.obtenerListaLibros();
            dgLibros.DataSource = lista;
        }

        void guardarLibro()
        {
            try
            {
                bool guardar = obj_controlador.agregarLibro(txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtNumeroPags.Text), txtGenero.Text, dtFechaIngreso.Text, dtFechaPublicacion.Text, txtDescripcion.Text, txtEditorial.Text, txtISBN.Text);
                if (guardar)
                {
                    MessageBox.Show("Libro ingresado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGrid();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al guardar los datos {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        void cargarHeadersDataGrid()
        {
            dgLibros.Columns[0].HeaderText = "Titulo del libro";
            dgLibros.Columns[0].HeaderText = "Autor del libro";
            dgLibros.Columns[0].HeaderText = "# de paginas ";
            dgLibros.Columns[0].HeaderText = "Genero del libro";
            dgLibros.Columns[0].HeaderText = "Fecha de Ingreso";
            dgLibros.Columns[0].HeaderText = "Fecha de publicacion";
            dgLibros.Columns[0].HeaderText = "Editorial del libro";
            dgLibros.Columns[0].HeaderText = "ISBN";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            guardarLibro();
        }
    }
}
