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
            
        }

        private void frmAggProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            string preProdP1 = mskPrecLote.Text.Trim().Replace("$", "");
            string preProdFull = preProdP1.Trim().Replace(".", "");

            //Validar campos vacíos
            if (txtNomProd.Text.Trim() == "" || ((int)nudCanProd.Value) == 0 || /*cbxCatProd.SelectedIndex == 0  ||*/
                preProdFull == "" || mskPorGanancia.Text.Trim() == "")
            {
                if (txtNomProd.Text.Trim() == "")
                {
                    MessageBox.Show("Debes asignarle un nombre al producto.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNomProd.Focus();
                }
                else if(((int)nudCanProd.Value) == 0)
                {
                    MessageBox.Show("Debes asignar la cantidad de producto.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    nudCanProd.Focus();
                }
                //Descomentar cando se consulten los datos de la BD
                /*else if (cbxCatProd.SelectedIndex == 0)
                {
                    MessageBox.Show("Debes seleccionar la categoría del producto.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cbxCatProd.Focus();
                }*/
                else if (preProdFull == "")
                {
                    MessageBox.Show("Debes asignar el precio del producto.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskPrecLote.Focus();
                }
                else if (mskPorGanancia.Text.Trim() == "")
                {
                    MessageBox.Show("Debes asignar el porcentaje de ganancia que deseas obtener del precio del producto.", "Dato requerido",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    mskPorGanancia.Focus();
                }
            } 
            else
            {
                string nombreProducto = txtNomProd.Text.Trim();
                int cantidad = ((int)nudCanProd.Value);
                int idCategoria = (cbxCatProd.SelectedIndex + 1);
                double preProd = double.Parse(preProdFull);


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Preguntar si desea cancelar
            limpiarControles();
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

        //Limpia los controles del formulario
        private void limpiarControles()
        {
            pbxImgProd.Image = StockIt.Properties.Resources.noImage;
            txtNomProd.Text = null;
            nudCanProd.Value = 0;
            //cbxCatProd.SelectedIndex = 0;
            mskPrecLote.Text = null;
            txtDetProd.Text = null;
        }
    }
}
