using System;
using System.Collections.Generic;
using System.Text;

namespace _03.zad28Year2023
{
    public class Pilot
    {
        public Pilot(string name, int age, Car carp, string category)
        {
            Name = name;
            Age = age;
            Carp = carp;
            Category = category;
        }

        public  string Name { get; set; }

        public  int Age { get; set; }

        public  Car Carp { get; set; }

        public  string Category { get; set; }

        override public string ToString()
        {
            return $"{Name},{Age},{Category},{Carp.ToString()}";
        }

    }
}
