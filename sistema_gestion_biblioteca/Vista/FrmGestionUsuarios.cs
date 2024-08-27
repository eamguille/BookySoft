using sistema_gestion_biblioteca.Controlador;
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
        // Creamos un objeto para mandar a llamar los metodos del controlador
        private usuarioControlador obj_controlador;

        // Iniciamos una variable para el control del DataGridView
        private int indexDataGrid = -1;
        

        public FrmGestionUsuarios()
        {
            InitializeComponent();
            obj_controlador = new usuarioControlador(); // Instanciamos el objeto del controlador
            ActualizarDataGrid();
        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        // Metodo para cargar los datos de la lista en el DataGridView
        void ActualizarDataGrid()
        {
            var listaUsuarios = obj_controlador.obtenerUsuarios();
            dgUsuarios.DataSource = listaUsuarios;
        }


        void guardarUsuario()
        {
            try
            {
                bool guardado = obj_controlador.almacenarRegistro(txtNombres.Text, txtApellidos.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);

                if (guardado)
                {
                    MessageBox.Show("Usuario Agregado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ActualizarDataGrid();
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
                    // Verificamos que exista un registro seleccionado
                    if (dgUsuarios.SelectedRows.Count > 0)
                    {
                        if (indexDataGrid >= 0)
                        {
                            bool eliminar = obj_controlador.eliminarUsuario(indexDataGrid);

                            if (eliminar)
                            {
                                MessageBox.Show("Usuario eliminado exitosamente", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            ActualizarDataGrid();
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
                if (indexDataGrid >= 0)
                {
                     bool actualizar = obj_controlador.actualizarUsuario(indexDataGrid, txtNombres.Text, txtApellidos.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text);

                     MessageBox.Show("Usuario actulizado con exito", "Tarea exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                     ActualizarDataGrid();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Error al actualizar el usuario {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                indexDataGrid = e.RowIndex;

                var fila = dgUsuarios.Rows[e.RowIndex].Cells;
                txtNombres.Text = fila[0].Value.ToString();
                txtApellidos.Text = fila[1].Value.ToString();
                txtDireccion.Text = fila[2].Value.ToString();
                txtTelefono.Text = fila[3].Value.ToString();
                txtEmail.Text = fila[4].Value.ToString();
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
