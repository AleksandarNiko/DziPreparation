using System;
using System.Collections.Generic;
using System.Text;

namespace _06.zad28Year2023May
{
    public class Table : Furniture
    {
        public Table(string typeProduct, double productionPrice) 
            : base(typeProduct, productionPrice)
        {
        }

        public override double PriceClient()
        {
            return base.ProductionPrice + (0.20 * base.ProductionPrice);
        }

        public override string ToString() 
        {
            return $"The table costs {PriceClient():f2} lv.";
        }
    }
}
