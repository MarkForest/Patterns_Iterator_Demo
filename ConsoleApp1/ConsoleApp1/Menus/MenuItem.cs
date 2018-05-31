using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    public class MenuItem
    {
        public string Name{ get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Vegetarian { get; set; }
        public MenuItem(string name, string description, double price, bool vegetarian)
        {
            Name = name;
            Description = description;
            Price = price;
            Vegetarian = vegetarian;
        }

    }
}
