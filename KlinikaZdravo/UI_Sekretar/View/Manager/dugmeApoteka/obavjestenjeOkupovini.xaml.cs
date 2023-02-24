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

namespace Aplikacija.dugmeApoteka
{
    /// <summary>
    /// Interaction logic for obavjestenjeOkupovini.xaml
    /// </summary>
    public partial class obavjestenjeOkupovini : Window
    {
        public obavjestenjeOkupovini()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

            imeDoktora.Text = DodajDugme.doktor;
            imeLijeka.Text = DodajDugme.ime;
           // imeLijeka.Text = s[1];
        }

        private void ok(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
