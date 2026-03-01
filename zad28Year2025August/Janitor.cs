using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2025August
{
    public class Janitor:HospitalStaff
    {
        public Janitor(string firstName, string lastName, int age, decimal salary, int areaOfResponsibility) : base(firstName, lastName, age, salary)
        {
            AreaCovered = areaOfResponsibility;
        }
        public  int AreaCovered { get; set; }
        public override void Info()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Janitor: {FirstName} {LastName}");
            sb.AppendLine($"Salary: {Salary:f2}");
            sb.AppendLine($"Age: {Age}");
            sb.AppendLine($"Area covered: {AreaCovered} sqm");

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
