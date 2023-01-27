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

namespace LicenseGuide
{
    /// <summary>
    /// Interaction logic for FontAnswer.xaml
    /// </summary>
    public partial class FontAnswer : Page
    {
        public FontAnswer(string resourceName)
        {
            InitializeComponent();
            answerTitle.Text = (string)LicenseGuide.Resources.Font.ResourceManager.GetObject($"{resourceName}_title")!;
            answerExplanation.Text = (string)LicenseGuide.Resources.Font.ResourceManager.GetObject($"{resourceName}_explanation")!;
            answerCopyright.Text = (string)LicenseGuide.Resources.Font.ResourceManager.GetObject($"{resourceName}_text")!;
        }
    }
}
