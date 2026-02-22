using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2024
{
    public class FootballPlayer : ClubMember
    {
        public  string Position { get; set; }
        public  int ContractLength { get; set; }

        public  int Matches { get; set; }

        public  int Goals { get; set; }

        public int Assist { get; set; }

        public FootballPlayer(string firstName, string lastName, int age, decimal salary, string position, int contractLength, int matches, int goals, int assist) 
            : base(firstName, lastName, age, salary)
        {
            Position = position;
            ContractLength = contractLength;
            Matches = matches;
            Goals = goals;
            Assist = assist;
        }

        public override void Info()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Position}");
            Console.WriteLine($"salary: {Salary} lv");
            Console.WriteLine($"age: {Age} years");
            Console.WriteLine($"{Goals} goals and {Assist} assists in {Matches} matches");
        }
    }
}
