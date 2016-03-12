using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 0)
        {
            n = 1;
        }
        int twoN = 2 * n;

        BigInteger twoNFact = 1;
        BigInteger nPlusOneFact = 1;
        BigInteger nFact = 1;

        for (int i = twoN; i >= 2; i--)
        {
            twoNFact *= i;
            if ((n + 1) >= i)
            {
                nPlusOneFact *= i;
            }
            if (n >= i)
            {
                nFact *= i;
            }
        }
        BigInteger catalan = twoNFact / (nPlusOneFact * nFact);
        Console.WriteLine(catalan);
    }
}