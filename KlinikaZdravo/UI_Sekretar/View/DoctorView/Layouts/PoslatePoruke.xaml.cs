using Newtonsoft.Json;
using ProjekatHciDoktor.Model.Questions;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for PoslatePoruke.xaml
    /// </summary>
    public partial class Poslatee : UserControl
    {
        public List<Poruka> poruke = new List<Poruka>();
        public Poruka p = new Poruka();
        public List<Poruka> Poruka
        {
            set
            {
                poruke = value;
            }
            get
            {
                return poruke;
            }
        }

        public Poslatee()
        {
            //InitializeComponent();
            //this.DataContext = this;
            //string json = File.ReadAllText("../../Data/PoslateP.txt");
            //var jset = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
            //poruke = JsonConvert.DeserializeObject<List<Poruka>>(json, jset);
        }
        private void Row_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            p = this.tabela.SelectedItem as Poruka;
            // Ensure row was clicked and not empty space
            //var row = ItemsControl.ContainerFromElement((DataGrid)sender,
            //                                   e.OriginalSource as DependencyObject) as DataGridRow;
            var row = tabela.SelectedIndex + 1;
            if (row == null) return;
            var prikaz = new PrikazPoruke();
            prikaz.prima.Visibility = Visibility.Visible;
            prikaz.salje.Visibility = Visibility.Collapsed;
            prikaz.ko.Content = p.PrimaA;
            prikaz.naslov.Content = p.Naslov;
            prikaz.tekst.Content = p.Tekst;
            prikaz.Show();
        }
    }
}
