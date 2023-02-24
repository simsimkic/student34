using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using System;
using System.Drawing;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Syncfusion.Pdf.Grid;
using System.Data;
using healthClinic.podaci;
using System.Diagnostics;

namespace healthClinic
{
    /// <summary>
    /// Interaction logic for TreatmentHistory.xaml
    /// </summary>
    public partial class TreatmentHistory : Page
    {
        public List<Alergije> alergijee = new List<Alergije>();
        public List<Nalazi> nalazi = new List<Nalazi>();

        public int colNum = 0;

        public List<Alergije> mojeAl
        {
            get { return alergijee; }
            set
            {
                alergijee = value;
            }
        }

        public List<Nalazi> NalaziM
        {
            get { return nalazi; }
            set
            {
                nalazi = value;
            }
        }


        public TreatmentHistory()
        {
            InitializeComponent();
            this.DataContext = this;


            //   termini = new ZakazaniTermini();
            alergie.Focus();
            mojeAl = new List<Alergije>();

            mojeAl.Add(new Alergije() { Alergen = "Paracetamol", Reakcija = "Stomacni bolovi", PrvoPojavljivanje = "Prva upotreba", Preventiva = "Izbegavati" });
            mojeAl.Add(new Alergije() { Alergen = "Amoksicilin", Reakcija= "Povracanje", PrvoPojavljivanje = "Rana mladost", Preventiva = "Izbegavati" });
            mojeAl.Add(new Alergije() { Alergen = "Celer", Reakcija = "Mucnina", PrvoPojavljivanje = "Rana mladost", Preventiva = "Izbegavati" });
            mojeAl.Add(new  Alergije() { Alergen = "Bakalar", Reakcija = "Glavobolja", PrvoPojavljivanje = "Rana mladost", Preventiva = "Izbegavati" });

            NalaziM = new List<Nalazi>();

            NalaziM.Add(new Nalazi() { Tip = "AFP", PozeljneVrednosti = "10-15", GranicneVrednosti = "20", VisokoRizicne = "preko 30" });
            NalaziM.Add(new Nalazi() { Tip = "Cea 19-9", PozeljneVrednosti = "90-110", GranicneVrednosti = "115", VisokoRizicne = "preko 130" });
            NalaziM.Add(new Nalazi() { Tip = "HE4", PozeljneVrednosti = "50-60", GranicneVrednosti = "75", VisokoRizicne = "preko 75" });
            NalaziM.Add(new Nalazi() { Tip = "Mioglobin", PozeljneVrednosti = "10-12", GranicneVrednosti = "12", VisokoRizicne = "vise od 15" });


        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }


        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 4)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void PreuzmiTerapijuKlik(object sender, RoutedEventArgs e)
        {
            //           StringWriter sw = new StringWriter();

            /*
                                    Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                                    PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Terapija.pdf", FileMode.Create));
                                    doc.Open();
                                  //  ReportTablexaml rt = new ReportTablexaml();

                                    iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph();
                                    doc.Add(paragraph);
                                    doc.Close();
                        MessageBox.Show("Uspješno izgenerisan fajl u pdf-u!");
                  //      Process proc = new Process();

                        /*  Syncfusion.Pdf.PdfDocument document = new Syncfusion.Pdf.PdfDocument();
                          //Adds page settings
                          document.PageSettings.Orientation = PdfPageOrientation.Landscape;
                          document.PageSettings.Margins.All = 50;
                          //Adds a page to the document
                          ReportTablexaml rt = new ReportTablexaml();
                         Syncfusion.Pdf.PdfPage page = document.Pages.Add();
                         */
            /*         Syncfusion.Pdf.PdfDocument doc = new Syncfusion.Pdf.PdfDocument();
                     //Add a page.
                     Syncfusion.Pdf.PdfPage page = doc.Pages.Add();

                     PdfGraphics graphics = page.Graphics;



                     //Set the standard font
                     Syncfusion.Pdf.Graphics.PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 18);
                     PdfStringFormat format = new PdfStringFormat();
                     //Set the text alignment.
                     format.Alignment = PdfTextAlignment.Justify;

                     //Draw the text
                     graphics.DrawString("Terapija za narednu nedelju", font, PdfBrushes.Black, new PointF(0, 0), format);


                     //Create a PdfGrid.
                     Syncfusion.Pdf.Grid.PdfGrid pdfGrid = new PdfGrid();

                     PdfGridCellStyle ps = new PdfGridCellStyle();
                     //Create a DataTable.
                     DataTable dataTable = new DataTable();

                     //Add columns to the DataTable
                     dataTable.Columns.Add("Ponedeljak");
                     dataTable.Columns.Add("Utorak");
                     dataTable.Columns.Add("Sreda");
                     dataTable.Columns.Add("Cetvrtak");
                     dataTable.Columns.Add("Petak");
                     dataTable.Columns.Add("Subota");
                     dataTable.Columns.Add("Nedelja");
                     //Add rows to the DataTable.
                     dataTable.Rows.Add(new object[] { "15:00 Enalapril 22:00 Laktuloza", "15:00 Enalapril 22:00 Laktuloza", "15:00 Enalapril 22:00 Laktuloza", "15:00 22:00 Enalapril 22:00 Laktuloza", "15:00 Enalapril Laktuloza", "15:00 Enalapril Laktuloza", "15:00 Enalapril Laktuloza" });
                     dataTable.Rows.Add(new object[] { "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol"});
                     dataTable.Rows.Add(new object[] { "12:00 Kytril 17:00 Sabax", "12:00 Panrazol 17:00 Sabax", "12:00 Panrazol 12:00 Sabax", "12:00 Panrazol 17:00 Sabax", "10:00 Panrazol 17:00 Sabax", "10:00 Panrazol", "10:00 Panrazol" });
                     dataTable.Rows.Add(new object[] { "10:00 Panrazol            ", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol" });
                     dataTable.Rows.Add(new object[] { "10:00 Panrazol               ", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol" });
                     dataTable.Rows.Add(new object[] { "10:00 Panrazol"            , "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol" });
                     dataTable.Rows.Add(new object[] { "10:00 Panrazol"             , "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol", "10:00 Panrazol" });
                     //Assign data source.
                     pdfGrid.DataSource = dataTable;
                     //Draw grid to the page of PDF document.
                     pdfGrid.Draw(page, new PointF(10, 100));
                     //Save the document.
                     doc.Save("Output.pdf");
                     //close the document
                     doc.Close(true);
           */
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream("Izvestaj4.pdf", FileMode.Create));
                doc.Open();

