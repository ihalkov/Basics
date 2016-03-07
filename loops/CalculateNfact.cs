using System;
using System.Numerics;
class CalculateNfact
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        for (int i = n; i > 1; i--)
        {
            factorial *= i;
        }
        Console.WriteLine("{0}", factorial);
    }
}
