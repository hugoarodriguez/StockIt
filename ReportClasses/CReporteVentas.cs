using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using StockIt_Entidades;
using StockIt_Logica;

namespace StockIt.ReportClasses
{
    public class CReporteVentas
    {
        private List<EReporteFacturacionEncabezado> eReporteFacturacionEncabezadoList;
        private List<EDetalleFacturacion> eDetalleFacturacionList;
        private EReporteFacturacionEncabezado eReporteFacturacionEncabezado;
        private string fechaInicio, fechaFinal;
        private string nombreCliente;
        public void generarReporte(int idEncabezadoFacturacion, List<EReporteFacturacionEncabezado> eReporteFacturacionEncabezadoList,
            List<EDetalleFacturacion> eDetalleFacturacionList, EReporteFacturacionEncabezado eReporteFacturacionEncabezado,
            string fechaInicio, string fechaFinal, string nombreCliente)
        {
            this.eReporteFacturacionEncabezadoList = eReporteFacturacionEncabezadoList;
            this.eDetalleFacturacionList = eDetalleFacturacionList;
            this.eReporteFacturacionEncabezado = eReporteFacturacionEncabezado;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.nombreCliente = nombreCliente;

            if (idEncabezadoFacturacion == 0)
            {
                //Hacer reporte general
                generarReporteVentasGeneral();
            }
            else
            {
                //Hacer reporte específicado por idEncabezadoCompra
                generarReporteVentasDetalle();
            }
        }
        private void generarReporteVentasGeneral()
        {
            try
            {
                SaveFileDialog svg = new SaveFileDialog();
                DialogResult dialogResult = svg.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    Document document = new Document(PageSize.LETTER, 30f, 30f, 80f, 40f);

                    string rutaArchivo = svg.FileName;
                    string rutaArchivoFinal = svg.FileName;

                    if (rutaArchivo.Contains(".pdf"))
                    {
                        rutaArchivoFinal = rutaArchivo.Replace(".pdf", "");
                    }

                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(rutaArchivoFinal + ".pdf", FileMode.Create));
                    writer.PageEvent = new PageEventHelperRU();//Con esto agregamos los números de página

                    document.Open();

                    //Tipo de fuente
                    Font fuenteEmision = FontFactory.GetFont("Arial", 10, BaseColor.BLACK);
                    Font fuente = FontFactory.GetFont("Arial", 10, BaseColor.BLACK);
                    Font negrita = FontFactory.GetFont("Arial", 10, Font.BOLD, BaseColor.BLACK);
                    Font title = FontFactory.GetFont("Arial", 12, Font.BOLD, BaseColor.BLACK);


                    /* Variables para encabezado */
                    string TITULO = "REPORTE GENERAL\n DE VENTAS";//Título a mostrar en el Encabezado
                    string fechaEmision = new LUtils().fechaHoraActual();//Fecha de creacion para poner en el PDF

                    //Obtenemos los datos del Encabezado
                    EUsuario eUsuario = new LUsuarios().seleccionarUsuarioByCorreo(new Utils().getCorreoUsuario());

                    string nombreEmisor = String.Concat(eUsuario.Nombres, " ", eUsuario.Apellidos);//Nombre del Usuario
                    string nombreEmpresa = eUsuario.NombreEmpresa;//Nombre de la Empresa
                    string filtroFecha = String.Concat(this.fechaInicio, " a ", this.fechaFinal);//Nombre de la Empresa
                    string filtroCliente = this.nombreCliente != "" ? this.nombreCliente : "TODOS";
                    double montoCompra = 0.0;//El monto total de la compra

                    document.AddCreationDate();

                    #region Asignacion del Logo de StockIt
                    string nombreImagen = "logoStockIt.jpg";//Cambiar nombre por el de la nueva imagen

                    string PathImage = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources\\" + nombreImagen);

                    //Begin image
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(PathImage);
                    logo.SetAbsolutePosition(400f, 700f);
                    logo.ScaleAbsolute(110f, 80f);
                    float percentage = 0.0f;
                    percentage = 200 / logo.Width;
                    logo.ScalePercent(percentage * 100);
                    document.Add(logo);
                    //End image;
                    #endregion

                    #region Header de la Compra
                    PdfPTable tbHeader = new PdfPTable(3);

                    tbHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                    tbHeader.DefaultCell.Border = 0;
                    tbHeader.AddCell(new Paragraph());

                    PdfPCell _cell = new PdfPCell(new Paragraph(TITULO, title));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    _cell.Border = 0;
                    tbHeader.AddCell(_cell);

                    tbHeader.AddCell(new Paragraph());
                    tbHeader.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin) + 2, writer.DirectContent);

                    var fechaPhrase = new Phrase();
                    fechaPhrase.Add(new Chunk("FECHA Y HORA DE EMISIÓN: ", negrita));
                    fechaPhrase.Add(new Chunk(fechaEmision, fuenteEmision));

                    var emisorPhrase = new Phrase();
                    emisorPhrase.Add(new Chunk("NOMBRE DEL EMISOR: ", negrita));
                    emisorPhrase.Add(new Chunk(nombreEmisor, fuenteEmision));

