using System;
using System.Numerics;
class TrailingZeroesInNFact
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;

        for (int i = 2; i <= n; i++)
        {
            nFact *= i;
        }
        int countZeroes = 0;
        while (nFact % 10 == 0)
        {
            nFact /= 10;
            countZeroes++;
        }
        Console.WriteLine(countZeroes);
    }
}