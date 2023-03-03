using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class NumbersDivisibleBy3
    {
        internal static void GetNumbersDivisibleBy3()
        {
            int i = 1;

            while (i <= 100)
            {
                if (IsDivisibleBy3(i))
                {
                    Console.WriteLine(i);
                }

                i++;
            }
        }
        static bool IsDivisibleBy3(int number)
        {
            if (number % 3 == 0) return true; else return false;
        }
    }
}
