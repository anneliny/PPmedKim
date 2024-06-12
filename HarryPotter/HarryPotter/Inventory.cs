
namespace HarryPotter
{
    internal class Inventory
    {
        public string Type { get; private set; }
        public int Pieces { get; private set; }

        public List<Inventory> MyInventory {  get; private set; }

        public Inventory()
        {
            MyInventory = new List<Inventory>()
            {
                new Inventory ("Ugle", 1),
                new Inventory ("Trollstav", 1)
            };
        }

        public Inventory(string type, int pieces)
        {
            Type = type;
            Pieces = pieces;
        }

        public void PrintMyItems()
        {
            foreach (Inventory item in MyInventory)
            {
                Console.WriteLine($"{item.Type}");

            }
        }

    }

}