                iTextSharp.text.Paragraph p = new iTextSharp.text.Paragraph("");

                PdfPTable table = new PdfPTable(8);
                var cell = new PdfPCell(new Phrase(" Terapija za nedelju dana. Datum generisanja 15.6.2020.\n\n\n"));
                cell.Colspan = 8;
                cell.HorizontalAlignment = 1;
                table.AddCell(cell);

                table.AddCell("Vreme");
                table.AddCell("Ponedeljak");
                table.AddCell("Utorak");
                table.AddCell("Sreda");
                table.AddCell("Cetvrtak");
                table.AddCell("Petak");
                table.AddCell("Subota");
                table.AddCell("Nedelja");

                table.AddCell("11:00");
    
                table.AddCell("Enalapril \n\n");
                table.AddCell("Enalapril \n\n");
                table.AddCell("Enalapril \n\n");
                table.AddCell("Enalapril \n\n");
                table.AddCell("Enalapril \n\n");
                table.AddCell("Enalapril \n\n");
                table.AddCell("Enalapril \n\n");

                table.AddCell("14:00");

                table.AddCell("Laktuloza\n\n");
                table.AddCell("Laktuloza\n\n");
                table.AddCell("Laktuloza\n\n");
                table.AddCell("Laktuloza\n\n");
                table.AddCell("Laktuloza\n\n");
                table.AddCell("Laktuloza\n\n");
                table.AddCell("Laktuloza\n\n");

                table.AddCell("17:00");
    

                table.AddCell("Controloc\n\n");
                table.AddCell("Controloc\n\n");
                table.AddCell("\n\n");
                table.AddCell("\n\n");
                table.AddCell("Controloc\n\n");
                table.AddCell("Controloc\n\n");
                table.AddCell("\n\n");

                table.AddCell("19:00");

                table.AddCell("Panrazol\n\n");
                table.AddCell("Panrazol\n\n");
                table.AddCell("Panrazol\n\n");
                table.AddCell("Panrazol\n\n");
                table.AddCell("Panrazol\n\n");
                table.AddCell("\n\n");
                table.AddCell("Panrazol\n\n");

                table.AddCell("21:00");

                table.AddCell("Kytril\n\n");
                table.AddCell("Kytril\n\n");
                table.AddCell("Kytril\n\n");
                table.AddCell("Kytril\n\n");
                table.AddCell("\n\n");
                table.AddCell("Kytril\n\n");
                table.AddCell("Kytril\n\n");

                table.AddCell("23:00");

                table.AddCell("Vitamini\n\n");
                table.AddCell("Vitamini\n\n");
                table.AddCell("Vitamini\n\n");
                table.AddCell("Vitamini\n\n");
                table.AddCell("Vitamini\n\n");
                table.AddCell("Vitamini\n\n");
                table.AddCell("Vitamini\n\n");


            doc.Add(p);
                doc.Add(table);
                doc.Close();
                MessageBox.Show("Uspesno izgenerisan fajl u pdf-u!");

                Process proc = new Process();
                proc.StartInfo = new ProcessStartInfo()
                {
                    FileName = "Izvestaj4.pdf"
                };
                proc.Start();
            }

        
        

        private void PogledajTerapijuKlik(object sender, RoutedEventArgs e)
        {
              ReportTablexaml rt = new ReportTablexaml();
             this.NavigationService.Navigate(rt);

            //izvestaj iz = new izvestaj();
            //this.NavigationService.Navigate(iz);
        
        }
    }
}
