using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockIt_Entidades;
using StockIt_Logica;

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
            Utils utils = new Utils();

            if (txtCorreo.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                if (txtCorreo.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir tu correo electrónico.");
                    txtCorreo.Focus();
                }
                else if(txtPassword.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir tu correo contraseña.");
                    txtPassword.Focus();
                }
            }
            else
            {
                EUsuario eUsuario = new EUsuario();
                eUsuario.Correo = txtCorreo.Text.Trim();
                eUsuario.Password = txtPassword.Text.Trim();

                int r = new LUsuarios().Login(eUsuario);

                if (r > 1)
                {
                    //Validar inicio de sesión
                    frmPrincipal frmPrincipal = new frmPrincipal();
                    frmPrincipal.lblIdUsuario.Text = r.ToString();
                    frmPrincipal.lklCorreo.Text = eUsuario.Correo;
                    abrirFormularioHijo(frmPrincipal);
                    limpiarControles();
                }
                else if(r == -1)
                {
                    utils.messageBoxAlerta("Contraseña incorrecta. Intenta nuevamente");
                    txtPassword.Focus();
                }
                else if(r == -2)
                {
                    utils.messageBoxAlerta("No existe ningún usuario registrado con ese corre electrónico.");
                    txtCorreo.Focus();
                }
                else
                {
                    utils.messageBoxAlerta("Hubo un error. Intente más tarde.");
                }
            }
        }

        //Limpiar controles del formulario
        private void limpiarControles()
        {
            txtCorreo.Text = null;
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

        private void lklPasOlv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirFormularioHijo(new frmRecuperarCuenta());
            limpiarControles();
        }

        private void lklRegistrate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirFormularioHijo(new frmRegistro());
        }
    }
}
