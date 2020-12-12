using System;
using System.Collections.Generic;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            //habitants:

            Person ivan = new Person("Ivan", "Sládeček", 53);
            Console.WriteLine($"{ivan.ToString()}");
            Person jožko = new Person("Jožko", "Hranovský", 68);
            Console.WriteLine($"{jožko.ToString()}");
            Person martin = new Person("Martin", "Janovský", 37);
            Console.WriteLine($"{martin.ToString()}");

            //flats:

            Flat first = new Flat(1, 25, 3);
            Console.WriteLine($"{ first.ToString()}");
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


            int addContinue = 0;
            while (addContinue != 4)
            {
                Console.WriteLine("\t Enter habitant (write 1 to continue and then press enter)");
                Console.WriteLine("\t Write habitants (write 2 to continue and then press enter)");
                Console.WriteLine("\t Create new flat (write 3 to continue and then press enter)");
                Console.WriteLine("\t End adding habitant (write 4 to continue and then press enter)");
                int addSelection = int.Parse(Console.ReadLine());

                switch (addSelection)
                {
                    case 1:
                        Console.WriteLine("Enter name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter surname");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Enter age:");
                        int age = int.Parse(Console.ReadLine());

                        first.AddHabitant(name, surname, age);
                        break;

                    case 2:
                        first.GetInfoAboutHabitants();
                        break;

                    default:
                        addContinue = 4;
                        break;
                }
            }
        }        
    }
}
