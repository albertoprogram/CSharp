using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal static class CurrencyConverter
    {
        internal static void Converter()
        {
            Console.WriteLine("Enter the current Euro rate");

            decimal euroRate = checked(decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Enter Dollar amount");

            decimal dollarAmount = checked(decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            decimal conversion = checked(dollarAmount * euroRate);

            conversion = decimal.Round(conversion, 2);

            Console.WriteLine($"{dollarAmount.ToString(CultureInfo.InvariantCulture)} dollars is equal to {conversion.ToString(CultureInfo.InvariantCulture)} euros");
        }
    }
}
