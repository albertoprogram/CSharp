using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class StringOperations
    {
        internal static void String_Operations()
        {
            Console.WriteLine("Enter a sentence.");

            string? str = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(str))
            {
                if (str.Length > 20)
                {
                    string[] strings = str.Split(' ');

                    int numberOfWords = 0;

                    foreach (string s in strings)
                    {
                        numberOfWords++;
                    }

                    if (numberOfWords >= 4)
                    {
                        Console.WriteLine($"The length of the string is: {str.Length}");

                        string str_a_to_x = str;

                        str_a_to_x = str_a_to_x.Replace('a', 'x');

                        str_a_to_x = str_a_to_x.Replace('A', 'X');

                        Console.WriteLine($"Change \"a\" to \"x\" and \"A\" to \"X\": {str_a_to_x}");

                        Console.WriteLine($"Uppercase string: {str.ToUpper()}");

                        Console.WriteLine($"Lowercase string: {str.ToLower()}");

                        string strRemove3 = str.Remove(0, 3);

                        Console.WriteLine($"The first three letters are removed: {strRemove3}");

                        Console.WriteLine($"String from position 5 to 10: {str.Substring(4, 6)}");

                        string reverseString = string.Empty;

                        for (int i = 0; i < str.Length; i++)
                        {
                            reverseString += str[str.Length - i - 1];
                        }

                        Console.WriteLine($"Inverted string: {reverseString}");

                        Console.WriteLine($"Number of words: {numberOfWords}");

                        foreach (string item in strings)
                        {
                            Console.WriteLine(item);
                        }

                        string thirdWord = string.Empty;
                        int wordNumber = 0;

                        foreach (string s in strings)
                        {
                            wordNumber++;
                            if (wordNumber == 3)
                            {
                                Console.WriteLine($"The third word is: {s}");
                            }
                        }

                        Console.WriteLine($"IndexOf of 'a': {str.IndexOf('a')}");
                        Console.WriteLine($"LastIndexOf of 'a': {str.LastIndexOf('a')}");
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
