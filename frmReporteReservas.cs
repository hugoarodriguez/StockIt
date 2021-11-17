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
    public partial class frmReporteReservas : Form
    {
        Utils utils = new Utils();
        List<EReporteReservasEncabezado> eReporteReservasEncabezadoList = new List<EReporteReservasEncabezado>();
        List<EReporteReservasDetalle> eDetalleReservasList = new List<EReporteReservasDetalle>();
        EReporteReservasEncabezado eReporteReservasEncabezado;
        int idEncabezadoReserva = 0;
        int idCliente = 0;
        string nombreCliente = "";
        string estadoReserva = "";
        string nombreEstadoReserva = "";

        public frmReporteReservas()
        {
            InitializeComponent();
        }

        private void frmReporteReservas_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
            dtpFechaFinal.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
            llenarCbxEstadosReserva();
            getValoresSeleccionados();
            llenarCbxClientes();
            llenarDataGridViewConEncabezados();
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            llenarCbxEstadosReserva();
            getValoresSeleccionados();
            llenarCbxClientes();
            btnImprimir.Enabled = false;
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            llenarCbxEstadosReserva();
            getValoresSeleccionados();
            llenarCbxClientes();
            btnImprimir.Enabled = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CReporteReservas cReporteReservas = new CReporteReservas();
            cReporteReservas.generarReporte(idEncabezadoReserva, eReporteReservasEncabezadoList, eDetalleReservasList,
                eReporteReservasEncabezado, dtpFechaInicio.Value.Date.ToString("dd-MM-yyyy"), dtpFechaFinal.Value.Date.ToString("dd-MM-yyyy"),
                nombreEstadoReserva, nombreCliente);
        }

        private void cbxEstadoReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            getValoresSeleccionados();
            llenarCbxClientes();
            btnImprimir.Enabled = false;
        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnImprimir.Enabled = false;
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
            if (idEncabezadoReserva > 0)
            {
                idEncabezadoReserva = 0;
                dtpFechaInicio.Enabled = true;
                dtpFechaFinal.Enabled = true;
                btnFiltrar.Enabled = true;
                cbxEstadoReserva.Enabled = true;
                cbxCliente.Enabled = true;
                btnLimpiar.Text = "Limpiar";
                llenarDataGridViewConEncabezados();
            }
            else
            {
                dtpFechaInicio.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
                dtpFechaFinal.Value = DateTime.Parse(new LUtils().fechaHoraActual()).Date;
                idCliente = 0;
                nombreCliente = "";
                estadoReserva = "";
                nombreEstadoReserva = "";
                llenarDataGridViewConEncabezados();
            }
        }

        private void dgvReservas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarCompra();
        }

        #region Métodos creados

        private void llenarCbxEstadosReserva()
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFinal = dtpFechaFinal.Value.Date;

            DataTable dt = new LDetalleReservas().SeleccionarEstadosReservaByIdUsuarioAndFechasForReporteDT(utils.getIdUsuario(), fechaInicio, fechaFinal);

            DataRow dr = dt.NewRow();
            dr["ESTADO_RESERVA"] = "0";
            dr["NOMBRE_ESTADO"] = "TODOS";
            dt.Rows.InsertAt(dr, 0);

            cbxEstadoReserva.DisplayMember = "NOMBRE_ESTADO";
            cbxEstadoReserva.ValueMember = "ESTADO_RESERVA";
            cbxEstadoReserva.DataSource = dt;

            cbxEstadoReserva.SelectedIndex = 0;
        }

        private void llenarCbxClientes()
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFinal = dtpFechaFinal.Value.Date;

            DataTable dt = new LClientes().SeleccionarClientesByIdUsuarioFechasAndEstadoReservaForReporteDT(utils.getIdUsuario(), fechaInicio, fechaFinal, 
                estadoReserva);

            DataRow dr = dt.NewRow();
            dr["ID_CLIENTE"] = "0";
            dr["CLIENTE"] = "TODOS";
            dt.Rows.InsertAt(dr, 0);

            cbxCliente.DisplayMember = "CLIENTE";
            cbxCliente.ValueMember = "ID_CLIENTE";
            cbxCliente.DataSource = dt;

            cbxCliente.SelectedIndex = 0;
        }

        private void getValoresSeleccionados()
        {
            if (cbxEstadoReserva.SelectedIndex > 0)
            {
                estadoReserva = cbxEstadoReserva.SelectedValue.ToString();

                DataRowView rowView = cbxEstadoReserva.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    nombreEstadoReserva = rowView["NOMBRE_ESTADO"].ToString();
                }
            }
            else
            {
                estadoReserva = "";
                nombreEstadoReserva = "";
            }

            if (cbxCliente.SelectedIndex > 0)
            {
                idCliente = int.Parse(cbxCliente.SelectedValue.ToString());

                DataRowView rowView = cbxCliente.SelectedItem as DataRowView;
                if (rowView != null)
                {
                    nombreCliente = rowView["CLIENTE"].ToString();
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

            eReporteReservasEncabezadoList = new LEncabezadoReservas().EncabezadosReporteReservas(fechaInicio, fechaFinal, utils.getIdUsuario(),
                estadoReserva, idCliente);

            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("#");
            dt.Columns.Add("CLIENTE");
            dt.Columns.Add("TELÉFONO");
            dt.Columns.Add("F. RESERVA");
            dt.Columns.Add("F. PROMESA\nENTREGA");
            dt.Columns.Add("MONTO");
            dt.Columns.Add("ESTADO");

            int numRegistro = 1;
            foreach (EReporteReservasEncabezado encabezadoReserva in eReporteReservasEncabezadoList)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(encabezadoReserva.IdEncabezadoReserva, numRegistro,
                    String.Concat(encabezadoReserva.NombreCliente, " ", encabezadoReserva.ApellidoCliente),
                    encabezadoReserva.TelefonoCliente,
                    encabezadoReserva.FechaReserva.ToString("dd-MM-yyyy"), encabezadoReserva.FechaPromesaEntrega.ToString("dd-MM-yyyy"), 
                    String.Concat("$", encabezadoReserva.MontoEncabezadoReserva.ToString("0.00")), 
                    encabezadoReserva.EstadoReserva);
                numRegistro++;
            }
            dgvReservas.DataSource = dt;
            dgvReservas.Columns[0].Visible = false;//Ocultamos la columa del ID
            deshabilitarOrdenamientoDGV();
        }

        private void llenarDataGridViewConDetalle()
        {
            eDetalleReservasList = new LDetalleReservas().DetalleReporteReservas(idEncabezadoReserva);

            DataTable dt = new DataTable();
            dt.Columns.Add("#");
            dt.Columns.Add("PRODUCTO");
            dt.Columns.Add("CANTIDAD");
            dt.Columns.Add("PRECIO");
            dt.Columns.Add("SUB TOTAL");

            int numRegistro = 1;
            foreach (EReporteReservasDetalle detalleReserva in eDetalleReservasList)
            {
                DataRow dr = dt.NewRow();
                dr.Table.Rows.Add(numRegistro, detalleReserva.NombreProducto, detalleReserva.Cantidad.ToString(),
                    String.Concat("$", detalleReserva.PrecioProducto.ToString("0.00")),
                    String.Concat("$", detalleReserva.Monto.ToString("0.00")));
                numRegistro++;
            }
            dgvReservas.DataSource = dt;
            deshabilitarOrdenamientoDGV();
        }

        private void seleccionarCompra()
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                cbxCliente.Enabled = false;
                foreach (DataGridViewRow row in dgvReservas.SelectedRows)
                {
                    try
                    {
                        //Deshabilitamos las opciones para cambiar el filtro
                        dtpFechaInicio.Enabled = false;
                        dtpFechaFinal.Enabled = false;
                        cbxEstadoReserva.Enabled = false;
                        cbxCliente.Enabled = false;
                        btnFiltrar.Enabled = false;
                        btnLimpiar.Text = "Volver";

                        //Obtenemos los datos para el encabezado de la compra
                        eReporteReservasEncabezado = new EReporteReservasEncabezado();
                        //Utilizar solo el atributo NombreCliente para contener Nombre y Apellido del cliente
                        eReporteReservasEncabezado.NombreCliente = row.Cells[2].Value.ToString() + " TEL.:" + row.Cells[3].Value.ToString();
                        nombreCliente = row.Cells[2].Value.ToString() + " TEL.:" + row.Cells[3].Value.ToString();
                        eReporteReservasEncabezado.FechaReserva = DateTime.Parse(row.Cells[4].Value.ToString());
                        eReporteReservasEncabezado.FechaPromesaEntrega = DateTime.Parse(row.Cells[5].Value.ToString());
                        eReporteReservasEncabezado.MontoEncabezadoReserva = Double.Parse(row.Cells[6].Value.ToString().Replace("$", ""));
                        eReporteReservasEncabezado.EstadoReserva = row.Cells[7].Value.ToString();

                        idEncabezadoReserva = int.Parse(row.Cells[0].Value.ToString());
                        //Llenar dgvVentas con el detalle de la compra seleccionada
                        llenarDataGridViewConDetalle();
                    }
                    catch (Exception)
                    {
                        idEncabezadoReserva = 0;
                    }
                }
            }
        }

        private void deshabilitarOrdenamientoDGV()
        {
            foreach (DataGridViewColumn column in dgvReservas.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        #endregion
    }
}
