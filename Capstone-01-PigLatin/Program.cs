using System;
using System.Globalization;

namespace Capstone_01_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;

            while (keepPlaying)
            {

                Console.WriteLine("Welcome to the Pig Latin Translator!\n");
                Console.Write("Enter a line to be translated: ");
                string input = Console.ReadLine().ToLower();
                if (input == "")
                {
                    input = "z";
                }

                string output = PigLatin(input);

                if (output == " ")
                {
                    Console.WriteLine("Oops. That can't be converted.\n");
                }
                else
                {
                    Console.WriteLine($"{char.ToUpper(input[0]) + input.Substring(1)} is {output} in pig Latin.\n");
                }

                Console.Write("Would you like to try another word? (y/n) ");

                keepPlaying = CheckExit();
                Console.WriteLine();
            }

            Console.WriteLine("Goodbye.");
            {

            }
        }



        public static string PigLatin(string word)
        {

            string pigWord;

            for (int i = 0; i < word.Length; i++)
            {

                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    if (i == 0)
                    {
                        pigWord = word + "way";
                        return pigWord;

                    }
                    pigWord = word.Substring(i) + word.Substring(0, i) + "ay";
                    return pigWord;
                }

            }
            return " ";

        }

        public static bool CheckExit()
        {

            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "")
                {
                    input = " ";
                }

                if (input[0] == 'y')
                {
                    Console.WriteLine();
                    return true;
                }
                else if (input[0] == 'n')
                {
                    return false;
                }

                Console.Write("Sorry, I couldn't understand you. Please try again: ");
            }

        }
    }
}
