using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace _02.Lunapark
{
    public class LunaPark
    {
        private List<Attraction> attractions;
        private string name;

        public LunaPark()
        {
            attractions = new List<Attraction>();
        }

        public string Name { get => name; set => name = value; }

        public void AddAttraction(Attraction attraction)
        {
            attractions.Add(attraction);
        }

        public void RemoveAttraction(string name)
        {
            Attraction? attractionToRemove = attractions
                .Find(a => a.Name == name);

            if (attractionToRemove != null)
            {
                attractions.Remove(attractionToRemove);
                Console.WriteLine($"Attraction removed: {name}");
            }
            else
            {
                Console.WriteLine("Attraction not found!");
            }
        }

        public int CountOlderThan10(int currentYear)
        {
            return attractions.Count(a => a.CalculateDepreciation(currentYear) > 10);
        }

        public List<string> GetKidsAttractionsSorted()
        {
            List<string> kidsAttractions = attractions
                .Where(a => a.IsForKids)
                .Select(a => a.Name)
                .OrderBy(name => name)
                .ToList();

            return kidsAttractions;
        }

        public Attraction GetMostExpensiveAttraction()
        {
            if (attractions.Count == 0)
            {
                return null;
            }
            Attraction mostExpensive = attractions[0];
            foreach (Attraction attraction in attractions)
            {
                if (attraction.Price > mostExpensive.Price)
                {
                    mostExpensive = attraction;
                }
            }
            return mostExpensive;
        }

        public double GetTotalIncomeIfAllUsedOnce()
        {
            return attractions.Sum(a => a.Price);
        }

        public void ShowAll()
        {
            if (attractions.Count == 0)
            {
                Console.WriteLine("No attractions available.");
                return;
            }
            else
            {
                Console.WriteLine("All attractions:");
                foreach (Attraction attraction in attractions)
                {
                    Console.WriteLine(attraction.ToString());
                }
            }

        }

        public Attraction GetByName(string name)
        {
            return attractions.Find(a => a.Name == name);
        }
}
