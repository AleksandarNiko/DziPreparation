using System;
using System.Collections.Generic;
using System.Text;

namespace _03.zad28Year2023
{
    public class Rally
    {
        private List<Pilot> pilots;

        public  string Name { get; set; }
        public int Year { get; set; }

        public Rally(string name, int year)
        {
            pilots = new List<Pilot>();
            Name = name;
            Year = year;
        }

        public void AddPilot(Pilot p)
        {
            pilots.Add(p);
        }

        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rally: {Name} - Year: {Year}");
            foreach (var pilot in pilots)
            {
                sb.AppendLine(pilot.ToString());
            }
            return sb.ToString();
        }
    }
}
