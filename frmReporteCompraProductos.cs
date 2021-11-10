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
    public partial class frmReporteCompraProductos : Form
    {
        Utils utils = new Utils();

        public frmReporteCompraProductos()
        {
            InitializeComponent();
        }

        private void frmReporteCompraProductos_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
            dtpFechaFinal.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
            llenarDataGridView();
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            btnImprimir.Enabled = false;
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            btnImprimir.Enabled = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            llenarDataGridView();
            btnImprimir.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
            dtpFechaFinal.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
            llenarDataGridView();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Llamar método de clase para imprimir este reporte
        }

        private void btnImprimir_MouseHover(object sender, EventArgs e)
        {
            btnImprimir.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            btnImprimir.BorderStyle = BorderStyle.None;
        }


        #region Métodos Creados

        private void llenarDataGridView()
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFinal = dtpFechaFinal.Value.Date;

            List <EReporteProductosEncabezado> eReporteProductosEncabezadoList = new LProductos().EncabezadosReporteCompraProductos(fechaInicio, fechaFinal, utils.getIdUsuario());

            frmSeleccionarCliente frmSeleccionarCliente = new frmSeleccionarCliente();

            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("PROVEEDOR");
            dt.Columns.Add("FECHA COMPRA");
            dt.Columns.Add("MONTO");

            int numRegistro = 1;
            foreach (EReporteProductosEncabezado encabezadoCompra in eReporteProductosEncabezadoList)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(numRegistro, encabezadoCompra.NombreProveedor, encabezadoCompra.FechaIngreso.ToString("dd-MM-yyyy"), 
                    String.Concat("$", encabezadoCompra.Monto.ToString("0.00")));
                numRegistro++;
            }
            gridProductos.DataSource = dt;
            deshabilitarOrdenamientoDGV();
        }

        private void deshabilitarOrdenamientoDGV()
        {
            foreach (DataGridViewColumn column in gridProductos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        #endregion
    }
}
