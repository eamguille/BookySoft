using sistema_gestion_biblioteca.Classes;
using sistema_gestion_biblioteca.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestion_biblioteca.Forms
{
    public partial class FrmGestionUsuarios : Form
    {
        // Definimos una lista donde se almacenan los usuarios
        private List<Usuario> listaUsuarios;
        private UsuarioController objUsuario;

        public FrmGestionUsuarios()
        {
            InitializeComponent();
            objUsuario = new UsuarioController();
            listaUsuarios = objUsuario.CargarDatosDesdeArchivo();
            ActualizarDataGrid();
        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        void guardarUsuario()
        {
            try
            {
                Usuario registro = new Usuario
                {
                    nombres = txtNombres.Text,
                    apellidos = txtApellidos.Text,
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text,
                    email = txtEmail.Text
                };

                listaUsuarios.Add(registro);
                ActualizarDataGrid();
                objUsuario.guardarDatosEnArchivoJson(listaUsuarios);
                MessageBox.Show("Usuario guardado con exito", "Tarea Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al guardar los datos {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void eliminarUsuario()
        {
            if (MessageBox.Show("Deseas eliminar el usuario ?", "Confirmacion de eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Verificamos que exista un registro seleccionado
                if (dgUsuarios.SelectedRows.Count > 0)
                {
                    // Obtenemos el indice de la fila seleccionada
                    int index = dgUsuarios.SelectedRows[0].Index;

                    // Obtenemos el registro correspondiente a la fila seleccionada
                    Usuario eliminacion = listaUsuarios[index];


                    // Eliminamos el usuario de la lista
                    listaUsuarios.Remove(eliminacion);

                    // Actualizamos el DataGridView
                    ActualizarDataGrid();

                    // Guardamos la lista actualizada en el JSON
                    objUsuario.guardarDatosEnArchivoJson(listaUsuarios);
                }
            }
        }

        void actualizarUsuario()
        {
            try
            {
                // Verificamos que el registro haya sido seleccionado por medio del txtIDUsuario
                if (int.TryParse(txtIDUsuario.Text, out int index))
                {
                    // Obtenemos el usuario seleccionado con el indice recien convertido
                    Usuario actualizar = listaUsuarios[index];

                    // Podremos actualizar los campos
                    actualizar.nombres = txtNombres.Text;
                    actualizar.apellidos = txtApellidos.Text;
                    actualizar.direccion = txtDireccion.Text;
                    actualizar.telefono = txtTelefono.Text;
                    actualizar.email = txtEmail.Text;

                    ActualizarDataGrid();

                    // Guardamos la lista actualizada en el archivo JSON
                    objUsuario.guardarDatosEnArchivoJson(listaUsuarios);

                    MessageBox.Show("Usuario actulizado con exito", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al actualizar el usuario {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ActualizarDataGrid()
        {
            dgUsuarios.DataSource = null;
            dgUsuarios.DataSource = listaUsuarios;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            guardarUsuario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarUsuario();
        }

        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtenemos el usuario de la lista
                Usuario fila = listaUsuarios[e.RowIndex];

                // Cargamos los datos de la fila seleccionada en los campos
                txtNombres.Text = fila.nombres;
                txtApellidos.Text = fila.apellidos;
                txtDireccion.Text = fila.direccion;
                txtTelefono.Text = fila.telefono;
                txtEmail.Text = fila.email;

                // Almacenamos el indice de usuario seleccionado
                txtIDUsuario.Text = e.RowIndex.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarUsuario();
        }


        // Aqui limpiamos todos los campos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtIDUsuario.Clear();
        }
    }
}
