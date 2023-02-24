using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for PodaciIzTabele.xaml
    /// </summary>
    public partial class ZakazivanjePregleda : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private string _ime;
        public string Ime
        {
            get { return _ime; }
            set
            {
                if (value != _ime)
                {
                    _ime = value;
                    OnPropertyChanged("Ime");
                }
            }
        }

        private string _prezime;
        public string Prezime
        {
            get { return _prezime; }
            set
            {
                if (value != _prezime)
                {
                    _prezime = value;
                    OnPropertyChanged("Prezime");
                }
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
    
        public ZakazivanjePregleda()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void btnOtkazi_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!RepozitorijumStalni.StalniNalozi.ContainsKey(Jmbg))
            {
                MessageBox.Show("Pacijent sa unetim JMBG ne postoji!");
                return;
            }
            PodaciStalni stalni = RepozitorijumStalni.StalniNalozi[Jmbg];
            PodaciRasporedDoktora raspored=(PodaciRasporedDoktora) UC_DoktorovRaspored.dataGrid.SelectedItem;
            raspored.Pacijent = stalni;
            RepozitorijumDoktorovRaspored.zakazaniTermini.Add(raspored);
            UC_DoktorovRaspored.dataGrid.Items.Refresh();
            this.Close();
        }
    }
}
