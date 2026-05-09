using System;
using System.Collections.Generic;
using System.Text;

namespace _01.PostMarks
{
    public class StampCollector : Collector
    {
        private List<Stamp> stamps;
        public StampCollector(string name, double budget) : base(name, budget)
        {
            stamps = new List<Stamp>();
        }

        public override double CalculateSum()
        {
            return stamps.Count > 0 ? stamps.Sum(s => s.CalculatePrice()) : 0;
        }

        public void BuyStamp(Stamp stamp)
        {
            double price = stamp.CalculatePrice();

            if (price > Budget)
            {
                Console.WriteLine($"{price - Budget:F2} leva more to purchase the stamp {stamp.Name}.");
            }
            else
            {
                stamps.Add(stamp);
                Budget -= price;
                Console.WriteLine($"The stamp {stamp.Name} has been purchased. ");
            }
        }

        public List<string> GetStampsFromYear(int year)
        {
            List<string> stampsFromYear = new List<string>();
            foreach (var stamp in stamps)
            {
                if (stamp.Year == year)
                {
                    stampsFromYear.Add(stamp.Name);
                }
            }
            
            return stampsFromYear.OrderBy(s => s).ToList();
        }

        public string DescribeCollection()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The collector {Name} owns the following stamps:");
            foreach (var stamp in stamps)
            {
                sb.AppendLine(stamp.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
