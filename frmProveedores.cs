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
    public partial class frmProveedores : Form
    {
        Utils utils = new Utils();
        ProveedorCard[] proveedores;
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cargarProveedores();
        }

        private void cargarProveedores()
        {
            proveedores = new ProveedorCard[10];
            for (int i = 0; i < proveedores.Length; i++)
            {
                proveedores[i] = new ProveedorCard();
                proveedores[i].Name = "ProveedorCard" + i.ToString();
                proveedores[i].NomProveedor = "Shopping Center " + i.ToString();
                proveedores[i].TelProveedor = "2598-9862";
                proveedores[i].CorrProveedor = "shoppingc@gmail.com";
                proveedores[i].DirProveedor = "San Salvador, El Salvador";

                //Creación de btnEditar
                proveedores[i].BtnEditarProp = new Button();
                proveedores[i].ButtonClickEditar += new EventHandler(btnEditar_ButtonClick);

                void btnEditar_ButtonClick(object sender, EventArgs e)
                {
                    //Manejar evento
                    ProveedorCard proveedorCardItem = ((ProveedorCard)sender);
                    this.txtNomProveedor.Text = proveedorCardItem.Name + "Editar";

                    //Hacer consulta en la BD del registro seleccionado

                    //Abrimos el formulario para modificar el producto
                    Utils utils = new Utils();
                    utils.setFormToPanelFormularioHijo(new frmModProveedores());

                }

                //Creación de btnEliminar
                proveedores[i].BtnEliminarProp = new Button();
                proveedores[i].ButtonClickEliminar += new EventHandler(btnEliminar_ButtonClick);

                void btnEliminar_ButtonClick(object sender, EventArgs e)
                {
                    //Manejar evento
                    ProveedorCard proveedorCardItem = ((ProveedorCard)sender);
                    this.txtNomProveedor.Text = proveedorCardItem.Name + "Eliminar";
                    proveedorCardItem.Dispose();
                }

                //Agregamos el ProveedorCard al FlowLAyoutPanel
                flpListadoProveedores.Controls.Add(proveedores[i]);
            }
        }

        private void txtNomProveedor_TextChanged(object sender, EventArgs e)
        {
            utils.filtrarCardsProveedores(proveedores, txtNomProveedor);
        }
    }
}
