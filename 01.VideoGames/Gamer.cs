using System;
using System.Collections.Generic;
using System.Text;

namespace _01.VideoGames
{
    public abstract class Gamer
    {
        private string name;
        private double budget;

        protected Gamer(string name, double budget)
        {
            Name = name;
            Budget = budget;
        }

        public string Name { get => name; set => name = value; }

        public double Budget { get => budget; set => budget = value; }

        public void AddToBudget(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount must be positive.");
            }
            Budget += amount;
        }

        public abstract double CalculateSum();
    }
}
