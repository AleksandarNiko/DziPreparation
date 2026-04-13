using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Lunapark
{
    public class Attraction
    {
        private string name;
        private string type;
        private int yearOpened;
        private double price;
        private bool isForKids;

        public Attraction(string name, string type, int yearOpened, double price, bool isForKids)
        {
            Name = name;
            Type = type;
            YearOpened = yearOpened;
            Price = price;
            IsForKids = isForKids;
        }

        public string Name { get => name; set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid attraction name!");
                }
                value = name;
            } }

        public string Type { get => type; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid attraction type!");
                }
                value = type;
            }
        }

        public int YearOpened
        {
            get => yearOpened; set
            {
                if (value <= 1900 || value >= 2026)
                {
                    throw new ArgumentException("Invalid year opened!");
                }
                value = yearOpened;
            }
        }

        public double Price { get => price; set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Invalid price!");
                }
                value = price;
            }
        }

        public bool IsForKids { get => isForKids; set => isForKids = value; }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {Type}, Year: {YearOpened}, Price: {Price}, For kids: {IsForKids}";       
        }

        public double CalculateDepreciation(int currentYear)
        {
            int yearsInOperation = currentYear - YearOpened;
            double depreciationRate = 0.05; 
            double depreciation = Price * depreciationRate * yearsInOperation;

            return Math.Max(0, Price - depreciation); 
        }



    }
}
