using System;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ivan = new Person("Ivan", "Sládeček", 53);
            Console.WriteLine($"{ivan.ToString()}"); //jednotkaaaa jeeee zamonouuuu...ouuu jeeee
            Flat firts = new Flat(1, 25, 3);
            Console.WriteLine($"{ firts.ToString()}");
            Flat second = new Flat(2, 18, 3);
            Console.WriteLine($"{ second.ToString()}");
            Flat third = new Flat(3, 13, 1);
            Console.WriteLine($"{ third.ToString()}");
            Flat fourth = new Flat(4, 21, 3);
            Console.WriteLine($"{ fourth.ToString()}");
            Flat fifth = new Flat(5, 45, 5);
            Console.WriteLine($"{ fifth.ToString()}");
            Flat sixth = new Flat(6, 31, 4);
            Console.WriteLine($"{ sixth.ToString()}");
        }
    }
}
