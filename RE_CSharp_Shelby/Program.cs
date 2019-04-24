using System;
using System.Collections.Generic;
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

            //Create a C# regex to parse email
            //sample: "Find me at IamACoolMama22@yahoo.com or person@cool.org or me@yahoo.biz"

            string emailPat = @"\S*\b@\S*\b";

            string emailString = "Find me at IamACoolMama22@yahoo.com or person@cool.org or me@yahoo.biz";
            string test = "high@gmail.com";

            showMatch(emailString, emailPat);

            //parse phone number

            string phoneString = "Dr. Watson left amessage to call 1-555-788-1874 or 1-257-577-5778";
            string phonePat = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";

            showMatch(phoneString, phonePat);

            //parse SSN

            string SSNString = "MY SSN is 123-23-4568";
            string SSNPat = @"\(?\d{3}\)?-? *\d{2}-? *-?\d{4}";

            showMatch(SSNString, SSNPat);

            //prevent SQL injection



        }
    }
}
