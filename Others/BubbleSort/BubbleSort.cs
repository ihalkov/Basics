using System;
using System.Collections.Generic;
class BubbleSort
{
    static void Main()
    {
        int[] bubble = { 2, 3, 4, 5, 1 };
        int count = 0;
        do
        {
            count = 0;
            for (int i = 0; i < bubble.Length - 1; i++)
            {
                if (bubble[i] > bubble[i + 1])
                {
                    bubble[i] = bubble[i] + bubble[i + 1];  //7 = 4 + 3
                    bubble[i + 1] = bubble[i] - bubble[i + 1];  //      7 - 3 = 4
                    bubble[i] = bubble[i] - bubble[i + 1];   // 7 - 4 = 3
                }
                else
                {
                    count++;
                }
            }
        } while (count < bubble.Length - 1);
        foreach (var item in bubble)
        {
            Console.Write("{0}", item);
        }
        Console.WriteLine();
    }
}