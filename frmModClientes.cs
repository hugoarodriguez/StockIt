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
    public partial class frmModClientes : Form
    {
        Utils utils = new Utils();
        public frmModClientes()
        {
            InitializeComponent();
        }

        private void frmModClientes_Load(object sender, EventArgs e)
        {
            //Llenar los datos del formulario
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string numClie = mskNumClie.Text.Trim();

            if (txtNomClie.Text.Trim() == "" || txtApeClie.Text.Trim() == "" || cbxSexoClie.SelectedIndex == 0
                || numClie.Length < 9 || txtCorreoClie.Text.Trim() == "")
            {
                if (txtNomClie.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir el/los nombre(s) del cliente.");
                    txtNomClie.Focus();
                }
                else if (txtApeClie.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir el/los apellido(s) del cliente.");
                    txtApeClie.Focus();
                }
                else if (cbxSexoClie.SelectedIndex == 0)
                {
                    utils.messageBoxCampoRequerido("Debes seleccionar el sexo del cliente.");
                    cbxSexoClie.Focus();
                }
                else if (numClie.Length < 9)
                {
                    utils.messageBoxCampoRequerido("Debes escribir el número de teléfono del cliente.");
                    mskNumClie.Focus();
                }
                else if (txtCorreoClie.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir el correo electrónico del cliente.");
                    txtCorreoClie.Focus();
                }
            }
            else
            {
                try
                {
                    //Validamos email
                    string email = txtCorreoClie.Text.Trim();
                    if (utils.validarEmail(email))
                    {
                        //Actualizamos el cliente


                        //Mensaje de registro exitoso
                        utils.messageBoxOperacionExitosa("El cliente se ha actualizado satisfactoriamente.");
                        reestablecerDatos();
                        utils.setFormToPanelFormularioHijo(new frmClientes());
                    }
                    else
                    {
                        utils.messageBoxFormatoIncorrecto("El formato de correo ingresado no es válido.");
                        txtCorreoClie.Focus();
                    }

                }
                catch (Exception)
                {
                    utils.messageBoxFormatoIncorrecto("El formato de correo ingresado no es válido.");
                    txtCorreoClie.Focus();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            reestablecerDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = utils.getMessageBoxCancelarOperacion("¿Quieres cancelar la actualización del cliente? \nSe perderán todos los cambios que no se guardaron.");
            if (dialogResult == DialogResult.Yes)
            {
                //Cargamos el frmClientes
                utils.setFormToPanelFormularioHijo(new frmClientes());
            }
        }

        //Limpiar campos
        private void reestablecerDatos()
        {
            //Cambiar esto por reestablecer los datos a los guardados actualmente en la BD
            txtNomClie.Text = null;
            txtApeClie.Text = null;
            //cbxSexoClie.SelectedIndex = 0;
            mskNumClie.Text = null;
            txtCorreoClie.Text = null;
        }
    }
}
