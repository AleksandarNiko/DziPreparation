using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Snowfall
{
    public class Snowfall
    {
        private List<Snowflake> snowflakes;

        public Snowfall()
        {
            snowflakes = new List<Snowflake>();
        }

        public void AddSnowflake(Snowflake snowflake)
        {
            snowflakes.Add(snowflake);
        }

        public int GetSnowflakeCount()
        {
            return snowflakes.Count;
        }

        public double GetSnowflakesPerSquareMeter(double area)
        {
            return GetSnowflakeCount() / area;
        }

        public string GetIntensity(double area)
        {
            double snowflakesPerSquareMeter = GetSnowflakesPerSquareMeter(area);
            if (snowflakesPerSquareMeter <= 50)
            {
                return "Light";
            }
            else if (snowflakesPerSquareMeter >= 51 ||
                snowflakesPerSquareMeter <= 150)
            {
                return "Normal";
            }
            else
            {
                return "Heavy";
            }
        }

        public double GetAverageFallingSpeed()
        {
            double sum = snowflakes.Sum(s => s.GetFallingSpeed());

            return sum / GetSnowflakeCount();
        }

        public Snowflake GetFastestSnowflake()
        {
            if(!snowflakes.Any())
            {
                return null;
            }
            else
            {
                var fastestSnowflake = snowflakes
                    .OrderByDescending(s=>s.GetFallingSpeed())
                    .FirstOrDefault();

                return fastestSnowflake;
            }
        }

        public void GetSnowflakes()
        {
            foreach (var snowflake in snowflakes)
            {
                Console.WriteLine(snowflake.ToString());
            }
        }
    }
}
