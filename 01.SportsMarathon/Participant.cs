using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _01.SportsMarathon
{
    public class Participant
    {
        private string name;
        private string country;
        private string ageGroup;
        private int time;

        public string Name { get => name; set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                name = value;
            } 
        }

        public string Country { get => country; set 
            {
                if(string.IsNullOrEmpty(value) || value.Length!=3)
                {
                    throw new ArgumentException("Country must be a valid 3-letter code.");
                }
                country = value;
            } }

        public string AgeGroup { get => ageGroup; set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Age group cannot be null or empty.");
                } ageGroup = value;
            } }

        public int Time { get => time; set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("Time cannot be negative.");
                } time = value;
            } }


    }
}
