using System;

namespace FridayOOP
{
    class Program
    {
        class Cat
        {
            string name;
            string colour;
            double hunger;

            public Cat(string _name, string _colour)
            {
                string name = _name;
                string colour = _colour;
                double hunger = 0;
            }

            public string Name
            {
                get { return name; }
            }

            public string Colour
            {
                get { return colour; }
            }

            public double Hunger
            {
                get { return hunger; }
            }

            public void Sleep()
            {
                hunger += 0.2;
                Console.WriteLine("cat sleeps");
            }

            public void Screech()
            {
                Console.WriteLine("meow~");
            }

            public void CatData()
            {
                Console.WriteLine($"The cats name is {name}, colour {colour} and his hunger level: {hunger}");
            }
        }
        static void Main(string[] args)
        {
            Cat newCat = new Cat("Pebbles", "White n' black spots");
            newCat.CatData();
            while (newCat.Hunger != 1)
            {
                newCat.Sleep();
            }


            newCat.Screech();


            newCat.CatData();


        }
    }
}