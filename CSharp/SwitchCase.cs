using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class SwitchCase
    {
        internal static string Selection()
        {
            int number = 7; //Change here
            string message = string.Empty;

        begin:

            try
            {
                switch (number)
                {
                    case 1:
                        message = $"The number is: {number}";
                        break;
                    case 2:
                    case 3:
                        message = $"The number is: {number}";
                        break;
                    case 4: goto case 1;
                    case 5: goto begin; //Warning: infinite loop. Test only with debugger.
                    case 6: return "Case 6";
                    case 7: throw new Exception("Error...");
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return number.ToString() + " " + message;

        }
    }
}
