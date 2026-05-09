using System;
using System.Collections.Generic;
using System.Text;

namespace _01.VideoGames
{
    public class Game
    {
        private string title;
        private int releaseYear;
        private int rating;

        public Game(string title, int releaseYear, int rating)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Rating = rating;
        }

        public string Title { get => title; set => title = value; }
        public int ReleaseYear { get => releaseYear; set 
            {
                if(value<1970 || value>2025)
                {
                    throw new ArgumentException("Year must be between 1970 and 2025.");
                }
                releaseYear = value;
            } 
        }

        public int Rating { get => rating; set 
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException("Rating must be between 1 and 10.");
                }
                rating = value;
            } }

        public double CalculatePrice()
        {
            double price = Rating * (2025 - ReleaseYear) * 2.1;
            return price;
        }

        override public string ToString()
        {
            return $"The {ReleaseYear} game {Title} with rating {Rating} has a price of {CalculatePrice():F2}"; 
        }

    }
}
