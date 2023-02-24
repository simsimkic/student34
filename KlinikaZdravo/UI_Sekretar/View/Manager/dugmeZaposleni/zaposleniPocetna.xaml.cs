using Aplikacija.Services;
using Aplikacija.Themes;
using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
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

namespace Aplikacija.dugmeZaposleni
{
    /// <summary>
    /// Interaction logic for zaposleniPocetna.xaml
    /// </summary>
    public partial class zaposleniPocetna : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IController<Employee, long> _employeeController;
        public static  Zaposleni selektovani=new Zaposleni();

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        private ObservableCollection<Zaposleni> listaZaposlenih;
        public ObservableCollection<Zaposleni> ListaZaposlenih
        {
            get
            {
                return listaZaposlenih;
            }
            set
            {
                listaZaposlenih = value;
                OnPropertyChanged("ListaZaposlenih");                
            }
        }

        public zaposleniPocetna()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();
           
            
            var app = Application.Current as App;


            

            _employeeController = app._EmployeeController;



            ListaZaposlenih = new ObservableCollection<Zaposleni>();

            foreach (Zaposleni zap in EmployeeService.Instance.GetSviZaposleni().Values)
            {
                ListaZaposlenih.Add(zap);
            }

            OnPropertyChanged("ListaZaposlenih");

            this.DataContext = this;
        }


        private void DodajZaposlenog_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void DodajZaposlenog_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Window5 w5 = new Window5();
            w5.setOwner(this);
            w5.Show();

            OnPropertyChanged("ListaZaposlenih");
        }

        private void IzbrisiZaposlenog_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            if (zaposleni?.SelectedIndex >= 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void IzbrisiZaposlenog_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            selektovani = zaposleni.SelectedItem as Zaposleni;
            string s = selektovani.IDZaposleni;
            Console.WriteLine(s);

            _employeeController.DeleteById(long.Parse(s));

            EmployeeService.Instance.ObrisiZaposlenog(selektovani);
            Refresh();
        }

        private void IzmeniZaposlenog_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            if (zaposleni?.SelectedIndex >= 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void IzmeniZaposlenog_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Zaposleni selektovani = zaposleni.SelectedItem as Zaposleni;
            
            Window5 w5 = new Window5(selektovani);
            w5.setOwner(this);


            w5.Show();
        }

        private void pocetna(object sender, RoutedEventArgs e)
        {
            pocetnaUpravnik p = new pocetnaUpravnik();
            p.Show();
            this.Close();
        }

        private void odjava(object sender, RoutedEventArgs e)
        {
            Window4 o = new Window4();
            o.Show();
            this.Close();

        }

        private void btnView(object sender ,RoutedEventArgs e)
        {
            string ID = ((Button)sender).CommandParameter.ToString();
            Zaposleni zap = new Zaposleni();

            Window1 i = new Window1(ID);
            i.Show();
        }
        
        public void Refresh()
        {
            ListaZaposlenih = new ObservableCollection<Zaposleni>();

            foreach (Zaposleni zap in EmployeeService.Instance.GetSviZaposleni().Values)
            {
                ListaZaposlenih.Add(zap);
            }

            OnPropertyChanged("ListaZaposlenih");
        }

        private void izbrisi(object sender, RoutedEventArgs e)
        {
            pitanjeBrisiRadnika p = new pitanjeBrisiRadnika();
            p.Show();
        }

        private void izmijeni(object sender, RoutedEventArgs e)
        {
            selektovani = zaposleni.SelectedItem as Zaposleni;
        }
    }
}
