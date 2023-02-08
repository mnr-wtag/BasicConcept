using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPractice
{
    internal class Tutorial
    {
        public void Demo()
        {
            var patternText = @"^[a-zA-Z0-9\._-]{5,25}.@.[a-z]{2,12}.(com|org|co\.in|net)";

            var reg = new Regex(patternText);

            //When pattern matches
            Console.WriteLine(reg.IsMatch("software_test123@gmail.com"));
            Console.WriteLine(reg.IsMatch("Special.Char@yahoo.co.in"));

            //When pattern doesnt match
            Console.WriteLine(reg.IsMatch("ww.alsjk9874561230.mo@vie.dont"));



            var pattern = @"\b(?<FirstWord>\w+)\s?((\w+)\s)*(?<LastWord>\w+)?(?<Punctuation>\p{Po})";
            var input = "The cow jumped over the moon.";
            var rgx = new Regex(pattern);
            var match = rgx.Match(input);
            if (match.Success)
                ShowMatches(rgx, match);


            string input2 = "1. Eggs 2. Bread 3. Milk 4. Coffee 52. Tea";
            string pattern2 = @"\b\d{1,2}\.\s";
            /*
             *
             * \b -     Begin the match at a word boundary.
             * \d{1,2}	Match one or two decimal digits.
             * \.	    Match a period.
             * \s	    Match a white-space character.
             *
             */
            foreach (string item in Regex.Split(input2, pattern2))
            {
                if (!string.IsNullOrEmpty(item))
                    Console.WriteLine(item);
            }



            string pattern3 = @"\b\d+(,\d{3})*\.\d{2}\b";
            string input3 = "16.32\n194.03\n1,903,672.08";

            foreach (Match match1 in Regex.Matches(input3, pattern3))
                Console.WriteLine(match1.Result("$$ $&"));

            string patternText2 = @"^[A-Z0-9a-z\._-]{5,25}.@.[a-z]{2,12}.(com|org|co\.in|net)";

            Regex regex = new Regex(patternText2);

            //When pattern matches
            Console.WriteLine(regex.IsMatch("software_test123@gmail.com"));
            Console.WriteLine(regex.IsMatch("Special.Char@yahoo.co.in"));

            //When pattern doesnt match
            Console.WriteLine(regex.IsMatch("ww.alsjk9874561230.mo@vie.dont"));
        }

        private static void ShowMatches(Regex r, Match m)
        {
            var names = r.GetGroupNames();
            Console.WriteLine("Named Groups:");
            foreach (var name in names)
            {
                var grp = m.Groups[name];
                Console.WriteLine("   {0}: '{1}'", name, grp.Value);
            }
        }
    }
}
