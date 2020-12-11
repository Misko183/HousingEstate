using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HousingEstate
{
    class Flat
    {
        public string Name { get; set; }
        public int FlatNum { get; set; }
        public int Extent { get; set; }
        public int Rooms { get; set; }


        public Flat(string name, int flatNum, int extent, int rooms)
        {
            Name = name;
            FlatNum = flatNum;
            Extent = extent;
            Rooms = rooms;
        }

        public Flat()
        {
            Name = "-1";
            FlatNum = -1;
            Extent = -1;
            Rooms = -1;
        }


        
        public override string ToString()
        {
            Console.WriteLine("-----------");
            return $"{Name}\n{FlatNum} {Extent} {Rooms}";
        }
    }
}
