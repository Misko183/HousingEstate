using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HousingEstate
{
    class Flat
    {
        public int FlatNum { get; set; }
        public int Extent { get; set; }
        public int Rooms { get; set; }
        public List<Person> person = new List<Person>();


        public Flat(int flatNum, int extent, int rooms)
        {
            FlatNum = flatNum;
            Extent = extent;
            Rooms = rooms;
        }

        public Flat()
        {
            FlatNum = -1;
            Extent = -1;
            Rooms = -1;
        }



        public override string ToString()
        {
            return $"-----------------------\nNumber of flat: {FlatNum}\nExtent of the flat: {Extent}\nNumbers of rooms: {Rooms}";
        }

        public void AddHabitant(string nameOfHabitant, string surnameOfHabitant, int ageOfHabitant)
        {
            Person habitant = new Person(nameOfHabitant, surnameOfHabitant, ageOfHabitant);
            person.Add(habitant);
        }

        public void GetInfoAboutHabitants()
        {
            for (int i = 0; i < person.Count; i++) 
            {
                Console.WriteLine($"{person[i]}\n");
            }
        }
    }
}
