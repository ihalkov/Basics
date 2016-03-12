using System;

class CalculateGCD
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a < b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        int q = 0;
        int r = 0;
        do
        {
            q = a / b;
            r = a % b;  // remainder
            a = b;
            b = r;
        }
        while (b > 0);
        Console.WriteLine(a);
    }
   
    
}