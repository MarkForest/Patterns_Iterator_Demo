using ConsoleApp1.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    public class DinerMenu
    {
        static int MAX_ITEMS = 4;
        MenuItem[] menuItems;
        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            InitialMenu();

        }
        private void InitialMenu()
        {
            menuItems[0] = new MenuItem("Diner menu item 1", "This is menu item", 2.99, false);
            menuItems[1] = new MenuItem("Diner menu item 2", "This is menu item", 2.99, false);
            menuItems[2] = new MenuItem("Diner menu item 3", "This is menu item", 2.99, false);
            menuItems[3] = new MenuItem("Diner menu item 4", "This is menu item", 2.99, false);
        
        }
        //public MenuItem[] GetMenuItems()
        //{
        //    return menuItems;
        //}
        public Iterator createIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
            
    }
}
