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
using System.Resources;

namespace LicenseGuide
{
    /// <summary>
    /// Interaction logic for Question.xaml
    /// </summary>
    public partial class Question : Page
    {
        private readonly Page yesPage;
        private readonly Page noPage;

        public Question(ResourceManager resourceManager, int number, string resourceName, Page yesPage, Page noPage)
        {
            this.yesPage = yesPage;
            this.noPage = noPage;
            InitializeComponent();
            UpdateQuestion(resourceManager, number, resourceName);
        }

        private void UpdateQuestion(ResourceManager resourceManager, int number, string resourceName)
        {
            qId.Text = String.Format(
                (string)resourceManager.GetObject("question_header")!,
                number);
            question.Text = (string)resourceManager.GetObject($"{resourceName}_question")!;
            yesButtonText.Text = (string)resourceManager.GetObject($"{resourceName}_yes")!;
            noButtonText.Text = (string)resourceManager.GetObject($"{resourceName}_no")!;
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(yesPage);
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(noPage);
        }
    }
}
