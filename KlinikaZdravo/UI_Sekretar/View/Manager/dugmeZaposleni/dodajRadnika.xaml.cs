using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using Aplikacija.dugmeZaposleni;
using Aplikacija.Services;
using Aplikacija.Themes;
using ClassDiagram.Controller;
using ClassDiagram.Model.Users;
using ClassDiagram.Repository.Sequencer;
using UI_sekretar;
using static Aplikacija.dugmeZaposleni.zaposleniPocetna;

namespace Aplikacija.dugmeZaposleni
{
    /// <summary>
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Window owner;
        private Zaposleni prikazaniZaposleni;
        //public Zaposleni prikazaniZaposleniKopija;      
        private  IController<Employee, long> _employeeController;





        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

        public Window5()
        {
            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();
            var app = Application.Current as App;

            _employeeController = app._EmployeeController;



        }

        public Window5(Zaposleni zaposleniZaIzmenu)
        {
          
            //prikazaniZaposleniKopija = zaposleniZaIzmenu;
            prikazaniZaposleni = zaposleniZaIzmenu;
            Ime = prikazaniZaposleni.ime;
            Prezime = prikazaniZaposleni.prezime;
            Email = prikazaniZaposleni.email;
            Telefon = prikazaniZaposleni.telefon;
            Specijalizacija = prikazaniZaposleni.zaposlenje;
            Jmbg = prikazaniZaposleni.jmbg;
            Datum = prikazaniZaposleni.datumRodjena;
            DataContext = this;

            InitializeComponent();
            tema.Fill = ThemeHelper.getPozadina();
            //ovde kontroler
            Console.WriteLine(zaposleniZaIzmenu.IDZaposleni+"LALALALALALLALALALALALALL");



        }
        //public Window5(Zaposleni zaposleniIzmjenaBrisanje,bool b)
        //{
        //    prikazaniZaposleniKopija = zaposleniIzmjenaBrisanje;
        //    b = true;

        //}

        public void setOwner(Window _owner)
        {
            owner = _owner;
        }

        private string imeText;
        private string prezimeText;
        private string datumRodjenaText;
        private string jmbgText;
        public string telefonText;
        public string emailText;
        public string specijalizacijaText;


        public string Ime
        {
            get
            {
                return imeText;
            }
            set
            {
                if (value != imeText)
                {
                    imeText = value;
                    OnPropertyChanged("ImeText");
                }
            }
        }

        public string Prezime
        {
            get
            {
                return prezimeText;
            }
            set
            {
                if (value != prezimeText)
                {
                    prezimeText = value;
                    OnPropertyChanged("Prezime");
                }
            }
        }

        public string Datum
        {
            get
            {
                return datumRodjenaText;
            }
            set
            {
                if (value != datumRodjenaText)
                {
                    datumRodjenaText = value;
                    OnPropertyChanged("Datum");
                }
            }
        }

        public string Jmbg
        {
            get
            {
                return jmbgText;
            }
            set
            {
                if (value != jmbgText)
                {
                    jmbgText = value;
                    OnPropertyChanged("Jmbg");
                }
            }
        }

        public string Telefon
        {
            get
            {
                return telefonText;
            }
            set
            {
                if (value != telefonText)
                {
                    telefonText = value;
                    OnPropertyChanged("Telefon");
                }
            }
        }

