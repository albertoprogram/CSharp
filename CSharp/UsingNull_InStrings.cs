using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class UsingNull_InStrings
    {
        internal static void NullInStrings()
        {
            string str1 = "\x0" + "abc";
            string str2 = "abc" + "\x0";
            string str3 = "\0" + "xyz";
            string str4 = "xyz" + null;

            Console.WriteLine("*" + str1 + "*");

            Console.WriteLine("*" + str2 + "*");

            Console.WriteLine("*" + str3 + "*");

            Console.WriteLine("*" + str4 + "*");

            Console.WriteLine(str1.Length);

            Console.WriteLine(str2.Length);

            Console.WriteLine(str3.Length);

            Console.WriteLine(str4.Length);
        }
    }
}
