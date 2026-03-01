using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2025August
{
    public class Nurse : HospitalStaff
    {
        public Nurse(string firstName, string lastName, int age, decimal salary, string department, int shiftsWorked) : base(firstName, lastName, age, salary)
        {
            Department = department;
            ShiftsWorked = shiftsWorked;
        }

        public  string Department { get; set; }

        public  int ShiftsWorked { get; set; }

        public override void Info()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Nurse: {FirstName} {LastName} - {Department}");
            sb.AppendLine($"Salary: {Salary:f2}");
            sb.AppendLine($"Age: {Age}");
            sb.AppendLine($"Shifts worked: {ShiftsWorked} ");

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
