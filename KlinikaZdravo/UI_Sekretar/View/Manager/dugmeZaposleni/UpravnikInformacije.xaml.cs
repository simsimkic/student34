using Aplikacija.Themes;
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
using System.Windows.Shapes;
using System.Windows.Shell;

namespace Aplikacija.dugmeZaposleni
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public  static string korisnickoText;
        public static string sifraText;
        public Window3()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

            korisnickoText = korisnicko.Text;
            sifraText = sifra.Password;
        }

        private void izmjena(object sender, RoutedEventArgs e)
        {
            ime.IsEnabled = true;
            prezime.IsEnabled = true;
            datum.IsEnabled = true;
            jmbg.IsEnabled = true;
            tel.IsEnabled = true;
            email.IsEnabled = true;
            korisnicko.IsEnabled = true;
            sifra.IsEnabled = true;
        }

        private void sacuvaj(object sender, RoutedEventArgs e)
        {
            
            if((ime.Text.Length==0) && (prezime.Text.Length == 0) && (jmbg.Text.Length == 0) && (tel.Text.Length == 0)
                && (email.Text.Length == 0) && (korisnicko.Text.Length == 0) && (sifra.Password.Length == 0))
            {
                MessageBox.Show("Morate popuniti sva polja!");
                return;
            }

            if (!jmbg.Text.All(Char.IsDigit) || !tel.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Polja JMBG  i TELEFON mogu da sadrze samo cifre!");
                return;
            }
            if (jmbg.Text.Length != 13)
            {
                MessageBox.Show("Polje JMBG moze da sadrzi 13 cifara!");
                return;
            }
            if (tel.Text.Length != 9 && tel.Text.Length != 10)
            {
                MessageBox.Show("Polje TELEFON moze da sadrzi 9 ili 10 cifara!");
                return;
            }
            if (!ime.Text.All(Char.IsLetter) || !prezime.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Polja IME i PREZIME mogu da sadze samo slova");
                return;
            }
            if (korisnicko.Text.All(Char.IsWhiteSpace) && sifra.Password.All(Char.IsWhiteSpace) && (email.Text.All(Char.IsWhiteSpace)))
            {
                MessageBox.Show("Polja EMAIL, KORISNICKO IME i SIFRA ne mogu sadrzati razmak(bjelinu)!");
                return;
            }
            if (!korisnicko.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Polje KORISNICKO IME smije da sadrzi slova! ");
                return;
            }
            if (!sifra.Password.All(Char.IsLetterOrDigit))
            {
                MessageBox.Show("Polje SIFRA smije da sadrzi slova i brojeve! ");
                return;
            }

            ime.IsEnabled = false;
                prezime.IsEnabled = false;
                datum.IsEnabled = false;
                jmbg.IsEnabled = false;
                tel.IsEnabled = false;
                email.IsEnabled = false;
                korisnicko.IsEnabled = false;
                sifra.IsEnabled = false;
            
           
        }

        private void nazad(object sender, RoutedEventArgs e)
        {
            pocetnaUpravnik pu = new pocetnaUpravnik();
            pu.Show();
            this.Close();
        }
    }
}
