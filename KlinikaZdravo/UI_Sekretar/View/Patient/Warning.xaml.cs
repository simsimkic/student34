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
using healthClinic.podaci;

namespace healthClinic
{
    /// <summary>
    /// Interaction logic for Warning.xaml
    /// </summary>
    public partial class Warning : Window
    {
        public List<ZakazaniTermini> mojiTermini = new List<ZakazaniTermini>();


        public List<ZakazaniTermini> mojiTer
        {
            get { return mojiTermini; }
            set
            {
                mojiTermini = value;
            }
        }
        public Warning()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int selektovani = patientSchedule.SelectedIndex;

            for (int i = 0; i < mojiTermini.Count; i++)
            {
           //     if (i == selektovani)
                {
                    mojiTermini.RemoveAt(i);
                }
            }

            
        }
    }
}
