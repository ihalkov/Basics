using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random r = new Random();    // random generator
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", r.Next(min, max + 1));
        }
    }
}