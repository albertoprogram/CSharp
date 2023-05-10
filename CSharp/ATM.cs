using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class ATM
    {
        internal static void CashDispensing()
        {
            decimal amount = 0.00M, progress = 0.00M;
            int quantityOfBillsOf20 = 0, quantityOfBillsOf10 = 0;

            Console.WriteLine("Enter the amount");

            amount = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (amount % 10 == 0 && amount > 0.00M && amount <= 300.00M)
            {
                while (progress + 20.00M <= amount)
                {
                    progress += 20.00M;

                    quantityOfBillsOf20++;
                }

                while (progress + 10.00M <= amount)
                {
                    progress += 10.00M;

                    quantityOfBillsOf10++;
                }
            }
            else
            {
                Console.WriteLine("Please enter a value that is a multiple of 10, that is greater than 0 and less than or equal to 300");
            }

            Console.WriteLine("The number of 20 bills to deliver is: {0}", quantityOfBillsOf20);
            Console.WriteLine("The number of 10 bills to deliver is: {0}", quantityOfBillsOf10);
        }
    }
}
