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

                        Utils utils = new Utils();

                        EProducto eProducto = new EProducto();
                        eProducto.IdProducto = int.Parse(productoCardItem.Name);
                        int r = new LProductos().VerificarExistenciaCantidadesNuevas(eProducto);

                        if (r == 0)
                        {
                            //Abrimos el formulario para modificar el producto
                            frmAggLoteProducto frmAggLoteProducto = new frmAggLoteProducto();
                            frmAggLoteProducto.ID_PRODUCTO = int.Parse(productoCardItem.Name);
                            frmAggLoteProducto.pbxImgProd.Image = productoCardItem.ImgProd;
                            utils.setFormToPanelFormularioHijo(frmAggLoteProducto);
                        }
                        else if (r == -1)
                        {
                            utils.messageBoxAlerta("No puedes agregar un nuevo lote, hay uno nuevo en existencia.");
                        }
                        else
                        {
                            utils.messageBoxAlerta("Hubo un error. Intente más tarde");
                        }

                    }

                    //Creación de btnEliminar
                    productos[i].BtnEliminarProp = new Button();
                    productos[i].ButtonClickEliminar += new EventHandler(btnEliminar_ButtonClick);

                    void btnEliminar_ButtonClick(object sender, EventArgs e)
                    {
                        //Manejar evento
                        ProductoCard productoCardItem = ((ProductoCard)sender);

                        if (productoCardItem.CanProd > 0)
                        {
                            DialogResult dialogResult = utils.getMessageBoxAlerta("Este producto posee existencias.\n" +
                            "¿Estás seguro que deseas eliminar el producto" +
                            " \"" + productoCardItem.NomProd + "\"?");
                            if (dialogResult == DialogResult.Yes)
                            {
                                EProducto eProducto = new EProducto();
                                eProducto.IdProducto = int.Parse(productoCardItem.Name);
                                int r = new LProductos().eliminarProducto(eProducto);

                                if (r > 0)
                                {
                                    productoCardItem.Dispose();
                                    utils.messageBoxOperacionExitosa("Se eliminó el producto \"" + productoCardItem.NomProd + "\"");
                                }
                                else if (r == -1)
                                {
                                    utils.messageBoxAlerta("No se puede eliminar este producto, " +
                                        "\nse encuentra relacionado con reservas en espera.");
                                }
                                else
                                {
                                    utils.messageBoxOperacionSinExito("Hubo un error. Intente más tarde.");
                                }
                            }
                        }
                        else
                        {
                            DialogResult dialogResult = utils.getMessageBoxAlerta("¿Estás seguro que deseas eliminar el producto" +
                            " \"" + productoCardItem.NomProd + "\"?");
                            if (dialogResult == DialogResult.Yes)
                            {
                                EProducto eProducto = new EProducto();
                                eProducto.IdProducto = int.Parse(productoCardItem.Name);
                                int r = new LProductos().eliminarProducto(eProducto);

                                if (r > 0)
                                {
                                    productoCardItem.Dispose();
                                }
                                else if (r == -1)
                                {
                                    utils.messageBoxAlerta("No se puede eliminar este producto, " +
                                        "\nse encuentra relacionado con reservas en espera.");
                                }
                                else
                                {
                                    utils.messageBoxOperacionSinExito("Hubo un error. Intente más tarde.");
                                }
                            }
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
