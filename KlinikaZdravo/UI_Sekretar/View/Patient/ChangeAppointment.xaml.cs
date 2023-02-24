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
    /// Interaction logic for changeAppointment.xaml
    /// </summary>
    public partial class changeAppointment : Page
    {
        public podaci.ZakazaniTermini selected;

        public changeAppointment(podaci.ZakazaniTermini selection)
        {
            InitializeComponent();
            selected = selection;
            this.lekar.Text = selection.Lekar;
            this.datum.Text = selection.Datum;
            this.vreme.Text = selection.Vreme;
          
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            mySchedule ms = new mySchedule();
            this.NavigationService.Navigate(ms);
        }

        private void Button_Click_Accept(object sender, RoutedEventArgs e)
        {
        
            selected.Lekar = this.lekar.Text;
            selected.Datum = this.datum.Text;
            selected.Vreme = this.vreme.Text;
            selected.Prostorija = "200";

            
            mySchedule ms = new mySchedule();
            this.NavigationService.Navigate(ms);
        }
    }
}
