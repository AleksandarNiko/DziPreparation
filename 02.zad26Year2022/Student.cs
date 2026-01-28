using System;
using System.Collections.Generic;
using System.Text;

namespace _02.zad26Year2022
{
    public class Student : Human
    {
        public Student(string firstName, string lastName, int age, double grade)
            : base(firstName, lastName, age)
        {
            Grade = grade;
        }

        public double Grade { get; private set; }

        override public string ToString()
        {
            return $"{base.ToString()}, grade: {Grade:f2}";
        }
    }
}
