using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Menus
{
    public class PancadeHouseMenu
    {
        List<MenuItem> menuItems = null;
        public PancadeHouseMenu()
        {
            menuItems = new List<MenuItem>();
            InitialMenu();
        }

        private void InitialMenu()
        {
            menuItems.AddRange(new MenuItem[] {
                new MenuItem("Pacade menu item 1", "This is menu item", 2.99, false),
                new MenuItem("Pacade menu item 2", "This is menu item", 2.99, false),
                new MenuItem("Pacade menu item 3", "This is menu item", 2.99, false),
                new MenuItem("Pacade menu item 4", "This is menu item", 2.99, false),
                new MenuItem("Pacade menu item 5", "This is menu item", 2.99, false),

            });
 
        }
        public List<MenuItem> GetMenuItems()
        {
            return menuItems;
        }
    }
}
