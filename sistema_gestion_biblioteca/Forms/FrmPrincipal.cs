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

        private void button6_Click(object sender, EventArgs e)
        {

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

        private void btnRegistroLibros_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmRegistroLibros());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmInicio());
        }

        private void btnConsultaLibros_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmConsultaLibros());
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(new FrmGestionUsuarios());
        }
    }
}
