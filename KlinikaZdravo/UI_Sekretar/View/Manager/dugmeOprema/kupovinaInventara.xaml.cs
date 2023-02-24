using Aplikacija.Services;
using ClassDiagram.Controller;
using ClassDiagram.Model.Rooms;
using System;
using System.Collections.Generic;
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
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;
using UI_sekretar;

namespace Aplikacija.dugmeOprema
{
    /// <summary>
    /// Interaction logic for kupovinaInventara.xaml
    /// </summary>
    public partial class kupovinaInventara : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Window owner;
        private Oprema prikazanaOprema;
        private  IController<Equipment, long> _equipmentController;
       

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public kupovinaInventara()
        {
            InitializeComponent();
            tema.Fill = Themes.ThemeHelper.getPozadina(); 
            var app = Application.Current as App;

            _equipmentController = app._EquipmentController;

        }
        public kupovinaInventara(Oprema opremaZaIzmjenu)
        {


            prikazanaOprema = opremaZaIzmjenu;
            Naziv = prikazanaOprema.naziv;
            Kolicina = prikazanaOprema.kolicina;
           
            DataContext = this;

            InitializeComponent();
        }
        public void setOwner(Window _owner)
        {
            owner = _owner;
        }

        private string nazivText;
        private int kolicinaText;

        public string Naziv
        {
            get
            {
                return nazivText;
            }
            set
            {
                if (value != nazivText)
                {
                    nazivText = value;
                    OnPropertyChanged("nazivText");
                }
            }
        }

        public int Kolicina
        {
            get
            {
                return kolicinaText;
            }
            set
            {
                if (value != kolicinaText)
                {
                    kolicinaText = value;
                    OnPropertyChanged("kolicinaText");
                }
            }
        }
        private void Dodaj_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Dodaj_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // provere i validacije probaj raditi ovde, pa ako je sve ok nastavi izvrsavanje ove metode, ako ne onda samo return
            // ali proveri :)


            //if (prikazaniZaposleni != null)
            //{

            //}
            Equipment equipment = new Equipment();
            equipment.Name = sta.Text;
            equipment.Quantity = int.Parse(kolicina.Text);
            _equipmentController.Create(equipment);
            (owner as Soba1).Refresh();//owner je null?
               this.Close();
            //equipment.Quantity = kolicina.Text.ToString();




            Oprema oprema = new Oprema();
            Random rnd = new Random();
            //if (ime.Text.Equals("") || prezime.Text.Equals("") || email.Text.Equals("") || telefon.Text.Equals("") || jmbg.Text.Equals(""))
            //{
            //    MessageBox.Show("morate popuniti sva polja!");
            //    return;
            //}
            //if (!ime.Text.All(Char.IsLetter) || (!prezime.Text.All(Char.IsLetter)))
            //{
            //    MessageBox.Show("Polja ime i prezime mogu da sadrza samo slova");
            //    return;
            //}
            //if (!jmbg.Text.All(Char.IsDigit) || jmbg.Text.Length != 12)
            //{
            //    MessageBox.Show("Polje jmbg moze da sadrzi maksimalno 12 brojeva");
            //    return;
            //}
            //if (telefon.Text.Length != 9 && telefon.Text.Length != 10)
            //{
            //    MessageBox.Show("Telefon moze da sadrzi 9 ili 10 cifara");
            //    return;
            //}

            //if (prikazanaOprema == null)
            //{
               oprema.IDOpreme = rnd.Next(100).ToString();  // osmisli logiku za kreiranje ID-a, vodi racuna da ocuvas ID kad radis izmenu
            //}
            //else
            //{
            //    oprema.IDOpreme = prikazanaOprema.IDOpreme;
            //}
            oprema.naziv = sta.Text;
            oprema.kolicina = int.Parse(kolicina.Text);
          //  int novaKolicina = 0;
            //if (!int.TryParse(kolicina.Text.Trim(), out novaKolicina))
            //{
            //    MessageBox.Show("Dozvoljen je uos cifara!");
            //    return;
            //}
            //oprema.kolicina = novaKolicina;

            bool success = false;

            if (prikazanaOprema == null)
            {
                success = OpremaService.Instance.RegistrujOpremu(oprema);
            }
            //else
            //{
            //    success = OpremaService.Instance.IzmeniOpremu(oprema);
            //}


            //if (success)
            //{
                (owner as Soba1).Refresh();//owner je null?
            this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("greska"); // prikazi ispravan error message
            //}

        }

        private void Odustani_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Odustani_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
        private void odustani(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void kupi(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void fokus(object sender, MouseEventArgs e)
        {
            sta.Clear();
        }

        private void kol(object sender, MouseEventArgs e)
        {
            kolicina.Clear();
        }

        private void fokusx(object sender, RoutedEventArgs e)
        {
            if (sta.Text.Equals(""))
            {
                sta.AppendText("INVENTAR KOJI KUPUJETE?");
            }
        }

        private void fokussx(object sender, RoutedEventArgs e)
        {
            if (kolicina.Text.Equals(""))
            {
                kolicina.AppendText("KOLICINA?");
            }
        }
    }
}
