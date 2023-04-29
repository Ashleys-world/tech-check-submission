using System;
using System.Collections.Generic;

namespace Letters_Code
{
    public class Program : BaseLetters
    {
        public static void Main(string[] args)
        {
            BaseLetters instance1 = new Program();
            Console.WriteLine("Enter text to be analyzed : ");

            string text = Console.ReadLine();
            string textTrimmed = text.Replace(" ", "");

            Console.WriteLine("Enter which operations to do on the supplied text, ‘1’ for         duplicate character check, ‘2’ to count the number of vowels, ‘3’ to check if there are more   vowels or non vowels, or anycombination of ‘1’, ‘2’ and ‘3’ to perform multiple checks.");

            string operation = Console.ReadLine();

            for (int i = 0; i < operation.Length; i++)
            {
                if (operation[i] == '1')
                {
                    Console.WriteLine("Checking for duplicates...");
                    Console.WriteLine("Found the follwing duplicates : " + instance1.DuplicateCheck(textTrimmed));
                }
                else if (operation[i] == '2')
                {
                    Console.WriteLine("Checking for number of unique vowels...");
                    if(instance1.VowelChecker(textTrimmed) > 0 )
                    {
                        Console.WriteLine("The number of vowels is : " + instance1.VowelChecker(textTrimmed).ToString());
                    }
                    else
                    {
                        Console.WriteLine("No vowels were found");
                    }
                }
                else if (operation[i] == '3')
                {
                    Console.WriteLine("Checking if the text has more vowels or nonvowels...");
                    Console.WriteLine(instance1.VowelsOrNonVowels(textTrimmed));
                }
                else
                {
                    Console.WriteLine("You entered an invalid option");
                }
            }
            string endOfProgram = Console.ReadLine();
        }
    }
}
