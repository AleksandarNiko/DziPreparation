using System;
using System.Collections.Generic;
using System.Text;

namespace _06.zad28Year2023May
{
    public abstract class Furniture
    {
        private string typeProduct;
        private double productionPrice;

        protected Furniture(string typeProduct, double productionPrice)
        {
            TypeProduct = typeProduct;
            ProductionPrice = productionPrice;
        }

        public string TypeProduct { get => typeProduct; set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception($"Invalid input: {nameof(value)}"); 
                }
                typeProduct = value;
            } 
        }

        public double ProductionPrice { get => productionPrice; set
            {
                if (value<=0)
                {
                    throw new Exception($"Invalid input: {nameof(value)}");
                }
                productionPrice = value;
            }
        }

        public abstract double PriceClient();
    }
}
