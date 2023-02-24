using Aplikacija.Themes;
using ClassDiagram.Controller;
using ClassDiagram.Model.Rooms;
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
using UI_sekretar;

namespace Aplikacija.dugmeSobe
{
    /// <summary>
    /// Interaction logic for zakazivanjeRednoviranja.xaml
    /// </summary>
    public partial class zakazivanjeRednoviranja : Window
    {
        private Raspored owner;
        private IController<Renovation, long> _renovationController;


        public void SetOwner(Raspored own)
        {
            owner = own;
        }

        public zakazivanjeRednoviranja()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();
            datumRenoviranja.Text = datum.datumizabran.ToString().Split(' ')[0];
            var app = Application.Current as App;

            _renovationController = app._RenovationController;

        }

        private void Da(object sender, RoutedEventArgs e)
        {
            owner.disableAll();
            this.Close();
            Renovation renovation = new Renovation();
            renovation.FromDate = DateTime.Parse(datumRenoviranja.Text);
            renovation.ToDate = DateTime.Parse("01.07.2020");
            _renovationController.Create(renovation);
            
        }

        private void Ne(object sender, RoutedEventArgs e)
        {
            owner.enableAll();
            this.Close();
        }
    }
}
