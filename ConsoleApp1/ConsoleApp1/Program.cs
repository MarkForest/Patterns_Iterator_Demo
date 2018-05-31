using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Menus;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Waitress waitress = new Waitress(new PancadeHouseMenu(), new DinerMenu());
            waitress.PrintMenu();
        }
    }
}
