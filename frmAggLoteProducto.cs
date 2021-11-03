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
    public partial class frmAggLoteProducto : Form
    {
        public int ID_PRODUCTO = 0;
        private int idProveedor = 0;
        Utils utils = new Utils();

        public frmAggLoteProducto()
        {
            InitializeComponent();
            aggTooltips();
        }

        private void frmModificarProductos_Load(object sender, EventArgs e)
        {
            datosIniciales();
        }

        private void btnAgregarLote_Click(object sender, EventArgs e)
        {
            string precLote = mskPrecLote.Text.Replace("$", "");
            string precLoteFull = precLote.Replace(" ", "0");

            //Validar campos vacíos
            if (txtProveedor.Text.Trim() == "" || txtCategoria.Text == "" || txtNomProd.Text.Trim() == ""
                || ((int)nudCanProd.Value) <= 0 || double.Parse(precLoteFull) <= 0.0 || txtPrecUnitario.Text.Trim() == "$0.00"
                || mskPorGanancia.Text.Trim() == "" || txtGanancia.Text.Trim() == "$0.00" || txtPrecVenta.Text.Trim() == "$0.00")
            {
                if (txtProveedor.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes seleccionar un proveedor.");
                }
                //Descomentar cando se consulten los datos de la BD
                /*else if (cbxCatProd.SelectedIndex == 0)
                {
                    utils.messageBoxCampoRequerido("Debes seleccionar la categoría del producto.");
                    cbxCatProd.Focus();
                }*/
                else if (txtNomProd.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes asignarle un nombre al producto.");
                    txtNomProd.Focus();
                }
                else if (((int)nudCanProd.Value) <= 0)
                {
                    utils.messageBoxCampoRequerido("Debes asignar la cantidad de producto.");
                    nudCanProd.Focus();
                }
                else if (double.Parse(precLoteFull) <= 0.0)
                {
                    utils.messageBoxCampoRequerido("Debes asignar el precio del lote de productos.");
                    mskPrecLote.Focus();
                }
                else if (txtPrecUnitario.Text.Trim() == "$0.00")
                {
                    utils.messageBoxCampoRequerido("Debes definir Cantidad y Precio Lote\npara calcular el Precio Unitario.");
                    nudCanProd.Focus();
                }
                else if (mskPorGanancia.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes asignar el porcentaje de ganancia\nque deseas obtener del precio del producto.");
                    mskPorGanancia.Focus();
                }
                else if (txtGanancia.Text.Trim() == "$0.00")
                {
                    utils.messageBoxCampoRequerido("Debes asignar el porcentaje de ganancia\nque deseas obtener del precio del producto.");
                    mskPorGanancia.Focus();
                }
                else if (txtPrecVenta.Text.Trim() == "$0.00")
                {
                    utils.messageBoxCampoRequerido("Debes asignar el porcentaje de ganancia\nque deseas obtener del precio del producto.");
                    mskPorGanancia.Focus();
                }
            }
            else
            {
                //Actualizar el producto

                int cantidad = ((int)nudCanProd.Value);
                double precLoteD = double.Parse(precLoteFull);
                string precUnitarioString = txtPrecUnitario.Text.Replace("$", "").Trim();
                double precUnitarioP = double.Parse(precUnitarioString);
                double precVenta = double.Parse(txtPrecVenta.Text.Replace("$", "").Trim());
                double porcentajeGananciaP = int.Parse(mskPorGanancia.Text.Trim()) / 100.00;

                EEncabezadoCompraProductos eEncabezadoCompraProductos = new EEncabezadoCompraProductos();
                eEncabezadoCompraProductos.IdProveedor = idProveedor;
                eEncabezadoCompraProductos.Monto = precLoteD;

                List<EDetalleCompraProductos> eDetalleCompraProductosList = new List<EDetalleCompraProductos>();

                EDetalleCompraProductos eDetalleCompraProductos = new EDetalleCompraProductos();
                eDetalleCompraProductos.IdProducto = ID_PRODUCTO;
                eDetalleCompraProductos.Cantidad = cantidad;
                eDetalleCompraProductos.PrecioLote = precLoteD;
                eDetalleCompraProductos.PrecioUnitario = precUnitarioP;
                eDetalleCompraProductos.PrecioVenta = precVenta;
                eDetalleCompraProductos.PorcentajeGanancia = porcentajeGananciaP;
                eDetalleCompraProductosList.Add(eDetalleCompraProductos);

                EProducto eProducto = new EProducto();
                eProducto.IdProducto = ID_PRODUCTO;
                int r = new LProductos().VerificarExistenciaCantidadesNuevas(eProducto);

                if (r == 0)
                {
                    r = new LDetalleCompras().insertarDetalleCompra(eDetalleCompraProductosList, eEncabezadoCompraProductos);

                    if (r > 0)
                    {
                        utils.messageBoxOperacionExitosa("La compra del lote se agregó satisfactoriamente.");
                        limpiarControles();
                    }
                    else if (r == -1)
                    {
                        utils.messageBoxAlerta("No se pudo agregar la compra del lote.");
                        limpiarControles();
                    }
                    else
                    {
                        utils.messageBoxAlerta("Hubo un error. Intente más tarde");
                        limpiarControles();
                    }
                }
                else if (r == -1)
                {
                    utils.messageBoxAlerta("No puedes agregar un nuevo lote, hay uno nuevo en existencia.");
                    limpiarControles();
                }
                else
                {
                    utils.messageBoxAlerta("Hubo un error. Intente más tarde");
                    limpiarControles();
                }


                //Cargamos el frmProductos
                utils.setFormToPanelFormularioHijo(new frmProductos());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Reestablecer los campos con sus datos iniciales
            limpiarControlesMenosDatosIniciales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = utils.getMessageBoxCancelarOperacion("¿Quieres cancelar la actualización del producto?. \nSe perderán todos los cambios que no se guardaron.");
            if (dialogResult == DialogResult.Yes)
            {
                //Cargamos el frmClientes
                utils.setFormToPanelFormularioHijo(new frmProductos());
            }
        }

        private void mskPrecLote_TextChanged(object sender, EventArgs e)
        {
            txtPrecUnitario.Text = calcularPrecioUnitario().ToString("$0.00");
        }

        private void nudCanProd_ValueChanged(object sender, EventArgs e)
        {
            txtPrecUnitario.Text = calcularPrecioUnitario().ToString("$0.00");
        }

        private void mskPorGanancia_TextChanged(object sender, EventArgs e)
        {
            calcGananciaYPrecVenta();
        }

        #region Métodos creados

        //Variables para métodos creados
        private double precUnitario = 0.0;
        private double prodGanancia = 0.0;
        private double precVenta = 0.0;

        //Calcular presio unitario
        private double calcularPrecioUnitario()
        {
            if (((int)nudCanProd.Value) > 0)
            {
                int cantProducto = ((int)nudCanProd.Value);
                string precLote = mskPrecLote.Text.Replace("$", "");
                double precLoteD = 0.0;

                if (double.TryParse(precLote.Replace(" ", "0"), out precLoteD))
                {
                    if (precLoteD > 0.0)
                    {
                        //Calcular precio unitario
                        precUnitario = (precLoteD / cantProducto);
                        calcGananciaYPrecVenta();
                    }
                    else
                    {
                        precUnitario = 0.0;
                    }
                }
                else
                {
                    precUnitario = 0.0;
                }
            }
            else
            {
                precUnitario = 0.0;
            }

            return Math.Round(precUnitario, 2); ;
        }


        //Calcula la ganancia y el precio de venta del producto
        private void calcGananciaYPrecVenta()
        {
            if (mskPorGanancia.Text.Trim() != "0" && mskPorGanancia.Text.Trim() != "")
            {
                double porcGanancia = double.Parse(mskPorGanancia.Text.Trim());
                prodGanancia = Math.Round((precUnitario * (porcGanancia / 100)), 2);
                precVenta = Math.Round((precUnitario + prodGanancia), 2);
                txtGanancia.Text = prodGanancia.ToString("$0.00");
                txtPrecVenta.Text = precVenta.ToString("$0.00");
            }
            else
            {
                txtGanancia.Text = "$0.00";
                txtPrecVenta.Text = "$0.00";
            }
        }

        //Agregar Tooltip a los controles
        private void aggTooltips()
        {
            ttActualizar.SetToolTip(btnAgregarLote, "Haz clic para agregar la compra de un nuevo lote del producto");
            ttLimpiar.SetToolTip(btnLimpiar, "Haz clic para limpiar el formulario");
            ttCancelar.SetToolTip(btnCancelar, "Haz clic para cancelar la compra actual");
        }

        //Reestablecer los controles del formulario con los datos de la BD
        private void datosIniciales()
        {
            if (ID_PRODUCTO > 0)
            {
                ECardProducto eCardProducto = new LProductos().SeleccionarProductoById(ID_PRODUCTO);

                txtProveedor.Text = eCardProducto.NombreProveedor;
                txtCategoria.Text = eCardProducto.Categoria;
                idProveedor = eCardProducto.IdProveedor;
                txtNomProd.Text = eCardProducto.NombreProducto;
                txtDetProd.Text = eCardProducto.Detalles;
            }
        }
        private void limpiarControlesMenosDatosIniciales()
        {
            nudCanProd.Value = 0;
            mskPrecLote.Text = null;
            txtPrecUnitario.Text = "$0.00";
            mskPorGanancia.Text = null;
            txtGanancia.Text = "$0.00";
            txtPrecVenta.Text = "$0.00";
        }


        //Reestablecer los controles a sus valores iniciales
        private void limpiarControles()
        {
            pbxImgProd.Image = StockIt.Properties.Resources.noImage;
            txtProveedor.Text = null;
            txtCategoria.Text = null;
            txtNomProd.Text = null;
            nudCanProd.Value = 0;
            mskPrecLote.Text = null;
            txtPrecUnitario.Text = "$0.00";
            mskPorGanancia.Text = null;
            txtGanancia.Text = "$0.00";
            txtPrecVenta.Text = "$0.00";
            txtDetProd.Text = null;
        }

        #endregion
    }
}
