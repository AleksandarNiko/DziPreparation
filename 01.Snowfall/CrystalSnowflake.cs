using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Snowfall
{
    public class CrystalSnowflake : Snowflake
    {
        public override double GetFallingSpeed()
        {
            double fallingSpeed = (Weight / Size) * 0.4;

            return fallingSpeed;
        }

        public override string GetTypeName()
        {
            return "Crystal";
        }

        public override string ToString()
        {
            return $"Snowflake Type: Crystal, Size: {Size:F2}  mm, Weight:  {Weight:F2}  mg, Speed:  {GetFallingSpeed():F3} m/s";
        }
    }
}
