// See https://aka.ms/new-console-template for more information
//stała
//public const string FILE_NAME = @"C:\Moneta\ImportFile.xlsx";

using Moneta;

Console.WriteLine("Welcome to Moneta app");
Console.WriteLine("Please let me know whate you want to do:");
Console.WriteLine("1. Add Item");
Console.WriteLine("2. Remove Item");
Console.WriteLine("3. Show me Items");
Console.WriteLine("Press 1, 2 or 3 ... ");
Console.WriteLine();

string operation = Console.ReadLine();
int chosenOperation = 0;
Int32.TryParse(operation, out chosenOperation);

//Nie wiem co z tą kategorią dalej!!!
string category = Console.ReadLine();
ItemType chosenCategory;
//Enum.TryParse(category, out chosenCategory);
Console.WriteLine( "testowy text");

if (chosenOperation == 1)
{
    Console.WriteLine("You have chosen number 1 and add new Item");
    Console.WriteLine();
    Console.WriteLine("Select item category");
    Console.WriteLine("1. Gold");
    Console.WriteLine("2. Silver");
    Console.WriteLine("3. Platinum");
    Console.WriteLine("Press 1, 2 or 3");
    Console.ReadLine();

    Item item = new Item() { Id = 1, Name = "Filharmonik", WeightOz = 10 };
}
else if (chosenOperation == 2)
{
    Console.WriteLine("You have chosen number 2 and remove Item");
    Console.WriteLine("Under construction");
    //context.Items.Remove(Item);
}
else if (chosenOperation == 3)
{
    Console.WriteLine("You have chosen number 3 and show you Items");
    Console.WriteLine("Under construction");
}
else
{ Console.WriteLine("You have wrong number, sorry try again!!!"); }

