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

        // price checker with if else
        public static void PriceCheker()
        {
            Console.WriteLine("?\nAnge årlder:");
            int age = int.Parse(Console.ReadLine()); // parsing string to int.

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
                Console.WriteLine("Standardpris 120kr.");

            }
        }

        //Total kostnad methoder 
        public static void GroupPrice()
        {
            Console.WriteLine("\nAnge antal personer i sällskapet: ");
            int numberOfPeople = int.Parse(Console.ReadLine());

            int totalCost = 0;

            for (int i = 0; i < numberOfPeople; i++)
            {
                Console.WriteLine($"\nAnge ålder för person {i + 1}: "); // add varje gång 1
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
            Console.WriteLine($"\nAntal personer: {numberOfPeople}, total kostnad: {totalCost}kr. ");

        }

        public static void nTimes()
        {
            Console.WriteLine("Skriv en mening För att skriv ut 10 gånger \n");
            string NTimes = Console.ReadLine().Trim();
            string input;
            bool validInput = false;

            {
                if (Regex.IsMatch(NTimes, @"^[a-zA-Z]+\s[a-zA-Z]+\s[a-zA-Z]+$"))
                {
                    validInput = true;
 for (int i = 0; i < 10; i++)
                {
                    Console.Write($" Loop Nummer {i + 1}: {NTimes} ");
                }

                }
                else
                {
                    Console.WriteLine("\nInmatningen är ogiltig. Vänligen ange en mening med exakt tre ord," +
                        " som endast innehåller bokstäver från A till Z. \n");
                }


               
                Console.WriteLine();
                // string[] Ntimes = Console.ReadLine().Split(' ');
                //Console.WriteLine(Ntimes[2]);


            }
        }
    }
}
