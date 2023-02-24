using Aplikacija.dugmeZaposleni;
using Aplikacija.Services;
using Aplikacija.Themes;
using ClassDiagram.Controller;
using ClassDiagram.Model.WorkingSchedule;
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
using System.Windows.Shapes;
using UI_sekretar;

namespace Aplikacija.dugmeRasporedi
{
    /// <summary>
    /// Interaction logic for smjene.xaml
    /// </summary>
    public partial class smjene : Window
    {
        private string id;
        private IController<PersonalDay, long> _pdController;
        private IController<WorkingHoursSchedule, long> _whsController;

        public smjene(string _id)
        {
            InitializeComponent();
            var app = Application.Current as App;
            _pdController = app._PersonalDayController;
            _whsController = app._SWorkingHoursSchedule;
            tema.Fill = ThemeHelper.getPozadina();

            id = _id;



            imeZaposlenog.Text = id;
               
        }

        private void izmjena(object sender, RoutedEventArgs e)
        {
            tp1.IsEnabled = true;
            tp2.IsEnabled = true;
            tp3.IsEnabled = true;
            tp4.IsEnabled = true;
            tp5.IsEnabled = true;
            tp6.IsEnabled = true;
            tp7.IsEnabled = true;
            tp8.IsEnabled = true;
            tp9.IsEnabled = true;
            tp10.IsEnabled = true;
            tp11.IsEnabled = true;
            tp12.IsEnabled = true;
            tp13.IsEnabled = true;
            tp14.IsEnabled = true;
            dp1.IsEnabled = true;
            dp2.IsEnabled = true;
            cb1.IsEnabled = true;
            cb2.IsEnabled = true;
            cb3.IsEnabled = true;
            cb4.IsEnabled = true;
            cb5.IsEnabled = true;
            cb6.IsEnabled = true;
            cb7.IsEnabled = true;
        }

        private void sacuvaj(object sender, RoutedEventArgs e)
        {
            {
                tp1.IsEnabled = false;
                tp2.IsEnabled = false;
                tp3.IsEnabled = false;
                tp4.IsEnabled = false;
                tp5.IsEnabled = false;
                tp6.IsEnabled = false;
                tp7.IsEnabled = false;
                tp8.IsEnabled = false;
                tp9.IsEnabled = false;
                tp10.IsEnabled = false;
                tp11.IsEnabled = false;
                tp12.IsEnabled = false;
                tp13.IsEnabled = false;
                tp14.IsEnabled = false;
                dp1.IsEnabled = false;
                dp2.IsEnabled = false;
                cb1.IsEnabled = false;
                cb2.IsEnabled = false;
                cb3.IsEnabled = false;
                cb4.IsEnabled = false;
                cb5.IsEnabled = false;
                cb6.IsEnabled = false;
                cb7.IsEnabled = false;
            }

            if (cb1.IsChecked==true)
            {
                PersonalDay pd = new PersonalDay();
                pd.Day = Days.monday;
                pd.Name = imeZaposlenog.Text;

                _pdController.Create(pd);
            }
            if (cb1.IsChecked == false)

            {
                if (tp1.SelectedTime != null && tp2.SelectedTime != null)
                {
                    WorkingHoursSchedule whs = new WorkingHoursSchedule();
                    whs.Name = imeZaposlenog.Text;
                    whs.From = (DateTime)tp1.SelectedTime;
                    whs.To = (DateTime)tp2.SelectedTime;
                    _whsController.Create(whs);
                }
            }
            if (cb2.IsChecked == true)
            {
                PersonalDay pd = new PersonalDay();
                pd.Name = imeZaposlenog.Text;
                pd.Day = Days.tuesday;
                _pdController.Create(pd);
            }
            if(cb2.IsChecked == false)
            {
                if (tp3.SelectedTime != null && tp4.SelectedTime != null)
                {
                    WorkingHoursSchedule whs = new WorkingHoursSchedule();
                    whs.From = (DateTime)tp3.SelectedTime;
                    whs.To = (DateTime)tp4.SelectedTime;
                    whs.Name = imeZaposlenog.Text;

                    _whsController.Create(whs);

                }

            }
            
            if (cb3.IsChecked == true)
            {
                PersonalDay pd = new PersonalDay();
                pd.Name = imeZaposlenog.Text;

                pd.Day = Days.wednesday;
                _pdController.Create(pd);
            }
            else
            {
                if (tp5.SelectedTime != null && tp6.SelectedTime != null)
                {
                    WorkingHoursSchedule whs = new WorkingHoursSchedule();
                    whs.From = (DateTime)tp5.SelectedTime;
                    whs.To = (DateTime)tp6.SelectedTime;
                    whs.Name = imeZaposlenog.Text;

                    _whsController.Create(whs);
                }
            }
            if (cb4.IsChecked == true)
            {
                PersonalDay pd = new PersonalDay();
                pd.Name = imeZaposlenog.Text;

                pd.Day = Days.thursday;
                _pdController.Create(pd);
            }
            else
            {
                if (tp7.SelectedTime != null && tp8.SelectedTime != null)
                {
                    WorkingHoursSchedule whs = new WorkingHoursSchedule();
                    whs.From = (DateTime)tp7.SelectedTime;
                    whs.To = (DateTime)tp8.SelectedTime;
                    whs.Name = imeZaposlenog.Text;

                    _whsController.Create(whs);
                }
            }
            if (cb5.IsChecked == true)
            {
                PersonalDay pd = new PersonalDay();
                pd.Name = imeZaposlenog.Text;

                pd.Day = Days.friday;
                _pdController.Create(pd);
            }
            else
            {
                if (tp9.SelectedTime != null && tp10.SelectedTime != null)
                {
                    WorkingHoursSchedule whs = new WorkingHoursSchedule();
                    whs.From = (DateTime)tp9.SelectedTime;
                    whs.To = (DateTime)tp10.SelectedTime;
                    whs.Name = imeZaposlenog.Text;

                    _whsController.Create(whs);
                }
                    

            }
            if (cb6.IsChecked == true)
            {
                PersonalDay pd = new PersonalDay();
                pd.Name = imeZaposlenog.Text;

                pd.Day = Days.saturday;
                _pdController.Create(pd);
            }
            else
            {
                if (tp11.SelectedTime != null && tp12.SelectedTime != null)
                {
                    WorkingHoursSchedule whs = new WorkingHoursSchedule();
                    whs.From = (DateTime)tp11.SelectedTime;
                    whs.To = (DateTime)tp12.SelectedTime;
                        whs.Name = imeZaposlenog.Text;


                    _whsController.Create(whs);
                }
                    

            }
            if (cb7.IsChecked == true)
            {
                PersonalDay pd = new PersonalDay();
                pd.Day = Days.sunday;
                pd.Name = imeZaposlenog.Text;

                _pdController.Create(pd);
            }
            else
            {
                if (tp13.SelectedTime != null && tp14.SelectedTime != null)
                {
                    WorkingHoursSchedule whs = new WorkingHoursSchedule();
                    whs.From = (DateTime)tp13.SelectedTime;
                    whs.To = (DateTime)tp14.SelectedTime;
                    whs.Name = imeZaposlenog.Text;

                    _whsController.Create(whs);
                }
                  

            }
        }

