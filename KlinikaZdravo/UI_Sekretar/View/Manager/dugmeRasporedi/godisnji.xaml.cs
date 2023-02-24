using Aplikacija.Themes;
using ClassDiagram.Controller;
using ClassDiagram.Model.WorkingSchedule;
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

namespace Aplikacija.dugmeRasporedi
{
    /// <summary>
    /// Interaction logic for godisnji.xaml
    /// </summary>
    public partial class godisnji : Window
    {
        private string id;
        private IController<VacationSchedule, long> _vsController;

        public godisnji( string _id)
        {
            InitializeComponent();
            var app = Application.Current as App;
            _vsController = app._VacationController;
            tema.Fill = ThemeHelper.getPozadina();


        id = _id;


            imeGodisnji.Text = id;

        }

        private void nazad(object sender, RoutedEventArgs e)
        {
            godisnjiOdmori go = new godisnjiOdmori();
            go.Show();
            this.Close();
        }

        private void izmijena(object sender, RoutedEventArgs e)
        {
            dp1.IsEnabled = true;
            dp2.IsEnabled = true;
        }

        private void sacuvaj(object sender, RoutedEventArgs e)
        {
            dp1.IsEnabled = false;
            dp2.IsEnabled = false;
            VacationSchedule vs = new VacationSchedule();
            vs.From = dp1.DisplayDate;
            vs.To = dp2.DisplayDate;
            vs.Name = imeGodisnji.Text;
            _vsController.Create(vs);
        }
    }
}
