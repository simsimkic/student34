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

namespace healthClinic
{
    /// <summary>
    /// Interaction logic for ReportTablexaml.xaml
    /// </summary>
    public partial class ReportTablexaml : Page
    {
        private int colNum = 0;

        public ReportTablexaml()
        {
            InitializeComponent();

            addData pregled = new addData();
            pregled.ponedeljak = "15:00\nEmanera";
            pregled.utorak = "13:00 Sabax";
            pregled.sreda = "Panrazol";
            pregled.cetvrtak = "15:00 Onda";
            pregled.petak = "Kytril pre jela";
            pregled.subota = "11:00 Fiasp";
            pregled.nedelja = "Panrazol";

            addData pregled1 = new addData();
            pregled1.ponedeljak = "15:00Emanera";
            pregled1.utorak = "13:00 Sabax";
            pregled1.sreda = "Panrazol";
            pregled1.cetvrtak = "15:00 Onda";
            pregled1.petak = "Kytril pre jela";
            pregled1.subota = "11:00 Fiasp";
            pregled1.nedelja = "Panrazol";


            addData pregled3 = new addData();
            pregled3.ponedeljak = "15:00Emanera";
            pregled3.utorak = "13:00 Sabax";
            pregled3.sreda = "Panrazol";
            pregled3.cetvrtak = "15:00 Onda";
            pregled3.petak = "Kytril pre jela";
            pregled3.subota = "11:00 Fiasp";
            pregled3.nedelja = "Panrazol";

            addData pregled2 = new addData();
            pregled2.ponedeljak = "15:00Emanera";
            pregled2.utorak = "13:00 Sabax";
            pregled2.sreda = "Panrazol";
            pregled2.cetvrtak = "15:00 Onda";
            pregled2.petak = "Kytril pre jela";
            pregled2.subota = "11:00 Fiasp";
            pregled2.nedelja = "Panrazol";

            addData pregled4 = new addData();
            pregled4.ponedeljak = "15:00Emanera";
            pregled4.utorak = "13:00 Sabax";
            pregled4.sreda = "Panrazol";
            pregled4.cetvrtak = "15:00 Onda";
            pregled4.petak = "Kytril pre jela";
            pregled4.subota = "11:00 Fiasp";
            pregled4.nedelja = "Panrazol";

            addData pregled5 = new addData();
            pregled5.ponedeljak = "";
            pregled5.utorak = "";
            pregled5.sreda = "";
            pregled5.cetvrtak = "";
            pregled5.petak = "";
            pregled5.subota = "";
            pregled5.nedelja = "";


            report.Items.Add(pregled);
            report.Items.Add(pregled1);
             report.Items.Add(pregled2);
            report.Items.Add(pregled3);
            report.Items.Add(pregled4);
            


        }

        private class addData
    {

        public string ponedeljak { get; set; }
        public string utorak { get; set; }
        public string sreda { get; set; }
        public string cetvrtak { get; set; }
        public string petak { get; set; }
        public string subota { get; set; }
        public string nedelja { get; set; }
        }
    private void generateColumns(object sender, DataGridAutoGeneratingColumnEventArgs e)
    {
        colNum++;
        if (colNum == 5)
            e.Column.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
    }
}
}
