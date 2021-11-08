using StockIt.CustomControls;
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
    public partial class frmClientes : Form
    {
        Utils utils = new Utils();
        ClienteCard[] clientes;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }

        private void cargarClientes()
        {
            List<ECliente> eClientesList = new LClientes().SeleccionarClientesActivosByIdUsuario(utils.getIdUsuario());

            if(eClientesList.Count > 0)
            {
                clientes = new ClienteCard[eClientesList.Count];
                for (int i = 0; i < clientes.Length; i++)
                {
                    clientes[i] = new ClienteCard();
                    clientes[i].Name = eClientesList[i].IdCliente.ToString();
                    clientes[i].NomClie = eClientesList[i].NombreCliente + " " + eClientesList[i].ApellidoCliente;
                    clientes[i].TelClie = eClientesList[i].TelefonoCliente;
                    clientes[i].CorrClie = eClientesList[i].CorreoCliente;
                    clientes[i].SexClie = eClientesList[i].SexoCliente == "M" ? "MASCULINO" : "FEMENINO";

                    //Creación de btnEditar
                    clientes[i].BtnEditarProp = new Button();
                    clientes[i].ButtonClickEditar += new EventHandler(btnEditar_ButtonClick);

                    void btnEditar_ButtonClick(object sender, EventArgs e)
                    {
                        //Manejar evento
                        ClienteCard clienteCardItem = ((ClienteCard)sender);
                        this.txtClientes.Text = clienteCardItem.Name + "Editar";

                        //Abrimos el formulario para modificar el cliente según el ID
                        Utils utils = new Utils();
                        frmModClientes frmModClientes = new frmModClientes();
                        frmModClientes.ID_CLIENTE = int.Parse(clienteCardItem.Name);
                        utils.setFormToPanelFormularioHijo(frmModClientes);
                    }

                    //Creación de btnEliminar
                    clientes[i].BtnEliminarProp = new Button();
                    clientes[i].ButtonClickEliminar += new EventHandler(btnEliminar_ButtonClick);

                    void btnEliminar_ButtonClick(object sender, EventArgs e)
                    {
                        //Manejar evento
                        ClienteCard clienteCardItem = ((ClienteCard)sender);
                        DialogResult dialogResult = utils.getMessageBoxAlerta("¿Estás seguro que deseas eliminar el cliente" +
                            " \"" + clienteCardItem.NomClie + "\"?");
                        if (dialogResult == DialogResult.Yes)
                        {
                            ECliente eCliente = new ECliente();
                            eCliente.IdCliente = int.Parse(clienteCardItem.Name);

                            int r = new LClientes().EliminarCliente(eCliente);

                            if (r > 0)
                            {
                                clienteCardItem.Dispose();
                                utils.messageBoxOperacionExitosa("Se eliminó el cliente \"" + clienteCardItem.NomClie + "\" " +
                                    "con número de teléfono " + clienteCardItem.TelClie + ".");
                            }
                            else if (r == -1)
                            {
                                utils.messageBoxAlerta("No se puede eliminar este cliente, " +
                                    "\nse encuentra relacionado con reservas sin facturar.");
                            }
                            else
                            {
                                utils.messageBoxOperacionSinExito("Hubo un error. Intente más tarde.");
                            }
                        }
                    }

                    //Agregamos el ClienteCard al FlowLAyoutPanel
                    flpListadoClientes.Controls.Add(clientes[i]);
                }
            }
        }

        private void txtClientes_TextChanged(object sender, EventArgs e)
        {
            utils.filtrarCardsClientes(clientes, txtClientes);
        }
    }
}
