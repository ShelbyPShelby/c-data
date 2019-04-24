using System;
using System.Text.RegularExpressions;

namespace RE_CSharp_Shelby
{
    class Program
    {
        private static void showMatch(string text, string expr)
        {
            Console.WriteLine("The Expression:" + expr);
            MatchCollection mc = Regex.Matches(text, expr);

            foreach(Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            string str = "A Thousand Splendid Suns";


            //match words that with 'S'
            Console.WriteLine("Matching Words That Begin with 'S': ");
            showMatch(str, @"\bS\S*");// \b - boundary search from Space to Space, \S matches any non-WhiteSpace character
            Console.ReadKey();

            //start with 'm' and end with 'e'
            string str2 = "make maze and manage to measure it meaning";
            showMatch(str2, @"\bm\S*e\b");

            string input = "Hello    World   ";
            string pattern = "\\s+";
            string replacement = " ";


            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("Original String {0}", input);
            Console.WriteLine("Replacement String: {0}", result);

            
        }
    }
}
