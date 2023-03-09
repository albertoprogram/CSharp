using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class SumAndAverage
    {
        internal static void ExecuteSumAndAverage()
        {
            Console.WriteLine("Enter a number from 1 to 1000.");

            short? number = Convert.ToInt16(Console.ReadLine());
            int result = 0;
            decimal average = 0.00M;

            if (number.HasValue && number > 0 && number <= 1000)
            {
                for (int i = 1; i <= number.Value; i++)
                {
                    result += i;
                }

                average = checked(result / number.Value);

                Console.WriteLine($"The sum is: {result}");

                Console.WriteLine($"The average is: {average}");
            }
        }
    }
}
