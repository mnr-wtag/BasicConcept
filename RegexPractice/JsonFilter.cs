using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegexPractice
{
    public class JsonFilter
    {
        public void Demo(string jsonData = "")
        {
            jsonData = @"
                        [
                            { ""name"": ""John"", ""age"": 30 },
                            { ""name"": ""Jane"", ""age"": 28},
                            { ""name"": ""Jim"", ""age"": 22 },
                            { ""name"": ""Joan"", ""age"": 32 }
                        ]";

            string pattern = @"""name"":\s*""([^""]+)"",\s*""age"":\s*(\d+)\s*,*";
            MatchCollection matches = Regex.Matches(jsonData, pattern);
            var filtered = from Match match in matches
                           let name = match.Groups[1].Value
                           let age = int.Parse(match.Groups[2].Value)
                           where age >= 25
                           select new { Name = name, Age = age };
            foreach (var item in filtered)
            {
                Console.WriteLine("Name: {0}, Age: {1}", item.Name, item.Age);
            }
        }
    }
}
