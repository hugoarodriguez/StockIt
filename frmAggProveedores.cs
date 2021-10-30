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
    public partial class frmAggProveedores : Form
    {
        Utils utils = new Utils();
        public frmAggProveedores()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
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
                        //Actualizamos el proveedor
                        EProveedor eProveedor = new EProveedor();
                        eProveedor.NombreProveedor = txtNomProveedor.Text.Trim().ToUpper();
                        eProveedor.TelefonoProveedor = mskNumProveedor.Text.Trim();
                        eProveedor.DireccionProveedor = txtDirProveedor.Text.Trim().ToUpper();
                        eProveedor.CorreoProveedor = txtCorreoProveedor.Text.Trim();

                        int r = new LProveedores().InsertarProveedor(utils.getIdUsuario(), eProveedor);

                        if (r > 0)
                        {
                            //Mensaje de registro exitoso
                            utils.messageBoxOperacionExitosa("El proveedor se ha registrado satisfactoriamente.");
                            limpiarCampos();
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
                            utils.messageBoxAlerta("No se pudo insertar el proveedor. Intente más tarde.");
                        }
                        else
                        {
                            utils.messageBoxOperacionSinExito("Hubo un error. Intente más tarde.");
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
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtNomProveedor.Text = null;
            mskNumProveedor.Text = null;
            txtDirProveedor.Text = null;
            txtCorreoProveedor.Text = null;
            txtNomProveedor.Focus();
        }
    }
}
