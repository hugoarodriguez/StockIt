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
    public partial class frmCambiarClave : Form
    {
        public frmCambiarClave()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            string pwdActual = txtClaveA.Text.Trim();
            string pwdNueva = txtClaveN.Text.Trim();
            string pwdNuevaC = txtClaveNC.Text.Trim();

            if(pwdActual == "" || pwdNueva == "" || pwdNuevaC == "")
            {
                //Si uno de los campos está vacío
                if(pwdActual == "")
                {
                    MessageBox.Show("Debes ingresar tu contraseña actual.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtClaveA.Focus();
                }
                else if (pwdNueva == "")
                {
                    MessageBox.Show("Debes ingresar una contraseña nueva.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtClaveN.Focus();
                }
                else if (pwdNuevaC == "")
                {
                    MessageBox.Show("Debes confirmar tu contraseña.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtClaveNC.Focus();
                }
            }
            else
            {
                //Si los campos contienen datos
                //Validar formatos de contraseña con una expresión regular
                if (pwdNueva == pwdNuevaC)
                {
                    //Validar existencia de pwdActual en la BD
                    string pwdBD = "password1";
                    if(pwdActual == pwdBD)
                    {
                        MessageBox.Show("Contraseña cambiada con éxito.", "Contraseña cambiada",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClaveA.Focus();

                        //Cambiar contraseña
                        //Limpiar campos
                        limpiarControles();
                    } 
                    else
                    {
                        MessageBox.Show("La contraseña actual no coincide con la registrada.", "Contraseña actual equivocada",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtClaveA.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña actual y su confirmación deben coincidir.", "Contraseñas no coinciden",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }

        private void limpiarControles()
        {
            txtClaveA.Text = null;
            txtClaveN.Text = null;
            txtClaveNC.Text = null;
            txtClaveA.Focus();
        }
    }
}
