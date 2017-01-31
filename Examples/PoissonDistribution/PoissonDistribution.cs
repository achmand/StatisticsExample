using System;

namespace PoissonDistribution
{
    public enum PoissonFunctionType
    {
        Mass,
        Cumulative
    }

    public sealed class PoissonDistribution
    {
        private decimal Lambda { get; }

        public PoissonDistribution(decimal lambda)
        {
            Lambda = lambda;
        }

        public decimal Compute(int k, PoissonFunctionType type)
        {
            switch (type)
            {
                case PoissonFunctionType.Mass:
                    var initial = k;
                    var result = 0.0M;
                    while (initial >= 0)
                    {
                        result += MassFunction(initial);
                        initial--;
                    }
                    return result;
            }

            return 0;
        }

        // Probability mass function
        private decimal MassFunction(int k)
        {
            var factorial = Factorial(k); // Gets factorial 
            var a = (Math.Pow((double)Lambda, k)) * (Math.Pow(Math.E, (double)-Lambda));
            var result = (decimal)a / factorial;
            return result;
        }

        // Computes factorial 
        private static int Factorial(int k)
        {
            var initial = k;
            var factorial = 1;

            while (initial >= 1)
            {
                factorial = factorial * initial;
                initial--;
            }
            return factorial;
        }
    }
}
