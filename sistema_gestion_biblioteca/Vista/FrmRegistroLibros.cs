using System;
using System.Linq;
using System.Text.RegularExpressions;
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
            cargarNombresHeaders();

            txtISBN.Text = "---";
            txtISBN.SelectionStart = 0;
        }

        void ActualizarDataGrid()
        {
            var lista = obj_controlador.obtenerListaLibros();
            dgLibros.DataSource = lista;
        }

        void cargarNombresHeaders()
        {
            dgLibros.Columns[0].HeaderText = "Título";
            dgLibros.Columns[1].HeaderText = "Autor";
            dgLibros.Columns[2].HeaderText = "Número de páginas";
            dgLibros.Columns[3].HeaderText = "Género";
            dgLibros.Columns[4].HeaderText = "Fecha de ingreso";
            dgLibros.Columns[5].HeaderText = "Fecha de publicación";
            dgLibros.Columns[6].HeaderText = "Descripción";
            dgLibros.Columns[7].HeaderText = "Editorial";
            dgLibros.Columns[8].HeaderText = "ISBN";
            dgLibros.Columns[9].HeaderText = "Estado";
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
                    bool guardar = obj_controlador.agregarLibro(txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtNumeroPags.Text), txtGenero.Text, dtFechaIngreso.Text, dtFechaPublicacion.Text, txtDescripcion.Text, txtEditorial.Text, txtISBN.Text, estado_libro);
                    if (guardar)

                    {
                        MessageBox.Show("La fecha de publicación no puede ser posterior a la fecha actual", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
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

            // Validar Editorial: Solo letras y espacios
            if (string.IsNullOrWhiteSpace(txtEditorial.Text) || !txtEditorial.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("El campo 'Editorial' solo debe contener letras y espacios", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // validar que no existan valores duplicados
            var valoresDuplicados = obj_controlador.validarLibrosDuplicados(txtISBN.Text);
            if (valoresDuplicados)
            {
                MessageBox.Show("El libro ya existe. Intenta nuevamente", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return true;
        }

        void guardarLibro()
        {
            if (ValidarCamposLibro()) // Solo si las validaciones pasan
            {
                try
                {
                    bool guardar;
                    if (!modoEdicion)
                    {
                        guardar = obj_controlador.agregarLibro(txtTitulo.Text, txtAutor.Text, Convert.ToInt32(txtNumeroPags.Text), txtGenero.Text, dtFechaIngreso.Text, dtFechaPublicacion.Text, txtDescripcion.Text, txtEditorial.Text, txtISBN.Text, estado_libro);
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
                    MessageBox.Show($"Error al guardar los datos: {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            guardarLibro();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (modoEdicion)
            {
                guardarLibro();
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

            var resultado = MessageBox.Show("¿Está seguro de que desea eliminar el libro seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                DataGridViewRow row = dgLibros.SelectedRows[0];
                string isbnEliminar = row.Cells[8].Value.ToString();
                bool eliminado = obj_controlador.eliminarLibro(isbnEliminar);

                if (eliminado)
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
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Metodos para manejar la validacion del ISBN del libro
        void validarISBN()
        {
            int cursorPos = txtISBN.SelectionStart;

            string textoLimpio = new string(txtISBN.Text.Where(c => char.IsDigit(c) || c == '-').ToArray());

            // Eliminar guiones existentes
            textoLimpio = textoLimpio.Replace("-", "");

            // Añadir guiones en las posiciones correctas
            if (textoLimpio.Length > 3)
            {
                textoLimpio = textoLimpio.Insert(3, "-");
            }
            if (textoLimpio.Length > 8)
            {
                textoLimpio = textoLimpio.Insert(8, "-");
            }
            if (textoLimpio.Length > 13)
            {
                textoLimpio = textoLimpio.Insert(13, "-");
            }

            // Formatear con guiones en las posiciones adecuadas
            if (textoLimpio.Length > 15)
            {
                textoLimpio = textoLimpio.Substring(0, 15);
            }


            // Actualizamos el texto
            txtISBN.Text = textoLimpio;
            txtISBN.SelectionStart = txtISBN.Text.Length;
        }
        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            validarISBN();
        }

        private void dtFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            // Fecha de devolución real seleccionada por el usuario
            DateTime fechaDevolucionReal = dtFechaIngreso.Value;

            if (fechaDevolucionReal > DateTime.Now)
            {
                MessageBox.Show("La fecha de devolución no puede ser mayor a la fecha actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtFechaIngreso.Value = DateTime.Now;
            }
        }

        private void dtFechaPublicacion_ValueChanged(object sender, EventArgs e)
        {
            // Fecha de devolución real seleccionada por el usuario
            DateTime fechaDevolucionReal = dtFechaPublicacion.Value;

            if (fechaDevolucionReal > DateTime.Now)
            {
                MessageBox.Show("La fecha de devolución no puede ser mayor a la fecha actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                dtFechaPublicacion.Value = DateTime.Now;
            }
        }
    }
}