                    var empresaPhrase = new Phrase();
                    empresaPhrase.Add(new Chunk("EMPRESA: ", negrita));
                    empresaPhrase.Add(new Chunk(nombreEmpresa, fuenteEmision));

                    var filtroFechaPhrase = new Phrase();
                    filtroFechaPhrase.Add(new Chunk("FILTRO DE FECHAS: ", negrita));
                    filtroFechaPhrase.Add(new Chunk(filtroFecha, fuenteEmision));

                    var clientePhrase = new Phrase();
                    clientePhrase.Add(new Chunk("CLIENTE: ", negrita));
                    clientePhrase.Add(new Chunk(filtroCliente, fuenteEmision));

                    Chunk chunk = new Chunk();
                    document.Add(new Paragraph(chunk));
                    document.Add(new Paragraph("                       "));
                    document.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------------------------"));
                    document.Add(new Paragraph(fechaPhrase));
                    document.Add(new Paragraph(emisorPhrase));
                    document.Add(new Paragraph(empresaPhrase));
                    document.Add(new Paragraph(filtroFechaPhrase));
                    document.Add(new Paragraph(clientePhrase));
                    document.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------------------------"));
                    document.Add(new Paragraph("                       "));
                    #endregion

                    #region Listado General de las Compras
                    //Encabezado de la tabla
                    PdfPTable table = new PdfPTable(5);
                    float[] widths = new float[] { 15f, 30f, 15f, 15f, 25f };
                    table.SetWidths(widths);

