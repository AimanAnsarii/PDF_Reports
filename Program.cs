using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using PdfSharp;
using PdfSharp.Drawing;
//using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using static System.Net.Mime.MediaTypeNames;

namespace HelloWorld
{
    /// <summary>
    /// This sample is the obligatory Hello World program.
    /// </summary>
    class Program
    {
        private static object text;

        static void Main(string[] args)
        {
            try
            {
                // Create a new PDF document
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Created with PDFsharp";

                // Create an empty page
                PdfPage page = document.AddPage();

                // Get an XGraphics object for drawing
                XGraphics gfx = XGraphics.FromPdfPage(page);


                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                // Create fonts
                XFont headingFont = new XFont("Verdana", 20, XFontStyle.Bold);
                XFont paragraphFont = new XFont("Verdana", 12, XFontStyle.Regular);

                // Draw the heading
                gfx.DrawString("Hello, Aiman!", headingFont, XBrushes.Black,
                  new XRect(0, 0, page.Width, page.Height / 6),
                  XStringFormats.TopCenter);
                // Define the paragraph text
                string paragraphText = "This is the first line of the paragraph. " +
                                       "This is the second line of the paragraph. " +
                                       "This is the third line of the paragraph. " +
                                       "This is the fourth line of the paragraph. " +
                                       "This is the fifth line of the paragraph.";
                // Draw the paragraph
                gfx.DrawString(paragraphText, paragraphFont, XBrushes.Black,
                  new XRect(40, 80, page.Width - 80, page.Height - 160),
                  XStringFormats.TopLeft);


                // Save the document
                const string filename = "HelloWorld.pdf";
                document.Save("D:/PDFs/HelloWorld.pdf");
                // Optionally, start a viewer
                // Process.Start(filename);

              
            }
            catch (Exception exc)
            {

                //throw;
            }
        }
    }
}