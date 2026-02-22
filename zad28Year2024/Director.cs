using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2024
{
    public class Director : ClubMember
    {
        private string directorType;

        public string DirectorType { get => directorType; set => directorType = value; }
        public Director(string firstName, string lastName, int age, decimal salary,string directorType)
            : base(firstName, lastName, age, salary)
        {
            DirectorType = directorType;
        }

        public override void Info()
        {
            Console.WriteLine($"{DirectorType} director: {FirstName} {LastName}");
            Console.WriteLine($"salary: {Salary:f2} lv");
            Console.WriteLine($"age: {Age} years");
        }
    }
}
