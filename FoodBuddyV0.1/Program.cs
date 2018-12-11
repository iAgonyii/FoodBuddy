using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBuddyV0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkome, Voer je naam in: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Voer je gender in: ");
            string gender = Console.ReadLine();
            Console.WriteLine("Voer je allergieen in: ");
            string allergieen = Console.ReadLine();
            ConnectionDB connection = new ConnectionDB();
            Product newProduct = new Product("8715600231090");
            Console.WriteLine(newProduct.GetProductName());
            Console.ReadLine();
            Console.WriteLine(newProduct.GetProductIngredients());
            Console.ReadLine();





           /* // Eerst connectie met DB en Arduino opstellen
            ConnectDatabase();
            ConnectArduino();
            // Profielregistratie
            SaveInputName();
            SaveInputGender();
            SaveInputAllergies();
            SaveProfile();
            // ButtonScan_click:
            WaitForScan();
            if(BarcodeScanned)
            {
                GetData();
                AddToHistory();
                // Als alle data goed is uitvangen vanuit de DB mag het programma het displayen
                if(GetData = Done)
                {
                    DisplayProductPicture();
                    DisplayProductGraphs();
                    DisplayProductInfo();
                    DisplayProductImportant();   // Kan in allemaal in 1 worden opgeslagen als Display(); ofzo
                }
            }
            // Terug naar home screen button
            DisplayScanHistory();
            if(ProductHistoryItem = Pressed)
            {
                Display();
            }
            */








        }
    }
}
