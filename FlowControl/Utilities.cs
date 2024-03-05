using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace FlowControl
{
    public class Utilities
    {
        public static void PriceCheker()
        {
            Console.WriteLine("Ange ålder:");
            int age = int.Parse(Console.ReadLine());

            if (age < 20)
            {
                Console.WriteLine("Ungdomspris: 80kr.");
            }
            else if (age > 64)
            {
                Console.WriteLine("Pensionärspris: 90kr.");
            }
            else
            {
                Console.WriteLine("Standardpris: 120kr.");
            }
        }

        public static void GroupPrice()
        {
            Console.WriteLine("\nAnge antal personer i sällskapet: ");
            int numberOfPeople = int.Parse(Console.ReadLine());

            int totalCost = 0;

            for (int i = 0; i < numberOfPeople; i++)
            {
                Console.WriteLine($"\nAnge ålder för person {i + 1}: ");
                int age = int.Parse(Console.ReadLine());

                if (age < 20)
                {
                    totalCost += 80;
                }
                else if (age > 64)
                {
                    totalCost += 90;
                }
                else
                {
                    totalCost += 120;
                }
            }

            Console.WriteLine($"\nAntal personer: {numberOfPeople}, total kostnad: {totalCost}kr.");
        }

        public static void nTimes()
        {
            Console.WriteLine("Skriv en mening som ska skrivas ut 10 gånger:\n");
            string input = Console.ReadLine().Trim();

            // Validate input
            if (!Regex.IsMatch(input, @"^\b[a-zA-Z]+\b\s\b[a-zA-Z]+\b\s\b[a-zA-Z]+\b$"))
            {
                Console.WriteLine("\nOgiltig inmatning. Ange en mening med exakt tre ord, som endast innehåller bokstäver från A till Z.\n");
                return;
            }

            // Print the input 10 times
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Loop Nummer {i + 1}: {input}");
            }
        }

       

   

public class StringSplitter
    {
        public string GetThirdWordFromSentence()
        {
            Console.WriteLine("Enter a sentence with at least 3 words:");
            string sentence = Console.ReadLine().Trim(); 
            string[] words = sentence.Split(' '); 

            if (words.Length < 3)
            {
                Console.WriteLine("The sentence does not contain at least 3 words.");
                return null; 
            }


            string thirdWord = words[2];

           
            return thirdWord;
        }
    }



}
}
       