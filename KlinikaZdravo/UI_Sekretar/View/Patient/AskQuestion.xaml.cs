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
using ClassDiagram.Controller;
using ClassDiagram.Model.Questions;
using UI_sekretar;

namespace healthClinic
{
    /// <summary>
    /// Interaction logic for askQuestion.xaml
    /// </summary>
    public partial class askQuestion : Page
    {
        private readonly IController<QuestionAndAnswer, long> _questionController;


        public askQuestion()
        {
            InitializeComponent();
            var app = Application.Current as App;
            _questionController = app._QuestionController;
        }

        private void Button_Click_Send(object sender, RoutedEventArgs e)
        {
            QuestionAndAnswer questionAndAnswer = new QuestionAndAnswer();
            questionAndAnswer.Content = content.Text;
            _questionController.Create(questionAndAnswer);

            PocetnaStranica ps = new PocetnaStranica();
            this.NavigationService.Navigate(ps);
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
