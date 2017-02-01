using System;

namespace CosineSimilarity
{
    class Program
    {
        static void Main(string[] args)
        {
            var vectorA = new double[] { 5, 0, 3, 0, 2, 0, 0, 2, 0, 0 };
            var vectorB = new double[] { 3, 0, 2, 0, 1, 1, 0, 1, 0 ,1};
            var cosineSimilarity = new CosineSimilarity();

            var result = cosineSimilarity.Compute(vectorA, vectorB);
            Console.WriteLine($"Cosine Similarity : {result} or {result * 100} %");

            Console.ReadKey();
        }
    }
}
