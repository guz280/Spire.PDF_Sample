using System.IO;
using Spire.Pdf.HtmlConverter.Qt;
using System.Drawing;
using Spire.Pdf.Graphics;



namespace Spire.PDF_Sample
{
	internal static class ConvertUrlToPdfQTPlugin
	{
		public static void Generate()
		{
            //Get the HTML string from a .html file
            string htmlString = File.ReadAllText(@"C:\development\Spire.PDF\Spire.PDF_Sample\htmltoconvertCopy.html");

            //Specify the output file path
            string fileName = "HtmlToPDFWithQTPlugin.pdf";

            //Specify the plugin path
            string pluginPath = "C:\\Libraries\\Plugin\\plugins-windows-x64\\plugins";

            //Set the plugin path
            HtmlConverter.PluginPath = pluginPath;

            //Convert HTML string to PDF
            HtmlConverter.Convert(htmlString, fileName, true, 100000, new Size(1080, 1000), new PdfMargins(0), Spire.Pdf.HtmlConverter.LoadHtmlType.SourceCode);

        }
    }
}
