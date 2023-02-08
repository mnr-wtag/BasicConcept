using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPractice
{
    internal class RegexEscapeExample
    {
        void RegexEscape()
        {
            string input = "^$.|?*+()[{";
            string pattern = Regex.Escape(input);
            Console.WriteLine("Escaped pattern: " + pattern);
        }
        
    }
}
