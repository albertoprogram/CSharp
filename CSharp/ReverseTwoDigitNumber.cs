using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class ReverseTwoDigitNumber
    {
        internal static void ExecReverseTwoDigitNumber()
        {
            int number, invertedNumber, z, remainder;

            string? line;

            Console.WriteLine("Enter a two-digit number");

            line = Console.ReadLine();

            number = int.Parse(line);

            z = number / 10;

            remainder = number % 10;

            invertedNumber = (remainder * 10) + z;

            Console.WriteLine($"The inverted number is (Method 1): {invertedNumber}");
        }

        internal static void ExecReverseTwoDigitNumber_v2()
        {
            string line, invertedNumber;

            Console.WriteLine("Enter a two-digit number");

            line = Console.ReadLine();

            if (int.Parse(line) > 0 && int.Parse(line) <= 99)
            {
                invertedNumber = line[1].ToString() + line[0].ToString();

                Console.WriteLine($"The inverted number is (Method 2): {invertedNumber}");
            }
        }
    }
}
