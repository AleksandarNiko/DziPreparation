using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Snowfall
{
    public class FluffySnowflake : Snowflake
    {
        public override double GetFallingSpeed()
        {
            double fallingSpeed = (Weight / (Size * 2)) * 0.3;

            return fallingSpeed;
        }

        public override string GetTypeName()
        {
            return "Fluffy";
        }

        public override string ToString()
        {
            return $"Snowflake Type: Fluffy, Size: {Size:F2} mm, Weight: {Weight:F2} mg, Speed: {GetFallingSpeed():F3} m/s";
        }
    }
}
