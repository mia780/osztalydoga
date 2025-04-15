using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Toyota", "Corolla", 2015, 6.5, 152000);
            auto.adatkiiras();
        }
    }

}
