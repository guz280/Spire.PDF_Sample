using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spire.PDF_Sample
{
	internal class Program
	{
		static void Main(string[] args)
		{

			ConvertHtmlFromFileToPdfWithoutPlugin.Generate();
			Console.WriteLine("Finshed dude");



			ConverHtmlFromUrlToPdfWithoutPlugin.Generate();
			Console.WriteLine("Finshed dude");

			ConvertHtmlToPDFWithQTPlugin.Generate();
			Console.WriteLine("Finshed dude");
		}
	}
}
