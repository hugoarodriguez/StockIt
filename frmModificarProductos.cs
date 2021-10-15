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
    public partial class frmModificarProductos : Form
    {
        public string nombreFormAnterior;

        public frmModificarProductos()
        {
            InitializeComponent();
        }

        private void frmModificarProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Realizar validaciones
            //Realizar modificación de producto si las validaciones se cumplen
            //Llamar frmProductos para que muestre los productos actualizados
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
