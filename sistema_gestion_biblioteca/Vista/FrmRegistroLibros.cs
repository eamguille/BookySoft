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
        bool modoEdicion = false;
        string isbnSeleccionado;
        // Definimos el estado del libro predeterminado al momento de registrar
        string estado_libro = "Disponible";

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

        void LimpiarCampos()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtNumeroPags.Text = "";
            txtGenero.Text = "";
            dtFechaIngreso.Text = "";
            dtFechaPublicacion.Text = "";
            txtDescripcion.Text = "";
            txtEditorial.Text = "";
            txtISBN.Text = "";
        }

        void guardarLibro()
        {
            try
            {
                bool guardar = obj_controlador.agregarLibro(txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtNumeroPags.Text), txtGenero.Text, dtFechaIngreso.Text, dtFechaPublicacion.Text, txtDescripcion.Text, txtEditorial.Text, txtISBN.Text, estado_libro);
                if (guardar)
                {
                    MessageBox.Show("Libro ingresado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGrid();
                    LimpiarCampos();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al guardar los datos {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ActualizarLibro()
        {
            if (dgLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el libro a actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el libro seleccionado
            DataGridViewRow row = dgLibros.SelectedRows[0];
            isbnSeleccionado = row.Cells[8].Value.ToString(); // Asegúrate de que el ISBN está en la columna correcta

            // Cargar datos del libro en los campos
            txtTitulo.Text = row.Cells[0].Value.ToString();
            txtAutor.Text = row.Cells[1].Value.ToString();
            txtNumeroPags.Text = row.Cells[2].Value.ToString();
            txtGenero.Text = row.Cells[3].Value.ToString();
            dtFechaIngreso.Text = row.Cells[4].Value.ToString();
            dtFechaPublicacion.Text = row.Cells[5].Value.ToString();
            txtDescripcion.Text = row.Cells[6].Value.ToString();
            txtEditorial.Text = row.Cells[7].Value.ToString();
            txtISBN.Text = isbnSeleccionado;

            modoEdicion = true; // Establecer el modo de edición
            btnActualizar.Text = "Guardar Cambios"; // Cambiar el texto del botón
        }

        void GuardarLibro()
        {
            try
            {
                bool guardar;
                if (!modoEdicion) // Si no está en modo de edición, es una nueva entrada
                {
                    guardar = obj_controlador.agregarLibro(txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtNumeroPags.Text), txtGenero.Text, dtFechaIngreso.Text, dtFechaPublicacion.Text, txtDescripcion.Text, txtEditorial.Text, txtISBN.Text, estado_libro);
                }
                else // Si está en modo de edición, actualizar el libro
                {
                    guardar = obj_controlador.actualizarLibro(isbnSeleccionado, txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtNumeroPags.Text), txtGenero.Text, dtFechaIngreso.Text, dtFechaPublicacion.Text, txtDescripcion.Text, txtEditorial.Text, txtISBN.Text);
                }

                if (guardar)
                {
                    MessageBox.Show("Libro guardado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGrid();
                    LimpiarCampos();
                    modoEdicion = false; // Resetear el modo de edición
                    btnActualizar.Text = "Actualizar"; // Restaurar el texto del botón
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al guardar los datos {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void CargarHeadersDataGrid()
        {
            dgLibros.Columns[0].HeaderText = "Titulo del libro";
            dgLibros.Columns[1].HeaderText = "Autor del libro";
            dgLibros.Columns[2].HeaderText = "# de paginas ";
            dgLibros.Columns[3].HeaderText = "Genero del libro";
            dgLibros.Columns[4].HeaderText = "Fecha de Ingreso";
            dgLibros.Columns[5].HeaderText = "Fecha de publicacion";
            dgLibros.Columns[6].HeaderText = "Editorial del libro";
            dgLibros.Columns[7].HeaderText = "ISBN";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            guardarLibro();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (modoEdicion)
            {
                // Guardar cambios si está en modo de edición
                GuardarLibro();
            }
            else
            {
                // Cargar datos del libro seleccionado para edición
                ActualizarLibro();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el libro a eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var isbnSeleccionado = dgLibros.SelectedRows[0].Cells[8].Value.ToString();

            // Mostrar mensaje de confirmación
            var result = MessageBox.Show("¿Está seguro de que desea eliminar este libro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool eliminar = obj_controlador.eliminarLibro(isbnSeleccionado);

                if (eliminar)
                {
                    MessageBox.Show("Libro eliminado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eliminación cancelada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
