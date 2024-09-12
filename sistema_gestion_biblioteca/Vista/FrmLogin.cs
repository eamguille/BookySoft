using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using sistema_gestion_biblioteca.Controlador;

namespace sistema_gestion_biblioteca.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        credencialesControlador obj_controlador = new credencialesControlador();

        // Codigo para agregar la funcionalidad de arrastre del Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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

        void validarLogin()
        {
            try
            {
                bool validar = obj_controlador.validarLogin(txtUsuario.Text, txtClave.Text);
                if (validar)
                {
                    FrmPrincipal next_form = new FrmPrincipal();
                    next_form.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Usuario o Clave incorrectos", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception e)
            {
                MessageBox.Show("Hubo un error para validar las credenciales", "Error externo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            validarLogin();
        }
    }
}
