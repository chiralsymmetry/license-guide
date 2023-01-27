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
    /// Interaction logic for QAndA.xaml
    /// </summary>
    public partial class QAndA : Page
    {
        public List<QAPair> GeneralPairs { get; set; } = QAPairs.GeneralPairs();
        public List<QAPair> CodePairs { get; set; } = QAPairs.CodePairs();
        public List<QAPair> FontPairs { get; set; } = QAPairs.FontPairs();

        public QAndA()
        {
            InitializeComponent();
        }
    }
}
