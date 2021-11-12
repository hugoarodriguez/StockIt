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
    public partial class frmReporteVentas : Form
    {
        Utils utils = new Utils();
        List<EReporteFacturacionEncabezado> eReporteFacturacionEncabezadoList = new List<EReporteFacturacionEncabezado>();
        List<EDetalleFacturacion> eDetalleFacturacionList = new List<EDetalleFacturacion>();
        EReporteFacturacionEncabezado eReporteFacturacionEncabezado;
        int idEncabezadoFacturacion = 0;
        int idCliente = 0;
        string nombreCliente = "";

        public frmReporteVentas()
        {
            InitializeComponent();
        }

        private void frmReporteVentas_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
            dtpFechaFinal.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
            llenarCbxClientes();
            llenarDataGridViewConEncabezados();
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            llenarCbxClientes();
            btnImprimir.Enabled = false;
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            llenarCbxClientes();
            btnImprimir.Enabled = false;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnImprimir.Enabled = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CReporteVentas cReporteVentas = new CReporteVentas();
            cReporteVentas.generarReporte(idEncabezadoFacturacion, eReporteFacturacionEncabezadoList, eDetalleFacturacionList, 
                eReporteFacturacionEncabezado, dtpFechaInicio.Value.Date.ToString("dd-MM-yyyy"), dtpFechaFinal.Value.Date.ToString("dd-MM-yyyy"), 
                nombreCliente);
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
            if (dtpFechaInicio.Value > dtpFechaFinal.Value)
            {
                utils.messageBoxFormatoIncorrecto("La Fecha Inicio debe ser inferior a la Fecha Final");
                dtpFechaInicio.Focus();
            }
            else
            {
                getValoresSeleccionados();
                llenarDataGridViewConEncabezados();
                btnImprimir.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (idEncabezadoFacturacion > 0)
            {
                idEncabezadoFacturacion = 0;
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
                idCliente = 0;
                nombreCliente = "";
                llenarDataGridViewConEncabezados();
            }
        }

        private void dgvVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarCompra();
        }

        #region Métodos creados

        private void llenarCbxClientes()
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFinal = dtpFechaFinal.Value.Date;

            DataTable dt = new LClientes().SeleccionarClientesActivosByIdUsuarioForReporteDT(utils.getIdUsuario(), fechaInicio, fechaFinal);

            DataRow dr = dt.NewRow();
            dr["ID_CLIENTE"] = "0";
            dr["CLIENTE"] = "SELECCIONAR";
            dt.Rows.InsertAt(dr, 0);

            cbxCliente.DisplayMember = "CLIENTE";
            cbxCliente.ValueMember = "ID_CLIENTE";
            cbxCliente.DataSource = dt;

            cbxCliente.SelectedIndex = 0;
        }

        private void getValoresSeleccionados()
        {
            if (cbxCliente.SelectedIndex > 0)
            {
                idCliente = int.Parse(cbxCliente.SelectedValue.ToString());

                DataRowView rowView = cbxCliente.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    int indexComa = rowView["CLIENTE"].ToString().IndexOf(",");
                    nombreCliente = rowView["CLIENTE"].ToString().Substring(0, indexComa);
                    Console.WriteLine("Nombre Cliente: " + nombreCliente);
                }
            }
            else
            {
                idCliente = 0;
                nombreCliente = "";
            }
        }

        private void llenarDataGridViewConEncabezados()
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFinal = dtpFechaFinal.Value.Date;

            eReporteFacturacionEncabezadoList = new LEncabezadoFacturacion().EncabezadosReporteFacturacion(fechaInicio, fechaFinal, utils.getIdUsuario(), 
                idCliente);

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("#");
            dt.Columns.Add("CLIENTE");
            dt.Columns.Add("TELÉFONO CLIENTE");
            dt.Columns.Add("FECHA DE FACTURACIÓN");
            dt.Columns.Add("MONTO");

            int numRegistro = 1;
            foreach (EReporteFacturacionEncabezado encabezadoFacturacion in eReporteFacturacionEncabezadoList)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(encabezadoFacturacion.IdEncabezadoFacturacion, numRegistro, 
                    String.Concat(encabezadoFacturacion.NombreCliente, " ", encabezadoFacturacion.ApellidoCliente), 
                    encabezadoFacturacion.TelefonoCliente, encabezadoFacturacion.FechaFacturacion.ToString("dd-MM-yyyy"), 
                    String.Concat("$", encabezadoFacturacion.MontoEncabezadoFacturacion.ToString("0.00")));
                numRegistro++;
            }
            dgvVentas.DataSource = dt;
            dgvVentas.Columns[0].Visible = false;//Ocultamos la columa del ID
            deshabilitarOrdenamientoDGV();
        }

        private void llenarDataGridViewConDetalle()
        {
            eDetalleFacturacionList = new LDetalleFacturacion().SeleccionarDetalleFacturacionByIdEncabezadoFacturacion(idEncabezadoFacturacion);

            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("PRODUCTO");
            dt.Columns.Add("CANTIDAD");
            dt.Columns.Add("PRECIO");
            dt.Columns.Add("SUB TOTAL");

            int numRegistro = 1;
            foreach (EDetalleFacturacion detalleFacturacion in eDetalleFacturacionList)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(numRegistro, detalleFacturacion.NombreProducto, detalleFacturacion.Cantidad.ToString(),
                    String.Concat("$", detalleFacturacion.Precio.ToString("0.00")),
                    String.Concat("$", detalleFacturacion.MontoDetalleFacturacion.ToString("0.00")));
                numRegistro++;
            }
            dgvVentas.DataSource = dt;
            deshabilitarOrdenamientoDGV();
        }

        private void seleccionarCompra()
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvVentas.SelectedRows)
                {
                    try
                    {
                        //Deshabilitamos las opciones para cambiar el filtro
                        dtpFechaInicio.Enabled = false;
                        dtpFechaFinal.Enabled = false;
                        btnFiltrar.Enabled = false;
                        btnLimpiar.Text = "Volver";

                        //Obtenemos los datos para el encabezado de la compra
                        eReporteFacturacionEncabezado = new EReporteFacturacionEncabezado();
                        //Utilizar solo el atributo NombreCliente para contener Nombre y Apellido del cliente
                        eReporteFacturacionEncabezado.NombreCliente = row.Cells[2].Value.ToString();
                        eReporteFacturacionEncabezado.TelefonoCliente = row.Cells[3].Value.ToString();
                        eReporteFacturacionEncabezado.FechaFacturacion = DateTime.Parse(row.Cells[4].Value.ToString());
                        eReporteFacturacionEncabezado.MontoEncabezadoFacturacion = Double.Parse(row.Cells[5].Value.ToString().Replace("$", ""));

                        idEncabezadoFacturacion = int.Parse(row.Cells[0].Value.ToString());
                        //Llenar dgvVentas con el detalle de la compra seleccionada
                        llenarDataGridViewConDetalle();
                    }
                    catch (Exception)
                    {
                        idEncabezadoFacturacion = 0;
                    }
                }
            }
        }

        private void deshabilitarOrdenamientoDGV()
        {
            foreach (DataGridViewColumn column in dgvVentas.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion
    }
}
