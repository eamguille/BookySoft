using sistema_gestion_biblioteca.Controlador;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace sistema_gestion_biblioteca.Forms
{
    public partial class FrmLogin : Form
    {
        private usuarioControlador obj_controlador;
        private LoginController loginController;

        public FrmLogin()
        {
            InitializeComponent();
            obj_controlador = new usuarioControlador();
            loginController = new LoginController();
        }

        // Código para agregar la funcionalidad de arrastre del Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Clave = txtClave.Text;

            // Verificar si loginController está inicializado
            if (loginController == null)
            {
                MessageBox.Show("El controlador de inicio de sesión no está inicializado.");
                return; // Salir del método si loginController es null
            }

            // Validar las credenciales
            if (loginController.ValidarCredenciales(Usuario, Clave))
            {
                MessageBox.Show("Inicio de sesión exitoso.");

                // Crear una instancia de FrmPrincipal y mostrarla
                FrmPrincipal principalForm = new FrmPrincipal();
                principalForm.Show();

                // Ocultar el formulario de inicio de sesión
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales inválidas.");
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
