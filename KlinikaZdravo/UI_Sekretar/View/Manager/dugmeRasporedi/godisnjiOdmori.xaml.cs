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
    /// Interaction logic for godisnjiOdmori.xaml
    /// </summary>
    public partial class godisnjiOdmori : Window
    {
        public godisnjiOdmori()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

            Godisnji g = new Godisnji();
            g.zaposleni = "Marko Markovic";
            g.ID = "fgh5kjh";
            podaciGodisnji.Items.Add(g);

            Godisnji g1 = new Godisnji();
            g1.zaposleni = "Mika  Mikic";
            g1.ID = "snhcds";
            podaciGodisnji.Items.Add(g1);

        }
        public class Godisnji
        {
            public string zaposleni { get; set; }
            public string ID { get; set; }
        }

        private void Termin_Click(object sender, RoutedEventArgs e)
        {
            string ID = ((Button)sender).CommandParameter.ToString();
            godisnji go1 = new godisnji(ID);
            go1.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            pocetnaRasporedi pr = new pocetnaRasporedi();
            pr.Show();
        }
    }
}
