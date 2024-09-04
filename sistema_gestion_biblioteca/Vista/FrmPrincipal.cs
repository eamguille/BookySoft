using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_gestion_biblioteca.Vista;

namespace sistema_gestion_biblioteca.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        // Evento del cargar para el formulario
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        // Metodo para abrir el formulario para abrir formulario para agregar libros
        private void abrirFormularioHijo(object obj_form)
        {
            if (this.PnContenedor.Controls.Count > 0)
                this.PnContenedor.Controls.RemoveAt(0);

            Form myForm = obj_form as Form;
            myForm.TopLevel = false;
            myForm.Dock = DockStyle.Fill;
            this.PnContenedor.Controls.Add(myForm);
            this.PnContenedor.Tag = myForm;
            myForm.Show();
        }

        // Creamos un metodo para la seleccion de la barra de navegacion
        private void seleccinarBoton(Button obj_btn)
        {
            Color primerColor = Color.FromArgb(26, 32, 40);
            Color segundoColor = Color.FromArgb(0, 80, 200);

            List<Button> listaBotones = new List<Button> { btnRegistroLibros, btnConsultaLibros, btnGestionUsuarios, btnGestionPrestamos, btnHistorialPrestamos, btnGestionDev, btnHistorialDev };

            // Recorremos cada boton para su seleccion
            foreach (Button boton in listaBotones)
            {
                boton.BackColor = primerColor;
            }

            // Cambiamos el color de fondo al color seleccionado
            obj_btn.BackColor = segundoColor;
        }

        private void btnRegistroLibros_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmRegistroLibros());
            seleccinarBoton(btnRegistroLibros);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmInicio());
        }

        private void btnConsultaLibros_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmConsultaLibros());
            seleccinarBoton(btnConsultaLibros);
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmGestionUsuarios());
            seleccinarBoton(btnGestionUsuarios);
        }

        private void btnHistorialPrestamos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmHistorialPrestamos());
            seleccinarBoton(btnHistorialPrestamos);
        }

        private void btnSalirSesion_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnGestionDev_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmGestionDevoluciones());
            seleccinarBoton(btnGestionDev);
        }

        private void btnHistorialDev_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmHistorialDevoluciones());
            seleccinarBoton(btnHistorialDev);
        }

        private void btnGestionPrestamos_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmPrestamos());
            seleccinarBoton(btnGestionPrestamos);
        }
    }
}
