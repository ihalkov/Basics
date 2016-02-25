using System;

class CalculateFormula
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double s = 1;
        int factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            s += factorial / Math.Pow(x, i);
        }
        Console.WriteLine("{0:F5}", s);
    }
}
