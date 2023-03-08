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

        internal static void GetTheDayOfWeek()
        {
            short numberOfTheDay = 0;

            Console.WriteLine("Enter a number of a day of the week");

            numberOfTheDay = Convert.ToInt16(Console.ReadLine());

            switch (numberOfTheDay)
            {
                case 1:
                    Console.WriteLine("The day entered is: Monday");
                    break;
                case 2:
                    Console.WriteLine("The day entered is: Tuesday");
                    break;
                case 3:
                    Console.WriteLine("The day entered is: Wednesday");
                    break;
                case 4:
                    Console.WriteLine("The day entered is: Thursday");
                    break;
                case 5:
                    Console.WriteLine("The day entered is: Friday");
                    break;
                case 6:
                    Console.WriteLine("The day entered is: Satarday");
                    break;
                case 7:
                    Console.WriteLine("The day entered is: Sunday");
                    break;
                default:
                    Console.WriteLine("Invalida number for a day of the week");
                    break;
            }
        }
    }
}
