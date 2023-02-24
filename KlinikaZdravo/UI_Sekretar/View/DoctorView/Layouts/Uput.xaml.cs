using ClassDiagram.Controller;
using ClassDiagram.Model.DoctorExaminations;
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
    /// Interaction logic for Uput.xaml
    /// </summary>
    public partial class Uput : Window
    {
        private IController<ReferralLetter, long> rfController;
        private static String s;
        public Uput()
        {
            InitializeComponent();
            dateD.Text = DateTime.Now.Date.ToString();

            var app = Application.Current as App;

            rfController = app._RefferalLetterController;
            
        }
        private void Povratak(object sender, RoutedEventArgs e)
        {
            s = combo.SelectedItem.ToString();
            
            rfController.Create(new ReferralLetter(1, Specialization.pediatrician, DateTime.Now));
            this.Close();
        }
    }
}
