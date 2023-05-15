using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class ReverseAString
    {
        internal static void ReverseString()
        {
            string? str = string.Empty;
            string reverseString = string.Empty;

            Console.WriteLine("Enter a string");

            str = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    reverseString += str[str.Length - i - 1];
                }
                Console.WriteLine(reverseString);
            }
            else
            {
                Console.WriteLine("null or empty string");
            }
        }
    }
}