        public string Email
        {
            get
            {
                return emailText;
            }
            set
            {
                if (value != emailText)
                {
                    emailText = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        public string Specijalizacija
        {
            get
            {
                return specijalizacijaText;
            }
            set
            {
                if (value != specijalizacijaText)
                {
                    specijalizacijaText = value;
                    OnPropertyChanged("Specijalizacija");
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
            Employee employee = new Employee();
            LongSequencer l = new LongSequencer();
            //long id = l.GenerateId();
            //User u = new User(id, ime.Text, prezime.Text, (DateTime)datum.SelectedDate, jmbg.Text, new Contact(id, telefon.Text, email.Text));
            ////Employee em = new Employee(id, spec.Text);
            //_userController.Create(u);
            //_contactController.Create(u.Contact);

            employee.Name = ime.Text;
            employee.Surname = prezime.Text;
            employee.DateOfBirth = (DateTime)datum.SelectedDate;
            employee.PersonalId = jmbg.Text;
            // employee.Contact.PhoneNumber = telefon.Text;
            // employee.Contact.EmailAdress = email.Text;
            employee.Employment = spec.Text;


            employee.PersonalId = jmbg.Text;
            employee.DateOfBirth = datum.DisplayDate;
            //employee.Contact.PhoneNumber = telefon.Text;
            //employee.Contact.EmailAdress = email.Text;







            Zaposleni zaposleni = new Zaposleni();
            //if ((ime.Text.Length == 0) && (prezime.Text.Length == 0) && (jmbg.Text.Length == 0) && (telefon.Text.Length == 0)
            //  && (email.Text.Length == 0))
            //{
            //    MessageBox.Show("Morate popuniti sva polja!");
            //    return;
            //}

            //if (!jmbg.Text.All(Char.IsDigit) || !telefon.Text.All(Char.IsDigit))
            //{
            //    MessageBox.Show("Polja JMBG  i TELEFON mogu da sadrze samo cifre!");
            //    return;
            //}
            //if (jmbg.Text.Length != 13)
            //{
            //    MessageBox.Show("Polje JMBG moze da sadrzi 13 cifara!");
            //    return;
            //}
            //if (telefon.Text.Length != 9 && telefon.Text.Length != 10)
            //{
            //    MessageBox.Show("Polje TELEFON moze da sadrzi 9 ili 10 cifara!");
            //    return;
            //}
            //if (!ime.Text.All(Char.IsLetter) || !prezime.Text.All(Char.IsLetter))
            //{
            //    MessageBox.Show("Polja IME i PREZIME mogu da sadze samo slova");
            //    return;
            //}
            //if ((email.Text.All(Char.IsWhiteSpace)))
            //{
            //    MessageBox.Show("Polje EMAIL ne smije sadrzati razmak(bjelinu)!");
            //    return;
            //}

            if (prikazaniZaposleni == null)
            {
                zaposleni.IDZaposleni = employee.Id.ToString();  // osmisli logiku za kreiranje ID-a, vodi racuna da ocuvas ID kad radis izmenu
            }
            else
            {
                zaposleni.IDZaposleni = prikazaniZaposleni.IDZaposleni;
                //Employee emm = _employeeController.GetByID(long.Parse(zaposleni.IDZaposleni));

            }

            zaposleni.ime = ime.Text;
            zaposleni.prezime = prezime.Text;
            String[] dijelovi = datum.SelectedDate.ToString().Split(' ');
            zaposleni.datumRodjena = dijelovi[0];
            zaposleni.email = email.Text;
            zaposleni.jmbg = jmbg.Text;
            zaposleni.telefon = telefon.Text;
            zaposleni.zaposlenje = spec.Text;
          
            bool success = false;


            if (prikazaniZaposleni == null)
            {
                success = EmployeeService.Instance.RegistrujZaposlenog(zaposleni);
                _employeeController.Create(employee);
                //Employee E = _employeeController.GetByID(22);
                //E.Name = "LALALLA";
                //_employeeController.Update(E);


            }
            else
            {
                success = EmployeeService.Instance.IzmeniZaposlenog(zaposleni);
                //    EmployeeService.Instance.ObrisiZaposlenog(prikazaniZaposleniKopija);
                //_employeeController.Update(employee);
                Zaposleni selektovani = zaposleniPocetna.selektovani;
                Console.WriteLine("AAAAAAA");

                
                //Employee emm = _employeeController.GetByID(long.Parse(selektovani.IDZaposleni));
                
                // _employeeController.Create(new Employee(123,"",""));
            }


            if (success)
            {
                (owner as zaposleniPocetna).Refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("greska"); // prikazi ispravan error message
            }

        }

        private void Odustani_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Odustani_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }

    }
}
