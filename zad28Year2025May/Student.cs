using System;
using System.Collections.Generic;
using System.Text;

namespace zad28Year2025May
{
    public class Student : SchoolMember
    {
        private string instrument;
        private int practiceHours;

        public Student(string name, int age, string instrument, int practiceHours) 
            : base(name, age)
        {
            Instrument = instrument;
            PracticeHours = practiceHours;
        }

        public string Instrument { get => instrument; set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Instrument cannot be an empty string!");
                }
                instrument = value;
            } }

        public int PracticeHours { get => practiceHours; set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("Practice hours must be a positive number!");
                }
                practiceHours = value;
            } }

        public override void Info()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Student: {Name}, Age: {Age} years");
            sb.AppendLine($"Instrument: {Instrument}");
            sb.AppendLine($"Practice Hours: {PracticeHours} per week");

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
