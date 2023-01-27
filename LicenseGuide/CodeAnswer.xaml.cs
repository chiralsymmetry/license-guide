using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for CodeAnswer.xaml
    /// </summary>
    public partial class CodeAnswer : Page
    {
        public CodeAnswer(string resourceName)
        {
            InitializeComponent();
            answerTitle.Text = (string)LicenseGuide.Resources.Code.ResourceManager.GetObject($"{resourceName}_title")!;
            answerExplanation.Text = (string)LicenseGuide.Resources.Code.ResourceManager.GetObject($"{resourceName}_explanation")!;
            answerShort.Text = (string)LicenseGuide.Resources.Code.ResourceManager.GetObject($"{resourceName}_short_text")!;
            answerLong.Text = (string)LicenseGuide.Resources.Code.ResourceManager.GetObject($"{resourceName}_full_text")!;
        }
    }
}
