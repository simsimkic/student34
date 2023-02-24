using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using ClassDiagram.Controller;
using ClassDiagram.Model.DoctorExaminations;
using healthClinic.podaci;
using UI_sekretar;

namespace healthClinic
{
    
    public partial class MakeAnAppointment : Page
    {
        public readonly IController<Examination, long> ExaminationController;


        private DateTime currentDateTime = DateTime.Now;
        public DateTime CurrentDateTime
        {
            get
            {
                return currentDateTime;
            }
            set
            {
                currentDateTime = value;
            }
        }
        public List<ZakazaniTermini> mojiTermini = new List<ZakazaniTermini>();


        public List<ZakazaniTermini> mojiTer
        {
            get { return mojiTermini; }
            set
            {
                mojiTermini = value;
            }
        }
     
        public object MySchedule { get; private set; }

        public MakeAnAppointment()
        {
            InitializeComponent();
            this.DataContext = this;

            var app = Application.Current as App;
            ExaminationController = app.examnationController;

        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            mySchedule ms = new mySchedule();
            this.NavigationService.Navigate(ms);
        }

        private void Button_Click_Recommend(object sender, RoutedEventArgs e)
        {
            RecommendTerms rt = new RecommendTerms();
            rt.ShowDialog();
        }

        private void Button_Click_Accept(object sender, RoutedEventArgs e)
        {
            Examination examination = new Examination();

            examination.DoctorName = cmbBox.Text;
            examination.AvailableDate = (DateTime) Kalendar.SelectedDate;
            examination.Vreme = (DateTime) vreme.SelectedTime.Value;

            ExaminationController.Create(examination);

            mySchedule ms = new mySchedule();

            this.NavigationService.Navigate(ms);

            /*
            mojiTer = new List<ZakazaniTermini>();

            mojiTer.Add(new ZakazaniTermini() { Lekar = this.cmbBox.Text, Datum = this.Kalendar.Text, 
                Vreme = this.vreme.Text, Prostorija = "123"});

           
            podaci.ZakazaniTermini terminii = new podaci.ZakazaniTermini();
            terminii.Lekar = this.cmbBox.Text;
            terminii.Datum = this.Kalendar.Text;
            terminii.Vreme = this.vreme.Text;
            terminii.Prostorija = "209";

            if (this.Kalendar.Text == "" || this.cmbBox.Text == "" || this.vreme.Text == "")
            {
                MessageBox.Show("Morate da unesete sva polja!");
            }
            else
            {
                podaci.DataBase.zakazani.Add(terminii);
            }*/
        }
        private void ComboBox_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }
    }
}