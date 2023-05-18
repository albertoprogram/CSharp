namespace CSharp
{
    internal class Program
    {
        internal const string line = "---------------------------------------------";
        internal static void Main(string[] args)
        {
            try
            {
                short? option;
                char? toContinue;

            Begin:
                Console.WriteLine("Select an option:");

                Console.WriteLine("1    SwitchCase");
                Console.WriteLine("2    PairNumbers");
                Console.WriteLine("3    NumbersDivisibleBy3");
                Console.WriteLine("4    Arrays");
                Console.WriteLine("5    CalculateAdditionEvenAndSubtractionOdd");
                Console.WriteLine("6    ExecuteSumAndAverage");
                Console.WriteLine("7    PrimeNumber");
                Console.WriteLine("8    NumberOfDigits");
                Console.WriteLine("9    StackQueue");
                Console.WriteLine("10   ReturnMultipleValuesByReference");
                Console.WriteLine("11   ReverseTwoDigitNumber");
                Console.WriteLine("12   RomanToInterger");
                Console.WriteLine("13   CurrencyConverter");
                Console.WriteLine("14   ATM");
                Console.WriteLine("15   NullInStrings");
                Console.WriteLine("16   ReverseAString");
                Console.WriteLine("17   StringOperations");
                Console.WriteLine(line);

                option = Convert.ToInt16(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine(line);
                        Console.WriteLine(SwitchCase.Selection());
                        Console.WriteLine(line);
                        SwitchCase.GetTheDayOfWeek();
                        break;
                    case 2:
                        Console.WriteLine(line);
                        PairNumbers.GetEvenNumbers();
                        break;
                    case 3:
                        Console.WriteLine(line);
                        NumbersDivisibleBy3.GetNumbersDivisibleBy3();
                        break;
                    case 4:
                        Console.WriteLine(line);
                        Arrays.ArrayOfEvenNumbers();
                        break;
                    case 5:
                        Console.WriteLine(line);
                        AdditionEvenSubtractionOdd.CalculateAdditionEvenAndSubtractionOdd();
                        break;
                    case 6:
                        Console.WriteLine(line);
                        SumAndAverage.ExecuteSumAndAverage();
                        break;
                    case 7:
                        Console.WriteLine(line);
                        PrimeNumber.CheckIfNumberIsPrime();
                        break;
                    case 8:
                        Console.WriteLine(line);
                        NumberOfDigits.GetNumberOfDigits();
                        break;
                    case 9:
                        Console.WriteLine(line);
                        Stack_Queue.StackQueue();
                        break;
                    case 10:
                        Console.WriteLine(line);
                        int number1 = 1, number2 = 3; string firstName = "John";
                        ReturnMultipleValuesByReference.MultipleValuesByReference(ref number1, ref number2, ref firstName);
                        Console.WriteLine($"The values are: '{number1}', '{number2}', '{firstName}'");
                        break;
                    case 11:
                        Console.WriteLine(line);
                        ReverseTwoDigitNumber.ExecReverseTwoDigitNumber();
                        ReverseTwoDigitNumber.ExecReverseTwoDigitNumber_v2();
                        break;
                    case 12:
                    BeginRomanToInteger:
                        Console.WriteLine(line);
                        Console.WriteLine("Enter a Roman Number");
                        string? romanNumber = Console.ReadLine();
                        int number = RomanToInterger.RomanToInt(romanNumber);
                        Console.WriteLine($"The Roman Number {romanNumber} is the integer {number}");
                        goto BeginRomanToInteger;
                    case 13:
                        CurrencyConverter.Converter();
                        break;
                    case 14:
                        ATM.CashDispensing(); break;
                    case 15:
                        UsingNull_InStrings.NullInStrings();
                        break;
                    case 16:
                        ReverseAString.ReverseString(); break;
                    case 17:
                        StringOperations.String_Operations();
                        break;
                    default: Console.WriteLine("Select a valid option"); goto Begin;
                }

                Console.WriteLine(line);
                Console.WriteLine("To return to the menu press Y, or press any other key to end the program");

                toContinue = Convert.ToChar(Console.ReadLine().ToUpper());

                if (toContinue == 'Y') goto Begin; else return; ;
            }
            catch (Exception) { return; }
        }
    }
}