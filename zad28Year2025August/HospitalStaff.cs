using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2025August
{
    public abstract class HospitalStaff
    {
        private int age;
        private decimal salary;

        protected HospitalStaff(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public  string FirstName { get; set; }

        public  string LastName { get; set; }

        public int Age { get => age; set 
            {
                if(value<0)
                {
                    throw new ArgumentException("Age must be a positive number.");
                }
                age = value;
            } }

        public decimal Salary { get => salary; set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary must be a positive number!");
                }
                salary = value;
            }
        }

        public abstract void Info();
    }
}
