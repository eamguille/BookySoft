using sistema_gestion_biblioteca.Controlador;
using sistema_gestion_biblioteca.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace sistema_gestion_biblioteca.Forms
{
    public partial class FrmGestionUsuarios : Form
    {
        private usuarioControlador obj_controlador;
        private int indexDataGrid = -1;
        private BindingSource enlaceDatos = new BindingSource();

        public FrmGestionUsuarios()
        {
            InitializeComponent();
            obj_controlador = new usuarioControlador();
            ActualizarDataGrid();
        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            txtTelefono.Text = "----";
            txtTelefono.SelectionStart = 0;
        }

        void ActualizarDataGrid()
        {
            var listaUsuarios = obj_controlador.ObtenerUsuarios();
            enlaceDatos.DataSource = listaUsuarios;
            dgUsuarios.DataSource = enlaceDatos;
        }

        void guardarUsuario()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar el usuario.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!EsValidoTexto(txtNombres.Text) || !EsValidoTexto(txtApellidos.Text))
                {
                    MessageBox.Show("Los campos de nombres y apellidos solo pueden contener letras y espacios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!EsFormatoEmailValido(txtEmail.Text))
                {
                    MessageBox.Show("Por favor, ingrese el dato en formato de email en este campo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var usuario = new usuarioModelo
                {
                    nombres = txtNombres.Text,
                    apellidos = txtApellidos.Text,
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text,
                    email = txtEmail.Text,
                    Usuario = txtUsuario.Text,
                    Clave = txtClave.Text
                };

                bool guardado = obj_controlador.AlmacenarRegistro(usuario);

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

        void eliminarUsuario()
        {
            try
            {
                if (MessageBox.Show("Deseas eliminar el usuario ?", "Confirmacion de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgUsuarios.SelectedRows.Count > 0)
                    {
                        if (indexDataGrid >= 0)
                        {
                            bool eliminar = obj_controlador.EliminarUsuario(indexDataGrid);

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

        void actualizarUsuario()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txtClave.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de actualizar el usuario.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!EsValidoTexto(txtNombres.Text) || !EsValidoTexto(txtApellidos.Text))
                {
                    MessageBox.Show("Los campos de nombres y apellidos solo pueden contener letras y espacios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!EsFormatoEmailValido(txtEmail.Text))
                {
                    MessageBox.Show("Por favor, ingrese el dato en formato de email en este campo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (indexDataGrid >= 0)
                {
                    var usuarioActualizado = new usuarioModelo { nombres = txtNombres.Text, apellidos = txtApellidos.Text, direccion = txtDireccion.Text, telefono = txtTelefono.Text, email = txtEmail.Text, Usuario = txtUsuario.Text, Clave = txtClave.Text };
                    bool actualizar = obj_controlador.ActualizarUsuario(indexDataGrid, usuarioActualizado);

                    if (actualizar)
                    {
                        MessageBox.Show("Usuario actualizado con exito", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDataGrid();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al actualizar el usuario {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void filtrarUsuario(string filtro_buscador)
        {
            List<usuarioModelo> listaUsuarios = obj_controlador.ObtenerUsuarios();
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

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgUsuarios.Rows[e.RowIndex];

                txtNombres.Text = fila.Cells[0].Value?.ToString() ?? string.Empty;
                txtApellidos.Text = fila.Cells[1].Value?.ToString() ?? string.Empty;
                txtDireccion.Text = fila.Cells[2].Value?.ToString() ?? string.Empty;
                txtTelefono.Text = fila.Cells[3].Value?.ToString() ?? string.Empty;
                txtEmail.Text = fila.Cells[4].Value?.ToString() ?? string.Empty;
                txtUsuario.Text = fila.Cells[5].Value?.ToString() ?? string.Empty;
                txtClave.Text = fila.Cells[6].Value?.ToString() ?? string.Empty;

                indexDataGrid = e.RowIndex;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtUsuario.Clear();
            txtClave.Clear();
        }

        private bool EsValidoTexto(string texto)
        {
            return !string.IsNullOrWhiteSpace(texto) && texto.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private bool EsFormatoEmailValido(string email)
        {
            var regex = new System.Text.RegularExpressions.Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");
            return regex.IsMatch(email);
        }

        private void ValidarSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en este campo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void validarCampoTelefono()
        {
            int cursorPos = txtTelefono.SelectionStart;
            string textoLimpio = new string(txtTelefono.Text.Where(c => char.IsDigit(c) || c == '-').ToArray());
            int indexGuion = textoLimpio.IndexOf('-');
            if (indexGuion != 4)
            {
                textoLimpio = textoLimpio.Replace("-", "");
                if (textoLimpio.Length > 4)
                {
                    textoLimpio = textoLimpio.Insert(4, "-");
                }
            }
            if (textoLimpio.Length > 9)
            {
                textoLimpio = textoLimpio.Substring(0, 9);
            }
            txtTelefono.Text = textoLimpio;
            txtTelefono.SelectionStart = txtTelefono.Text.Length;
        }

        private void txtTelefono_TextChanged_1(object sender, EventArgs e)
        {
            validarCampoTelefono();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (!EsFormatoEmailValido(txtEmail.Text))
            {
                MessageBox.Show("Por favor, ingrese el dato en formato de email en este campo.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
