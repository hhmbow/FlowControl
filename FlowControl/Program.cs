// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


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
            PriceCheker();
            break;
            case "2":
            GroupPrice();
            break;  
            case "0":
            running = false;
            break;
            default:
            Console.WriteLine("Felaktig input.");
            break ;
    }
}

// price checker with if else
static void PriceCheker()
{
    Console.WriteLine("?\nAnge årlder:");
    int age= int.Parse(Console.ReadLine()); // parsing string to int.

    if(age < 20 )
    {
        Console.WriteLine("Ungdomspris: 80kr.");
    }
    else if  ( age > 64 ) {
        Console.WriteLine("Pensionärspris: 90kr.");
    }
    else
    {
        Console.WriteLine("Standardpris 120kr.");
           
    }
}

//Total kostnad methoder 
static void GroupPrice()
{
    Console.WriteLine("\nAnge antal personer i sällskapet: ");
    int numberOfPeople = int.Parse(Console.ReadLine());

    int totalCost = 0;

    for (int i = 0; i < numberOfPeople; i++)
    {
        Console.WriteLine($"\nAnge ålder för person {i + 1}: "); // add varje gång 1
        int age = int.Parse(Console.ReadLine());

        if (age < 20 )
        {
            totalCost += 80; 
        }
        else if (age > 64 )
        {
            totalCost += 90;
        }
        else
        {
            totalCost += 120;
        }
    }
    Console.WriteLine($"\nAntal personer: {numberOfPeople}, total kostnad: {totalCost}kr. " );

}