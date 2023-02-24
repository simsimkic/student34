using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UI_sekretar
{
    /// <summary>
    /// Interaction logic for ZakazivanjeOperacije.xaml
    /// </summary>
    public partial class ZakazivanjeOperacije : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _jmbg;
        public string Jmbg
        {
            get { return _jmbg; }
            set
            {
                if (value != _jmbg)
                {
                    _jmbg = value;
                    OnPropertyChanged("Jmbg");
                }
            }
        }
        public ZakazivanjeOperacije()
        {
            InitializeComponent();
            this.DataContext = this;
            cbLekari.ItemsSource = RepozitorijumDoktori.doktori;
            cbLekari.DisplayMemberPath = "Doktor";
        }

        private void btnOtkazi_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cbLekari_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!RepozitorijumStalni.StalniNalozi.ContainsKey(Jmbg))
            {
                MessageBox.Show("Pacijent sa unetim JMBG ne postoji!");
                return;
            }
            PodaciStalni stalni = RepozitorijumStalni.StalniNalozi[Jmbg];
            PodaciDoktor doktor = (PodaciDoktor)cbLekari.SelectedItem;
            if (doktor == null)
            {
                return;
            }
            List<PodaciRasporedOS> raspored = (List<PodaciRasporedOS>)UC_RasporedOS.dataGrid.SelectedItems.Cast<PodaciRasporedOS>().ToList();
            foreach (PodaciRasporedOS termin in raspored)
            {
                termin.Pacijent = stalni;
                termin.Doktor = doktor;
                RepozitorijumRasporedOS.zakazaneOperacije.Add(termin);
            }
            UC_RasporedOS.dataGrid.Items.Refresh();
            this.Close();
        }
    }
}
