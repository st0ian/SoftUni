using System;
using System.Text.RegularExpressions;

namespace P01_MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);
           
            string input = Console.ReadLine();
            MatchCollection matchCollection = regex.Matches(input);

            foreach (Match item in matchCollection)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
