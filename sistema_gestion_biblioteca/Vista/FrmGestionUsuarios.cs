using sistema_gestion_biblioteca.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestion_biblioteca.Forms
{
    public partial class FrmGestionUsuarios : Form
    {
        // Objeto para poder usar los metodos dentro de usuarioControlador
        private usuarioControlador obj_controlador;
        // Variable que guardara el valor del indice seleccionado del dataGridView
        private int indexDataGrid = -1;
        // Objeto que guarda el enlace constante de datos con la lista
        private BindingSource enlaceDatos = new BindingSource();

        public FrmGestionUsuarios()
        {
            InitializeComponent();
            obj_controlador = new usuarioControlador();
            ActualizarDataGrid();

            // Configuracion global de cultura para el ingreso y lectura de la fecha en el formato deseado
            CultureInfo culture = new CultureInfo("es-ES");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            cargarNombresDataGrid();
            dgUsuarios.ReadOnly = true;

            // Inicializamos los textboxes con ciertos valores
            txtTelefono.Text = "----";
            txtTelefono.SelectionStart = 0;
        }

        // Método para cargar los datos de la lista en el DataGridView
        void ActualizarDataGrid()
        {
            var listaUsuarios = obj_controlador.obtenerUsuarios();
            enlaceDatos.DataSource = listaUsuarios;
            dgUsuarios.DataSource = enlaceDatos;
        }

        // Agregamos titulos a cada columna
        void cargarNombresDataGrid()
        {
            dgUsuarios.Columns[0].HeaderText = "Nombres";
            dgUsuarios.Columns[1].HeaderText = "Apellidos";
            dgUsuarios.Columns[2].HeaderText = "Direccion";
            dgUsuarios.Columns[3].HeaderText = "Telefono";
            dgUsuarios.Columns[4].HeaderText = "Correo";
            dgUsuarios.Columns[5].Visible = false;
        }

        // Método para guardar el usuario
        void guardarUsuario()
        {
            try
            {
                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar el usuario.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método sin guardar
                }

                // Validar campos de texto
                if (!EsValidoTexto(txtNombres.Text) || !EsValidoTexto(txtApellidos.Text))
                {
                    MessageBox.Show("Los campos de nombres y apellidos solo pueden contener letras y espacios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método sin guardar
                }

                // Validar email
                if (!EsFormatoEmailValido(txtEmail.Text))
                {
                    MessageBox.Show("Por favor, ingrese el dato en formato de email en este campo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método sin guardar
                }

                var validarDuplicados = obj_controlador.validarUsariosDuplicados(txtEmail.Text, txtTelefono.Text);
                if (validarDuplicados)
                {
                    MessageBox.Show("El usuario ya existe.", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Codigo para guardar la fecha actual para la fecha de registro
                string fecha_actual = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);

                bool guardado = obj_controlador.almacenarRegistro(txtNombres.Text, txtApellidos.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, DateTime.Parse(fecha_actual).Date);

                if (guardado)
                {
                    MessageBox.Show("Usuario Agregado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGrid();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al guardar los datos {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para eliminar el usuario
        void eliminarUsuario()
        {
            try
            {
                if (MessageBox.Show("Deseas eliminar el usuario ?", "Confirmacion de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgUsuarios.CurrentCell != null)
                    {
                        if (indexDataGrid >= 0)
                        {
                            bool eliminar = obj_controlador.eliminarUsuario(indexDataGrid);

                            if (eliminar)
                            {
                                MessageBox.Show("Usuario eliminado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ActualizarDataGrid();
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se ha logrado eliminar el usuario {e.Message}", "Tarea sin exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para actualizar el usuario
        void actualizarUsuario()
        {
            try
            {
                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de actualizar el usuario.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método sin actualizar
                }

                // Validar campos de texto
                if (!EsValidoTexto(txtNombres.Text) || !EsValidoTexto(txtApellidos.Text))
                {
                    MessageBox.Show("Los campos de nombres y apellidos solo pueden contener letras y espacios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método sin actualizar
                }

                // Validar email
                if (!EsFormatoEmailValido(txtEmail.Text))
                {
                    MessageBox.Show("Por favor, ingrese el dato en formato de email en este campo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Salir del método sin actualizar
                }

                if (indexDataGrid >= 0)
                {
                    bool actualizar = obj_controlador.actualizarUsuario(indexDataGrid, txtNombres.Text, txtApellidos.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);

                    MessageBox.Show("Usuario actualizado con exito", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGrid();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al actualizar el usuario {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para filtrar usuarios en el DataGridView
        void filtrarUsuario(string filtro_buscador)
        {
            var listaUsuarios = obj_controlador.obtenerUsuarios();
            if (string.IsNullOrEmpty(filtro_buscador))
            {
                enlaceDatos.DataSource = listaUsuarios;
            }
            else
            {
                var busqueda = filtro_buscador.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var listaFiltrada = listaUsuarios.Where(ele =>
                    busqueda.All(t =>
                        (ele.nombres != null && ele.nombres.Contains(t, StringComparison.OrdinalIgnoreCase)) ||
                        (ele.apellidos != null && ele.apellidos.Contains(t, StringComparison.OrdinalIgnoreCase)) ||
                        (ele.email != null && ele.email.Contains(t, StringComparison.OrdinalIgnoreCase))
                    )
                ).ToList();

                if (listaFiltrada.Any())
                {
                    enlaceDatos.DataSource = listaFiltrada;
                }
            }

            dgUsuarios.DataSource = enlaceDatos;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrarUsuario(txtBuscar.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            guardarUsuario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarUsuario();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarUsuario();
        }

        // Evento CellClick para capturar los valores del dataGrid en los campos respectivos
        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgUsuarios.Rows[e.RowIndex].Cells[0].Value != null)
            {
                indexDataGrid = e.RowIndex;

                var fila = dgUsuarios.Rows[e.RowIndex].Cells;
                txtNombres.Text = fila[0].Value.ToString();
                txtApellidos.Text = fila[1].Value.ToString();
                txtDireccion.Text = fila[2].Value.ToString();
                txtTelefono.Text = fila[3].Value.ToString();
                txtEmail.Text = fila[4].Value.ToString();
            } else
            {
                indexDataGrid = -1;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        // Validar que el texto solo contenga letras y espacios
        private bool EsValidoTexto(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto) && texto.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        // Validar el formato del email
        private bool EsFormatoEmailValido(string email)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");
            return regex.IsMatch(email);
        }

        // Validar que solo se permitan letras en los campos de nombres y apellidos
        private void ValidarSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en este campo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Validar el formato del teléfono cuando el usuario cambia el texto
        void validarCampoTelefono()
        {
            // Guardar la posición del cursor
            int cursorPos = txtTelefono.SelectionStart;

            // Eliminar cualquier carácter que no sea un número o guion
            string textoLimpio = new string(txtTelefono.Text.Where(c => char.IsDigit(c) || c == '-').ToArray());

            // Asegurarse de que solo haya un guion
            int indexGuion = textoLimpio.IndexOf('-');
            if (indexGuion != 4)    
            {
                textoLimpio = textoLimpio.Replace("-", ""); // Remueve todos los guiones
                if (textoLimpio.Length > 4)
                {
                    textoLimpio = textoLimpio.Insert(4, "-"); // Inserta el guion en la posición correcta
                }
            }

            // Limitar la longitud máxima a 9 caracteres
            if (textoLimpio.Length > 9)
            {
                textoLimpio = textoLimpio.Substring(0, 9);
            }

            // Actualizar el texto del TextBox
            txtTelefono.Text = textoLimpio;
            txtTelefono.SelectionStart = txtTelefono.Text.Length;
        }

        private void txtTelefono_TextChanged_1(object sender, EventArgs e)
        {
            validarCampoTelefono();
        }

        // Validar el formato del email cuando el usuario cambia el texto
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!EsFormatoEmailValido(txtEmail.Text))
            {
                MessageBox.Show("Por favor, ingrese el dato en formato de email en este campo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
