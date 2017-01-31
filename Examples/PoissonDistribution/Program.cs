using System;

namespace PoissonDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *

            ----------------------
            Poisson Distribution:
            ----------------------
            Suppose that we can expect some independent event to occur '^' times over 
            a specified time interval. The probability of exactly 'x' occurances is equal to: https://wikimedia.org/api/rest_v1/media/math/render/svg/c3aa61d2a6d2e549fba969b4cfb923e5f612356a (Formula)

            MORE INFO: https://en.wikipedia.org/wiki/Poisson_distribution
                          
             * 
             */

            /*
            
            Suppose a fast food restaurant can expect 2 customers every 3 minutes, on avg. 
            What is the probability that four or fewer patrons will enter the restaurant in a 9 minute period ?                       

            = 6 customers in 9 minutes (^)
             
            => P(0) + P(1) + P(2) + P(3) + P(4)
             */

            var poissonDistibution = new PoissonDistribution(6);
            var result = poissonDistibution.Compute(4,PoissonFunctionType.Mass);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
