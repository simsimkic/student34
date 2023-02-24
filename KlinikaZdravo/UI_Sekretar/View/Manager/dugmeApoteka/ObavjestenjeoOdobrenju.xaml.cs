using Aplikacija.Services;
using Aplikacija.Themes;
using ClassDiagram.Controller;
using ClassDiagram.Model.Medicine;
using ClassDiagram.Repository.Sequencer;
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
using System.Windows.Shapes;
using UI_sekretar;

namespace Aplikacija.dugmeApoteka
{
    /// <summary>
    /// Interaction logic for ObavjestenjeoOdobrenju.xaml
    /// </summary>
    public partial class ObavjestenjeoOdobrenju : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Window owner;
        private IController<Drug, long> _drugController;



        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        public ObavjestenjeoOdobrenju()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();

            ljekarOdobrio.Text = DodajDugme.doktor;
            imeLlijeka.Text = DodajDugme.ime;
            var app = Application.Current as App;

            _drugController = app._DrugController;
        }
    
      //  private string nazivText;

        //public string Naziv
        //{
        //    get
        //    {
        //        return nazivText;
        //    }
        //    set
        //    {
        //        if (value != nazivText)
        //        {
        //            nazivText = value;
        //            OnPropertyChanged("nazivText");
        //        }
        //    }
        //}
        public void setOwner(Window _owner)
        {
            owner = _owner;
        }
        private void DodajLijek_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void DodajLijek_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            // provere i validacije probaj raditi ovde, pa ako je sve ok nastavi izvrsavanje ove metode, ako ne onda samo return
            // ali proveri :)


            //if (prikazaniZaposleni != null)
            //{

            //}


            Lijekovi lijek = new Lijekovi();
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

          
                lijek.IDlijeka = rnd.Next(100).ToString();  // osmisli logiku za kreiranje ID-a, vodi racuna da ocuvas ID kad radis izmenu

            Drug drug = new Drug();
            LongSequencer l = new LongSequencer();
            drug.Name = imeLlijeka.Text;

            lijek.nazivLijeka = DodajDugme.ime;
            bool success = false;


            success = LijekoviServece.Instance.RegistrujLijek(lijek);
            


            if (success)
            {
                (owner as pocetnaApoteka).Refresh();
                _drugController.Create(drug);
                this.Close();
            }
            else
            {
                MessageBox.Show("greska"); // prikazi ispravan error message
            }
        }

        private void ok(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
