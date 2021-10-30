using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockIt_Logica;
using StockIt_Entidades;

namespace StockIt
{
    public partial class frmRegistro : Form
    {
        Utils utils = new Utils();
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVolver_MouseHover(object sender, EventArgs e)
        {
            btnVolver.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BorderStyle = BorderStyle.None;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text.Trim() == "" || txtApellidos.Text.Trim() == "" || txtNegocio.Text.Trim() == "" 
                || txtMail.Text.Trim() == "" || txtPassword.Text.Trim() == "" || txtPassword2.Text.Trim() == "")
            {
                if (txtNombres.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir tus nombres.");
                    txtNombres.Focus();
                }
                else if (txtApellidos.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir tus apellidos.");
                    txtApellidos.Focus();
                }
                else if (txtNegocio.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir el nombre de tu negocio.");
                    txtNegocio.Focus();
                }
                else if (txtMail.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir tu correo electrónico.");
                    txtMail.Focus();
                }
                else if (txtPassword.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir la contraseña de tu usuario.");
                    txtPassword.Focus();
                }
                else if (txtPassword2.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes confirmar la contraseña.");
                    txtPassword2.Focus();
                }
            }
            else
            {
                string correo = txtMail.Text.Trim();
                if (utils.validarEmail(correo))
                {
                    string password = txtPassword.Text.Trim();
                    if (utils.validarPassword(password))
                    {
                        string passwordC = txtPassword2.Text.Trim();
                        if (password == passwordC)
                        {
                            EUsuario eUsuario = new EUsuario();
                            eUsuario.Usuario = correo;
                            eUsuario.Nombres = txtNombres.Text.Trim().ToUpper();
                            eUsuario.Apellidos = txtApellidos.Text.Trim().ToUpper();
                            eUsuario.NombreEmpresa = txtNegocio.Text.Trim().ToUpper();
                            eUsuario.Correo = correo;
                            eUsuario.Password = password;

                            int r = new LUsuarios().CrearCuenta(eUsuario);

                            if (r == 1)
                            {
                                limpiarControles();
                                utils.messageBoxOperacionExitosa("Su usuario ha sido registrado satisfactoriamente." +
                                    "\nSerá redirigido al Login para que inicie sesión.");
                                this.Close();
                            }
                            else if (r == -1)
                            {
                                utils.messageBoxAlerta("Ya existe un usuario registrado con este correo electrónico." +
                                    "\nIntente con uno distinto.");
                                txtMail.Focus();
                            }
                            else if (r == -2)
                            {
                                utils.messageBoxAlerta("No se ha podido registrar su usuario." +
                                    "\nIntente más tarde.");
                                limpiarControles();
                                txtNombres.Focus();
                            }
                            else
                            {
                                utils.messageBoxAlerta("Hubo un error. Intente más tarde.");
                                limpiarControles();
                                this.Close();
                            }
                        }
                        else
                        {
                            utils.messageBoxAlerta("Debe repetir su contraseña correctamente.");
                            txtPassword2.Focus();
                        }
                    }
                    else
                    {
                        utils.messageBoxFormatoIncorrecto("La contraseña debe contener como mínimo: " +
                        "\n+ 8 carácteres." +
                        "\n+ Un número dígito." +
                        "\n+ Una letra minúscula." +
                        "\n+ Una letra mayúscula." +
                        "\n+ Un carácter especial (!*@#$%^&+=).");
                        txtPassword.Focus();
                    }
                }
                else
                {
                    utils.messageBoxFormatoIncorrecto("El formato del correo es inválido.");
                    txtMail.Focus();
                }
            }
        }

        private void limpiarControles()
        {
            txtNombres.Text = null;
            txtApellidos.Text = null;
            txtNegocio.Text = null;
            txtMail.Text = null;
            txtPassword.Text = null;
            txtPassword2.Text = null;
            chkbMostrarPwd.Checked = false;
        }

        private void chkbMostrarPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

            if (txtPassword2.PasswordChar == '*')
            {
                txtPassword2.PasswordChar = '\0';
            }
            else
            {
                txtPassword2.PasswordChar = '*';
            }
        }
    }
}
