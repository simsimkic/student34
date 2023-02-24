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

namespace Aplikacija.dugmeSobe
{
    /// <summary>
    /// Interaction logic for SobeKrevetiRaspored.xaml
    /// </summary>
    public partial class SobeKrevetiRaspored : Window
    {
        public SobeKrevetiRaspored()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void nazad(object sender, RoutedEventArgs e)
        {
            bolnickoLijecenjePocetna bp = new bolnickoLijecenjePocetna();
            bp.Show();
            this.Close();
        }

        private void izmijeni(object sender, RoutedEventArgs e)
        {
           
            Datum1.IsEnabled = true;
            Datum11.IsEnabled = true;
            Datum2.IsEnabled = true;
            Datum22.IsEnabled = true;
            Datum3.IsEnabled = true;
            Datum33.IsEnabled = true;
            Pacijent1.IsEnabled = true;
            Pacijent2.IsEnabled = true;
            Pacijent.IsEnabled = true;
            Dijagnoza1.IsEnabled = true;
            Dijagnoza2.IsEnabled = true;
            Dijagnoza3.IsEnabled = true;


        }

        private void sacuvaj(object sender, RoutedEventArgs e)
        {
            if((Pacijent.Text.Length!=0 && Dijagnoza1.Text.Length==0))
            {
                MessageBox.Show("Morate popuniti sva polja vezana za  krevet broj 1");
                return;
            }
            else
            {
                if (Pacijent.Text.All(Char.IsLetter) && !Dijagnoza1.Text.All(Char.IsLetter))
                {
                    MessageBox.Show("Dozvoljen je unos slova!");
                    return;
                }
            }
            if((Pacijent.Text.Length == 0 && Dijagnoza1.Text.Length != 0))
            {
                MessageBox.Show("Morate popuniti sva polja vezana za  krevet broj 1");
                return;
            }
            else
            {
                if (Pacijent.Text.All(Char.IsLetter) && !Dijagnoza1.Text.All(Char.IsLetter))
                {
                    MessageBox.Show("Dozvoljen je unos slova!");
                    return;
                }
            }

            //-----------------------------------------
            if ((Pacijent1.Text.Length != 0 && Dijagnoza2.Text.Length == 0))
            {
                MessageBox.Show("Morate popuniti sva polja vezana za  krevet broj 2");
                return;
            }
            else
            {
                if (Pacijent1.Text.All(Char.IsLetter) && !Dijagnoza2.Text.All(Char.IsLetter))
                {
                    MessageBox.Show("Dozvoljen je unos slova!");
                    return;
                }
            }
            if ((Pacijent1.Text.Length == 0 && Dijagnoza2.Text.Length != 0))
            {
                MessageBox.Show("Morate popuniti sva polja vezana za  krevet broj 2");
                return;
            }
            else
            {
                if (Pacijent1.Text.All(Char.IsLetter) && !Dijagnoza2.Text.All(Char.IsLetter))
                {
                    MessageBox.Show("Dozvoljen je unos slova!");
                    return;
                }
            }
            //-------------------------------------------------
            if ((Pacijent2.Text.Length != 0 && Dijagnoza3.Text.Length == 0))
            {
                MessageBox.Show("Morate popuniti sva polja vezana za  krevet broj 3");
                return;
            }
            else
            {
                if (Pacijent2.Text.All(Char.IsLetter) && !Dijagnoza3.Text.All(Char.IsLetter))
                {
                    MessageBox.Show("Dozvoljen je unos slova!");
                    return;
                }
            }
            if ((Pacijent2.Text.Length == 0 && Dijagnoza3.Text.Length != 0))
            {
                MessageBox.Show("Morate popuniti sva polja vezana za  krevet broj 3");
                return;
            }
            else
            {
                if (Pacijent2.Text.All(Char.IsLetter) && !Dijagnoza3.Text.All(Char.IsLetter))
                {
                    MessageBox.Show("Dozvoljen je unos slova!");
                    return;
                }
            }

                 Datum1.IsEnabled = false;
                Datum11.IsEnabled = false;
                Datum2.IsEnabled = false;
                Datum22.IsEnabled = false;
                Datum3.IsEnabled = false;
                Datum33.IsEnabled = false;
                Pacijent1.IsEnabled = false;
                Pacijent2.IsEnabled = false;
                Pacijent.IsEnabled = false;
                Dijagnoza1.IsEnabled = false;
                Dijagnoza2.IsEnabled = false;
                Dijagnoza3.IsEnabled = false;
            
            
               
            
           

        }
    }
}
