using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockIt_Entidades;
using StockIt_Logica;

namespace StockIt
{
    public partial class frmRecuperarCuenta : Form
    {
        Utils utils = new Utils();

        public frmRecuperarCuenta()
        {
            InitializeComponent();
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            //Abrir ventana modal que muestra contraseña temporal (si el correo es válido y existe en la BD)
            try
            {
                if (txtCorreo.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes escribir tu correo electrónico.");
                    txtCorreo.Focus();
                }
                else
                {
                    string email = txtCorreo.Text.Trim();
                    if (utils.validarEmail(email))
                    {
                        //Validar la existencia del email en la BD
                        EUsuario eUsuario = new EUsuario();
                        eUsuario.Correo = email;

                        string r = new LUsuarios().AsignarPasswordTemporal(eUsuario);

                        if (r.Length > 2)
                        {
                            //Si el correo existe mostrar la clave temporal
                            this.Close();
                            frmClaveTemporal frmClaveTemporal = new frmClaveTemporal();
                            frmClaveTemporal.txtConTemp.Text = r;
                            frmClaveTemporal.Show();
                        }
                        else if (r == "-1")
                        {
                            utils.messageBoxAlerta("No existe ningún usuario registrado con ese correo electrónico.");
                            txtCorreo.Focus();
                        }
                        else if (r == "-2")
                        {
                            utils.messageBoxAlerta("No se pudo asignar una password temporal." +
                                "\nIntente más tarde.");
                            txtCorreo.Focus();
                        }
                        else
                        {
                            utils.messageBoxAlerta("Hubo un error. Intente más tarde.");
                            this.Close();
                        }
                    }
                    else
                    {
                        utils.messageBoxFormatoIncorrecto("El formato de correo ingresado no es válido.");
                        txtCorreo.Focus();
                    }
                }
                    
            }
            catch (Exception)
            {
                utils.messageBoxFormatoIncorrecto("El formato de correo ingresado no es válido.");
                txtCorreo.Focus();
            }
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
    }
}
