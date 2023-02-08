using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPractice
{
    internal class Routing
    {
        private int ExtractIdFromUrl(string url)
        {
            string pattern = @"/api/resources/(\d+)";
            Match match = Regex.Match(url, pattern);
            if (match.Success)
            {
                return int.Parse(match.Groups[1].Value);
            }
            else
            {
                return -1;
            }
        }
    }
}
