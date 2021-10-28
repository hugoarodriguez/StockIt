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
    public partial class ProveedorCard : UserControl
    {
        public ProveedorCard()
        {
            InitializeComponent();
        }

        private string nomProveedor;
        private string telProveedor;
        private string corrProveedor;
        private string dirProveedor;
        private Button btnEditarProp;
        private Button btnEliminarProp;

        [Category("Custom Props")]
        public string NomProveedor
        {
            get { return nomProveedor; }
            set { nomProveedor = value; this.lblNomProveedor.Text = value; }
        }

        [Category("Custom Props")]
        public string TelProveedor
        {
            get { return telProveedor; }
            set { telProveedor = value; this.lblTelProveedor.Text = value; }
        }

        [Category("Custom Props")]
        public string CorrProveedor
        {
            get { return corrProveedor; }
            set { corrProveedor = value; this.lblCorrProveedor.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public string DirProveedor
        {
            get { return dirProveedor; }
            set { dirProveedor = value; this.lblDirProveedor.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public Button BtnEditarProp
        {
            get { return btnEditarProp; }
            set { btnEditarProp = value; this.btnEditar = value; }
        }

        [Category("Custom Props")]
        public Button BtnEliminarProp
        {
            get { return btnEliminarProp; }
            set { btnEliminarProp = value; this.btnEliminar = value; }
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
        [Description("Invocado cuando el usuario hace clic en boton Eliminar")]
        public event EventHandler ButtonClickEliminar;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.ButtonClickEliminar != null)
                this.ButtonClickEliminar(this, e);
        }
    }
}
