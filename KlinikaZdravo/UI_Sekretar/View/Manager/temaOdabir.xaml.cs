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

namespace Aplikacija
{
    /// <summary>
    /// Interaction logic for temaOdabir.xaml
    /// </summary>
    public partial class temaOdabir : Window
    {
        public static bool temaSvijetla = false;
        public temaOdabir()
        {
            InitializeComponent();
            

        }

        private void ok(object sender, RoutedEventArgs e)
        {


            string cmbvalue = combooo.SelectedItem.ToString();
            string[] cmbvalues = cmbvalue.Split(new char[] { ' ' });
            Console.WriteLine(cmbvalues[1]);
           
            if (cmbvalues[1].Equals("svijetla"))
            {
                temaSvijetla = true;

            }
            else
            {
                temaSvijetla = false;
            }
            pocetnaUpravnik pu = new pocetnaUpravnik();
            pu.Show();
            this.Close();
        }
    }
}
