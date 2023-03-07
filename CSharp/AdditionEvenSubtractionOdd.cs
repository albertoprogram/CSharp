using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class AdditionEvenSubtractionOdd
    {
        internal static void CalculateAdditionEvenAndSubtractionOdd()
        {
            Console.WriteLine("Enter ten numbers separated by commas");

            string? strNumbers = Console.ReadLine();

            string[] numbers;

            if (strNumbers is not null) numbers = strNumbers.Split(','); else return;

            int result = 0;

            foreach (string number in numbers)
            {
                if (Convert.ToInt32(number) % 2 == 0)
                {
                    result += Convert.ToInt32(number);
                }
                else
                {
                    result -= Convert.ToInt32(number);
                }
            }
            Console.WriteLine($"The result is: {result}");
        }
    }
}
