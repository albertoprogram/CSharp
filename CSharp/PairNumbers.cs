using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class PairNumbers
    {
        internal static void GetEvenNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {

                if (IsEven(i))
                {
                    Console.WriteLine(i.ToString());
                }

            }
        }
        static bool IsEven(int number)
        {
            if ((number % 2) == 0) return true; else return false;
        }
    }
}
