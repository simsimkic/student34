using Aplikacija.dugmeSobe;
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

namespace Aplikacija.dugmeZaposleni
{
    /// <summary>
    /// Interaction logic for log.xaml
    /// </summary>
    public partial class log : Window
    {
        public log()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
           
        }

 
        private void klikk(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrEmpty(prvo.Text) )
            {
                prvo.AppendText("Korisnicko ime");
            }
        }

        private void klik(object sender, MouseEventArgs e)
        {
            prvo.Clear();
        }

      
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string s = prvo.Text;
            bool ispravno = prvo.Text.Equals("HANA");
            //string s2 = novo.Password.;
            if (!string.IsNullOrEmpty(prvo.Text) && !string.IsNullOrEmpty(novo.Password))
            {
                //if (!prvo.Text.Equals("HanaUpravnik") || !novo.Password.Equals("upravnik"))
                //{
                //    upozorenjelog u = new upozorenjelog();
                //    u.Show();

                //}
                //else
                //{
                    potvrda.IsEnabled = true;
                    temaOdabir pu = new temaOdabir();
                    pu.ShowDialog();
                    this.Close();
                //}

            }

            else
            {
                upozorenjee upo = new upozorenjee();
                upo.Show();

            }
        }

        private void oddustani(object sender, RoutedEventArgs e)
        {
          
            pocetnaMain mw = new pocetnaMain();
            mw.Show();
            this.Close();
        }

        private void boksklik(object sender, MouseEventArgs e)
        {
            novo.Clear();
        }

        private void boksklikx(object sender, MouseEventArgs e)
        {

        }

        private void sifraklik(object sender, MouseEventArgs e)
        {

        }

    }
}
