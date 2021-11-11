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
        int idProducto = 0;
        string nombreCategoria;
        string nombreProducto;
        public frmReporteProductos()
        {
            InitializeComponent();
        }

        private void frmReporteProductos_Load(object sender, EventArgs e)
        {
            llenarDataGridView();
            llenarCbmCategorias();
            llenarCmbProductos();
            cmbProductos.Enabled = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            getValoresSeleccionados();
            
            /*CReporteProductos cReporteProductos = new CReporteProductos();
            cReporteProductos.generarReporteProductos(utils.getIdUsuario(), idCategoria, nombreCategoria, 
              estadoProducto, nombreProducto);*/
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
            dtpFechaInicio.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
            dtpFechaFinal.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
            cmbCateProc.SelectedIndex = 0;
            cmbProductos.SelectedIndex = 0;
            getValoresSeleccionados();
            llenarDataGridView();
        }

        private void cmbCateProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            getValoresSeleccionados();
            if (cmbCateProc.SelectedIndex > 0)
            {
                llenarCmbProductos();
                cmbProductos.Enabled = true;
            }
            else
            {
                llenarCmbProductos();
                cmbProductos.Enabled = false;
            }
        }

        #region Métodos Creados
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

            if (cmbProductos.SelectedIndex > 0)
            {
                idProducto = int.Parse(cmbProductos.SelectedValue.ToString());

                DataRowView rowView = cmbProductos.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    nombreProducto = rowView["NOMBRE_PRODUCTO"].ToString();
                }
            }
            else
            {
                idProducto = 0;
                nombreProducto = "";
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

        private void llenarCmbProductos()
        {
            DataTable dt = new LProductos().seleccionarProductosByIdCategoria(idCategoria);

            DataRow dr = dt.NewRow();
            dr["ID_PRODUCTO"] = "0";
            dr["NOMBRE_PRODUCTO"] = "TODOS";
            dt.Rows.InsertAt(dr, 0);

            cmbProductos.DisplayMember = "NOMBRE_PRODUCTO";
            cmbProductos.ValueMember = "ID_PRODUCTO";
            cmbProductos.DataSource = dt;

            cmbProductos.SelectedIndex = 0;
        }

        private void llenarDataGridView()
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFinal = dtpFechaFinal.Value.Date;

            List<EReporteProductosDetalle> eReporteProductosDetalleList = new LProductos().ReporteProductos(idProducto, fechaInicio, fechaFinal, idCategoria, 
                utils.getIdUsuario());

            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("PRODUCTO");
            dt.Columns.Add("CANTIDAD");
            dt.Columns.Add("PRECIO LOTE");
            dt.Columns.Add("PRECIO UNITARIO\n (COMPRA)");
            dt.Columns.Add("PRECIO UNITARIO\n (VENTA)");
            dt.Columns.Add("FECHA\n COMPRA");


            int numRegistro = 1;
            foreach (EReporteProductosDetalle detalleCompra in eReporteProductosDetalleList)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(numRegistro, detalleCompra.NombreProducto, detalleCompra.Cantidad.ToString(),
                    String.Concat("$", detalleCompra.PrecioLote.ToString("0.00")),
                    String.Concat("$", detalleCompra.PrecioUnitario.ToString("0.00")),
                    String.Concat("$", detalleCompra.PrecioVenta.ToString("0.00")), 
                    detalleCompra.FechaIngreso.ToString("dd-MM-yyyy"));
                numRegistro++;
            }
            dgvProductos.DataSource = dt;
            deshabilitarOrdenamientoDGV();
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
