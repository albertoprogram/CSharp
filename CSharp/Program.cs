namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short option;

            Console.WriteLine("Select an option:");

            Console.WriteLine("1    SwitchCase");
            Console.WriteLine("2    PairNumbers");

            option = Convert.ToInt16(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine(SwitchCase.Selection());
                    break;
                case 2:
                    PairNumbers.GetEvenNumbers();
                    break;
                default: Console.WriteLine("Select a valid option"); break;
            }

            Console.ReadLine();
        }
    }
}