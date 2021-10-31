using StockIt_Entidades;
using StockIt_Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt
{
    public partial class frmAggProductos : Form
    {
        Utils utils = new Utils();
        int idCategoria;
        List<EProducto> eProductosList = new List<EProducto>();
        List<EDetalleCompraProductos> eDetalleCompraProductosList = new List<EDetalleCompraProductos>();

        public frmAggProductos()
        {
            InitializeComponent();
            aggTooltips();
        }

        private void frmAggProductos_Load(object sender, EventArgs e)
        {
            llenarCbmCategorias();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string precLote = mskPrecLote.Text.Replace("$", "");
            string precLoteFull = precLote.Replace(" ", "0");

            //Validar campos vacíos
            if (txtProveedor.Text.Trim() == "" || cbxCatProd.SelectedIndex == 0 || txtNomProd.Text.Trim() == ""
                || ((int)nudCanProd.Value) <= 0 || double.Parse(precLoteFull) <= 0.0 || txtPrecUnitario.Text.Trim() == "$0.00"
                || mskPorGanancia.Text.Trim() == "" || txtGanancia.Text.Trim() == "$0.00" || txtPrecVenta.Text.Trim() == "$0.00")
            {
                if (txtProveedor.Text.Trim() == "")
                {
                    utils.messageBoxCampoRequerido("Debes seleccionar un proveedor.");
                }
                //Descomentar cando se consulten los datos de la BD
                else if (cbxCatProd.SelectedIndex == 0)
                {
                    utils.messageBoxCampoRequerido("Debes seleccionar la categoría del producto.");
                    cbxCatProd.Focus();
                }
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
                //Agregar Producto al Arreglo
                string nombreProducto = txtNomProd.Text.Trim().ToUpper();
                int cantidad = ((int)nudCanProd.Value);
                double precLoteD = double.Parse(precLoteFull);
                string precUnitarioString = txtPrecUnitario.Text.Replace("$", "").Trim();
                double precUnitarioP = double.Parse(precUnitarioString);
                double precVenta = double.Parse(txtPrecVenta.Text.Replace("$", "").Trim());
                double porcentajeGananciaP = int.Parse(mskPorGanancia.Text.Trim()) / 100.00;
                getValoresSeleccionados();//Valores de los combobox

                EProducto eProducto = new EProducto();
                eProducto.IdCategoria = idCategoria;
                eProducto.IdUsuario = utils.getIdUsuario();
                eProducto.NombreProducto = nombreProducto;
                eProducto.Precio = precVenta;
                eProducto.Existencia = cantidad;
                eProducto.Img = imageToByteArray(pbxImgProd.Image);
                eProducto.Detalles = txtDetProd.Text.Trim().ToUpper();
                eProductosList.Add(eProducto);

                lklProductos.Text = "Productos de esta compra: " + eProductosList.Count;

                EDetalleCompraProductos eDetalleCompraProductos = new EDetalleCompraProductos();
                eDetalleCompraProductos.Cantidad = cantidad;
                eDetalleCompraProductos.PrecioLote = precLoteD;
                eDetalleCompraProductos.PrecioUnitario = precUnitarioP;
                eDetalleCompraProductos.PrecioVenta = precVenta;
                eDetalleCompraProductos.PorcentajeGanancia = porcentajeGananciaP;
                eDetalleCompraProductosList.Add(eDetalleCompraProductos);

                limpiarControlesMenosProveedor();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = utils.getMessageBoxCancelarOperacion("¿Estás seguro que deseas cancelar la compra actual?");
            if (dialogResult == DialogResult.Yes)
            {
                //Limpiamos arreglo que contenga nuestros productos
                eDetalleCompraProductosList.Clear();
                eProductosList.Clear();
                limpiarControles();
            }
        }

        private void btnSImagen_Click(object sender, EventArgs e)
        {
            //Abrimos un FileDialog
            OpenFileDialog open = new OpenFileDialog();
            //Establecemos los filtros de tupos de imágenes
            open.Filter = "Archivos de Imagen(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Mostramos la imagen en el PictureBox
                pbxImgProd.Image = new Bitmap(open.FileName);
                // image file path  
                //txtNomProd.Text = open.FileName;

                //Convertir Imagen a byte[] en la Capa Lógica
            }
        }

        private void lklProductos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Abrir ventana modal con DataGrid que contenga los productos agregados de la compra actual
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
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

        private void llenarCbmCategorias()
        {
            DataTable dt = new LCategorias().SeleccionarCategoriasActivasByIdUsuarioDT(utils.getIdUsuario());

            DataRow dr = dt.NewRow();
            dr["ID_CATEGORIA"] = "0";
            dr["CATEGORIA"] = "SELECCIONAR";
            dt.Rows.InsertAt(dr, 0);

            cbxCatProd.DisplayMember = "CATEGORIA";
            cbxCatProd.ValueMember = "ID_CATEGORIA";
            cbxCatProd.DataSource = dt;

            cbxCatProd.SelectedIndex = 0;
        }

        private void getValoresSeleccionados()
        {
            if (cbxCatProd.SelectedIndex > 0)
            {
                idCategoria = int.Parse(cbxCatProd.SelectedValue.ToString());
            }
        }

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
            ttProductos.SetToolTip(lklProductos, "Haz clic para ver los productos de esta compra");
            ttSelImagen.SetToolTip(btnSImagen, "Haz clic para seleccionar una imagen");
            ttSelProveedor.SetToolTip(btnSelProveedor, "Haz clic para seleccionar un proveedor");
            ttAgregar.SetToolTip(btnAgregar, "Haz clic para agregar el producto a la compra actual");
            ttLimpiar.SetToolTip(btnLimpiar, "Haz clic para limpiar el formulario");
            ttFinalizar.SetToolTip(btnFinalizar, "Haz clic para finalizar la compra actual");
            ttCancelar.SetToolTip(btnCancelar, "Haz clic para cancelar la compra actual");
        }

        //Limpia los controles del formulario
        private void limpiarControles()
        {
            pbxImgProd.Image = StockIt.Properties.Resources.noImage;
            txtProveedor.Text = null;
            cbxCatProd.SelectedIndex = 0;
            txtNomProd.Text = null;
            nudCanProd.Value = 0;
            mskPrecLote.Text = null;
            txtPrecUnitario.Text = "$0.00";
            mskPorGanancia.Text = null;
            txtGanancia.Text = "$0.00";
            txtPrecVenta.Text = "$0.00";
            txtDetProd.Text = null;
            btnSelProveedor.Focus();
        }

        private void limpiarControlesMenosProveedor()
        {
            pbxImgProd.Image = StockIt.Properties.Resources.noImage;
            cbxCatProd.SelectedIndex = 0;
            txtNomProd.Text = null;
            nudCanProd.Value = 0;
            mskPrecLote.Text = null;
            txtPrecUnitario.Text = "$0.00";
            mskPorGanancia.Text = null;
            txtGanancia.Text = "$0.00";
            txtPrecVenta.Text = "$0.00";
            txtDetProd.Text = null;
            txtNomProd.Focus();
        }

        #endregion

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (eProductosList.Count > 0)
            {
                double montoCompra = 0.0;

                foreach (EDetalleCompraProductos item in eDetalleCompraProductosList)
                {
                    montoCompra += item.PrecioLote;
                }

                EEncabezadoCompraProductos eEncabezadoCompraProductos = new EEncabezadoCompraProductos();
                eEncabezadoCompraProductos.IdProveedor = int.Parse(lblIdProveedor.Text.Trim());
                eEncabezadoCompraProductos.Monto = montoCompra;

                int r = new LProductos().compraProductosInexistentes(eProductosList, eEncabezadoCompraProductos, 
                    eDetalleCompraProductosList);

                if(r > 0)
                {
                    utils.messageBoxOperacionExitosa("La compra se agregó satisfactoriamente.");
                    limpiarControles();
                    eDetalleCompraProductosList.Clear();
                    eProductosList.Clear();
                }
                else if(r == -1)
                {
                    utils.messageBoxAlerta("No se pudo agregar la compra.");
                    limpiarControles();
                    eDetalleCompraProductosList.Clear();
                    eProductosList.Clear();
                }
                else
                {
                    utils.messageBoxAlerta("Hubo un error. Intente más tarde");
                    limpiarControles();
                    eDetalleCompraProductosList.Clear();
                    eProductosList.Clear();
                }
            }
            else
            {
                utils.messageBoxAlerta("Debes agregar un producto primero.");
            }
        }

        private void btnSelProveedor_Click(object sender, EventArgs e)
        {

            List<EProveedor> eProveedoresList = new LProveedores().SeleccionarProveedoresActivosByIdUsuario(utils.getIdUsuario());

            frmSeleccionarProveedor frmSeleccionarProveedor = new frmSeleccionarProveedor();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Teléfono");
            dt.Columns.Add("Dirección");
            dt.Columns.Add("Correo");

            foreach (var proveedor in eProveedoresList)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(proveedor.IdProveedor, proveedor.NombreProveedor, 
                    proveedor.TelefonoProveedor, proveedor.DireccionProveedor, proveedor.CorreoProveedor);
            }
            frmSeleccionarProveedor.lblFormularioLlamada.Text = this.Name;
            frmSeleccionarProveedor.dgvProveedores.DataSource = dt;
            frmSeleccionarProveedor.Show();
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
