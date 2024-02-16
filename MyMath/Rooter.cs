using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMath
{
    public class Rooter
    {
        public double SquareRoot(double input)
        {
            if (input < 0.0)
            {
                throw new ArgumentOutOfRangeException(nameof(input), "Input must be non-negative");
            }

            double result = input;
            double previousResult = -input;

            while (Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = result - (result * result - input) / (2 * result);
            }

            return result;
        }
    }
}
// Path: MyMath/Rooter.cs
// Compare this snippet from TestProject1/UnitTest1.cs:
// AUTHOR : ARCAN CAGLAYAN STUDENT NUMBER : 301316211