        private void nazad(object sender, RoutedEventArgs e)
        {
            smjenePocetna sp = new smjenePocetna();
            sp.Show();
            this.Close();
        }

        private void cb1_Click(object sender, RoutedEventArgs e)
        {
            if (cb1.IsChecked == true)
            {
                tp1.IsEnabled = false;
                tp1.Text="slobodan dan";
                tp2.IsEnabled = false;
                tp2.Text = "slobodan dan";

            }
        }

        private void cb2_Click(object sender, RoutedEventArgs e)
        {
            if (cb2.IsChecked == true)
            {
                tp3.IsEnabled = false;
                tp4.IsEnabled = false;
                tp3.Text = "slobodan dan"; 
                tp4.Text = "slobodan dan";
            }
        }

        private void cb3_Click(object sender, RoutedEventArgs e)
        {
            if (cb3.IsChecked == true)
            {
                tp5.IsEnabled = false;
                tp6.IsEnabled = false;
                tp5.Text = "slobodan dan";
                tp6.Text = "slobodan dan";
            }
        }

        private void cb4_Click(object sender, RoutedEventArgs e)
        {
            if (cb4.IsChecked == true)
            {
                tp7.IsEnabled = false;
                tp8.IsEnabled = false;
                tp7.Text = "slobodan dan";
                tp9.Text = "slobodan dan";
            }
        }

        private void cb5_Click(object sender, RoutedEventArgs e)
        {
            if (cb5.IsChecked == true)
            {
                tp9.IsEnabled = false;
                tp10.IsEnabled = false;
                tp9.Text = "slobodan dan";
                tp10.Text = "slobodan dan";
            }
        }
        private void cb6_Click(object sender, RoutedEventArgs e)
        {
            if (cb6.IsChecked == true)
            {
                tp11.IsEnabled = false;
                tp12.IsEnabled = false;
                tp11.Text = "slobodan dan";
                tp12.Text = "slobodan dan";
            }
        }
        private void cb7_Click(object sender, RoutedEventArgs e)
        {
            if (cb7.IsChecked == true)
            {
                tp13.IsEnabled = false;
                tp14.IsEnabled = false;
                tp13.Text = "slobodan dan";
                tp14.Text = "slobodan dan";
            }
        }

    }
}
