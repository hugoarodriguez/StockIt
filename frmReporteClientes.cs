using StockIt.ReportClasses;
using StockIt_Entidades;
using StockIt_Logica;
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
    public partial class frmReporteClientes : Form
    {
        Utils utils = new Utils();

        public frmReporteClientes()
        {
            InitializeComponent();
        }

        private void frmReporteClientes_Load(object sender, EventArgs e)
        {
            llenarDataGridView();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CReporteClientes cReporteClientes = new CReporteClientes();
            cReporteClientes.generarReporteClientes(utils.getIdUsuario());
        }

        private void btnImprimir_MouseHover(object sender, EventArgs e)
        {
            btnImprimir.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            btnImprimir.BorderStyle = BorderStyle.None;
        }

        private void llenarDataGridView()
        {
            List<ECliente> eClientesList = new LClientes().SeleccionarClientesActivosByIdUsuario(utils.getIdUsuario());

            frmSeleccionarCliente frmSeleccionarCliente = new frmSeleccionarCliente();

            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Teléfono");
            dt.Columns.Add("Correo");
            dt.Columns.Add("Sexo");

            int numRegistro = 1;
            foreach (var cliente in eClientesList)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(numRegistro, cliente.NombreCliente + " " + cliente.ApellidoCliente, cliente.TelefonoCliente, 
                    cliente.CorreoCliente, cliente.SexoCliente == "M" ? "MASCULINO" : "FEMENINO");
                numRegistro++;
            }
            gridClientes.DataSource = dt;
        }
    }
}
