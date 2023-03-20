using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class ReturnMultipleValuesByReference
    {
        internal static void MultipleValuesByReference(ref int num1, ref int num2, ref string name1)
        {
            num1 = 5; num2 = 6; name1 = "Test Name";
        }
    }
}
