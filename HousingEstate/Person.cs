using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HousingEstate
{
    class Person
    {
        public string Name { get; set; }
        public string Surname{get; set;}
        public int Age { get; set; }


        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public Person()
        {
            Name = "-1";
            Surname = "-1";
            Age = -1;
        }

        public override string ToString()
        {
            return $"{Name}\n{Surname}\n{Age}";
        }
    }
}
