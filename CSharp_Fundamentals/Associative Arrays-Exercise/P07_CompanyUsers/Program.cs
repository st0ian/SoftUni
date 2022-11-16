using System;
using System.Collections.Generic;

namespace P07_CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyRegister = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputArgs = input.Split(" -> ");
                string companyName = inputArgs[0];
                string employeName = inputArgs[1];

                if (!companyRegister.ContainsKey(companyName))
                {
                    companyRegister.Add(companyName, new List<string>());
                }
                if (!companyRegister[companyName].Contains(employeName))
                {
                    companyRegister[companyName].Add(employeName);
                }

                input = Console.ReadLine();
            }

            foreach (var company in companyRegister)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }                
            }
        }
    }
}
