
using ClassDiagram.Model.DoctorExaminations;
using Newtonsoft.Json;
using ProjekatHciDoktor.Model.Examination;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Windows;
using System.Windows.Documents;

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for Odabir.xaml
    /// </summary>
    public partial class Odabir : Window
    {
        public Odabir()
        {
            InitializeComponent();
        }

        private void zapocni_Click(object sender, RoutedEventArgs e)
        {

            //foreach (Window parentW in Application.Current.Windows)
            //{
            //    if (parentW.GetType() == typeof(Pocetni))
            //    {
            //        (parentW as Pocetni).dnevniRaspored.Visibility = Visibility.Collapsed;
            //        (parentW as Pocetni).karton.Visibility = Visibility.Visible;
            //        (parentW as Pocetni).karton.imee.Content = DnevniRaspored.t.Karton.Pacijent.Ime;
            //        (parentW as Pocetni).karton.prezimee.Content +=DnevniRaspored.t.Karton.Pacijent.Prezime;
            //        (parentW as Pocetni).karton.jmbgg.Content += DnevniRaspored.t.Karton.Pacijent.Jmbg.ToString();
            //        (parentW as Pocetni).karton.mestoo.Content += DnevniRaspored.t.Karton.Pacijent.Mesto;
            //        (parentW as Pocetni).karton.poll.Content += DnevniRaspored.t.Karton.Pacijent.Pol;
            //        (parentW as Pocetni).karton.alerg.Content += DnevniRaspored.t.Karton.Pacijent.Alergija;
            //        (parentW as Pocetni).karton.brk.Content += DnevniRaspored.t.Karton.Brojk.ToString();
            //        if (DnevniRaspored.t.Karton.Pregled.Count() != 0)
            //        {
            //            int i = DnevniRaspored.t.Karton.Pregled.Count() - 1;
            //            (parentW as Pocetni).karton.preg.Content = DnevniRaspored.t.Karton.Pregled[i].Odd.Date.ToString();
            //        }
            //        else
            //        {
            //            (parentW as Pocetni).karton.preg.Content = "Prvi pregled.";
            //        }

            //        (parentW as Pocetni).karton.izdup.Visibility = Visibility.Visible;
            //        (parentW as Pocetni).karton.unesi.Visibility = Visibility.Visible;
            //    }
            //}
            this.Close();

        }

        private void zakazi_Click(object sender, RoutedEventArgs e)
        {
            var odb = new izmena();
            odb.lekar.Content = DnevniRaspored.t.DoctorName;
            odb.datum.Content = DnevniRaspored.t.Vreme.Date.ToString();
            odb.vreme.Content = DnevniRaspored.t.Vreme;


            odb.Show();
            this.Close();
            
        }

        private void otkazi_Click(object sender, RoutedEventArgs e)
        {
            Examination ee = DnevniRaspored.examinationController.GetByID(DnevniRaspored.t.Id);
            ee.RoomId = 0;
            DnevniRaspored.examinationController.Update(ee);
            List<Examination> p = (List<Examination>)DnevniRaspored.examinationController.GetAll();
            
            foreach (Window parentWindow in Application.Current.Windows)
            {

                if (parentWindow.GetType() == typeof(Pocetni))
                {
                    (parentWindow as Pocetni).dnevniRaspored.tabel.ItemsSource = new List<Examination>();
                    (parentWindow as Pocetni).dnevniRaspored.tabel.ItemsSource = p;
                    (parentWindow as Pocetni).dnevniRaspored.tabel.Items.Refresh();
                }
            }
            this.Close();
        }
    }
}
