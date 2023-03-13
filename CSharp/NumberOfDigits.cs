using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class NumberOfDigits
    {
        internal static void GetNumberOfDigits()
        {
            Console.WriteLine("Entered a number");

            string? number = Console.ReadLine();

            if (number != null)
            {
                Console.WriteLine($"The number '{number}' have {number.Length} digits");
            }
        }
    }
}
