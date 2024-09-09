using System;
using System.Linq;
using System.Windows.Forms;
using sistema_gestion_biblioteca.Controlador;

namespace sistema_gestion_biblioteca.Forms
{
    public partial class FrmRegistroLibros : Form
    {
        libroControlador obj_controlador;
        bool modoEdicion = false;
        string isbnSeleccionado;

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

        // Validaciones para los campos del libro
        bool ValidarCamposLibro()
        {
            // Validar Título: Solo letras y espacios
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || !txtTitulo.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El campo 'Título del libro' solo debe contener letras y espacios", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar Autor: Solo letras y espacios
            if (string.IsNullOrWhiteSpace(txtAutor.Text) || !txtAutor.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El campo 'Autor' solo debe contener letras y espacios", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar Número de Páginas: Solo números
            if (!int.TryParse(txtNumeroPags.Text, out int numeroPaginas) || numeroPaginas <= 0)
            {
                MessageBox.Show("El campo 'Número de páginas' debe ser un número positivo", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar Género: Solo letras y espacios
            if (string.IsNullOrWhiteSpace(txtGenero.Text) || !txtGenero.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El campo 'Género del libro' solo debe contener letras y espacios", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar Fecha de Publicación: No debe ser futura
            if (DateTime.TryParse(dtFechaPublicacion.Text, out DateTime fechaPublicacion))
            {
                if (fechaPublicacion > DateTime.Now)
                {
                    MessageBox.Show("La fecha de publicación no puede ser posterior a la fecha actual", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Fecha de publicación inválida", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar Fecha de Ingreso: No debe ser futura
            if (DateTime.TryParse(dtFechaIngreso.Text, out DateTime fechaIngreso))
            {
                if (fechaIngreso > DateTime.Now)
                {
                    MessageBox.Show("La fecha de ingreso no puede ser posterior a la fecha actual", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Fecha de ingreso inválida", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar ISBN: Solo números y guiones, longitud total 10-13
            var isbn = txtISBN.Text;
            var isbnSinGuiones = isbn.Replace("-", ""); // Elimina guiones para validar longitud total

            if (!isbn.All(c => char.IsDigit(c) || c == '-'))
            {
                MessageBox.Show("El ISBN solo puede contener números y guiones", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (isbnSinGuiones.Length < 10 || isbnSinGuiones.Length > 13)
            {
                MessageBox.Show("El ISBN debe tener entre 10 y 13 dígitos (excluyendo guiones)", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar Editorial: Solo letras y espacios
            if (string.IsNullOrWhiteSpace(txtEditorial.Text) || !txtEditorial.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El campo 'Editorial' solo debe contener letras y espacios", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        void guardarLibro()
        {
            if (ValidarCamposLibro()) // Solo si las validaciones pasan
            {
                try
                {
                    bool guardar = obj_controlador.agregarLibro(txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtNumeroPags.Text), txtGenero.Text, dtFechaIngreso.Text, dtFechaPublicacion.Text, txtDescripcion.Text, txtEditorial.Text, txtISBN.Text);
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
        }

        void ActualizarLibro()
        {
            if (dgLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione el libro a actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgLibros.SelectedRows[0];
            isbnSeleccionado = row.Cells[8].Value.ToString();

            txtTitulo.Text = row.Cells[0].Value.ToString();
            txtAutor.Text = row.Cells[1].Value.ToString();
            txtNumeroPags.Text = row.Cells[2].Value.ToString();
            txtGenero.Text = row.Cells[3].Value.ToString();
            dtFechaIngreso.Text = row.Cells[4].Value.ToString();
            dtFechaPublicacion.Text = row.Cells[5].Value.ToString();
            txtDescripcion.Text = row.Cells[6].Value.ToString();
            txtEditorial.Text = row.Cells[7].Value.ToString();
            txtISBN.Text = isbnSeleccionado;

            modoEdicion = true;
            btnActualizar.Text = "Guardar Cambios";
        }

        void GuardarLibro()
        {
            if (ValidarCamposLibro()) // Aplicar validaciones también al actualizar
            {
                try
                {
                    bool guardar;
                    if (!modoEdicion)
                    {
                        guardar = obj_controlador.agregarLibro(txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtNumeroPags.Text), txtGenero.Text, dtFechaIngreso.Text, dtFechaPublicacion.Text, txtDescripcion.Text, txtEditorial.Text, txtISBN.Text);
                    }
                    else
                    {
                        guardar = obj_controlador.actualizarLibro(isbnSeleccionado, txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtNumeroPags.Text), txtGenero.Text, dtFechaIngreso.Text, dtFechaPublicacion.Text, txtDescripcion.Text, txtEditorial.Text, txtISBN.Text);
                    }

                    if (guardar)
                    {
                        MessageBox.Show("Libro guardado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDataGrid();
                        LimpiarCampos();
                        modoEdicion = false;
                        btnActualizar.Text = "Actualizar";
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Error al guardar los datos {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            guardarLibro();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (modoEdicion)
            {
                GuardarLibro();
            }
            else
            {
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

