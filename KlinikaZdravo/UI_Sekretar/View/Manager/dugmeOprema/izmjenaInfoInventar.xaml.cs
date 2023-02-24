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
    /// Interaction logic for izmjenaInfoInventar.xaml
    /// </summary>
    public partial class izmjenaInfoInventar : Window
    {
        private string id;
        private Soba1 owner;
        private Oprema prikazanaOprema;

        public izmjenaInfoInventar(string _id)
        {
            InitializeComponent();
            id = _id;
            foreach (Oprema zap in OpremaService.Instance.GetSvaOprema().Values)
            {
                if (id.Equals(zap.naziv))
                {
                    sifra.Text = zap.IDOpreme;
                    kolicinaa.Text = zap.kolicina.ToString();
                    nazivv.Text = zap.naziv;
                }
            }
        }

        public izmjenaInfoInventar(Oprema opr)
        {
            InitializeComponent();
            tema.Fill = Themes.ThemeHelper.getPozadina();

            prikazanaOprema = opr;
            sifra.Text = opr.IDOpreme;
            kolicinaa.Text = opr.kolicina.ToString();
            nazivv.Text = opr.naziv;
        }

        public void setOwner(Soba1 own)
        {
            owner = own;
        }

        private void osut(object sender, RoutedEventArgs e)
        {

        }

        private void Odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Potvrdi(object sender, RoutedEventArgs e)
        {
            int novaKolicina = 0;
            if (!int.TryParse(kolicinaa.Text.Trim(), out novaKolicina))
            {
                MessageBox.Show("Dozvoljen je uos cifara!");
                return;
            }


            prikazanaOprema.kolicina = novaKolicina;
            prikazanaOprema.naziv = nazivv.Text.Trim();

            bool success = OpremaService.Instance.IzmeniOpremu(prikazanaOprema);
            if (!success)
            {
                // prikazi error poruku
                return;
            }


            owner.Refresh();
            this.Close();
        }
    }
}
