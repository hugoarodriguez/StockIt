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
using StockIt_Entidades;

namespace StockIt
{
    public partial class frmAggReserva : Form
    {
        ProductoVRCard[] productosVR;
        ECliente[] eClientes;

        public frmAggReserva()
        {
            InitializeComponent();
        }

        private void frmAggReserva_Load(object sender, EventArgs e)
        {
            cargarProductos();
            cargarClientes();
        }

        private void btnSelCliente_Click(object sender, EventArgs e)
        {
            frmSeleccionarCliente frmSeleccionarCliente = new frmSeleccionarCliente();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Teléfono");
            dt.Columns.Add("Correo");

            foreach (var cliente in eClientes)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(cliente.IdCliente, cliente.NombreCliente, cliente.ApellidoCliente, cliente.TelefonoCliente, cliente.CorreoCliente);
            }
            frmSeleccionarCliente.dgvClientes.DataSource = dt;
            frmSeleccionarCliente.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void cargarProductos()
        {
            productosVR = new ProductoVRCard[10];
            for (int i = 0; i < productosVR.Length; i++)
            {
                productosVR[i] = new ProductoVRCard();
                productosVR[i].Name = "ProductoVRCard" + i.ToString();
                productosVR[i].NomProd = "Camiseta Verde " + i.ToString();
                productosVR[i].CatProd = "Camisetas";
                productosVR[i].CanProd = 5;
                productosVR[i].PreProd = 8.50;
                productosVR[i].SubTotal = 8.50;

                /*Agregar función para cambiar el SubTotal cuando se aumente o decremente la cantidad
                 * de producto a reservar
                */

                //Agregamos el ProductoCard al FlowLAyoutPanel
                flpListadoProductos.Controls.Add(productosVR[i]);
            }
        }

        private void cargarClientes()
        {
            eClientes = new ECliente[10];
            for (int i = 0; i < eClientes.Length; i++)
            {
                eClientes[i] = new ECliente();
                eClientes[i].IdCliente = i + 1;
                eClientes[i].IdUsuario = 1;
                eClientes[i].NombreCliente = "Nombre " + (i + 1).ToString();
                eClientes[i].ApellidoCliente = "Apellido 1" + (i + 1).ToString();
                eClientes[i].SexoCliente = "A";
                eClientes[i].TelefonoCliente = "7022-8563";
                eClientes[i].CorreoCliente = "correo" + (i + 1).ToString() + "@gmail.com";
                eClientes[i].EstadoCliente = "A";
            }
        }
    }
}
