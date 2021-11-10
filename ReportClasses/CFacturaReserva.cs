using iTextSharp.text;
using iTextSharp.text.pdf;
using StockIt_Logica;
using StockIt_Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIt.ReportClasses
{
    public class CFacturaReserva
    {
        public void generarFacturaVenta(int idEncabezadoFacturacion)
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
                    EEncabezadoFacturacion eEncabezadoFacturacion = new LEncabezadoFacturacion().SeleccionarEncabezadoFacturacionByIdEncabezadoFacturacion(idEncabezadoFacturacion);

                    string nombreEmisor = eEncabezadoFacturacion.Nombres + " " + eEncabezadoFacturacion.Apellidos;//Nombre del Usuario
                    string nombreEmpresa = eEncabezadoFacturacion.NombreEmpresa;//Nombre de la Empresa
                    string nombreCliente = eEncabezadoFacturacion.NombreCliente + " " + eEncabezadoFacturacion.ApellidoCliente;//Nombre del Cliente
                    double montoFactura = eEncabezadoFacturacion.MontoEncabezadoFacturacion;//El monto total de la venta

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

                    #region Header de la Factura
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

                    var clientePhrase = new Phrase();
                    clientePhrase.Add(new Chunk("CLIENTE: ", negrita));
                    clientePhrase.Add(new Chunk(nombreCliente, fuenteEmision));

                    Chunk chunk = new Chunk();
                    document.Add(new Paragraph(chunk));
                    document.Add(new Paragraph("                       "));
                    document.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------------------------"));
                    document.Add(new Paragraph(fechaPhrase));
                    document.Add(new Paragraph(emisorPhrase));
                    document.Add(new Paragraph(empresaPhrase));
                    document.Add(new Paragraph(clientePhrase));
                    document.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------------------------"));
                    document.Add(new Paragraph("                       "));
                    #endregion

                    #region Detalle de la Factura
                    //Encabezado de la tabla
                    PdfPTable table = new PdfPTable(4);
                    float[] widths = new float[] { 40f, 15f, 20f, 25f };
                    table.SetWidths(widths);
                    
                    _cell = new PdfPCell(new Paragraph("PRODUCTO", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("CANTIDAD", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("PRECIO U.", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("SUBTOTAL", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    table.WidthPercentage = 100f;

                    //Lista de productos de la venta
                    List<EDetalleFacturacion> eDetalleFacturacionList = new LDetalleFacturacion().SeleccionarDetalleFacturacionByIdEncabezadoFacturacion(idEncabezadoFacturacion);

                    foreach (EDetalleFacturacion eDetalleFacturacion in eDetalleFacturacionList)
                    {
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
                    }

                    #region Total de Factura
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

                    _cell = new PdfPCell(new Paragraph(String.Concat("$", montoFactura.ToString("0.00")), fuente));
                    _cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    table.AddCell(_cell);

                    document.Add(table);
                    #endregion

                    #endregion

                    document.Close();

                    Utils utils = new Utils();
                    utils.messageBoxOperacionExitosa("La factura se guardó como " + Path.GetFileNameWithoutExtension(rutaArchivoFinal) + ".pdf");
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
