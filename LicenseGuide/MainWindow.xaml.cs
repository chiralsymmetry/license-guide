using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace LicenseGuide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly Page FirstCodeQuestion = Questionnaire.FirstCodeQuestion();
        private static readonly Page FirstContentQuestion = Questionnaire.FirstContentQuestion();
        private static readonly Page FirstFontQuestion = Questionnaire.FirstFontQuestion();
        //private static readonly Page QuestionsAndAnswers = new QAndA();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Frame_Loaded(object sender, RoutedEventArgs e)
        {
            codeFrame.Content = FirstCodeQuestion;
        }

        private void CodeButton_Click(object sender, RoutedEventArgs e)
        {
            codeFrame.Content = FirstCodeQuestion;
        }

        private void ContentButton_Click(object sender, RoutedEventArgs e)
        {
            codeFrame.Content = FirstContentQuestion;
        }

        private void FontButton_Click(object sender, RoutedEventArgs e)
        {
            codeFrame.Content = FirstFontQuestion;
        }

        private void QAndAButton_Click(object sender, RoutedEventArgs e)
        {
            codeFrame.Content = new QAndA();
        }
    }
}
