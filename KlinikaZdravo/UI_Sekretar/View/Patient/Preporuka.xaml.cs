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
    /// Interaction logic for Preporuka.xaml
    /// </summary>
    public partial class Preporuka : UserControl
    {
        RecommendTerms rt = new RecommendTerms();

        public Preporuka()
        {
            InitializeComponent();

            //this.termin.Content = 

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
