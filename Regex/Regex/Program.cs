using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Regex
{
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            //RegexIsMatch();
            //RegexMatch();
            //RegexReplace();
            //RegexSplit();
            //Match();
            Groups();
            Console.ReadLine();
        }

        private static void RegexIsMatch()
        {
            string[] values = { "111-22-3333", "111-2-3333" };
            string pattern = @"^\d{3}-\d{2}-\d{4}$";

            foreach (string value in values)
            {
                if (Regex.IsMatch(value, pattern))
                {

                    Console.WriteLine("{0} is valid", value);
                }
                else
                {

                    Console.WriteLine("{0} is not valid", value);
                }
            }
        }

        private static void RegexMatch()
        {
            var input = "this is henry henry Gary Gary!";
            var pattern = @"\b(\w+)\W(\1)\b";

            Match match = Regex.Match(input,pattern);          

            while (match.Success)
            {
                
                Console.WriteLine("Duplication {0} is match", match.Groups[1]);
                match = match.NextMatch();
            }
            
        }

        private static void RegexReplace()
        {
            string pattern = @"\b\d+\.\d{2}\b";
            string replacement = "$$$&";
            string input = "total cost: 103.26";

            Console.WriteLine(Regex.Replace(input, pattern, replacement));
        }

        private static void RegexSplit()
        {
            string input = "1. egg 2. milk 3. coffee";
            string pattern = @"\b\d{1,2}\.\s";

            foreach(string item in Regex.Split(input,pattern))
            {
                if(!String.IsNullOrEmpty(item))
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void Match()
        {
            MatchCollection matches;
            Regex r = new Regex("abc");
            matches = r.Matches("abc123abc123abc");

            foreach(Match match in matches)
            {
                Console.WriteLine("{0} found at position {1}", match.Value, match.Index);
 
                Console.WriteLine("{0}", match.Result("$&, hello henry! "));
            }

            
        }

        private static void Groups()
        {
            string input = "Born: July 12, 1993";
            string pattern = @"\b(\w+)\s(\d{1,2}),\s(\d{4})\b";

            Match match = Regex.Match(input, pattern);

            if(match.Success)
            {
                for(int ctr=0; ctr<match.Groups.Count; ctr++)
                {
                    Console.WriteLine("Group {0}: {1}", ctr, match.Groups[ctr].Value);
                }
            }

        }

    }
}
