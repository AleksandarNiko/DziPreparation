using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2025May
{
    public class Manager : SchoolMember
    {
        private double budget;
        private int yearsInService;

        public Manager(string name, int age, double budget, int yearsInService) : base(name, age)
        {
            Budget = budget;
            YearsInService = yearsInService;
        }

        public double Budget { get => budget; set 
            {
                if(value<0)
                {
                    throw new ArgumentException("Budget must be a positive number!");
                }
                budget = value;
            } }

        public int YearsInService { get => yearsInService; set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("Years in service cannot be negative!");
                }
                yearsInService = value;
            } }

        public override void Info()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Manager: {Name}, Age: {Age} years");
            sb.AppendLine($"Budget: {Budget:f2} lv.");
            sb.AppendLine($"Years in service: {YearsInService} years");

            Console.WriteLine(sb.ToString());
        }
    }
}
