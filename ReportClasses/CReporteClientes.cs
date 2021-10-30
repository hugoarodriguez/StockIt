using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Windows.Forms;
using System.IO;
using StockIt_Entidades;
using StockIt_Logica;

namespace StockIt.ReportClasses
{
    class CReporteClientes
    {
        LUtils lUtils = new LUtils();
        Utils utils = new Utils();
        public void generarReporteClientes(int idUsuario)
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

                    //Fecha de creacion para poner en el PDF
                    string fechaCreacion = lUtils.fechaDDMMAAAA();
                    document.AddCreationDate();

                    /*Agregar otra imagen (puede ser un texto que diga StockIt) a la carpeta "Resources" 
                     * y establecer la propiedad "Copy to Output Directory" de esta imagen como "Copy always" */
                    string nombreImagen = "logoStockIt.jpg";//Cambiar nombre por el de la nueva imagen

                    string PathImage = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources\\" + nombreImagen);

                    //Cambiar propiedades de tamaño y posición de la imagen según sea necesario
                    //Begin image
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(PathImage);
                    logo.SetAbsolutePosition(400f, 700f);
                    logo.ScaleAbsolute(110f, 80f);
                    float percentage = 0.0f;
                    percentage = 200 / logo.Width;
                    logo.ScalePercent(percentage * 100);
                    
                    document.Add(logo);
                    //End image;

                    //Header del reporte
                    PdfPTable tbHeader = new PdfPTable(3);

                    tbHeader.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                    tbHeader.DefaultCell.Border = 0;
                    tbHeader.AddCell(new Paragraph());

                    PdfPCell _cell = new PdfPCell(new Paragraph("REPORTE DE CLIENTES", title));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    _cell.Border = 0;
                    tbHeader.AddCell(_cell);

                    tbHeader.AddCell(new Paragraph());
                    tbHeader.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetTop(document.TopMargin) + 2, writer.DirectContent);

                    string nombreCompleto = new LUsuarios().getNombreUsuario(utils.getCorreoUsuario());

                    var emisorPhrase = new Phrase();
                    emisorPhrase.Add(new Chunk("Nombre del emisor: ", negrita));
                    emisorPhrase.Add(new Chunk(nombreCompleto, fuenteEmision));

                    var fechaPhrase = new Phrase();
                    fechaPhrase.Add(new Chunk("Fecha y hora de emisión: ", negrita));
                    fechaPhrase.Add(new Chunk(fechaCreacion, fuenteEmision));

                    Chunk chunk = new Chunk();
                    document.Add(new Paragraph(chunk));
                    document.Add(new Paragraph("                       "));
                    document.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------------------------"));
                    document.Add(new Paragraph(emisorPhrase));
                    document.Add(new Paragraph(fechaPhrase));
                    document.Add(new Paragraph("------------------------------------------------------------------------------------------------------------------------------------------"));
                    document.Add(new Paragraph("                       "));

                    //Encabezado de la tabla
                    PdfPTable table = new PdfPTable(5);
                    float[] widths = new float[] { 10f, 35f, 20f, 20f, 15f };
                    table.SetWidths(widths);

                    _cell = new PdfPCell(new Paragraph("#", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("NOMBRE", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("TELEFONO", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("CORREO", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    _cell = new PdfPCell(new Paragraph("SEXO", negrita));
                    _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(_cell);

                    table.WidthPercentage = 100f;

                    /********* Esto será cambiado dinámicamente con la BD *********/
                    //La lista de los empleados
                    List<ECliente> eClientesList = new LClientes().SeleccionarClientesActivosByIdUsuario(idUsuario);

                    int numRegistro = 1;
                    foreach (var item in eClientesList)
                    {
                        _cell = new PdfPCell(new Paragraph(numRegistro.ToString(), fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(item.NombreCliente + " " + item.ApellidoCliente, fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(item.TelefonoCliente, fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(item.CorreoCliente, fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);

                        _cell = new PdfPCell(new Paragraph(item.SexoCliente == "M" ? "MASCULINO" : "FEMENINO", fuente));
                        _cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(_cell);
                        numRegistro++;
                    }

                    document.Add(table);

                    document.Close();

                    
                    utils.messageBoxOperacionExitosa("El reporte se guardó como " + Path.GetFileNameWithoutExtension(rutaArchivoFinal) + ".pdf");
                }
            }
            catch (Exception)
            {
                
                utils.messageBoxOperacionSinExito("No se pudo generar el reporte. Intente más tarde.");
            }
        }
    }
}
