using System;
using System.Numerics;
class Combinatorics
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int nMinusK = n - k;
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger nMinusKFact = 1;

        for (int i = n; i >= 2; i--)
        {
            nFact *= i;
            if (i <= k)
            {
                kFact *= i;
            }
            if (i <= nMinusK)
            {
                nMinusKFact *= i;
            }
        }
        double combinations = (double)nFact / (double)(kFact * nMinusKFact);
        Console.WriteLine(combinations);
    }
}