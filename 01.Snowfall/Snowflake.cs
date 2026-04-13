using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Snowfall
{
    public abstract class Snowflake
    {
        public  double Size { get; set; }

        public  double Weight { get; set; }

        public abstract double GetFallingSpeed();

        public abstract string GetTypeName();

        public bool IsLarge()
        {
            if(Size>5.0)
            {
                return true;
            }

            return false;
        }

        override public string ToString()
        {
            return $"Size: {Size:F2} mm, Weight: {Weight:F2} mg";
        }
    }
}
