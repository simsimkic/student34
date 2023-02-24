using ClassDiagram.Model.Medicine;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ProjekatHciDoktor.Model.Medicine;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for Izvestaj.xaml
    /// </summary>
    
    public partial class Izvestaj : UserControl
    {
        List<Izvestajj> izv = new List<Izvestajj>();
        public Izvestaj()
        {
            InitializeComponent();
            //Drug l5=new Drug()
            //{
    //            Ime = "Panadol Extra",
    //            Jacina = "500mg",
    //            Kolicina = "15 tabli",
    //            Tip = TipLeka.analgetik,
    //            Informacije = "Panadol Extra sadrži paracetamol koji je analgetik(lek protiv bolova)"
    //+ "i antipiretik(pomaže u snižavanju telesne temperature kad imate groznicu)"
    //+ "i kofein koji svojim dejstvom pojačava dejstvo paracetamola."
    //        };
    //        Drug l1=new Drug()
    //        {
    //            Ime = "Panadol Advance",
    //            Jacina = "500mg",
    //            Kolicina = "20 tabli",
    //            Tip = TipLeka.analgetik,
    //            Informacije = "Panadol Advance sadrži paracetamol koji je analgetik(lek protiv bolova)"
    //            + "i antipiretik(pomaže u snižavanju telesne temperature kad imate groznicu)."
    //        };
    //        Drug l2= new Drug()
    //        {
    //            Ime = "Brufen",
    //            Jacina = "400mg",
    //            Kolicina = "18 tabli",
    //            Tip = TipLeka.analgetik,
    //            Informacije = "Brufen se može koristiti za lečenje bolnih stanja sa blagim"
    //            + "do umerenim bolovima kao što su zubobolja, bol nakon operacije,"
    //            + "bolne menstruacije(krvarenje kod žena) i glavobolje,"
    //            + "uključujući migrenu. "
    //        };
    //        Drug l3=new Drug()
    //        {
    //            Ime = "Brufen",
    //            Jacina = "600mg",
    //            Kolicina = "18 tabli",
    //            Tip = TipLeka.analgetik,
    //            Informacije = "Brufen se može koristiti za lečenje bolnih stanja sa blagim"
    //            + "do umerenim bolovima kao što su zubobolja, bol nakon operacije,"
    //            + "bolne menstruacije(krvarenje kod žena) i glavobolje,"
    //            + "uključujući migrenu. "
    //        };
    //        Drug l4= new Drug()
    //        {
    //            Ime = "Flunisan",
    //            Jacina = "20mg",
    //            Kolicina = "3 pakovanja tableta",
    //            Tip = TipLeka.antidepresiv,
    //            Informacije = "Terapiju fluoksetinom treba započeti tek posle 2 nedelje"
    //            + "po prekidu terapije ireverzibilnim inhibitorom MAO"
    //            + "(kao što je tranilcipromin) i sledećeg dana po prestanku terapije"
    //            + "reverzibilnim inhibitorom MAO(kao što jemoklobemid)."
    //        };
    //        izv.Add(new Izvestajj() {Datum = new DateTime(2020, 6, 16), Lek=l1,Potroseno="5tabli"});
    //        izv.Add(new Izvestajj() {Datum = new DateTime(2020, 6, 16), Lek=l2,Potroseno="19tabli"});
    //        izv.Add(new Izvestajj() {Datum = new DateTime(2020, 6, 16), Lek=l3,Potroseno="2table"});
    //        izv.Add(new Izvestajj() {Datum = new DateTime(2020, 6, 16), Lek=l4,Potroseno="-"});
    //        izv.Add(new Izvestajj() {Datum = new DateTime(2020, 6, 16), Lek=l5,Potroseno="-"});

    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 14), Lek = l1, Potroseno = "5tabli" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 14), Lek = l2, Potroseno = "19tabli" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 14), Lek = l3, Potroseno = "2table" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 14), Lek = l5, Potroseno = "2table" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 14), Lek = l4, Potroseno = "-" });

    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 13), Lek = l1, Potroseno = "1tabla" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 13), Lek = l2, Potroseno = "10tabli" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 13), Lek = l5, Potroseno = "10tabli" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 13), Lek = l3, Potroseno = "3table" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 13), Lek = l4, Potroseno = "4table" });

    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 10), Lek = l1, Potroseno = "1tabla" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 10), Lek = l2, Potroseno = "10tabli" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 10), Lek = l3, Potroseno = "3table" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 10), Lek = l4, Potroseno = "4table" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 10), Lek = l5, Potroseno = "4table" });

    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 15), Lek = l1, Potroseno = "-" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 15), Lek = l2, Potroseno = "-" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 15), Lek = l3, Potroseno = "3table" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 15), Lek = l4, Potroseno = "-" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 15), Lek = l5, Potroseno = "-" });

    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 12), Lek = l1, Potroseno = "-" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 12), Lek = l2, Potroseno = "-" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 12), Lek = l3, Potroseno = "2table" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 12), Lek = l4, Potroseno = "-" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 12), Lek = l5, Potroseno = "-" });

    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 11), Lek = l1, Potroseno = "10tabali" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 11), Lek = l2, Potroseno = "-" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 11), Lek = l3, Potroseno = "32table" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 11), Lek = l4, Potroseno = "5tabli" });
    //        izv.Add(new Izvestajj() { Datum = new DateTime(2020, 6, 11), Lek = l5, Potroseno = "5tabli" });

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var pdf = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
            string path = $"C:\\Users\\Administrator\\Desktop\\ProjekatHciDoktor\\Data\\izvestaj.pdf";
            PdfWriter.GetInstance(pdf,new FileStream(path,FileMode.OpenOrCreate));
            pdf.Open();

            PdfPTable table = new PdfPTable(3);
            var cell = new PdfPCell(new Phrase("Izveštaj o potrošnji lekova u periodu od" +dateod.SelectedDate.ToString()+" do"+ datedo.SelectedDate.ToString()));
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);
            var cell1 = new PdfPCell(new Phrase("DATUM"));
            var cell2 = new PdfPCell(new Phrase("LEK"));
            var cell3 = new PdfPCell(new Phrase("POTROŠNJA"));
            table.AddCell(cell1);
            table.AddCell(cell2);
            table.AddCell(cell3);

            foreach (Izvestajj i in izv)
            {
                if(i.Datum.CompareTo(dateod.SelectedDate)>0 && i.Datum.CompareTo(datedo.SelectedDate) < 0)
                {   
                    //table.AddCell(i.Datum.Date.ToString());
                    //table.AddCell(i.Lek.Ime + i.Lek.Jacina);                  
                    //table.AddCell(i.Potroseno);
                }
            }
            pdf.Add(table);
            pdf.Close();
            MessageBox.Show("Izveštaj je uspešno kreiran");
            IZV.Visibility = Visibility.Collapsed;
        }
    }
}
