using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_AppendArrays_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

            List<int> list = new List<int>();
            //string temp = string.Empty;
            //7 | 4  5|1 0| 2 5 |3
            //
            bool twoChars = false;
            int spcaces = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                string curInput = input[i];

                for (int j = 0; j < curInput.Length; j++)
                {
                    //| 2 5 31 2

                    char curChar = curInput[j];
                    string temp;

                    if (curChar == ' ')
                    {
                        spcaces++;
                        continue;
                    }

                    if (curChar >= 48 && curChar <= 57)
                    {
                        string test = curChar.ToString();
                        list.Add(int.Parse(test));

                        if (spcaces == 0)
                        {

                        }


                        spcaces = 0;
                    }
                }
               

            }

            
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
