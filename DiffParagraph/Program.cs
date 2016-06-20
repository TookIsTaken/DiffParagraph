using DiffMatchPatch;
using PdfSharp;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace DiffParagraph
{
    class Program
    {
        static void Main(string[] args)
        {
            var dmp = new diff_match_patch();
            var differences = dmp.diff_main("Hello World", "Hello orldffffffffffffffffffffff!");
            var diffHtml = dmp.diff_prettyHtml(differences);
            diffHtml = diffHtml.Replace("background:", "background-color:");    
            PdfDocument pdf = PdfGenerator.GeneratePdf("<p><h1 style='background-color: red'>Hello World</h1>" + diffHtml + "</p>", PageSize.A4);
            
            pdf.Save("C:\\Users\\bmoye\\Documents\\document.pdf");
        }
    }
}
