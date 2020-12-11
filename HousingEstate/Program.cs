using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ivan = new Person("Ivan", "Sládeček", 53);
            Console.WriteLine($"{ivan.ToString()}"); //jednotkaaaa jeeee zamonouuuu...ouuu jeeee
            Flat firts = new Flat("First", 1, 25, 3);
            Console.WriteLine($"{ firts.ToString()}");
        }
    }
}
