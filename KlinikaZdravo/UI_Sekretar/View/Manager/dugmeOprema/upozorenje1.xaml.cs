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
    /// Interaction logic for upozorenje1.xaml
    /// </summary>
    public partial class upozorenje1 : Window
    {
        public upozorenje1()
        {
            InitializeComponent();
            tema.Fill = Themes.ThemeHelper.getPozadina();

        }

        private void Ok(object sender, RoutedEventArgs e)
        {
           
              this.Close();
       
        }
    }
}
