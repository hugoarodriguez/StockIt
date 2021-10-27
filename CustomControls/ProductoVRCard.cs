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
    public partial class ProductoVRCard : UserControl
    {
        public ProductoVRCard()
        {
            InitializeComponent();
        }

        private string nomProd;
        private String catProd;
        private int canProd;
        private double preProd;
        private double subTotal;
        private NumericUpDown nudCanReservaProp;

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
        public double SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; this.lblSubTotal.Text = "$" + value.ToString("0.00"); }
        }

        [Category("Custom Props")]
        public NumericUpDown NudCanReservaProp
        {
            get { return nudCanReservaProp; }
            set { nudCanReservaProp = value; this.nudCanReserva = value; }
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invocado cuando el usuario modifica el valor del campo Reservar")]
        public event EventHandler ValueChangedNUDCanReserva;
        private void nudCanReserva_ValueChanged(object sender, EventArgs e)
        {
            if (this.ValueChangedNUDCanReserva != null)
                this.ValueChangedNUDCanReserva(this, e);
        }
    }
}
