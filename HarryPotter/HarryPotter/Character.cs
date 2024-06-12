
namespace HarryPotter
{
    internal class Character
    {
        public string Name { get;  private set; }
        public string House { get; private set; }

        public int Cash { get; private set; }

        public Character(string name, string house, int cash)
        {
            Name = name;
            House = house;
            Cash = cash;
        }

        public Character()
        {
            
        }

    }
}
