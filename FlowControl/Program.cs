// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class program
{

    static void Main(string[] args)
    {
        //Welkomen meny
        Console.WriteLine("Welkomen!\ndu har kommit i FlowControl,\nDu " +
          " komma att navigera genom att skriva in siffror. ");

        //while loop med info och methoder
        bool running = true;

        while (running)
        {

            Console.WriteLine("\nVälj nummer:\n1. För priser tryck 1." +
                "\n2. För sällskap totalkostnad tryck 2." +
                "\n0. För att avsluta programmet tryck 0.\n");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    FlowControl.Utilities.PriceCheker();
                    break;
                case "2":
                   FlowControl.Utilities.GroupPrice();
                    break;
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Felaktig input.");
                    break;
            }
        }


 
       

    }
}