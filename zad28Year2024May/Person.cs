using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2024May
{
    public class Person
    {
        private string lastName;
        private string firstName;
        private string id;

        public Person(string id, string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

       

        public string FirstName { get => firstName; set => firstName = value; }

        public string LastName { get => lastName; set => lastName = value; }

        public string Id
        {
            get => id; set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentException($"{FirstName} {LastName} - invalid identifier!");
                }
                id = value;
            }
        }
    }
}
