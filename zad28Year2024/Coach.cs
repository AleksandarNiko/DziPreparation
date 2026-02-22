using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2024
{
    public class Coach : ClubMember
    {
        private string coachType;
        private int contractLength;

        public string CoachType { get => coachType; set => coachType = value; }

        public int ContractLength { get => contractLength; set => contractLength = value; }
        public Coach(string firstName, string lastName, int age, decimal salary, string coachType, int contractLength) 
            : base(firstName, lastName, age, salary)
        {
            CoachType = coachType;
            ContractLength = contractLength;
        }

        public override void Info()
        {
            Console.WriteLine($"{CoachType} coach: {FirstName} {LastName}");
            Console.WriteLine($"salary: {Salary:f2} lv");
            Console.WriteLine($"age: {Age} years");
        }
    }
}
