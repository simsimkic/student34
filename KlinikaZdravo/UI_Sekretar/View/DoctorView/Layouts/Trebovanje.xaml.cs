using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI_sekretar;

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for Trebovanje.xaml
    /// </summary>
    public partial class Trebovanje : Window
    {
        public IController<Notifications, long> notificationssController;
        public Trebovanje()
        {
            InitializeComponent();
            odabirdana.End = DateTime.Now;
            var app = Application.Current as App;

            notificationssController = app._NotificationssController;
        }

        private void Povratak(object sender, RoutedEventArgs e)
        {

        }

        private void Trebuj(object sender, RoutedEventArgs e)
        {
            if (naziv.Text.Equals("") || kolicina.Text.Equals("") || dateD.Text.Equals("") )
            {
                error.Content = "Morate popuniti sva obavezna polja!";
            }
            else
            {
                notificationssController.Create(new Notifications(1,"TREBOVANJE",naziv.Text+" "+kolicina.Text+" "+"datum za isporuku:"+dateD.Text,1));
                this.Close();
            }
        }

        private void Fokus(object sender, RoutedEventArgs e)
        {
            naziv.Focus();
        }

        private void naziv_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == System.Windows.Input.Key.Enter)
            {
                kolicina.Focus();
                kolicina.SelectAll();
            }
        }

        private void kolicina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter || e.Key==System.Windows.Input.Key.Down)
            {
                dateD.IsDropDownOpen = true;
                dateD.Focus();
            }

        }

        private void dateD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter || e.Key == System.Windows.Input.Key.Down)
            {
                dodatneinfo.Focus();
            }

        }

        private void RichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Down)
            {
                trebovanje.Focus();
            }
        }

        private void kolicina_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Up)
            {
                naziv.Focus();
                naziv.SelectAll();
            }
        }

        private void dateD_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Up)
            {
                kolicina.Focus();
                kolicina.SelectAll();
            }

        }

        private void RichTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Up)
            {
                dateD.Focus();
            }
        }
    }
}
