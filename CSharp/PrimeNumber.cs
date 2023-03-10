using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class PrimeNumber
    {
        internal static void CheckIfNumberIsPrime()
        {
            try
            {
                Console.WriteLine("*** A number is prime only when it can be divided exactly by itself and by 1 ***");
                Console.WriteLine(Program.line);
                Console.WriteLine("Enter a number greater than 1");

                int? number = Convert.ToInt32(Console.ReadLine());

                if (!number.HasValue || number <= 1)
                {
                    Console.WriteLine("invalid number.");
                    return;
                }

                for (int i = 2; i < number; i++)
                {
                    if ((number % i) == 0)
                    {
                        Console.WriteLine($"The number {number} is not prime");
                        return;
                    }
                }

                Console.WriteLine($"The number {number} is prime");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + Environment.NewLine + ex.StackTrace);
            }
            finally { ContinueInCurrentFunction(); }
        }

        static void ContinueInCurrentFunction()
        {
            try
            {
                char? toContinue;

                Console.WriteLine(Program.line);
                Console.WriteLine("To continue in this function press Y, or press any other key to return to the menu");

                toContinue = Convert.ToChar(Console.ReadLine().ToUpper());

                if (toContinue == 'Y') CheckIfNumberIsPrime(); else Program.Main(new string[] { });
            }
            catch { Program.Main(new string[] { }); };
        }
    }
}
