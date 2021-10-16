using StockIt.CustomControls;
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
    public partial class frmAggReserva : Form
    {
        public frmAggReserva()
        {
            InitializeComponent();
        }

        private void frmAggReserva_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {
            ProductoVRCard[] productos = new ProductoVRCard[10];
            for (int i = 0; i < productos.Length; i++)
            {
                productos[i] = new ProductoVRCard();
                productos[i].Name = "ProductoVRCard" + i.ToString();
                productos[i].NomProd = "Camiseta Verde " + i.ToString();
                productos[i].CatProd = "Camisetas";
                productos[i].CanProd = 5;
                productos[i].PreProd = 8.50;
                productos[i].SubTotal = 8.50;

                /*Agregar función para cambiar el SubTotal cuando se aumente o decremente la cantidad
                 * de producto a reservar
                */

                //Agregamos el ProductoCard al FlowLAyoutPanel
                flpListadoProductos.Controls.Add(productos[i]);
            }
        }
    }
}
