using iTextSharp.text;
using iTextSharp.text.pdf;
using StockIt_Entidades;
using StockIt_Logica;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt.ReportClasses
{
    public class CReporteCompraProductos
    {
        public void generarReporte(int idEncabezadoCompra, List<EReporteProductosEncabezado> eReporteProductosEncabezadoList, 
            List<EReporteProductosDetalle> eReporteProductosDetalleList, EReporteProductosEncabezado eReporteProductosEncabezado,
            string fechaInicio, string fechaFinal)
        {
            if (idEncabezadoCompra == 0)
            {
                //Hacer reporte general
                generarReporteCompraGeneral(eReporteProductosEncabezadoList, fechaInicio, fechaFinal);
            }
            else
            {
                //Hacer reporte específicado por idEncabezadoCompra
                generarReporteCompraDetalle(eReporteProductosDetalleList, eReporteProductosEncabezado);
            }
        }
        private void generarReporteCompraGeneral(List<EReporteProductosEncabezado> eReporteProductosEncabezadoList, string fechaInicio, string fechaFinal)
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
                    string TITULO = "REPORTE GENERAL DE COMPRA DE PRODUCTOS";//Título a mostrar en el Encabezado
                    string fechaEmision = new LUtils().fechaHoraActual();//Fecha de creacion para poner en el PDF

                    //Obtenemos los datos del Encabezado
                    EUsuario eUsuario = new LUsuarios().seleccionarUsuarioByCorreo(new Utils().getCorreoUsuario());

                    string nombreEmisor = String.Concat(eUsuario.Nombres, " ", eUsuario.Apellidos);//Nombre del Usuario
                    string nombreEmpresa = eUsuario.NombreEmpresa;//Nombre de la Empresa
                    string filtro = String.Concat(fechaInicio, " a ", fechaFinal);//Nombre de la Empresa
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

                    var filtroPhrase = new Phrase();
                    filtroPhrase.Add(new Chunk("FILTRO: ", negrita));
                    filtroPhrase.Add(new Chunk(filtro, fuenteEmision));

                    Chunk chunk = new Chunk();
                    document.Add(new Paragraph(chunk));
                    document.Add(new Paragraph("                       "));
                    document.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------------------------"));
                    document.Add(new Paragraph(fechaPhrase));
                    document.Add(new Paragraph(emisorPhrase));
                    document.Add(new Paragraph(empresaPhrase));
                    document.Add(new Paragraph(filtroPhrase));
                    document.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------------------------"));
                    document.Add(new Paragraph("                       "));
                    #endregion

                    #region Listado General de las Compras
                    //Encabezado de la tabla
                    PdfPTable table = new PdfPTable(4);
                    float[] widths = new float[] { 15f, 40f, 20f, 25f };
                    table.SetWidths(widths);

                    _cell = new PdfPCell(new Paragraph("#", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("PROVEEDOR", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("FECHA INGRESO", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("MONTO DE COMPRA", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    table.WidthPercentage = 100f;

                    int numCompra = 1;

                    foreach (EReporteProductosEncabezado eReporteProductosEncabezado in eReporteProductosEncabezadoList)
                    {
                        _cell = new PdfPCell(new Paragraph(numCompra.ToString(), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(eReporteProductosEncabezado.NombreProveedor.ToString(), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(eReporteProductosEncabezado.FechaIngreso.ToString("dd-MM-yyyy"), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(String.Concat("$", eReporteProductosEncabezado.Monto.ToString("0.00")), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(_cell);
                        numCompra++;
                        montoCompra += eReporteProductosEncabezado.Monto;
                    }

                    #region Total de Compra
                    _cell = new PdfPCell(new Paragraph("", fuente));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    _cell.Border = Rectangle.LEFT_BORDER | Rectangle.BOTTOM_BORDER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("", fuente));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    _cell.Border = Rectangle.TOP_BORDER | Rectangle.BOTTOM_BORDER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("TOTAL", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
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

        private void generarReporteCompraDetalle(List<EReporteProductosDetalle> eReporteProductosDetalleList, 
            EReporteProductosEncabezado eReporteProductosEncabezado)
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
                    string TITULO = "FACTURA DE COMPRA DE PRODUCTOS";//Título a mostrar en el Encabezado
                    string fechaEmision = new LUtils().fechaHoraActual();//Fecha de creacion para poner en el PDF

                    //Obtenemos los datos del Encabezado
                    EUsuario eUsuario = new LUsuarios().seleccionarUsuarioByCorreo(new Utils().getCorreoUsuario());

                    string nombreEmisor = String.Concat(eUsuario.Nombres, " ", eUsuario.Apellidos);//Nombre del Usuario
                    string nombreEmpresa = eUsuario.NombreEmpresa;//Nombre de la Empresa
                    string nombreProveedor = eReporteProductosEncabezado.NombreProveedor;//Nombre del Proveedor
                    string fechaCompra = eReporteProductosEncabezado.FechaIngreso.ToString("dd-MM-yyyy");//Nombre del Proveedor
                    double montoCompra = eReporteProductosEncabezado.Monto;//El monto total de la compra

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

                    var filtroPhrase = new Phrase();
                    filtroPhrase.Add(new Chunk("PROVEEDOR: ", negrita));
                    filtroPhrase.Add(new Chunk(nombreProveedor, fuenteEmision));

                    var fechaCompraPhrase = new Phrase();
                    fechaCompraPhrase.Add(new Chunk("FECHA DE COMPRA: ", negrita));
                    fechaCompraPhrase.Add(new Chunk(fechaCompra, fuenteEmision));

                    Chunk chunk = new Chunk();
                    document.Add(new Paragraph(chunk));
                    document.Add(new Paragraph("                       "));
                    document.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------------------------"));
                    document.Add(new Paragraph(fechaPhrase));
                    document.Add(new Paragraph(emisorPhrase));
                    document.Add(new Paragraph(empresaPhrase));
                    document.Add(new Paragraph(filtroPhrase));
                    document.Add(new Paragraph(fechaCompraPhrase));
                    document.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------------------------"));
                    document.Add(new Paragraph("                       "));
                    #endregion

                    #region Listado General de las Compras
                    //Encabezado de la tabla
                    PdfPTable table = new PdfPTable(7);
                    float[] widths = new float[] { 8f, 25f, 15f, 12f, 15f, 15f, 15f };
                    table.SetWidths(widths);

                    _cell = new PdfPCell(new Paragraph("#", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("PRODUCTO", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("CATEGORÍA", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("CANTIDAD", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("PRECIO LOTE", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("PRECIO UNITARIO (COMPRA)", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("PRECIO UNITARIO (VENTA)", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    table.WidthPercentage = 100f;

                    int numProducto = 1;

                    foreach (EReporteProductosDetalle eReporteProductosDetalle in eReporteProductosDetalleList)
                    {
                        _cell = new PdfPCell(new Paragraph(numProducto.ToString(), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(eReporteProductosDetalle.NombreProducto, fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(eReporteProductosDetalle.Categoria, fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(eReporteProductosDetalle.Cantidad.ToString(), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(String.Concat("$", eReporteProductosDetalle.PrecioLote.ToString("0.00")), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(String.Concat("$", eReporteProductosDetalle.PrecioUnitario.ToString("0.00")), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(_cell);


                        _cell = new PdfPCell(new Paragraph(String.Concat("$", eReporteProductosDetalle.PrecioVenta.ToString("0.00")), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                        table.AddCell(_cell);

                        numProducto++;
                    }

                    #region Total de Compra
                    _cell = new PdfPCell(new Paragraph("TOTAL", negrita)) { Colspan = 5 };
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
