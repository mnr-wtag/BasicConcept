using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPractice
{
    internal class Extraction
    {
        private decimal ExtractPriceFromText(string text)
        {
            string pattern = @"\$(\d+(\.\d{2})?)";
            Match match = Regex.Match(text, pattern);
            if (match.Success)
            {
                return decimal.Parse(match.Groups[1].Value);
            }
            else
            {
                return -1;
            }
        }

        private DateTime ExtractDateFromText(string text)
        {
            string pattern = @"(\d{4}-\d{2}-\d{2})";
            Match match = Regex.Match(text, pattern);
            if (match.Success)
            {
                return DateTime.ParseExact(match.Value, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            }
            else
            {
                return DateTime.MinValue;
            }
        }
    }
}
