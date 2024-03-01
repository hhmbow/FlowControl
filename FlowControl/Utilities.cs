using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
