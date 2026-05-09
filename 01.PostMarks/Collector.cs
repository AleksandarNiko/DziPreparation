using System;
using System.Collections.Generic;
using System.Text;

namespace _01.PostMarks
{
    public abstract class Collector
    {
        public Collector(string name, double budget)
        {
            Name = name;
            Budget = budget;
        }

        public  string Name { get; set; }

        public  double Budget { get; set; }

        public void AddToBudget(double amount)
        {
            Budget += amount;
        }

        public abstract double CalculateSum();
    }
}
