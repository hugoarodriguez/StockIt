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
    public partial class CategoriaCard : UserControl
    {
        public CategoriaCard()
        {
            InitializeComponent();
        }

        private string categoria;
        private Button btnEditarProp;
        private Button btnEliminarProp;

        [Category("Custom Props")]
        public String Categ
        {
            get { return categoria; }
            set { categoria = value; this.lblCategoria.Text = value; }
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
