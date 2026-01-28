using System;
using System.Collections.Generic;
using System.Text;

namespace _02.zad26Year2022
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, int age, double wage, int workHours)
            : base(firstName, lastName, age)
        {
            Wage = wage;
            WorkHours = workHours;
        }
        public double Wage { get; private set; }
        public int WorkHours { get; private set; }
        public double Salary()
        {
            return Wage * WorkHours;
        }
        override public string ToString()
        {
            return $"{base.ToString()}, salary: ${Salary():f2}";
        }
    }
}
