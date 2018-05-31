using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Menus;
using ConsoleApp1.Iterators;

namespace ConsoleApp1
{
    public class Waitress
    {
        PancadeHouseMenu menu1 = null;
        DinerMenu menu2 = null;
        public Waitress(PancadeHouseMenu menu1, DinerMenu menu2)
        {
            this.menu1 = menu1;
            this.menu2 = menu2;
        }

        public void PrintMenu()
        {
            Iterator dinerIterator = menu2.createIterator();
            PrintMenu(dinerIterator);

            
        }

        private void PrintMenu(Iterator i)
        {
            while (i.HasNext())
            {
                MenuItem menuItem = i.Next() as MenuItem;
                Console.WriteLine($"{menuItem.Name} {menuItem.Description}");
            }
        }
    }
}
