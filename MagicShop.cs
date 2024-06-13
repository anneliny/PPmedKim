
using Microsoft.VisualBasic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace HarryPotter
{
    internal class MagicShop
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public string Description { get; private set; }

        public int Price { get; private set; }

        public List<Items> ShopItems { get; private set; }


        public MagicShop()
        {
            ShopItems = new List<Items>()
            { 
                new Items ("Owl", "Hubro", 100000, "Pet"),
                new Items ("Cat", "Main Coon", 10000, "Pet"),
                new Items ("Rat", "Sewagerat", 1, "Pet"),
                new Items ("unikornstaff", "Pink", 101, "Wand"),
                new Items ("føniksstaff", "Orange", 110000, "Wand"),
                new Items ("trollstaff", "Brown/Yellow (might Explode on use)", 99, "Wand")
            };
            
        }

        public MagicShop(string name, string type, string description, int price)
        {
            Name = name;
            Type = type;
            Description = description;
            Price = price;
        }

        public void Shop()
        {
            Console.WriteLine("Welcome to the Magicshop!");
            Console.WriteLine("What do you want to buy?");
            Console.WriteLine("1. Pet");
            Console.WriteLine("2. Wand");
            var userInput = Console.ReadLine();

            if (userInput == "1") 
                { PetShop(); }
            else if (userInput == "2") 
                { WandShop(); }
        }

        public void PetShop() 
        {
            List<Items> matchedItems = (List<Items>)ShopItems.Where(item => item.Type == "Pet").ToList();
            foreach (Items item in matchedItems)
            {
                Console.WriteLine (item.Name);
            }
            Console.ReadLine();
        }

        public void WandShop() 
        {
            List<Items> matchedItems = (List<Items>)ShopItems.Where(item => item.Type == "Wand").ToList();
            foreach (Items item in matchedItems)
            {
                Console.WriteLine(item.Name);
            }
        }


    }
}
