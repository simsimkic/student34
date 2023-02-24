using Aplikacija.Services;
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

namespace Aplikacija.dugmeOprema
{
    /// <summary>
    /// Interaction logic for premjestanjeOpreme.xaml
    /// </summary>
    public partial class premjestanjeOpreme : Window
    {
        private string id;
        public premjestanjeOpreme(string IdSale)
        {
            InitializeComponent();
            id = IdSale;

            foreach (Oprema zap in OpremaService.Instance.GetSvaOprema().Values)
            {
                if (id.Equals(zap.IDOpreme))
                {
                   sifraa.Text=zap.IDOpreme;
                    kolicinaa.Text = zap.kolicina.ToString();
                    nazivv.Text = zap.naziv;
                    

                   
                }

            }
            // nadjes salu iz repoa po id-u i setujes
            //setujes opremu

            //ucitaj dostupne sale iz repoa
            // setuj kombo box da sadrzi imena sala




            //privremeno


            tema.Fill = Themes.ThemeHelper.getPozadina();
        }

        private void odustanii(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void premjesti(object sender, RoutedEventArgs e)
        {
            // izmenis pocetnu salu, umanjis opremu
            // snimis


            // na osnovu selektovanog itema iz kombo boxa nadji koja je odredisna sala
            // dobavis od repoa odredisnu salu
            // izmeni novu (odredisnu) salu, i izmenis joj opremu

            // snimis


            // refreshuj parenta
            this.Close();
        }

        private void odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
