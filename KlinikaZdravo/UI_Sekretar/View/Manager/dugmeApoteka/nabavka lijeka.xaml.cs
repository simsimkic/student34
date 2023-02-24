using Aplikacija.Services;
using Aplikacija.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Packaging;
using System.Linq;
using System.Media;
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
    /// Interaction logic for nabavka_lijeka.xaml
    /// </summary>
    public partial class nabavka_lijeka : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Window owner;
        private Lijekovi prikazaniLijek;

        private string id;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public nabavka_lijeka()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private string imeLijekaText;
        private int kolicinaLijekaText;

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

        public int Kolicina
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
        public nabavka_lijeka(String _id)
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

            id = _id;

            prikazaniLijek = LijekoviServece.Instance.GetSviLijekovi()[_id];
            nabavka.Text = prikazaniLijek.nazivLijeka.ToUpper();

            //foreach (Lijekovi zap in LijekoviServece.Instance.GetSviLijekovi().Values)
            //{
            //    if (id.Equals(zap.nazivLijeka))
            //    {
            //        nabavka.Text = zap.nazivLijeka.ToUpper();
            //    }

            //}
        }

        public nabavka_lijeka(Lijekovi lijekZaNabavku)
        {
            prikazaniLijek = lijekZaNabavku;
            Ime = lijekZaNabavku.nazivLijeka;
            Kolicina = lijekZaNabavku.kolicina;

            DataContext = this;

            InitializeComponent();
        }
        private void NabaviLijek_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NabaviLijek_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // provere i validacije probaj raditi ovde, pa ako je sve ok nastavi izvrsavanje ove metode, ako ne onda samo return
            // ali proveri :)

            int novaKolicina = 0;
            //if (!kolicinaNova.Text.All(Char.IsDigit))
            if (!int.TryParse(kolicinaNova.Text.Trim(), out novaKolicina))
            {
                MessageBox.Show("Dozvoljen je unos cifara");
                return;
            }
            if(kolicinaNova.Text.Equals(""))
            {
                MessageBox.Show("Morate popuniti sva polja!");
                return;
            }


            prikazaniLijek.kolicina += novaKolicina;

            //ukupnaKolicina+=izmijenjeniLijek.kolicina;
           // int x =Convert.ToInt32(kolicinaNova.Text);

      
            //int s = Convert.ToInt16(kolicinaNova.Text); 
            bool success=false;
            
            
     //       kolicina.Text = nova_kolicina.ToString();
            if(prikazaniLijek!=null)
            {
                success = LijekoviServece.Instance.NabaviLijek(prikazaniLijek);
                 
            }


            if (success)
            {
                (owner as pocetnaApoteka).Refresh();//owner je null??
                this.Close();
            }
            else
            {
                MessageBox.Show("greska"); // prikazi ispravan error message
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void fokus(object sender, MouseEventArgs e)
        {

        }

        private void fokusx(object sender, RoutedEventArgs e)
        {
            
           
        }

        private void kupi(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
