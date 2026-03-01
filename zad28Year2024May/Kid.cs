using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2024May
{
    public class Kid : Person
    {
        private int age;
        private string group;
        private string group1;

        public Kid(string id, string firstName, string lastName, int age, string parentLastName, string parentGSM)
            : base(id, firstName, lastName)
        {

            Age = age;
            switch (age)
            {
                case 3:
                    Group = "I";
                    break;
                case 4:
                    Group = "II";
                    break;
                case 5:
                    Group = "III";
                    break;
                case 6:
                    Group = "IV";
                    break;
            }
            ParentLastName = parentLastName;
            ParentGSM = parentGSM;

        }

        public int Age
        {
            get => age; set
            {
                if (value < 3 || value > 6)
                {
                    throw new ArgumentException($"The child {FirstName} {LastName} age is invalid - {value}");
                }
                age = value;
            }
        }

        public string Group
        {
            get => group; set => group = value;
        }

        public string ParentLastName { get; set; }

        public string ParentGSM { get; set; }

        override public string ToString()
        {
            return $"{FirstName} {LastName}, {Age}, {ParentGSM} {ParentLastName})";
        }
    }
}
