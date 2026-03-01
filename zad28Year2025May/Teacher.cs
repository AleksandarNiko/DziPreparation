using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2025May
{
    public class Teacher : SchoolMember
    {
        private string specialty;
        private int studentsCount;
        private double salary;
        private double bonus;

        public Teacher(string name, int age, string specialty, int studentsCount, double salary, double bonus) : base(name, age)
        {
            Specialty = specialty;
            StudentsCount = studentsCount;
            Salary = salary;
            Bonus = bonus;
        }

        public string Specialty { get => specialty; set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Specialty cannot be an empty string!");
                }
                specialty = value;
            } }


        public int StudentsCount { get => studentsCount; set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("Students count cannot be negative!");
                }
                studentsCount = value;
            } }

        public double Salary { get => salary; set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("Salary cannot be a negative number!");
                }
                salary = value;
            } }

        public double Bonus { get => bonus; set => bonus = value; }

        public override void Info()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Teacher: {Name}, Age: {Age} years");
            sb.AppendLine($"Specialty: {Specialty}");
            sb.AppendLine($"Students count: {StudentsCount}");
            sb.AppendLine($"Salary: {Salary:f2} lv.");
            sb.AppendLine($"Bonus: {Bonus:f2} lv.");

            Console.WriteLine(sb.ToString());
        }
    }
}
