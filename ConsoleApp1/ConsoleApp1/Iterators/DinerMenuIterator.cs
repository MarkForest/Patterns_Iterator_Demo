using ConsoleApp1.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Iterators
{
    class DinerMenuIterator : Iterator
    {
        MenuItem[] menuItems = null;
        int position = 0;
        public DinerMenuIterator(MenuItem [] menuItems)
        {
            this.menuItems = menuItems;
        }
        public bool HasNext()
        {
            if(position >= menuItems.Length || menuItems[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public object Next()
        {
            
            return menuItems[position++];
           
        }
    }
}
