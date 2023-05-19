using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class NumbersInAString
    {
        internal static void DetectNumbersInAString()
        {
            Console.WriteLine("Enter a string");

            string? str = Console.ReadLine();
            string numbersInStr = string.Empty;

            if (!string.IsNullOrWhiteSpace(str))
            {
                foreach (var c in str)
                {
                    if (char.IsNumber(c))
                    {
                        numbersInStr += c.ToString();
                    }
                }

                Console.WriteLine($"The numbers in the string are: {numbersInStr}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
