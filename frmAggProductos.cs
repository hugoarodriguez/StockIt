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
            estiloInicial();
        }

        private void frmAggProductos_Load(object sender, EventArgs e)
        {
            
        }

        /*Este método asigna las dimensiones de tamaño para los controles de tipo TextBox y ComboBox,
         * ya que Windows Forms no permite modificar la altura (heigth) en las propiedades del control*/
        private void estiloInicial()
        {
            this.txtNomProd.AutoSize = false;
            this.txtNomProd.Size = new System.Drawing.Size(600, 30);
            this.txtCanProd.AutoSize = false;
            this.txtCanProd.Size = new System.Drawing.Size(200, 30);
            this.cbxCatProd.AutoSize = false;
            this.cbxCatProd.Size = new System.Drawing.Size(200, 30);
            this.txtPreProd.AutoSize = false;
            this.txtPreProd.Size = new System.Drawing.Size(200, 30);
            this.txtDetPRod.AutoSize = false;
            this.txtDetPRod.Size = new System.Drawing.Size(600, 30);
        }
    }
}
