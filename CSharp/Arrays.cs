using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Arrays
    {
        internal static void ArrayOfEvenNumbers()
        {
            int[] numbers = new int[50];
            int counter = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    numbers[counter] = i;
                    Console.WriteLine(numbers[counter]);
                    counter++;
                }
            }
        }
    }
}
