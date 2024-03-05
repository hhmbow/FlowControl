// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;



using System;
using static FlowControl.Utilities; 

class Program
{
    static void Main(string[] args)
    {
        
        FlowControl.Utilities.StringSplitter splitter = new StringSplitter();

        
        Console.WriteLine("Welcome!\nYou have entered the FlowControl.\nYou will navigate by entering numbers.");

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nChoose an option:\n1. To check prices, press 1." +
                "\n2. To calculate the total price for a group, press 2." +
                "\n3. To print out a sentence 10 times, press 3." +
                "\n4. To split a sentence into words, press 4." +
                "\n0. To exit the program, press 0.\n");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    FlowControl.Utilities.PriceCheker();
                    break;
                case "2":
                    FlowControl.Utilities.GroupPrice();
                    break;
                case "3":
                    FlowControl.Utilities.nTimes();
                    break;
                case "4":
                    string words = splitter.GetThirdWordFromSentence(); 
                   
                        Console.WriteLine("Det tredje ordet i meningen är: " + words);
                    
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
    }
}
