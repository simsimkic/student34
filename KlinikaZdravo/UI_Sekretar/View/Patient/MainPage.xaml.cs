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

namespace healthClinic
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class PocetnaStranica : Page
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myAccount my = new myAccount();
            this.NavigationService.Navigate(my);
        }

        private void Button_Click_Schedule(object sender, RoutedEventArgs e)
        {
            mySchedule ms = new mySchedule();
            this.NavigationService.Navigate(ms);
        }

        private void Button_Click_MRecord(object sender, RoutedEventArgs e)
        {
            TreatmentHistory th = new TreatmentHistory();
            this.NavigationService.Navigate(th);
        }

        private void Button_Click_LogOut(object sender, RoutedEventArgs e)
        {
            WarningWindow ww = new WarningWindow();
            ww.ShowDialog();
        }

        private void Button_Click_Question(object sender, RoutedEventArgs e)
        {
            askQuestion aq = new askQuestion();
            this.NavigationService.Navigate(aq);
        }

        private void Button_Click_Notification(object sender, RoutedEventArgs e)
        {

            Notifications nn = new Notifications();
            this.NavigationService.Navigate(nn);
        }

        private void Button_Click_Comment(object sender, RoutedEventArgs e)
        {
            Comment cm = new Comment();
            this.NavigationService.Navigate(cm);
        }

        private void Button_Click_Blog(object sender, RoutedEventArgs e)
        {
            BlogAndSurvey bs = new BlogAndSurvey();
            this.NavigationService.Navigate(bs);
        }

        private void btnTutorial(object sender, RoutedEventArgs e)
        {
         //   Tutorial tutorial = new Tutorial();
           // tutorial.ShowDialog();
        }

       
    }
}
