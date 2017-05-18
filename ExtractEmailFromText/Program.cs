using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractEmailFromText
{
    class Program
    {
        /// <summary>
        /// Input the data in StartExtraction function of Instance e in the Main function.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ExtractEmailFromText e = new ExtractEmailFromText();
            e.StartExtraction("Input your data here");
            Console.ReadKey();
        }
    }

    class ExtractEmailFromText
    {
        /// <summary>
        /// Use RegexOptions.Compiled if you would like to use this code to test lots of strings. 
        /// Having this option enabled will allow the compiler to make use of already compiled pattern.
        /// </summary>
        /// <param name="text"></param>
        public void StartExtraction(string text)
        {
            const string matchEmailPattern =
                @"(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
                + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
                + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
                + @"([\d]|[\w-]?[a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,10})";

            Regex reg = new Regex(matchEmailPattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            MatchCollection matchedEmailsCollection = reg.Matches(text);
            foreach (Match variable in matchedEmailsCollection)
            {
                Console.WriteLine(variable.Value);
            }

        }
    }
}
