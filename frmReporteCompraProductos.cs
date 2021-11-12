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
    public partial class frmReporteCompraProductos : Form
    {
        Utils utils = new Utils();
        List<EReporteProductosEncabezado> eReporteProductosEncabezadoList = new List<EReporteProductosEncabezado>();
        List<EReporteProductosDetalle> eReporteProductosDetalleList = new List<EReporteProductosDetalle>();
        EReporteProductosEncabezado eReporteProductosEncabezado;
        int idEncabezadoCompraProductos = 0;

        public frmReporteCompraProductos()
        {
            InitializeComponent();
        }

        private void frmReporteCompraProductos_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
            dtpFechaFinal.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
            llenarDataGridViewConEncabezados();
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
            if (dtpFechaInicio.Value > dtpFechaFinal.Value)
            {
                utils.messageBoxFormatoIncorrecto("La Fecha Inicio debe ser inferior a la Fecha Final");
                dtpFechaInicio.Focus();
            }
            else
            {
                llenarDataGridViewConEncabezados();
                btnImprimir.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (idEncabezadoCompraProductos > 0)
            {
                idEncabezadoCompraProductos = 0;
                dtpFechaInicio.Enabled = true;
                dtpFechaFinal.Enabled = true;
                btnFiltrar.Enabled = true;
                btnLimpiar.Text = "Limpiar";
                llenarDataGridViewConEncabezados();
            }
            else
            {
                dtpFechaInicio.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
                dtpFechaFinal.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
                llenarDataGridViewConEncabezados();
            }
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Llamar método de clase para imprimir este reporte
            CReporteCompraProductos cReporteCompraProductos = new CReporteCompraProductos();
            cReporteCompraProductos.generarReporte(idEncabezadoCompraProductos, eReporteProductosEncabezadoList, eReporteProductosDetalleList,
                eReporteProductosEncabezado, dtpFechaInicio.Value.Date.ToString("dd-MM-yyyy"), dtpFechaFinal.Value.Date.ToString("dd-MM-yyyy"));
        }

        private void btnImprimir_MouseHover(object sender, EventArgs e)
        {
            btnImprimir.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            btnImprimir.BorderStyle = BorderStyle.None;
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarCompra();
        }

        #region Métodos Creados

        private void llenarDataGridViewConEncabezados()
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFinal = dtpFechaFinal.Value.Date;

            eReporteProductosEncabezadoList = new LProductos().EncabezadosReporteCompraProductos(fechaInicio, fechaFinal, utils.getIdUsuario());

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("#");
            dt.Columns.Add("PROVEEDOR");
            dt.Columns.Add("FECHA COMPRA");
            dt.Columns.Add("MONTO");

            int numRegistro = 1;
            foreach (EReporteProductosEncabezado encabezadoCompra in eReporteProductosEncabezadoList)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(encabezadoCompra.IdEncCompraProductos, numRegistro, encabezadoCompra.NombreProveedor, 
                    encabezadoCompra.FechaIngreso.ToString("dd-MM-yyyy"), String.Concat("$", encabezadoCompra.Monto.ToString("0.00")));
                numRegistro++;
            }
            dgvProductos.DataSource = dt;
            dgvProductos.Columns[0].Visible = false;//Ocultamos la columa del ID
            deshabilitarOrdenamientoDGV();
        }

        private void llenarDataGridViewConDetalle()
        {
            eReporteProductosDetalleList = new LProductos().DetalleReporteCompraProductos(idEncabezadoCompraProductos);

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("#");
            dt.Columns.Add("PRODUCTO");
            dt.Columns.Add("CANTIDAD");
            dt.Columns.Add("PRECIO LOTE");
            dt.Columns.Add("PRECIO UNITARIO\n (COMPRA)");
            dt.Columns.Add("PRECIO UNITARIO\n (VENTA)");

            int numRegistro = 1;
            foreach (EReporteProductosDetalle detalleCompra in eReporteProductosDetalleList)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(detalleCompra.IdEncCompraProductos, numRegistro, detalleCompra.NombreProducto, detalleCompra.Cantidad.ToString(), 
                    String.Concat("$", detalleCompra.PrecioLote.ToString("0.00")),
                    String.Concat("$", detalleCompra.PrecioUnitario.ToString("0.00")),
                    String.Concat("$", detalleCompra.PrecioVenta.ToString("0.00")));
                numRegistro++;
            }
            dgvProductos.DataSource = dt;
            dgvProductos.Columns[0].Visible = false;//Ocultamos la columa del ID
            deshabilitarOrdenamientoDGV();
        }

        private void seleccionarCompra()
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProductos.SelectedRows)
                {
                    try
                    {
                        //Deshabilitamos las opciones para cambiar el filtro
                        dtpFechaInicio.Enabled = false;
                        dtpFechaFinal.Enabled = false;
                        btnFiltrar.Enabled = false;
                        btnLimpiar.Text = "Volver";

                        //Obtenemos los datos para el encabezado de la compra
                        eReporteProductosEncabezado = new EReporteProductosEncabezado();
                        eReporteProductosEncabezado.NombreProveedor = row.Cells[2].Value.ToString();
                        eReporteProductosEncabezado.FechaIngreso = DateTime.Parse(row.Cells[3].Value.ToString());
                        eReporteProductosEncabezado.Monto = Double.Parse(row.Cells[4].Value.ToString().Replace("$", ""));

                        idEncabezadoCompraProductos = int.Parse(row.Cells[0].Value.ToString());
                        //Llenar dgvProductos con el detalle de la compra seleccionada
                        llenarDataGridViewConDetalle();
                    }
                    catch (Exception)
                    {
                        idEncabezadoCompraProductos = 0;
                    }
                }
            }
        }

        private void deshabilitarOrdenamientoDGV()
        {
            foreach (DataGridViewColumn column in dgvProductos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        #endregion
    }
}
