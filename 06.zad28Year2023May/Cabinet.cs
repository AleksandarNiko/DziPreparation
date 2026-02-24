using System;
using System.Collections.Generic;
using System.Text;

namespace _06.zad28Year2023May
{
    public class Cabinet : Furniture
    {
        private int numberOfHinges;
        public Cabinet(string typeProduct, double productionPrice, int numberOfHinges)
            : base(typeProduct, productionPrice)
        {
            this.NumberOfHinges = numberOfHinges;
        }

        public int NumberOfHinges { get => numberOfHinges; set 
            {
                if (value < 0)
                {
                    throw new Exception($"Invalid value: {nameof(value)}");
                }
                numberOfHinges = value;
            } }

        public override double PriceClient()
        {
            return (base.ProductionPrice + (0.15 * base.ProductionPrice)) + (NumberOfHinges * 4.50);
        }

        public override string ToString()
        {
            return $"The cabinet costs {PriceClient():f2} lv.";
        }
    }
}
