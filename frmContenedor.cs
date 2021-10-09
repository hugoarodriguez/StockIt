using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt
{
    public partial class frmContenedor : Form
    {
        public frmContenedor()
        {
            InitializeComponent();
        }

        private void frmContenedor_Load(object sender, EventArgs e)
        {

        }
        
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            //Validar inicio de sesión
            abrirFormularioHijo(new frmPrincipal());
            limpiarControles();
        }

        //Limpiar controles del formulario
        private void limpiarControles()
        {
            txtUsuario.Text = null;
            txtPassword.Text = null;
        }

        private Form formularioActivo = null;

        //Permite abrir y cerrar formularios en el panel llamado "panelFormularioHijoC"
        private void abrirFormularioHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelFormularioHijoC.Controls.Add(formularioHijo);
            panelFormularioHijoC.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }
    }
}
