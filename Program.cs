﻿// See https://aka.ms/new-console-template for more information
//stała
//public const string FILE_NAME = @"C:\Moneta\ImportFile.xlsx";

using Moneta;

internal class Program
{
    private static void Main(string[] args)
    {   //view 1 main menu
        Console.WriteLine("Welcome to CoinApp");
        Console.WriteLine("Please let me know, whate you want to do:");
        Console.WriteLine("1. Add coin item");
        Console.WriteLine("2. Remove coin item");
        Console.WriteLine("3. Show me all items");
        Console.WriteLine("Press 1, 2 or 3");

        string operation = Console.ReadLine();
        int chosenOperation = 0;
        int.TryParse(operation, out chosenOperation);

        if (chosenOperation == 1)
        {
            Console.WriteLine();
            Console.WriteLine("You have chosen number 1, add new coin item.");
            Console.WriteLine("Created a new coin item, push Enter.");
            Console.ReadLine();

            ItemCoin Coin1 = new ItemCoin();
            
            Console.WriteLine("This coin is gold or silver? Write here ...");
            Coin1.SetMetal(Console.ReadLine());

            Console.WriteLine("Get my weight this coin");
            Coin1.SetWeightOz(int.Parse(Console.ReadLine()));

            Console.WriteLine("Get my price this coin");
            Coin1.SetPrice(int.Parse(Console.ReadLine()));

            
            Console.WriteLine("You have metal: " + Coin1.GetMetal() + ", weight: " + Coin1.GetWeightOz() + ", price: " + Coin1.GetPrice());
            Console.WriteLine("You have metal: " + Coin2.GetMetal() + ", weight: " + Coin2.GetWeightOz() + ", price: " + Coin2.GetPrice());
            Console.ReadKey();

        }
        else if (chosenOperation == 2)
        {
            Console.WriteLine("You have chosen number 2, You want remove coin item");
            Console.WriteLine("Remove a Item");
            Console.ReadLine();
        }
        else if (chosenOperation == 3)
        {
            Console.WriteLine("You have chosen number 3, show me all coins items");
            Console.WriteLine("Showe me all item");
            Console.ReadLine();
        }
        else
        { Console.WriteLine("Dial another number!"); }



    }
}