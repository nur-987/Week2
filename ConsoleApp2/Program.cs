using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// properties example
    /// using get and set
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item("Pen", 1.5);
            Item item2 = new Item("Juice", 3.5);
            Console.WriteLine(item);
            Console.ReadLine();
        }
    }
    class Item
    {
        public string Name { get; set; }
        public double price { get; set; }
        public Item(string name, double price)
        {
            this.Name = name;
            this.price = price;

        }

    }
}
