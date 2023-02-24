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

namespace healthClinic
{
    /// <summary>
    /// Interaction logic for RecommendTerms.xaml
    /// </summary>
    public partial class RecommendTerms : Window
    {
        public RecommendTerms()
        {
            InitializeComponent();
        }

        private void Button_Click_Confirm(object sender, RoutedEventArgs e)
        {


            podaci.ZakazaniTermini preporuka = new podaci.ZakazaniTermini();
            preporuka.Lekar = this.lekar.Text;
            preporuka.Datum = this.od.Text;
            preporuka.Vreme = "05:00 PM" ;
            preporuka.Prostorija = "303";

            if (this.od.Text == "") 
            {
                MessageBox.Show("Morate uneti datum termina!");
            }
            else
            {
                this.termin.Text = "Lekar:" + this.lekar.Text + "\n" + "Datum:" + this.od.Text + "\n" +
                                    "Vreme: 05:00 PM" + "\n" + "Prostorija:303";
            }
     


        }

        private void Zakazi(object sender, RoutedEventArgs e)
        {
            podaci.ZakazaniTermini preporuka = new podaci.ZakazaniTermini();
            preporuka.Lekar = this.lekar.Text;
            preporuka.Datum = this.od.Text;
            preporuka.Vreme = "05:00 PM";
            preporuka.Prostorija = "303";

            podaci.DataBase.zakazani.Add(preporuka);
            this.Close();
            
        }
    }


    
    }


