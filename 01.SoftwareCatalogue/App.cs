using System;
using System.Collections.Generic;
using System.Text;

namespace _01.SoftwareCatalogue
{
    public class App
    {
        private string name;
        private string category;
        private double rating;
        private int downloads;
        private decimal price;

        public string Name { get => name; set 
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                name = value;
                
            } 
        }

        public string Category { get => category; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                category = value;

            }
        }

        public double Rating { get => rating; set 
            {
                if(value < 1 || value > 5)
                {
                    throw new ArgumentException("Rating must be between 0 and 5.");
                }
                rating = value;
            } 
        }

        public int Downloads { get => downloads; set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Downloads must be a positive number.");
                }
                downloads = value;
            }
        }

        public decimal Price { get => price; set => price = value; }
    }
}
