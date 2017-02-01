using System;

namespace CosineSimilarity
{
    class Program
    {
        static void Main(string[] args)
        {
            var vectorA = new double[] { 0, 0, 3,4,0};
            var vectorB = new double[] {4,3,0,2,0};
            var cosineSimilarity = new CosineSimilarity();

            var result = cosineSimilarity.Compute(vectorA, vectorB);
            Console.WriteLine($"Cosine Similarity : {result} or {result * 100} %");

            Console.ReadKey();
        }
    }
}
