using Aplikacija.Services;
using ClassDiagram.Controller;
using ClassDiagram.Model.Rooms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Aplikacija.dugmeOprema
{
    /// <summary>
    /// Interaction logic for pocetnaOprema.xaml
    /// </summary>
    public partial class Soba1 : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private IController<Equipment, long> _eqController;
        public static Oprema selektovani = new Oprema();


        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        private ObservableCollection<Oprema> listaOpreme;
        public ObservableCollection<Oprema> ListaOpreme
        {
            get
            {
                return listaOpreme;
            }
            set
            {
                listaOpreme = value;
                OnPropertyChanged("ListaOpreme");
            }
        }
        public Soba1()
        {
            InitializeComponent();
            tema.Fill = Themes.ThemeHelper.getPozadina();
            var app = Application.Current as App;
            _eqController = app._EquipmentController;
            ListaOpreme = new ObservableCollection<Oprema>();

            foreach (Oprema zap in OpremaService.Instance.GetSvaOprema().Values)
            {
                ListaOpreme.Add(zap);
            }

            OnPropertyChanged("ListaOpreme");

            this.DataContext = this;

        }
        private void DodajOpremu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void DodajOpremu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            kupovinaInventara w5 = new kupovinaInventara();
            w5.setOwner(this);
            w5.Show();

            OnPropertyChanged("ListaOpreme");
        }

        private void IzbrisiOpremu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            if (podaciOsali1?.SelectedIndex >= 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void IzbrisiOpremu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
             selektovani = podaciOsali1.SelectedItem as Oprema;
            string s = selektovani.IDOpreme;
            Console.WriteLine(s);

            _eqController.DeleteById(long.Parse(s));

            OpremaService.Instance.ObrisiOpremu(selektovani);
            Refresh();
        }

        private void IzmeniOpremu_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

            if (podaciOsali1?.SelectedIndex >= 0)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void IzmeniOpremu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (podaciOsali1.SelectedItem == null)
            {
                upozorenje1 u1 = new upozorenje1();
                u1.Show();
            }
            else
            {
                //string ID = ((Button)sender).CommandParameter.ToString();//kod izmjene kad treba da pokupi info puca jer je ID=null??
                //izmjenaInfoInventar ii = new izmjenaInfoInventar(ID);

                Oprema selektovani = podaciOsali1.SelectedItem as Oprema;
                izmjenaInfoInventar ii = new izmjenaInfoInventar(selektovani);
                ii.setOwner(this);
                ii.Show();
            }
        }

        private void nazad(object sender, RoutedEventArgs e)
        {
            saleIordinacijeOpremaPocetna pu = new saleIordinacijeOpremaPocetna();
            pu.Show();
            this.Close();
        }

        private void odj(object sender, RoutedEventArgs e)
        {
            Odjava1 o1 = new Odjava1();
            o1.Show();
            this.Close();
        }
        private void btnView2(object sender, RoutedEventArgs e)
        {
            string IdSale = "1";
            Oprema selektovani = podaciOsali1.SelectedItem as Oprema;
            premjestanjeOpreme po = new premjestanjeOpreme(IdSale);
            po.Show();
        }

        private void kupi(object sender, RoutedEventArgs e)
        {
            kupovinaInventara ki = new kupovinaInventara();
            ki.Show();
        }

        private void tab_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {


        }
        public void Refresh()
        {
            ListaOpreme = new ObservableCollection<Oprema>();

            foreach (Oprema zap in OpremaService.Instance.GetSvaOprema().Values)
            {
                ListaOpreme.Add(zap);
            }

            OnPropertyChanged("ListaOprema");
        }
    }
}
