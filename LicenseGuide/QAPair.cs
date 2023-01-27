using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseGuide
{
    public class QAPair
    {
        public string Q { get; set; }
        public string A { get; set; }
        public QAPair(string question, string answer)
        {
            Q = question;
            A = answer;
        }
    }
}
