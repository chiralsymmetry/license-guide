using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseGuide
{
    internal static class QAPairs
    {
        private static List<QAPair> PopulatePairs(string[] resourceNames)
        {
            var qaPairs = new List<QAPair>();

            foreach (var resourceName in resourceNames)
            {
                var rm = LicenseGuide.Resources.QAndA.ResourceManager;
                var pair = new QAPair(
                    rm.GetString($"{resourceName}_question")!,
                    rm.GetString($"{resourceName}_answer")!);
                qaPairs.Add(pair);
            }

            return qaPairs;
        }

        public static List<QAPair> GeneralPairs()
        {
            var resourceNames = new string[]
            {
                "general_what_is_originality",
                "general_copyright_length",
                "general_copyright_symbol",
                "general_copyright_years",
                "general_anonymous",
                "general_moral_rights",
                "general_derivative_works",
                "general_publicity_rights",
                "general_international",
            };
            return PopulatePairs(resourceNames);
        }

        public static List<QAPair> CodePairs()
        {
            var resourceNames = new string[]
            {
                "code_why_license",
                "code_custom_license",
                "code_multiple_licenses",
                "code_spdx",
                "code_derivative_works_limit",
                "code_gpl_output",
                "code_license_compatibility",
                "code_gpl_mixing",
                "code_noncode_mix",
                "code_use_gpl_without_gpl",
            };
            return PopulatePairs(resourceNames);
        }

        public static List<QAPair> FontPairs()
        {
            var resourceNames = new string[]
            {
                "font_fonts_typefaces",
                "font_why_font_license",
            };
            return PopulatePairs(resourceNames);
        }
    }
}