                    _cell = new PdfPCell(new Paragraph("#", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("CLIENTE", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("TELÉFONO\nCLIENTE", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("FECHA\nVENTA", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("MONTO VENTA", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    table.WidthPercentage = 100f;

                    int numCompra = 1;

                    foreach (EReporteFacturacionEncabezado eReporteFacturacionEncabezado in this.eReporteFacturacionEncabezadoList)
                    {
                        _cell = new PdfPCell(new Paragraph(numCompra.ToString(), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(String.Concat(eReporteFacturacionEncabezado.NombreCliente, " ", 
                            eReporteFacturacionEncabezado.ApellidoCliente), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(eReporteFacturacionEncabezado.TelefonoCliente, fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(eReporteFacturacionEncabezado.FechaFacturacion.ToString("dd-MM-yyyy"), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(String.Concat("$", eReporteFacturacionEncabezado.MontoEncabezadoFacturacion.ToString("0.00")), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(_cell);
                        numCompra++;
                        montoCompra += eReporteFacturacionEncabezado.MontoEncabezadoFacturacion;
                    }

                    #region Total de Compra
                    _cell = new PdfPCell(new Paragraph("TOTAL", negrita)) { Colspan = 4 };
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    _cell.Border = Rectangle.LEFT_BORDER | Rectangle.TOP_BORDER | Rectangle.BOTTOM_BORDER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph(String.Concat("$", montoCompra.ToString("0.00")), fuente));
                    _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    table.AddCell(_cell);

                    document.Add(table);
                    #endregion

                    #endregion

                    document.Close();

                    Utils utils = new Utils();
                    utils.messageBoxOperacionExitosa("El reporte se guardó como " + Path.GetFileNameWithoutExtension(rutaArchivoFinal) + ".pdf");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Utils utils = new Utils();
                utils.messageBoxOperacionSinExito("No se pudo generar la factura. Intente más tarde.");
            }
        }

        private void generarReporteVentasDetalle()
        {
            try
            {
                SaveFileDialog svg = new SaveFileDialog();
                DialogResult dialogResult = svg.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    Document document = new Document(PageSize.LETTER, 30f, 30f, 80f, 40f);

                    string rutaArchivo = svg.FileName;
                    string rutaArchivoFinal = svg.FileName;

                    if (rutaArchivo.Contains(".pdf"))
                    {
                        rutaArchivoFinal = rutaArchivo.Replace(".pdf", "");
                    }

                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(rutaArchivoFinal + ".pdf", FileMode.Create));
                    writer.PageEvent = new PageEventHelperRU();//Con esto agregamos los números de página

                    document.Open();

                    //Tipo de fuente
                    Font fuenteEmision = FontFactory.GetFont("Arial", 10, BaseColor.BLACK);
                    Font fuente = FontFactory.GetFont("Arial", 10, BaseColor.BLACK);
                    Font negrita = FontFactory.GetFont("Arial", 10, Font.BOLD, BaseColor.BLACK);
                    Font title = FontFactory.GetFont("Arial", 12, Font.BOLD, BaseColor.BLACK);


                    /* Variables para encabezado */
                    string TITULO = "FACTURA DE VENTA";//Título a mostrar en el Encabezado
                    string fechaEmision = new LUtils().fechaHoraActual();//Fecha de creacion para poner en el PDF

                    //Obtenemos los datos del Encabezado
                    EUsuario eUsuario = new LUsuarios().seleccionarUsuarioByCorreo(new Utils().getCorreoUsuario());

                    string nombreEmisor = String.Concat(eUsuario.Nombres, " ", eUsuario.Apellidos);//Nombre del Usuario
                    string nombreEmpresa = eUsuario.NombreEmpresa;//Nombre de la Empresa
                    string fechaVenta = eReporteFacturacionEncabezado.FechaFacturacion.ToString("dd-MM-yyyy");
                    string filtroCliente = this.nombreCliente != "" ? nombreCliente : "TODOS";
                    double montoCompra = eReporteFacturacionEncabezado.MontoEncabezadoFacturacion;//El monto total de la compra

                    document.AddCreationDate();

                    #region Asignacion del Logo de StockIt
                    string nombreImagen = "logoStockIt.jpg";//Cambiar nombre por el de la nueva imagen

                    string PathImage = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources\\" + nombreImagen);

                    //Begin image
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(PathImage);
                    logo.SetAbsolutePosition(400f, 700f);
                    logo.ScaleAbsolute(110f, 80f);
                    float percentage = 0.0f;
                    percentage = 200 / logo.Width;
                    logo.ScalePercent(percentage * 100);
                    document.Add(logo);
                    //End image;
                    #endregion

                    #region Header de la Compra
                    PdfPTable tbHeader = new PdfPTable(3);

                    tbHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                    tbHeader.DefaultCell.Border = 0;
                    tbHeader.AddCell(new Paragraph());

                    PdfPCell _cell = new PdfPCell(new Paragraph(TITULO, title));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    _cell.Border = 0;
                    tbHeader.AddCell(_cell);

                    tbHeader.AddCell(new Paragraph());
                    tbHeader.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin) + 2, writer.DirectContent);

                    var fechaPhrase = new Phrase();
                    fechaPhrase.Add(new Chunk("FECHA Y HORA DE EMISIÓN: ", negrita));
                    fechaPhrase.Add(new Chunk(fechaEmision, fuenteEmision));

                    var emisorPhrase = new Phrase();
                    emisorPhrase.Add(new Chunk("NOMBRE DEL EMISOR: ", negrita));
                    emisorPhrase.Add(new Chunk(nombreEmisor, fuenteEmision));

                    var empresaPhrase = new Phrase();
                    empresaPhrase.Add(new Chunk("EMPRESA: ", negrita));
                    empresaPhrase.Add(new Chunk(nombreEmpresa, fuenteEmision));

                    var fechaVentaPhrase = new Phrase();
                    fechaVentaPhrase.Add(new Chunk("FECHA DE VENTA: ", negrita));
                    fechaVentaPhrase.Add(new Chunk(fechaVenta, fuenteEmision));

                    var clientePhrase = new Phrase();
                    clientePhrase.Add(new Chunk("CLIENTE: ", negrita));
                    clientePhrase.Add(new Chunk(filtroCliente, fuenteEmision));

                    Chunk chunk = new Chunk();
                    document.Add(new Paragraph(chunk));
                    document.Add(new Paragraph("                       "));
                    document.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------------------------"));
                    document.Add(new Paragraph(fechaPhrase));
                    document.Add(new Paragraph(emisorPhrase));
                    document.Add(new Paragraph(empresaPhrase));
                    document.Add(new Paragraph(fechaVentaPhrase));
                    document.Add(new Paragraph(clientePhrase));
                    document.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------------------------"));
                    document.Add(new Paragraph("                       "));
                    #endregion

                    #region Listado General de las Compras
                    //Encabezado de la tabla
                    PdfPTable table = new PdfPTable(5);
                    float[] widths = new float[] { 15f, 30f, 15f, 15f, 25f };
                    table.SetWidths(widths);

                    _cell = new PdfPCell(new Paragraph("#", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("PRODUCTO", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("CANTIDAD", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("PRECIO", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("SUBTOTAL", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    table.WidthPercentage = 100f;

                    int numProducto = 1;

                    foreach (EDetalleFacturacion eDetalleFacturacion in eDetalleFacturacionList)
                    {
                        _cell = new PdfPCell(new Paragraph(numProducto.ToString(), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(eDetalleFacturacion.NombreProducto, fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(eDetalleFacturacion.Cantidad.ToString(), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(String.Concat("$", eDetalleFacturacion.Precio.ToString("0.00")), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(String.Concat("$", eDetalleFacturacion.MontoDetalleFacturacion.ToString("0.00")), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(_cell);

                        numProducto++;
                    }

                    #region Total de Compra
                    _cell = new PdfPCell(new Paragraph("TOTAL", negrita)) { Colspan = 4 };
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    _cell.Border = Rectangle.LEFT_BORDER | Rectangle.TOP_BORDER | Rectangle.BOTTOM_BORDER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph(String.Concat("$", montoCompra.ToString("0.00")), fuente)) { Colspan = 2 };
                    _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    table.AddCell(_cell);

                    document.Add(table);
                    #endregion

                    #endregion

                    document.Close();

                    Utils utils = new Utils();
                    utils.messageBoxOperacionExitosa("El reporte se guardó como " + Path.GetFileNameWithoutExtension(rutaArchivoFinal) + ".pdf");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Utils utils = new Utils();
                utils.messageBoxOperacionSinExito("No se pudo generar la factura. Intente más tarde.");
            }
        }
    }
}
