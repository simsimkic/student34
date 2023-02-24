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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UI_sekretar
{
    /// <summary>
    /// Interaction logic for UC_Prijava.xaml
    /// </summary>
    public partial class UC_Prijava : UserControl
    {
        public UC_Prijava()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrijaviSe.Visibility = Visibility.Collapsed;
            GlProzor.Visibility = Visibility.Visible;
        }
    }
}
