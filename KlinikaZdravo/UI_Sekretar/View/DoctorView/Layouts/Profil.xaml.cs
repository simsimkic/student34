
using ProjekatHciDoktor.Model.Examination;
using System.Windows;
using System.Windows.Controls;

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for Profil.xaml
    /// </summary>
    public partial class Profil : UserControl
    {



        public Profil()
        {

            InitializeComponent();
            //if (MainWindow.lekarr.Spec.Equals(""))
            //{
            //    specijalizacija.Content = "/";
            //}
            //else
            //{
            //    specijalizacija.Content = MainWindow.lekarr.Spec;
            //}
            //ime.Content = MainWindow.lekarr.Ime;
            //prezime.Content = MainWindow.lekarr.Prezime;
            //mail.Content = MainWindow.lekarr.Ime+"@gmail.com";
            //kontakt.Content = "323-3333";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var izmena = new IzmenaProfila();
            izmena.Show();
        }

        private void slika_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Right)
            {
                izmenapod.Focus();
            }
        }

        private void izmenapod_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Left)
            {
                izmenaslike.Focus();
            }
        }
    }


}
