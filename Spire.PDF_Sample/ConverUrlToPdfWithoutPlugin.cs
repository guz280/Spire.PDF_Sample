using Spire.Pdf;
using System.Threading;
using Spire.Pdf.HtmlConverter;
using System.Drawing;
using System;

namespace Spire.PDF_Sample
{
    internal static class ConverUrlToPdfWithoutPlugin
    {
        public static void Generate()
        {
            try
            {
                //Create a PdfDocument object
                PdfDocument doc = new PdfDocument();
                //Create a PdfPageSettings object
                PdfPageSettings setting = new PdfPageSettings();

                //Save page size and margins through the object
                setting.Size = new SizeF(1000, 1000);
                setting.Margins = new Spire.Pdf.Graphics.PdfMargins(20);

                //Create a PdfHtmlLayoutFormat object
                PdfHtmlLayoutFormat htmlLayoutFormat = new PdfHtmlLayoutFormat();

                //Set IsWaiting property to true
                htmlLayoutFormat.IsWaiting = true;
                //Specific the URL path to convert
                String url = "https://en.wikipedia.org/wiki/Greece";

                //Load HTML from a URL path using LoadFromHTML method
                Thread thread = new Thread(() =>
                {
                    doc.LoadFromHTML(url, true, true, false, setting, htmlLayoutFormat);
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                thread.Join();

                //Save the document to a PDF file
                doc.SaveToFile("HtmlFromUrlToPdf.pdf");
                doc.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
