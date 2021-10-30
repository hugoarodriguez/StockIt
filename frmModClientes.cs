using StockIt_Entidades;
using StockIt_Logica;
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
        public int ID_CLIENTE;
        ECliente eClienteInicial;

        public frmModClientes()
        {
            InitializeComponent();
        }

        private void frmModClientes_Load(object sender, EventArgs e)
        {
            llenarCbxSexo();
            datosIniciales();
        }

        private void datosIniciales()
        {
            eClienteInicial = new LClientes().SeleccionarClienteById(ID_CLIENTE);
            txtNomClie.Text = eClienteInicial.NombreCliente;
            txtApeClie.Text = eClienteInicial.ApellidoCliente;
            cbxSexoClie.SelectedIndex = eClienteInicial.SexoCliente == "M" ? 1 : 2;
            mskNumClie.Text = eClienteInicial.TelefonoCliente;
            txtCorreoClie.Text = eClienteInicial.CorreoCliente;
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
                        string sexoCliente = cbxSexoClie.SelectedIndex == 1 ? "M" : "F";

                        //Actualizamos el cliente
                        if (eClienteInicial.NombreCliente != txtNomClie.Text.Trim().ToUpper() ||
                            eClienteInicial.ApellidoCliente != txtApeClie.Text.Trim().ToUpper() ||
                            eClienteInicial.SexoCliente != sexoCliente ||
                            eClienteInicial.TelefonoCliente != mskNumClie.Text.Trim() ||
                            eClienteInicial.CorreoCliente != txtCorreoClie.Text.Trim())
                        {
                            //Registramos el cliente
                            ECliente eCliente = new ECliente();
                            eCliente.IdCliente = ID_CLIENTE;
                            eCliente.NombreCliente = txtNomClie.Text.Trim().ToUpper();
                            eCliente.ApellidoCliente = txtApeClie.Text.Trim().ToUpper();
                            eCliente.SexoCliente = sexoCliente;
                            eCliente.TelefonoCliente = mskNumClie.Text.Trim();
                            eCliente.CorreoCliente = txtCorreoClie.Text.Trim();

                            int r = new LClientes().ActualizarCliente(utils.getIdUsuario(), eCliente);

                            if (r > 0)
                            {
                                //Mensaje de actualizción exitosa
                                utils.messageBoxOperacionExitosa("El cliente se ha actualizado satisfactoriamente.");
                                limpiarCampos();
                                utils.setFormToPanelFormularioHijo(new frmClientes());
                            }
                            else if (r == -1)
                            {
                                utils.messageBoxAlerta("No se puede asignar el telefono \"" + eCliente.TelefonoCliente + "\" al cliente." +
                                    "\nHay uno existente con idéntico telefono.");
                            }
                            else if (r == -2)
                            {
                                utils.messageBoxAlerta("No se puede asignar el correo \"" + eCliente.CorreoCliente + "\" al cliente." +
                                    "\nHay uno existente con idéntico correo.");
                            }
                            else if (r == -3)
                            {
                                utils.messageBoxAlerta("No se pudo actualizar el cliente. Intente más tarde.");
                            }
                            else
                            {
                                utils.messageBoxOperacionSinExito("Hubo un error. Intente más tarde.");
                            }
                        }
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
            datosIniciales();
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

        private void llenarCbxSexo()
        {
            cbxSexoClie.Items.Add("SELECCIONAR");
            cbxSexoClie.Items.Add("MASCULINO");
            cbxSexoClie.Items.Add("FEMENINO");
            cbxSexoClie.SelectedIndex = 0;
        }

        //Limpiar campos
        private void limpiarCampos()
        {
            txtNomClie.Text = null;
            txtApeClie.Text = null;
            cbxSexoClie.SelectedIndex = 0;
            mskNumClie.Text = null;
            txtCorreoClie.Text = null;
        }
    }
}
