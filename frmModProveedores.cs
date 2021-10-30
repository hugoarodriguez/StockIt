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
    public partial class frmModProveedores : Form
    {
        Utils utils = new Utils();
        public int ID_PROVEEDOR;
        EProveedor eProveedorInicial;

        public frmModProveedores()
        {
            InitializeComponent();
        }

        private void frmModProveedores_Load(object sender, EventArgs e)
        {
            datosIniciales();
        }

        private void datosIniciales()
        {
            eProveedorInicial = new LProveedores().SeleccionarProveedorById(ID_PROVEEDOR);
            txtNomProveedor.Text = eProveedorInicial.NombreProveedor;
            mskNumProveedor.Text = eProveedorInicial.TelefonoProveedor;
            txtDirProveedor.Text = eProveedorInicial.DireccionProveedor;
            txtCorreoProveedor.Text = eProveedorInicial.CorreoProveedor;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string numProveedor = mskNumProveedor.Text.Trim();

            if (txtNomProveedor.Text.Trim() == "" || numProveedor.Length < 9 || txtDirProveedor.Text.Trim() == "" || txtCorreoProveedor.Text.Trim() == "")
            {
                if (txtNomProveedor.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir el nombre del proveedor.");
                    txtNomProveedor.Focus();
                }
                else if (numProveedor.Length < 9)
                {
                    utils.messageBoxCampoRequerido("Debes escribir el número de teléfono del proveedor.");
                    mskNumProveedor.Focus();
                }
                else if (txtDirProveedor.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir la dirección del proveedor.");
                    txtDirProveedor.Focus();
                }
                else if (txtCorreoProveedor.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir el correo electrónico del proveedor.");
                    txtCorreoProveedor.Focus();
                }
            }
            else
            {
                try
                {
                    //Validamos email
                    string email = txtCorreoProveedor.Text.Trim();
                    if (utils.validarEmail(email))
                    {

                        if (eProveedorInicial.NombreProveedor != txtNomProveedor.Text.Trim() ||
                            eProveedorInicial.TelefonoProveedor != mskNumProveedor.Text.Trim() ||
                            eProveedorInicial.DireccionProveedor != txtDirProveedor.Text.Trim() ||
                            eProveedorInicial.CorreoProveedor != txtCorreoProveedor.Text.Trim())
                        {
                            //Actualizamos el proveedor
                            EProveedor eProveedor = new EProveedor();
                            eProveedor.IdProveedor = ID_PROVEEDOR;
                            eProveedor.NombreProveedor = txtNomProveedor.Text.Trim().ToUpper();
                            eProveedor.TelefonoProveedor = mskNumProveedor.Text.Trim();
                            eProveedor.DireccionProveedor = txtDirProveedor.Text.Trim().ToUpper();
                            eProveedor.CorreoProveedor = txtCorreoProveedor.Text.Trim();

                            int r = new LProveedores().ActualizarProveedor(utils.getIdUsuario(), eProveedor);

                            if (r > 0)
                            {
                                //Mensaje de actualización exitosa
                                utils.messageBoxOperacionExitosa("El proveedor se ha actualizado satisfactoriamente.");
                                limpiarCampos();
                                utils.setFormToPanelFormularioHijo(new frmProveedores());
                            }
                            else if (r == -1)
                            {
                                utils.messageBoxAlerta("No se puede asignar el telefono \"" + eProveedor.TelefonoProveedor + "\" al proveedor." +
                                    "\nHay uno existente con idéntico telefono.");
                            }
                            else if (r == -2)
                            {
                                utils.messageBoxAlerta("No se puede asignar el correo \"" + eProveedor.CorreoProveedor + "\" al proveedor." +
                                    "\nHay uno existente con idéntico correo.");
                            }
                            else if (r == -3)
                            {
                                utils.messageBoxAlerta("No se pudo actualizar el proveedor. Intente más tarde.");
                            }
                            else
                            {
                                utils.messageBoxOperacionSinExito("Hubo un error. Intente más tarde.");
                            }
                        }
                        else
                        {
                            utils.messageBoxAlerta("Debes modificar el menos uno de los datos para efectuar la actualización.");
                            txtNomProveedor.Focus();
                        }

                    }
                    else
                    {
                        utils.messageBoxFormatoIncorrecto("El formato de correo ingresado no es válido.");
                        txtCorreoProveedor.Focus();
                    }

                }
                catch (Exception)
                {
                    utils.messageBoxFormatoIncorrecto("El formato de correo ingresado no es válido.");
                    txtCorreoProveedor.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = utils.getMessageBoxCancelarOperacion("¿Quieres cancelar la actualización del proveedor? \nSe perderán todos los cambios que no se guardaron.");
            if (dialogResult == DialogResult.Yes)
            {
                //Cargamos el frmProveedores
                utils.setFormToPanelFormularioHijo(new frmProveedores());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            datosIniciales();
        }

        private void limpiarCampos()
        {
            //Reestablecer campos a los valores iniciales obtenidos de la BD
            txtNomProveedor.Text = null;
            mskNumProveedor.Text = null;
            txtDirProveedor.Text = null;
            txtCorreoProveedor.Text = null;
        }
    }
}
