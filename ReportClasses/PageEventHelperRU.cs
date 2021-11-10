using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockIt.ReportClasses
{
    //Esta clase y sus métodos permiten agregar el número de página
    public class PageEventHelperRU : PdfPageEventHelper
    {
        PdfContentByte cb;
        PdfTemplate template;


        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            cb = writer.DirectContent;
            template = cb.CreateTemplate(50, 50);
        }

        public override void OnEndPage(PdfWriter writer, Document doc)
        {

            BaseColor grey = new BaseColor(128, 128, 128);
            iTextSharp.text.Font font = FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, grey);

            //tbl footer
            PdfPTable footerTbl = new PdfPTable(1);
            //footerTbl.TotalWidth = doc.PageSize.Width;
            footerTbl.TotalWidth = doc.PageSize.Width - doc.LeftMargin - doc.RightMargin;
            footerTbl.DefaultCell.Border = 0;

            //numero de la page
            Chunk myFooter = new Chunk("Página " + (doc.PageNumber));
            PdfPCell footer = new PdfPCell(new Phrase(myFooter));
            footer.Border = iTextSharp.text.Rectangle.NO_BORDER;
            footer.HorizontalAlignment = Element.ALIGN_RIGHT;
            footerTbl.AddCell(footer);


            footerTbl.WriteSelectedRows(0, -1, doc.LeftMargin, writer.PageSize.GetBottom(doc.BottomMargin) - 5, writer.DirectContent);
        }

        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);

        }
    }
}
