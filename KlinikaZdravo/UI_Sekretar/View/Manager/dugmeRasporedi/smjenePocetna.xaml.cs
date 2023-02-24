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

namespace Aplikacija.dugmeRasporedi
{
    /// <summary>
    /// Interaction logic for smjenePocetna.xaml
    /// </summary>
    public partial class smjenePocetna : Window
    {
        public smjenePocetna()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

            Smjene s = new Smjene();
            s.zaposleni = "Marko Markovic";
            s.ID = "1sk5";
            podaciSmjene.Items.Add(s);


            Smjene s1 = new Smjene();
            s1.zaposleni = "Petar Petrovic";
            s1.ID = "1ss5";
            podaciSmjene.Items.Add(s1);

        }
        public class Smjene
        {

            public string zaposleni { get; set; }
            public string ID { get; set; }
        }

        private void nazad(object sender, RoutedEventArgs e)
        {
           
            pocetnaRasporedi pr = new pocetnaRasporedi();
            pr.Show();
            this.Close();
        }
        private void SmjenaZaposleni(object sender, RoutedEventArgs e)
        {
            string ID = ((Button)sender).CommandParameter.ToString();

            smjene s = new smjene(ID);
            s.Show();
            this.Close();
        }
    }
}
