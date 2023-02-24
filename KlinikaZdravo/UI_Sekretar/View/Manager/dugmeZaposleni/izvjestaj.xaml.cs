using Aplikacija.Services;
using Aplikacija.Themes;
using System.Windows;
using System.Windows.Controls;

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;

using System.IO;

using System.Windows.Documents;

using Syncfusion.Pdf.Interactive;

using PdfDocument = Syncfusion.Pdf.PdfDocument;
using PdfPage = Syncfusion.Pdf.PdfPage;

namespace Aplikacija.dugmeZaposleni
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private string id;

        public Window1(string _id)
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

            id = _id;

            foreach (Zaposleni zap in EmployeeService.Instance.GetSviZaposleni().Values)
            {
                if (id.Equals(zap.prezime))
                {
                    ime.Text = zap.ime + " " + zap.prezime;
                }

            }

            //od servisa zaposlenih zatrazi zaposlenog da ga nadje po ID
            // uzmes njegove podatke i prikazes umesto Marka Markovica
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void izmijeniIzvjestaj(object sender, RoutedEventArgs e)
        {

            textIzvjestaja.IsEnabled = true;


        }

        private void sacuvaj(object sender, RoutedEventArgs e)
        {
            textIzvjestaja.IsEnabled = false;

        }

        private void nazad(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void fokus(object sender, RoutedEventArgs e)
        {
            textIzvjestaja.Clear();
        }

        private void pdf(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Izvjestaj sacuvan kao PDF fajl!");

            Syncfusion.Pdf.PdfDocument document = new PdfDocument();

            //Add page to the document

            PdfPage page = document.Pages.Add();

            PdfGraphics graphics = page.Graphics;

            string text = textIzvjestaja.Text;

            //Create a text element with the text and font

            PdfTextElement textElement = new PdfTextElement(text, new PdfStandardFont(PdfFontFamily.TimesRoman, 14));

            //Draw the text in the first column

            textElement.Draw(page, new RectangleF(0, 0, page.GetClientSize().Width, page.GetClientSize().Height));


            textElement = new PdfTextElement(text, new PdfStandardFont(PdfFontFamily.TimesRoman, 14));

            //Draw the text in the second column


            document.Save("IzvjestajPlanaRada.pdf");

            document.Close(true);







        }
    }
}
