using System;
using System.Collections.Generic;
using System.Text;

namespace _03.zad28Year2023
{
    public class Car
    {
        private string brand;
        private int hPower;

        public Car(string brand, int hPower)
        {
            Brand = brand;
            HPower = hPower;
        }

        public string Brand { get => brand; set => brand = value; }

        public int HPower { get => hPower; set => hPower = value; }

        override public string ToString()
        {
            return $"{Brand},{HPower}";
        }
    }
}
