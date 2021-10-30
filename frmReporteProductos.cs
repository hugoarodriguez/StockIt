using StockIt.ReportClasses;
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
using StockIt_Logica;

namespace StockIt
{
    public partial class frmReporteProductos : Form
    {
        Utils utils = new Utils();
        int idCategoria = 0;
        string nombreCategoria;
        string estadoProducto = "";
        string nombreEstado;
        public frmReporteProductos()
        {
            InitializeComponent();
        }

        private void frmReporteProductos_Load(object sender, EventArgs e)
        {
            llenarDataGridView();
            llenarCbmCategorias();
            llenarCmbEstadoProc();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            getValoresSeleccionados();
            
            CReporteProductos cReporteProductos = new CReporteProductos();
            cReporteProductos.generarReporteProductos(utils.getIdUsuario(), idCategoria, nombreCategoria, 
              estadoProducto, nombreEstado);
        }

        private void btnImprimir_MouseHover(object sender, EventArgs e)
        {
            btnImprimir.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            btnImprimir.BorderStyle = BorderStyle.None;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            getValoresSeleccionados();

            llenarDataGridView();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbCateProc.SelectedIndex = 0;
            cmbEstadoProc.SelectedIndex = 0;
            getValoresSeleccionados();
            llenarDataGridView();
        }

        private void getValoresSeleccionados()
        {
            if (cmbCateProc.SelectedIndex > 0)
            {
                idCategoria = int.Parse(cmbCateProc.SelectedValue.ToString());

                DataRowView rowView = cmbCateProc.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    nombreCategoria = rowView["CATEGORIA"].ToString();
                }
            }
            else
            {
                idCategoria = 0;
                nombreCategoria = "";
            }

            if (cmbEstadoProc.SelectedIndex == 1)
            {
                estadoProducto = "A";
                nombreEstado = "ACTIVO";
            }
            else if (cmbEstadoProc.SelectedIndex == 2)
            {
                estadoProducto = "I";
                nombreEstado = "INACTIVO";
            }
            else
            {
                estadoProducto = "";
                nombreEstado = "";
            }
        }

        private void llenarCbmCategorias()
        {
            DataTable dt = new LCategorias().SeleccionarCategoriasActivasByIdUsuarioDT(utils.getIdUsuario());

            DataRow dr = dt.NewRow();
            dr["ID_CATEGORIA"] = "0";
            dr["CATEGORIA"] = "TODAS";
            dt.Rows.InsertAt(dr, 0);

            cmbCateProc.DisplayMember = "CATEGORIA";
            cmbCateProc.ValueMember = "ID_CATEGORIA";
            cmbCateProc.DataSource = dt;

            cmbCateProc.SelectedIndex = 0;
        }

        private void llenarCmbEstadoProc()
        {
            cmbEstadoProc.Items.Add("TODOS");
            cmbEstadoProc.Items.Add("ACTIVO");
            cmbEstadoProc.Items.Add("INACTIVO");

            cmbEstadoProc.SelectedIndex = 0;
        }

        private void llenarDataGridView()
        {
            List<EReporteProductos> eReporteProductosList = new LProductos().ReporteProductos(utils.getIdUsuario(), idCategoria, estadoProducto);

            frmSeleccionarCliente frmSeleccionarCliente = new frmSeleccionarCliente();

            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("PRODUCTO");
            dt.Columns.Add("PROVEEDOR");
            dt.Columns.Add("EXISTENCIAS");
            dt.Columns.Add("PRECIO UNIDAD (COMPRA)");
            dt.Columns.Add("PRECIO VENTA");

            int numRegistro = 1;
            foreach (var producto in eReporteProductosList)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(numRegistro, producto.NombreProducto, producto.NombreProveedor,
                    producto.Existencia.ToString(), producto.PrecioUnitario, producto.PrecioVenta);
                numRegistro++;
            }
            gridProductos.DataSource = dt;
        }
    }
}
