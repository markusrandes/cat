using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace shoppinglist
{
    class Program
    {
        public class Item
        {
            string name;
            int price;

            public Item(string _name, int _price)
            {
                name = _name;
                price = _price;
                Console.WriteLine($"item {name} created.");
            }

            public string Name { get { return name; } }

            public int Price { get { return price; } }
        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"shoppinglist.txt";
            List<Item> shoppingItems = new List<Item>();
            List<string> linesFromFile = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();

            foreach (string line in linesFromFile)
            {
                List<Item> shoppingItems = new List<Item>();

                List<string> linesFromFile = File.ReadLines(Path.Combine(filePath, fileName)).ToList;

                foreach(string Line in ListFromFile)
                {
                    string[] tempArry = line.Split(new char[] {\}, StringSplitOptions.RemoveEmptyEntries);
                    Item newitem = new Item(tempArry[0], Int32.Parse(tempArry[1])));
                    shoppingItems.Add(newitem);
                }

                Console.WriteLine("enter shopping cart:");
                int total = 0;

                foreach(Item item in shoppingItems)
                {
                    Console.WriteLine($"item: {item.Name}; price: {item.Price}");
                    total += item.Price;
                    {
                        Console.WriteLine($"your shopping cart total: {total}");
                    }
                }
            }
        }
    }
}