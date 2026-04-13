using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Snowfall
{
    public class IceSnowflake : Snowflake
    {
        public override double GetFallingSpeed()
        {
            double fallingSpeed = (Weight / Size) * 0.7;

            return fallingSpeed;
        }

        public override string GetTypeName()
        {
            return "Ice";
        }

        override public string ToString()
        {
            return $"Snowflake Type: Ice, Size: {Size:F2} mm, Weight: {Weight:F2} mg, Speed: {GetFallingSpeed():F3} m/s";
        }
    }
}
