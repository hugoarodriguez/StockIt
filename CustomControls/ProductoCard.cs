using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt.CustomControls
{
    public partial class ProductoCard : UserControl
    {
        public ProductoCard()
        {
            InitializeComponent();
        }

        private Image imgProd;
        private string nomProd;
        private String catProd;
        private int canProd;
        private double preProd;
        private string nomProveedor;
        private Button btnAggLoteProp;
        private Button btnEliminarProp;

        [Category("Custom Props")]
        public Image ImgProd
        {
            get { return imgProd; }
            set { imgProd = value; this.pbxImgProd.Image = value; }
        }

        [Category("Custom Props")]
        public string NomProd
        {
            get { return nomProd; }
            set { nomProd = value; this.lblNomProd.Text = value; }
        }

        [Category("Custom Props")]
        public String CatProd
        {
            get { return catProd; }
            set { catProd = value; this.lblCatProd.Text = value; }
        }

        [Category("Custom Props")]
        public int CanProd
        {
            get { return canProd; }
            set { canProd = value; this.lblCanProd.Text = value.ToString() + " unidades"; }
        }

        [Category("Custom Props")]
        public double PreProd
        {
            get { return preProd; }
            set { preProd = value; this.lblPreProd.Text = "$" + value.ToString("0.00"); }
        }

        [Category("Custom Props")]
        public string NomProveedor
        {
            get { return nomProveedor; }
            set { nomProveedor = value; this.lblProveedor.Text = value; }
        }

        [Category("Custom Props")]
        public Button BtnAggLoteProp
        {
            get { return btnAggLoteProp; }
            set { btnAggLoteProp = value; this.btnAggLote = value; }
        }

        [Category("Custom Props")]
        public Button BtnEliminarProp
        {
            get { return btnEliminarProp; }
            set { btnEliminarProp = value; this.btnEliminar = value; }
        }


        [Browsable(true)]
        [Category("Action")]
        [Description("Invocado cuando el usuario hace clic en boton Nuevo Lote")]
        public event EventHandler ButtonClickAggLote;
        private void btnAggLote_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickAggLote != null)
                this.ButtonClickAggLote(this, e);
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invocado cuando el usuario hace clic en boton Eliminar")]
        public event EventHandler ButtonClickEliminar;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickEliminar != null)
                this.ButtonClickEliminar(this, e);
        }
    }
}
