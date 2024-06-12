
namespace HarryPotter
{
    internal class MagicWorld
    {

        public Character CurrentPlayer { get; private set; }
        public MagicWorld()
        {
            CurrentPlayer = new Character("Gustav", "Hufflepuff", 100);

            MainMenu();
        }

        public void MainMenu()
        {
            Console.WriteLine($"Hello! My name is {CurrentPlayer.Name}");
            Console.WriteLine($"I am a slave to the house {CurrentPlayer.House}");
            Console.WriteLine("This is my awesome stuff:");
            var myStuff = new Inventory();
            myStuff.PrintMyItems();

            Console.WriteLine($"I have {CurrentPlayer.Cash} gold coins");
        }
    }
}
