// See https://aka.ms/new-console-template for more information
//stała
//public const string FILE_NAME = "C:\\Moneta\\ImportFile.xlsx";

Console.WriteLine("Welcome to Moneta app");
Console.WriteLine("Please let me know whate you want to do:");
Console.WriteLine("1. Add Item");
Console.WriteLine("2. Remove Item");
Console.WriteLine("3. Show me Item");
Console.WriteLine("Press 1, 2 or 3 ... ");
Console.WriteLine();

string choice = Console.ReadLine();

Console.WriteLine($"You have chosen option numer: {choice}");

//zmienna
int chosenOption = 0;

//parsowanie zamiana na cyfrę
Int32.TryParse(choice, out chosenOption);

 