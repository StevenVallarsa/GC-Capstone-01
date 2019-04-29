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

                // check for numeric digits and symbols
                bool isAlpha = CheckNumeric(input);

                string output = " ";

                // if no numbers in word run Method to turn into Pig Latin
                // if numbers are detected, make output string "N/A" to be caught in the next step
                if (isAlpha)
                {
                   output = PigLatin(input);
                }
                else
                {
                    output = "N/A";
                }

                // Pig Latin Method will return " " if there are no vowels
                if (output == " ")
                {
                    Console.WriteLine("Oops. That can't be converted.\n");
                }
                else if (output == "N/A")
                {
                    Console.WriteLine("Your word contains non-letter characters and can't be converted.\n");
                }
                else
                {
                    //Console.WriteLine($"{char.ToUpper(input[0]) + input.Substring(1)} is {output} in pig Latin.\n");
                    Console.WriteLine($"{input.ToUpper()} is {output.ToUpper()} in pig Latin.\n");
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
                // itterate through each letter and check for vowels
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


        // check for numbers in word and not convert it to Pig Latin
        public static bool CheckNumeric(string input)
        {

            foreach (char digit in input)
            {
                if (char.IsDigit(digit))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
