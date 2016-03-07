using System;

class CalculateNK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long nFact = 1;
        long kFact = 1;

        for (int i = 2; i <= n; i++)
        {
            nFact *= i;
        }
        for (int j = 2; j <= k; j++)
        {
            kFact *= j;
        }

        Console.WriteLine("{0}", nFact / kFact);
    }
}