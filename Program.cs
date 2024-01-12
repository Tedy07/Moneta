// See https://aka.ms/new-console-template for more information
//stała
//public const string FILE_NAME = @"C:\Moneta\ImportFile.xlsx";

using Moneta;

internal class Program
{
    private static void Main(string[] args)
    {   //view 1 main menu
        Console.WriteLine("Welcome to Moneta app");
        Console.WriteLine("Please let me know whate you want to do:");
        Console.WriteLine("1. Add Item");
        Console.WriteLine("2. Remove Item");
        Console.WriteLine("3. Show me Items");
        Console.WriteLine("Press 1, 2 or 3");

        string operation = Console.ReadLine();
        int chosenOperation = 0;
        int.TryParse(operation, out chosenOperation);

        if (chosenOperation == 1)
        {
            Console.WriteLine("You have chosen number 1, add new Item");
            Console.WriteLine("Created a new Item, push Enter");
            Console.ReadLine();

            ItemMoneta Moneta1 = new ItemMoneta();
            // Moneta1.Id = 1;
            Moneta1.GetMetal("gold");
            Moneta1.GetWeightOz(10);
            Moneta1.GetPrice(200);

            ItemMoneta Moneta2 = new ItemMoneta();
            Moneta2.Id = 2;
            Moneta2.Metal = "silver";
            Moneta2.WeightOz = 20;
            Moneta2.Price = 50;

            Console.WriteLine("You have metal: " + Moneta1.Metal + ", weight: " + Moneta1.WeightOz + ", price: " + Moneta1.Price);
            Console.ReadKey();

        }
        else if (chosenOperation == 2)
        {
            Console.WriteLine("You have chosen number 2, You want remove Item");
            Console.WriteLine("Remove a Item");
            Console.ReadLine();
        }
        else if (chosenOperation == 3)
        {
            Console.WriteLine("You have chosen number 3, show me Items");
            Console.WriteLine("Showe me all Item");
            Console.ReadLine();
        }
        else
        { Console.WriteLine("Dial another number!"); }



    }
}