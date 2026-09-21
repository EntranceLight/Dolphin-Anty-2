using System;
using System.Collections.Generic;
using System.Linq;

namespace WarehouseApp
{
    class Item
    {
        public string Name { get; }
        public int Quantity { get; }

        public Item(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }

    class Warehouse
    {
        private readonly List<Item> items = new List<Item>();

        public void AddItem(string name, int quantity)
        {
            items.Add(new Item(name, quantity));
        }

        public void PrintReport()
        {
            Console.WriteLine("Warehouse Report");
            Console.WriteLine("================");

            foreach (Item item in items.OrderBy(i => i.Name))
            {
                Console.WriteLine($"{item.Name} | {item.Quantity} units");
            }

            Console.WriteLine("================");
            Console.WriteLine($"Total Units: {items.Sum(i => i.Quantity)}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();

            warehouse.AddItem("Keyboard", 18);
            warehouse.AddItem("Mouse", 42);
            warehouse.AddItem("Monitor", 11);
            warehouse.AddItem("Headset", 25);

            warehouse.PrintReport();
        }
    }
}
