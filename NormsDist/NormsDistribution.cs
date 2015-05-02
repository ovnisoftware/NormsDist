using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormsDist
{
    public static class NormsDistribution
    {
        //This is a conversion of the NORMSDIST() function from Excel.  The x value represents the z value and the function
        //converts it into a percentage.  3 standard deviations is 99.86% so NORMSDIST(3) returns .9986...
        public static double N(double x)
        {
            const double b1 = 0.319381530;
            const double b2 = -0.356563782;
            const double b3 = 1.781477937;
            const double b4 = -1.821255978;
            const double b5 = 1.330274429;
            const double p = 0.2316419;
            const double c = 0.39894228;

            if (x >= 0.0)
            {
                double t = 1.0 / (1.0 + p * x);
                return (1.0 - c * Math.Exp(-x * x / 2.0) * t * (t * (t * (t * (t * b5 + b4) + b3) + b2) + b1));
            }
            else
            {
                double t = 1.0 / (1.0 - p * x);
                return (c * Math.Exp(-x * x / 2.0) * t * (t * (t * (t * (t * b5 + b4) + b3) + b2) + b1));
            }
        }
    }
    ////Call this from Program.cs to test
    //Console.WriteLine(NormsDistribution.N(3));
}