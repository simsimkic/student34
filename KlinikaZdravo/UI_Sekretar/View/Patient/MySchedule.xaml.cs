using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
    /// <summary>
    /// Interaction logic for mySchedule.xaml
    /// </summary>
    public partial class mySchedule : Page
    {
        private int colNum = 0;

        public List<ZakazaniTermini> mojiTermini = new List<ZakazaniTermini>();
        private IController<Examination, long> examinationController;
        public List<Examination> termini = new List<Examination>();


        public List<Examination> mojiTer
        {
            get { return termini; }
            set
            {
                termini = value;
            }
        }
        public mySchedule()
        {
            InitializeComponent();
            this.DataContext = this;

      //      this.patientSchedule.ItemsSource = podaci.DataBase.zakazani;
            var app = Application.Current as App;
            examinationController = app.examnationController;
            termini = (List<Examination>) examinationController.GetAll();

    
        }


        private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            colNum++;
            if (colNum == 5)
                e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            PocetnaStranica ps = new PocetnaStranica();
            this.NavigationService.Navigate(ps);
        }

        private void Button_Click_Schedule(object sender, RoutedEventArgs e)
        {
            MakeAnAppointment ma = new MakeAnAppointment();
            patientSchedule.Items.Refresh();
            this.NavigationService.Navigate(ma);
        }

        private void Button_Click_Change(object sender, RoutedEventArgs e)
        {
            
            int z = patientSchedule.SelectedIndex;

            for (int i = 0; i < mojiTermini.Count; i++)
            {
                if (i == z)
                {
                    podaci.ZakazaniTermini selection = (podaci.ZakazaniTermini)patientSchedule.SelectedItem;
                    changeAppointment ca = new changeAppointment(selection);
                    this.NavigationService.Navigate(ca);
                }
               
            }
            if (patientSchedule.SelectedItem == null)
            {
                MessageBox.Show("Morate prvo da selektujete!");
            }

            this.patientSchedule.ItemsSource = podaci.DataBase.zakazani;
         
            //   patientSchedule.ItemsSource = new List<ZakazaniTermini>();
            //   patientSchedule.ItemsSource = mojiTermini;
            patientSchedule.Items.Refresh();

            }

        private void Button_Cancel(object sender, RoutedEventArgs e)
        {
            Examination examination = patientSchedule.SelectedItem as Examination;
            examinationController.Delete(examination);
            patientSchedule.Items.Refresh();
          
            /*int selektovani1 = patientSchedule.SelectedIndex;


            
                        for (int i = 0; i < podaci.DataBase.zakazani.Count; i++)
                        {
                            if (i == selektovani1)
                            {
                                podaci.DataBase.zakazani.RemoveAt(i);
                            }

                        }

                        if (patientSchedule.SelectedItem == null)
                        {
                            MessageBox.Show("Morate prvo da selektujete!");
                        }
                        
            //  this.patientSchedule.ItemsSource = podaci.DataBase.zakazani;
            
            */
        }
    }
}
