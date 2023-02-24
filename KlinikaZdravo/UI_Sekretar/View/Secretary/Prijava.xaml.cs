using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace UI_sekretar
{

    public partial class Prijava : Window
    {
        public Prijava()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String username = korisnIme.Text;
            String password = sifra.Password.ToString();
            if (username.Equals(RepozitorijumMojNalog.mojNalog.KorisnickoIme) && password.Equals(RepozitorijumMojNalog.mojNalog.Sifra)) {
                GlavniProzor gp = new GlavniProzor();
                gp.Show();
                this.Close();
            }
            else { return;
            }
        }


    }
}
