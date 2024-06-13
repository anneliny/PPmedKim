using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotter
{
    internal class Items
    {
        public string Name;
        public string Description;
        public int Price;
        public string Type;
        public Items(string name, string description, int price, string type)
        {
            Name = name;
            Description = description;
            Price = price;
            Type = type;
        }
    }
}
