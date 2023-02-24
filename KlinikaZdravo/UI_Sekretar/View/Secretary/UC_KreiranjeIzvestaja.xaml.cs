using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.Data;

namespace UI_sekretar
{
    /// <summary>
    /// Interaction logic for UC_Izvestaj.xaml
    /// </summary>
    public partial class UC_KreiranjeIzvestaja : UserControl
    {
        public UC_KreiranjeIzvestaja()
        {
            InitializeComponent();
        }

        public void IzvestajZauzetostProstorija() 
        {
            PdfDocument document = new PdfDocument();
            document.PageSettings.Orientation = PdfPageOrientation.Landscape;
            document.PageSettings.Margins.All = 50;

            PdfPage pdfPage = document.Pages.Add();
            PdfGraphics graphics = pdfPage.Graphics;

            PdfStringFormat fromat = new PdfStringFormat();
            fromat.Alignment = PdfTextAlignment.Center;
            RectangleF bounds = new RectangleF(176, 0, 390, 130);

            //PdfPageTemplateElement header = new PdfPageTemplateElement(bounds);
            //document.Template.Top = header;
            

            graphics.DrawString("Izvestaj zauzetosti operacionih sala od " + odDate.Text + " do " + toDate.Text, new PdfStandardFont(PdfFontFamily.TimesRoman, 20), PdfBrushes.Black, new RectangleF(10, 110, 0, 0));

            PdfBrush solidBrush = new PdfSolidBrush(new PdfColor(126, 151, 173));
            bounds = new RectangleF(0, bounds.Bottom + 30, graphics.ClientSize.Width, 30);
            graphics.DrawRectangle(solidBrush, bounds);

            //ovo je text koji se ubacuje u plavi pravougaonik
            PdfFont subHeadingFont = new PdfStandardFont(PdfFontFamily.TimesRoman, 14);
            PdfTextElement element = new PdfTextElement("Operacione sale ", subHeadingFont);
            element.Brush = PdfBrushes.White;

            //sad ubacivanje texta
            PdfLayoutResult result = element.Draw(pdfPage, new PointF(10, bounds.Top + 8));
            string currentDate = "Datum kreiranja " + DateTime.Now.ToString("MM/dd/yyyy");

            //poziciranje teksta
            SizeF textSize = subHeadingFont.MeasureString(currentDate);
            PointF textPosition = new PointF(graphics.ClientSize.Width - textSize.Width - 10, result.Bounds.Y);
            graphics.DrawString(currentDate, subHeadingFont, element.Brush, textPosition);

            //ovo je druga tabela
            PdfGrid grid = new PdfGrid();

            DataTable dataTable = new DataTable();


            dataTable.Columns.Add("Sala 1");
            dataTable.Columns.Add("Sala 2");
            dataTable.Columns.Add("Sala 3");


            String[] odDeo = odDate.Text.Split('/');
            String[] doDeo = toDate.Text.Split('/');

            int odDat = Int32.Parse(odDeo[1]);
            int doDat = Int32.Parse(doDeo[1]);

            //ovde mi se nalazi pocetni dan
            DateTime time = new DateTime(Int32.Parse(odDeo[2]), Int32.Parse(odDeo[0]), Int32.Parse(odDeo[1]));

            //ovde mi se nalazi razlika izmedju pocetnog i krajnjeg datuma
            int razlika = (doDat - odDat) + 1;
            Random rnd = new Random();

            for (int i = 0; i < razlika; i++)
            {
                dataTable.Rows.Add(new object[] { "Za datum " + time.ToString("MM/dd/yyy") + " broj zakazanih operacija je " + rnd.Next(0, 10) + ".",
                                                  "Za datum " + time.ToString("MM/dd/yyy") + " broj zakazanih operacija je " + rnd.Next(0, 10) + ".",
                                                  "Za datum " + time.ToString("MM/dd/yyy") + " broj zakazanih operacija je " + rnd.Next(0, 10) + "."});
                time = time.AddDays(1);
            }
            grid.DataSource = dataTable;
            PdfGridLayoutFormat layoutFormat = new PdfGridLayoutFormat();
            // Creates layout format settings to allow the table pagination
            layoutFormat.Layout = PdfLayoutType.Paginate;

            grid.Draw(pdfPage, new RectangleF(new PointF(0, result.Bounds.Bottom + 40), new SizeF(graphics.ClientSize.Width, graphics.ClientSize.Height - 100)), layoutFormat);


            document.Save("Izvestaj zauzetosti operacionih sala.pdf");
            document.Close(true);
        }

        public bool Validacija()
        {

            if (odDate.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Morate uneti datum od kog želite da vam se prikaže izveštaj!");
                return false;
            }

            if (toDate.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Morate uneti datum do kog želite da vam se prikaže izveštaj!");
                return false;
            }

            if (odDate.SelectedDate > toDate.SelectedDate)
            {
                System.Windows.MessageBox.Show("Početni datum ne može posle krajnjeg datuma!");
                return false;

            }
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Validacija())
            {
                return;
            }
            IzvestajZauzetostProstorija();

            MessageBox.Show("Uspesno ste kreirali izveštaj od " + odDate.Text + " do " + toDate.Text);
            GlavniProzor glavniProzor =new GlavniProzor();
            glavniProzor.Show();
            //this.Close();

        }
    }
}
