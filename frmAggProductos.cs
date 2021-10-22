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
    public partial class frmAggProductos : Form
    {

        public frmAggProductos()
        {
            InitializeComponent();
            aggTooltips();
        }

        private void frmAggProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string precLote = mskPrecLote.Text.Replace("$", "");
            string precLoteFull = precLote.Replace(" ", "0");

            //Validar campos vacíos
            if (txtProveedor.Text.Trim() == "" || /*cbxCatProd.SelectedIndex == 0  ||*/ txtNomProd.Text.Trim() == "" 
                || ((int)nudCanProd.Value) <= 0 || double.Parse(precLoteFull) <= 0.0 || txtPrecUnitario.Text.Trim() == "$0.00"
                || mskPorGanancia.Text.Trim() == "" || txtGanancia.Text.Trim() == "$0.00" || txtPrecVenta.Text.Trim() == "$0.00")
            {
                if (txtProveedor.Text.Trim() == "")
                {
                    MessageBox.Show("Debes seleccionar un proveedor.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnSelProveedor.Focus();
                }
                //Descomentar cando se consulten los datos de la BD
                /*else if (cbxCatProd.SelectedIndex == 0)
                {
                    MessageBox.Show("Debes seleccionar la categoría del producto.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbxCatProd.Focus();
                }*/
                else if (txtNomProd.Text.Trim() == "")
                {
                    MessageBox.Show("Debes asignarle un nombre al producto.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomProd.Focus();
                }
                else if (((int)nudCanProd.Value) <= 0)
                {
                    MessageBox.Show("Debes asignar la cantidad de producto.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    nudCanProd.Focus();
                }
                else if (double.Parse(precLoteFull) <= 0.0)
                {
                    MessageBox.Show("Debes asignar el precio del lote de productos.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskPrecLote.Focus();
                }
                else if (txtPrecUnitario.Text.Trim() == "$0.00")
                {
                    MessageBox.Show("Debes definir Cantidad y Precio Lote para calcular el Precio Unitario.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    nudCanProd.Focus();
                }
                else if (mskPorGanancia.Text.Trim() == "")
                {
                    MessageBox.Show("Debes asignar el porcentaje de ganancia que deseas obtener del precio del producto.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskPorGanancia.Focus();
                }
                else if (txtGanancia.Text.Trim() == "$0.00")
                {
                    MessageBox.Show("Debes asignar el porcentaje de ganancia que deseas obtener del precio del producto.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskPorGanancia.Focus();
                }
                else if (txtPrecVenta.Text.Trim() == "$0.00")
                {
                    MessageBox.Show("Debes asignar el porcentaje de ganancia que deseas obtener del precio del producto.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskPorGanancia.Focus();
                }
            } 
            else
            {
                //Agregar Producto al Arreglo
                string nombreProducto = txtNomProd.Text.Trim();
                int cantidad = ((int)nudCanProd.Value);
                int idCategoria = (cbxCatProd.SelectedIndex + 1);
                double precLoteD = double.Parse(precLoteFull);


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estás seguro que deseas cancelar la compra actual?", "Cancelar compra", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                //Limpiamos arreglo que contenga nuestros productos
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
            //cbxCatProd.SelectedIndex = 0;
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

        #endregion
    }
}
