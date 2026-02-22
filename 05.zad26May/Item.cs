using System;
using System.Collections.Generic;
using System.Text;

namespace _05.zad26May
{
    public class Item : IComparable
    {
        public  string Description { get; }

        public  decimal Price { get;}

        public Item(string description, decimal price)
        {
            if(string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Description cannot be null or empty.");
            }
            if (price < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }

            Description = description;
            Price = price;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)    
            {
                return 1;
            }

            if (obj is Item otherItem)
            {
                int descriptionComparison = string.Compare(this.Description, otherItem.Description, StringComparison.Ordinal);
                if (descriptionComparison != 0)
                {
                    return descriptionComparison;
                }
                else
                {
                    return this.Price.CompareTo(otherItem.Price);
                }
            }
            else
            {
                throw new ArgumentException("Object is not an Item.");
            }
        }

        override public string ToString()
        {
            return $"{Description} ({Price:f2})";
        }
    }
}
