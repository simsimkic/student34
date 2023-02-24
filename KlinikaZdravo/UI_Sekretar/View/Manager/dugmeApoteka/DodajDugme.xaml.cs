using Aplikacija.Services;
using Aplikacija.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Aplikacija.dugmeApoteka
{
    /// <summary>
    /// Interaction logic for DodajDugme.xaml
    /// </summary>
    public partial class DodajDugme :Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Window owner;
        private Lijekovi prikazaniLijekovi;
        public static string ime;
        public static string doktor;
        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public DodajDugme()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();


        }
        public DodajDugme(Lijekovi lijekoviZaIzmjenu)
        {
            prikazaniLijekovi = lijekoviZaIzmjenu;
            Ime = prikazaniLijekovi.nazivLijeka;
            Kolicina = prikazaniLijekovi.kolicina.ToString();
           


            InitializeComponent();
            
        }
        private string imeLijekaText;
        private string kolicinaLijekaText;

        public string Ime
        {
            get
            {
                return imeLijekaText;
            }
            set
            {
                if (value != imeLijekaText)
                {
                    imeLijekaText = value;
                    OnPropertyChanged("imeLijekaText");
                }
            }
        }
        public string Kolicina
        {
            get
            {
                return kolicinaLijekaText;
            }
            set
            {
                if (value != kolicinaLijekaText)
                {
                    kolicinaLijekaText = value;
                    OnPropertyChanged("kolicinaLijekaText");
                }
            }
        }
        public void setOwner(Window _owner)
        {
            owner = _owner;
        }
        private void Dodaj_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void DodajLijek_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // provere i validacije probaj raditi ovde, pa ako je sve ok nastavi izvrsavanje ove metode, ako ne onda samo return
            // ali proveri :)


            Lijekovi lijek = new Lijekovi();
            Random rnd = new Random();
            lijek.IDlijeka = rnd.Next(100).ToString();  // osmisli logiku za kreiranje ID-a, vodi racuna da ocuvas ID kad radis izmenu
            lijek.nazivLijeka = imeLijeka.Text;
            
            bool success = false;

            if (prikazaniLijekovi == null)
            {
                success = LijekoviServece.Instance.RegistrujLijek(lijek);
            }
            else
            {
                success = LijekoviServece.Instance.IzmeniLijek(lijek);
            }


            if (success)
            {
                (owner as pocetnaApoteka).Refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("greska"); // prikazi ispravan error message
            }
        }

        private void Odustani_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Odustani_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

        private void fokusxx(object sender, RoutedEventArgs e)
        {
            if(imeLijeka.Text.Equals(""))
            {
                imeLijeka.AppendText("IME LIJEKA:");
            }
        }

        private void fokuss(object sender, MouseEventArgs e)
        {

        }
        private void odustanii(object sender, MouseEventArgs e)
        {

        }

        private void fokus(object sender, MouseEventArgs e)
        {
            imeLijeka.Clear();
        }

        private void posalji(object sender, RoutedEventArgs e)
        {
            if (imeLijeka.Text.Equals(""))
            {
                MessageBox.Show("Morate popuniti sva polja!");
                return;
            }
            if(!imeLijeka.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Naziv lijeka moze da sadrzi samo slova!");
                return;
            }
            ime = imeLijeka.Text;
            string[] s = combo.SelectedValue.ToString().Split(':');
            doktor = s[1];
            obavjestenjeOkupovini o = new obavjestenjeOkupovini();
            o.Show();
            this.Close();
        }

        private void odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

//    private void fokus(object sender, MouseEventArgs e)
//   {
//       imeLijeka.Clear();
//   }




//private void posalji(object sender, RoutedEventArgs e)
//{
//    if (imeLijeka.Text.Equals("") || imeLijeka.Text.Equals("IME LIJEKA:") || imeLijeka.Text.Equals("ime lijeka:"))
//    {
//        upozorenje5 u5 = new upozorenje5();
//        u5.Show();
//    }
//    else
//    {
//        this.Close();
//        obavjestenje o = new obavjestenje();
//        o.Show();
//    }
//}


//}
