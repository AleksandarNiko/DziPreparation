using System;
using System.Collections.Generic;
using System.Text;

namespace _01.PostMarks
{
    public class Stamp
    {
        private string name;
        private int year;
        private int rarity;

        public Stamp(string name, int year, int rarity)
        {
            Name = name;
            Year = year;
            Rarity = rarity;
        }

        public string Name { get => name; set => name = value; }

        public int Year { get => year; set 
            {
                if(value<1800 || value>2025)
                {
                    throw new ArgumentException("Year must be between 1800 and 2025.");
                }
                year = value;
            } }

        public int Rarity { get => rarity; set
            {
                if(value < 1 || value > 10)
                {
                    throw new ArgumentException("Rarity must be between 1 and 10.");
                }
                rarity = value;
            } 
        }

        public double CalculatePrice()
        {
            double price = Rarity*(2025 - Year) * 1.9;
            return price;
        }

        override public string ToString()
        {
            return $"The {Year} stamp {Name} with rarity of {Rarity} has a price of {CalculatePrice():F2}.";
        }
    }
}
