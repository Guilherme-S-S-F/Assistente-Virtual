using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Assistente_Virtual.ErrorManager
{
    class PdfERM
    {
        //class complete name: PdfErrorRelatoryMaker.

        //Creates the pdf file
      public static void CreateFile(string Text)
      {
            if(File.Exists(Application.StartupPath + @"\ErrorText\relatório.pdf"))
            {
                File.Delete(Application.StartupPath + @"\ErrorText\relatório.pdf");
            }

            var doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream(Application.StartupPath + @"\ErrorText\relatório.pdf", FileMode.Create));

            doc.Open();
            doc.Add(new Paragraph(Text, new Font(Font.FontFamily.COURIER, 16f)));

            doc.Close();
      }
        
    }
}
