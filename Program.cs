// See https://aka.ms/new-console-template for more information
//stała
//public const string FILE_NAME = @"C:\Moneta\ImportFile.xlsx";

using Moneta;
using System.IO;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        //view 1 main menu
        Console.WriteLine("Welcome to CoinApp");
        Console.WriteLine();
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
            Console.WriteLine("You chosen number 1, add new coin item.");
            Console.WriteLine("Please choose metal coin type");
            Console.WriteLine("1. gold");
            Console.WriteLine("2. silver");
            Console.WriteLine("Press 1 or 2");
            //Console.ReadLine();

            ItemCoin Coin1 = new ItemCoin();
            int chosenOperation11 = int.Parse(Console.ReadLine());

            if (chosenOperation11 == 1)
            {
                Coin1.Metal = "gold";
            }
            else
            {
                Coin1.Metal = "silver";
            }

            // Coin1.Metal = int.Parse(Console.ReadLine());

            Console.WriteLine("Get my weight this coin");
            Coin1.WeightOz = int.Parse(Console.ReadLine());

            Console.WriteLine("Get my price this coin");
            Coin1.Price = int.Parse(Console.ReadLine());

            //blok zapis/odczyt, ścieżka do pliku.txt
            // zapis
            string path = @"MyPlikCoinApp.txt";
            StreamWriter sw;
            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                Console.WriteLine("File is exist!");
            }
            else
            {
                sw = new StreamWriter(path, true);
                Console.WriteLine("File is open!");
            }
            string tekst1 = $"You have metal: {Coin1.Metal}, weight: 1/{Coin1.WeightOz}, price: {Coin1.Price}";

            sw.WriteLine(tekst1);
            sw.Close();
            //odczyt danychz pliku
            StreamReader sr = File.OpenText(path);
            string s = "";
            int i = 1;
            Console.WriteLine("\nZawartość pliku, który otwieramy");
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(i++ + ". " + s);
            }
            sr.Close();

        }
        else if (chosenOperation == 2)
        {
            Console.WriteLine();
            Console.WriteLine("You have chosen number 2, You want remove coin item");
            Console.WriteLine("Please enter the number to be deleted.");
            int operation2 = int.Parse(Console.ReadLine());

            Console.WriteLine("wpisałeś nr " + operation2);
            Console.ReadLine();
        }
        else if (chosenOperation == 3)
        {
            Console.WriteLine();
            Console.WriteLine("You have chosen number 3, show me all coins");
            Console.WriteLine("Show me all, press Enter ...");
            Console.ReadKey();

            //odczyt z pliku
            string path = @"MyPlikCoinApp.txt";
            StreamReader sr = File.OpenText(path);
            string s = "";
            int i = 1;
            Console.WriteLine("All in this file:");

            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(i++ + ". " + s);
            }
            sr.Close();

            Console.WriteLine("The list it's The End.");

        }
        else
        { Console.WriteLine("Dial another number!"); }


        Console.ReadKey();

    }
}