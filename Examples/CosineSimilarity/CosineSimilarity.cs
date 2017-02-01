using System;

namespace CosineSimilarity
{
    public sealed class CosineSimilarity
    {
        public double? Compute(double[] vectorA , double[] vectorB)
        {
            if (vectorA.Length != vectorB.Length)
            {
                return null;
            }

            var dotProduct = 0.0d;
            var preMagnitudeA = 0.0d;
            var preMagnitudeB = 0.0d;

            for (int i = 0 ; i < vectorA.Length ; i++)
            {
                var a = vectorA[i];
                var b = vectorB[i];
                var mult = a*b;
                dotProduct += mult;

                var aMag = Math.Pow(a, 2);
                preMagnitudeA += aMag;

                var bMag = Math.Pow(b, 2);
                preMagnitudeB += bMag;
            }

            var prodMagnitude = Math.Sqrt(preMagnitudeA*preMagnitudeB);
            var result = dotProduct/prodMagnitude;
            return result;
        }
    }
}
