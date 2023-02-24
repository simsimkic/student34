using ClassDiagram.Controller;
using ClassDiagram.Model.DoctorExaminations;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI_sekretar;

namespace ProjekatHciDoktor.Layouts
{
    /// <summary>
    /// Interaction logic for Recept.xaml
    /// </summary>
    public partial class Recept : Window
    {

        private IController<Prescription, long> prController;
        private IController<MedicalRecord, long> mrController;
        public Recept()
        {
            InitializeComponent();

            var app = Application.Current as App;

            prController = app.precriptionController;
        }
        private void Izdaj(object sender, RoutedEventArgs e)
        {
            Prescription p = new Prescription(2, nazivl.Text, upotrebal.Text);
            prController.Create(p);
            this.Close();
        }
    }
}
