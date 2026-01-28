using System;
using System.Collections.Generic;
using System.Text;

namespace _02.zad26Year2022
{
    public class Human
    {
        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public  string FirstName { get; private set; }

        public string LastName { get; private set; }

        public  int  Age { get; private set; }


        override public string ToString()
        {
            return $"{FirstName} {LastName}, {Age} years old";
        }

    }
}
