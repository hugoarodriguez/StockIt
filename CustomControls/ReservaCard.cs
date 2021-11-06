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
    public partial class ReservaCard : UserControl
    {
        public ReservaCard()
        {
            InitializeComponent();
        }

        private string nomClie;
        private string telClie;
        private DateTime fechaReserva;
        private DateTime fechaPromesaEntrega;
        private double montoReserva;
        private Button btnFacturarProp;
        private Button btnEditarProp;
        private Button btnCancelarProp;

        [Category("Custom Props")]
        public string NomClie
        {
            get { return nomClie; }
            set { nomClie = value; this.lblNomClie.Text = value; }
        }

        [Category("Custom Props")]
        public string TelClie
        {
            get { return telClie; }
            set { telClie = value; this.lblTelClie.Text = value; }
        }

        [Category("Custom Props")]
        public DateTime FechaReserva
        {
            get { return fechaReserva; }
            set { fechaReserva = value; this.lblFReserva.Text = value.ToString("dd-MM-yyyy"); }
        }

        [Category("Custom Props")]
        public DateTime FechaPromesaEntrega
        {
            get { return fechaPromesaEntrega; }
            set { fechaPromesaEntrega = value; this.lblFPromesaEntrega.Text = value.ToString("dd-MM-yyyy"); }
        }

        [Category("Custom Props")]
        public double MontoReserva
        {
            get { return montoReserva; }
            set { montoReserva = value; this.lblMontoReserva.Text = "$" + value.ToString("0.00"); }
        }

        [Category("Custom Props")]
        public Button BtnFacturarProp
        {
            get { return btnFacturarProp; }
            set { btnFacturarProp = value; this.btnFacturar = value; }
        }

        [Category("Custom Props")]
        public Button BtnEditarProp
        {
            get { return btnEditarProp; }
            set { btnEditarProp = value; this.btnEditar = value; }
        }

        [Category("Custom Props")]
        public Button BtnCancelarProp
        {
            get { return btnCancelarProp; }
            set { btnCancelarProp = value; this.btnCancelar = value; }
        }


        [Browsable(true)]
        [Category("Action")]
        [Description("Invocado cuando el usuario hace clic en boton Facturar")]
        public event EventHandler ButtonClickFacturar;
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickFacturar != null)
                this.ButtonClickFacturar(this, e);
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invocado cuando el usuario hace clic en boton Editar")]
        public event EventHandler ButtonClickEditar;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickEditar != null)
                this.ButtonClickEditar(this, e);
        }

        [Browsable(true)]
        [Category("Action")]
        [Description("Invocado cuando el usuario hace clic en boton Cancelar")]
        public event EventHandler ButtonClickCancelar;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickCancelar != null)
                this.ButtonClickCancelar(this, e);
        }
    }
}
