using StockIt.CustomControls;
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
            clientes = new ClienteCard[10];
            for (int i = 0; i < clientes.Length; i++)
            {
                clientes[i] = new ClienteCard();
                clientes[i].Name = "ClienteCard" + i.ToString();
                clientes[i].NomClie = "Cliente " + i.ToString();
                clientes[i].TelClie = "7121-2321";
                clientes[i].CorrClie = "correo@mail.com";
                clientes[i].SexClie = "Masculino";

                //Creación de btnEditar
                clientes[i].BtnEditarProp = new Button();
                clientes[i].ButtonClickEditar += new EventHandler(btnEditar_ButtonClick);

                void btnEditar_ButtonClick(object sender, EventArgs e)
                {
                    //Manejar evento
                    ClienteCard clienteCardItem = ((ClienteCard)sender);
                    this.txtClientes.Text = clienteCardItem.Name + "Editar";

                    //Hacer consulta en la BD del registro seleccionado

                    //Abrimos el formulario para modificar el cliente según el ID
                    Utils utils = new Utils();
                    utils.setFormToPanelFormularioHijo(new frmModClientes());
                }

                //Creación de btnEliminar
                clientes[i].BtnEliminarProp = new Button();
                clientes[i].ButtonClickEliminar += new EventHandler(btnEliminar_ButtonClick);

                void btnEliminar_ButtonClick(object sender, EventArgs e)
                {
                    //Manejar evento
                    ClienteCard clienteCardItem = ((ClienteCard)sender);
                    this.txtClientes.Text = clienteCardItem.Name + "Eliminar";
                    clienteCardItem.Dispose();
                }

                //Agregamos el ClienteCard al FlowLAyoutPanel
                flpListadoClientes.Controls.Add(clientes[i]);
            }
        }

        private void txtClientes_TextChanged(object sender, EventArgs e)
        {
            utils.filtrarCardsClientes(clientes, txtClientes);
        }
    }
}
