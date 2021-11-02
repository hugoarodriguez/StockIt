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
    public partial class frmProductos : Form
    {
        Utils utils = new Utils();
        ProductoCard[] productos;
        List<ECardProducto> eCardProductosList;

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
            eCardProductosList = new LProductos().SeleccionarProductosByIdUsuarioAndEstadoProducto(utils.getIdUsuario(), "A");

            if (eCardProductosList.Count > 0)
            {
                productos = new ProductoCard[eCardProductosList.Count];
                for (int i = 0; i < productos.Length; i++)
                {
                    productos[i] = new ProductoCard();
                    productos[i].Name = eCardProductosList[i].IdProducto.ToString();
                    productos[i].ImgProd = utils.byteArrayToImage(eCardProductosList[i].Img);
                    productos[i].NomProd = eCardProductosList[i].NombreProducto;
                    productos[i].CatProd = eCardProductosList[i].Categoria;
                    productos[i].CanProd = eCardProductosList[i].Existencia;
                    productos[i].PreProd = eCardProductosList[i].Precio;
                    productos[i].NomProveedor = eCardProductosList[i].NombreProveedor;

                    //Creación de btnAggLote
                    productos[i].BtnAggLoteProp = new Button();
                    productos[i].ButtonClickAggLote += new EventHandler(btnAggLote_ButtonClick);

                    void btnAggLote_ButtonClick(object sender, EventArgs e)
                    {
                        //Manejar evento
                        ProductoCard productoCardItem = ((ProductoCard)sender);

                        //Hacer consulta en la BD del registro seleccionado

                        //Abrimos el formulario para modificar el producto
                        Utils utils = new Utils();
                        frmAggLoteProducto frmAggLoteProducto = new frmAggLoteProducto();
                        frmAggLoteProducto.ID_PRODUCTO = int.Parse(productoCardItem.Name);
                        utils.setFormToPanelFormularioHijo(frmAggLoteProducto);

                    }

                    //Creación de btnEliminar
                    productos[i].BtnEliminarProp = new Button();
                    productos[i].ButtonClickEliminar += new EventHandler(btnEliminar_ButtonClick);

                    void btnEliminar_ButtonClick(object sender, EventArgs e)
                    {
                        //Manejar evento
                        ProductoCard productoCardItem = ((ProductoCard)sender);
                        DialogResult dialogResult = utils.getMessageBoxAlerta("¿Estás seguro que deseas eliminar el producto" +
                            " \"" + productoCardItem.NomProd + "\"?");
                        if (dialogResult == DialogResult.Yes)
                        {
                            /*
                             * Validar si el producto seleccionado para eliminar tiene alguna reserva SIN FINALIZAR relacionada en la BD.
                             * Si NO tienen ninguno relacionada SI se debe permitir eliminar
                             */
                            productoCardItem.Dispose();
                        }
                    }

                    //Agregamos el ProductoCard al FlowLAyoutPanel
                    flpListadoProductos.Controls.Add(productos[i]);
                }
            }
        }

        private void txtNomProd_TextChanged(object sender, EventArgs e)
        {
            utils.filtrarCardsProductos(productos, txtNomProd);
        }
    }
}
