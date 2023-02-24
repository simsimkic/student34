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

namespace Aplikacija.dugmeZaposleni
{
    /// <summary>
    /// Interaction logic for pitanjeBrisiRadnika.xaml
    /// </summary>
    public partial class pitanjeBrisiRadnika : Window
    {
        public pitanjeBrisiRadnika()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

        }
        //private void IzbrisiZaposlenog_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        //{

        //    if (zaposleni?.SelectedIndex >= 0)
        //    {
        //        e.CanExecute = true;
        //    }
        //    else
        //    {
        //        e.CanExecute = false;
        //    }
        //}

        //private void IzbrisiZaposlenog_Executed(object sender, ExecutedRoutedEventArgs e)
        //{
        //    Zaposleni selektovani = zaposleni.SelectedItem as Zaposleni;

        //    EmployeeService.Instance.ObrisiZaposlenog(selektovani);
        //    Refresh();
        //}

        private void odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
