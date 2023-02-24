using Aplikacija.Services;
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

namespace Aplikacija.dugmeApoteka
{
    /// <summary>
    /// Interaction logic for izmjenaPodatakaLijek.xaml
    /// </summary>
    public partial class izmjenaPodatakaLijek : Window
    {
        private pocetnaApoteka owner;
        private Lijekovi selektovani;
        private string id;

        public izmjenaPodatakaLijek(string _id)
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

            id = _id;
            foreach (Lijekovi zap in LijekoviServece.Instance.GetSviLijekovi().Values)
            {
                if (id.Equals(zap.nazivLijeka))
                {
                    sifra.Text = id;
                    naziv.Text = zap.nazivLijeka;
                    kolicina.Text = zap.kolicina.ToString();
                }
            }
        }

        public izmjenaPodatakaLijek(Lijekovi _selektovani)
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

            selektovani = _selektovani;
            naziv.Text = _selektovani.nazivLijeka;
            kolicina.Text = _selektovani.kolicina.ToString();
            sifra.Text = _selektovani.IDlijeka;
        }

        public void setOwner(pocetnaApoteka _owner)
        {
            owner = _owner;
        }

        private void Odustani(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void Potvrda(object sender, RoutedEventArgs e)
        {
            int novaKolicina = 0;
            if (!int.TryParse(kolicina.Text.Trim(), out novaKolicina))
            {
                MessageBox.Show("Dozvoljen je unosss cifara!");
                return;
            }
            if (!naziv.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Dozvoljen je unnnos slova!");
                return;
            }

            selektovani.kolicina = novaKolicina;
            selektovani.nazivLijeka = naziv.Text.Trim();

            bool success = LijekoviServece.Instance.IzmeniLijek(selektovani);
            if (!success)
            {
                // prikazi error poruku
                return;
            }


            owner.Refresh();
            this.Close();
        }

        private void fokus(object sender, RoutedEventArgs e)
        {
            naziv.Clear();

        }

        private void fokusx(object sender, RoutedEventArgs e)
        {
            if (naziv.Text.Equals(""))
            {
                naziv.AppendText("naziv");
            }
        }

        private void fokuss(object sender, RoutedEventArgs e)
        {
            kolicina.Clear();

        }

        private void fokussx(object sender, RoutedEventArgs e)
        {
            if (kolicina.Text.Equals(""))
            {
                kolicina.AppendText("kolicina");
            }
        }
    }
}
