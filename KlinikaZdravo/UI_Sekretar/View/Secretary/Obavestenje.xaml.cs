using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UI_sekretar
{
    /// <summary>
    /// Interaction logic for Obavestenje.xaml
    /// </summary>
    public partial class Obavestenje : Window
    {
        public Obavestenje()
        {
            InitializeComponent();
        }

        private void btnNe_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnDa_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
