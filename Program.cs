﻿// See https://aka.ms/new-console-template for more information
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
            //view 2.1 category selection
            Console.WriteLine("You have chosen number 1 and add new Item");
            Console.WriteLine();
            Console.WriteLine("Select item category");
            Console.WriteLine("1. Gold");
            Console.WriteLine("2. Silver");
            Console.WriteLine("Press 1 or 2");
            Console.ReadLine();
                        
            //Tutaj po wybraniu kategorii tworzymy obiekt !!!
            //string category = Console.ReadLine();
            ItemType chosenCategory;
            //Enum.TryParse(category, out chosenCategory);
            // Item item = new Item() { Id = 1, Name = "Filharmonik", WeightOz = 10 };
        }
        else if (chosenOperation == 2)
        {
            Console.WriteLine("You have chosen number 2 and remove Item");
            Console.WriteLine();
            Console.WriteLine("Select what you want to remove?");
            Console.WriteLine("1. I want remove gold coin");
            Console.WriteLine("2. I want remove silver coin");
            Console.WriteLine("Press 1 or 2");
            Console.ReadLine();

        }
        else if (chosenOperation == 3)
        {
            Console.WriteLine("You have chosen number 3 and show you Items");
            Console.WriteLine();
            Console.WriteLine("Select what you want to show?");
            Console.WriteLine("1. Show me all");
            Console.WriteLine("2. Show me gold coin");
            Console.WriteLine("3. Show me silver coin");
            Console.WriteLine("Press 1, 2 or 3");
            Console.WriteLine("Test nr 1 changes commit Press 1, 2 or 3");
            Console.WriteLine("Test nr 2 changes commit Press 1, 2 or 3");
            Console.ReadLine();
        }

        else
        { Console.WriteLine("You choose another number!"); }
    }
}