using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2025May
{
    public abstract class SchoolMember
    {
        private string name;
        private int age;

        protected SchoolMember(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set 
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be an empty string!");
                }
                name = value;
            } }

        public int Age { get => age; set 
            {
                if (value <= 5)
                {
                    throw new ArgumentException("Age must be greater than 5 years!");
                }
                age = value;
            } }

        public abstract void Info();
    }
}
