using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LicenseGuide
{
    public static class Questionnaire
    {
        public static Page FirstCodeQuestion()
        {
            // Answers
            var copyright = new CodeAnswer("copyright");
            var agpl = new CodeAnswer("agpl");
            var gpl3 = new CodeAnswer("gpl3");
            var gpl2 = new CodeAnswer("gpl2");
            var lgpl = new CodeAnswer("lgpl");
            var bsdpatent = new CodeAnswer("bsdpatent");

            // Questions
            var rm = LicenseGuide.Resources.Code.ResourceManager;
            var weak_copyleft = new Question(rm, 5, "weak_copyleft", lgpl, bsdpatent);
            var strong_copyleft = new Question(rm, 4, "strong_copyleft", gpl2, weak_copyleft);
            var forbid_tivoization = new Question(rm, 3, "tivoization", gpl3, strong_copyleft);
            var forbid_netservice = new Question(rm, 2, "netservice", agpl, forbid_tivoization);
            var forbid_opensource = new Question(rm, 1, "opensource", copyright, forbid_netservice);

            return forbid_opensource;
        }

        public static Page FirstContentQuestion()
        {
            // Answers
            var cc0 = new ContentAnswer("cc0");
            var cc_by = new ContentAnswer("cc_by");
            var cc_by_sa = new ContentAnswer("cc_bysa");
            var cc_by_nd = new ContentAnswer("cc_bynd");
            var cc_by_nc = new ContentAnswer("cc_bync");
            var cc_by_nc_sa = new ContentAnswer("cc_byncsa");
            var cc_by_nc_nd = new ContentAnswer("cc_byncnd");
            var full_copyright = new ContentAnswer("full_copyright");

            // Questions
            var rm = LicenseGuide.Resources.Content.ResourceManager;
            var require_attribution = new Question(rm, 5, "attribution", cc_by, cc0);
            var require_sharing = new Question(rm, 4, "share_alike", cc_by_sa, require_attribution);
            var forbid_derivative = new Question(rm, 3, "no_derivatives", cc_by_nd, require_sharing);

            var forbid_commercial_require_sharing = new Question(rm, 4, "share_alike", cc_by_nc_sa, cc_by_nc);
            var forbid_commercial_forbid_derivative = new Question(rm, 3, "no_derivatives", cc_by_nc_nd, forbid_commercial_require_sharing);

            var forbid_commercial = new Question(rm, 2, "noncommercial", forbid_commercial_forbid_derivative, forbid_derivative);
            var forbid_use = new Question(rm, 1, "copyright", full_copyright, forbid_commercial);

            return forbid_use;
        }

        public static Page FirstFontQuestion()
        {
            // Answers
            var cc0 = new FontAnswer("cc0");
            var ofl = new FontAnswer("ofl");
            var use_only = new FontAnswer("use_only");
            var full_copyright = new FontAnswer("full_copyright");

            // Questions
            var rm = LicenseGuide.Resources.Font.ResourceManager;
            var require_attribution = new Question(rm, 3, "attribution", ofl, cc0);
            var forbid_derivative = new Question(rm, 2, "derivative", use_only, require_attribution);
            var forbid_use = new Question(rm, 1, "copyright", full_copyright, forbid_derivative);

            return forbid_use;
        }
    }
    
}
