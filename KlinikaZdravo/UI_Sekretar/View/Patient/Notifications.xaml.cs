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

namespace healthClinic
{
    /// <summary>
    /// Interaction logic for Notifications.xaml
    /// </summary>
    public partial class Notifications : Page
    {
        public Notifications()
        {
            InitializeComponent();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            PocetnaStranica ps = new PocetnaStranica();
            this.NavigationService.Navigate(ps);
        }

        private void Button_Click_Survey(object sender, RoutedEventArgs e)
        {
            Survey ss = new Survey();
            this.NavigationService.Navigate(ss);
        }

        private void Button_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void poruka1(object sender, RoutedEventArgs e)
        {
            Porukaa pr = new Porukaa();
            this.NavigationService.Navigate(pr);
        }
    }
}
