using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPractice
{
    internal class FindAndReplace
    {
        private string ReplaceWords(string text, string oldWord, string newWord)
        {
            string pattern = @"\b" + oldWord + @"\b";
            return Regex.Replace(text, pattern, newWord);
        }
    }
}
