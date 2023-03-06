﻿namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string line = "---------------------------------------------";
            short option;

        Begin:
            Console.WriteLine("Select an option:");

            Console.WriteLine("1    SwitchCase");
            Console.WriteLine("2    PairNumbers");
            Console.WriteLine("3    NumbersDivisibleBy3");
            Console.WriteLine("4    Arrays");

            option = Convert.ToInt16(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(line);
                    Console.WriteLine(SwitchCase.Selection());
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
                default: Console.WriteLine("Select a valid option"); goto Begin;
            }

            Console.ReadLine();
        }
    }
}