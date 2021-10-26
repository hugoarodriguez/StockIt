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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {
            ProductoCard[] productos = new ProductoCard[10];
            for (int i = 0; i < productos.Length; i++)
            {
                productos[i] = new ProductoCard();
                productos[i].Name = "ProductoCard" + i.ToString();
                productos[i].NomProd = "Camiseta Verde " + i.ToString();
                productos[i].CatProd = "Camisetas";
                productos[i].CanProd = 5;
                productos[i].PreProd = 8.50;

                //Creación de btnEditar
                productos[i].BtnEditarProp = new Button();
                productos[i].ButtonClickEditar += new EventHandler(btnEditar_ButtonClick);

                void btnEditar_ButtonClick(object sender, EventArgs e)
                {
                    //Manejar evento
                    ProductoCard productoCardItem = ((ProductoCard)sender);
                    this.txtNomProd.Text = productoCardItem.Name + "Editar";

                    //Hacer consulta en la BD del registro seleccionado

                    //Abrimos el formulario para modificar el producto
                    Utils utils = new Utils();
                    utils.setFormToPanelFormularioHijo(new frmModificarProductos());

                }

                //Creación de btnEliminar
                productos[i].BtnEliminarProp = new Button();
                productos[i].ButtonClickEliminar += new EventHandler(btnEliminar_ButtonClick);

                void btnEliminar_ButtonClick(object sender, EventArgs e)
                {
                    //Manejar evento
                    ProductoCard productoCardItem = ((ProductoCard)sender);
                    this.txtNomProd.Text = productoCardItem.Name + "Eliminar";
                    productoCardItem.Dispose();
                }

                //Agregamos el ProductoCard al FlowLAyoutPanel
                flpListadoProductos.Controls.Add(productos[i]);
            }
        }

        private void txtNomProd_TextChanged(object sender, EventArgs e)
        {
            //Filtrar registros por nombre de producto mientras el usuario escriba
        }
    }
}
