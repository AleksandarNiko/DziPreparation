using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2024
{
    public abstract class ClubMember
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public ClubMember(string firstName, string lastName, int age, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Salary = salary;
        }

        public string FirstName { get => firstName; set 
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The name can’t be an empty string!");
                }
                firstName = value;
            } 
        }

        public string LastName { get => lastName; set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The name can’t be an empty string!");
                }
                lastName  = value;
            }
        }

        public int Age { get => age; set
            {
                if (value<=17)
                {
                    throw new Exception("Age must be greater than 17 years!");
                }
                age = value;
            }
        }

        public decimal Salary { get => salary; set
            {
                if (value < 0)
                {
                    throw new Exception("Salary must be a positive number!");
                }
                salary = value;
            }
        }

        public abstract void Info();
    }
}
