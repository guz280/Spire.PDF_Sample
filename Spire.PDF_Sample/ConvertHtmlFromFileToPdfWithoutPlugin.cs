using Spire.Pdf;
using Spire.Pdf.HtmlConverter;
using System;
using System.Drawing;
using System.IO;
using System.Threading;

namespace Spire.PDF_Sample
{
	internal static class ConvertHtmlFromFileToPdfWithoutPlugin
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

               
                //Read html string from a .html file
                //string htmlString = File.ReadAllText(@"C:\development\Spire.PDF\Spire.PDF_Sample\htmltoconvert.html");
                string htmlString = File.ReadAllText(@"C:\development\Spire.PDF\Spire.PDF_Sample\htmltoconvertCopy.html");

                //Load HTML from html string using LoadFromHTML method
                Thread thread = new Thread(() =>
                {
                doc.LoadFromHTML(htmlString, true, setting, htmlLayoutFormat);
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                thread.Join();

                //Save to a PDF file
                doc.SaveToFile("HtmlFromFileToPdf.pdf");


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
