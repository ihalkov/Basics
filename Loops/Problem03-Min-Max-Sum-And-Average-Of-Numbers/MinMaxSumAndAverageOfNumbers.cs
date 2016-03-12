using System;

class MinMaxSumAndAverageOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int temp = 0;
        int sum = 0;
        double average = 0;
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            temp = int.Parse(Console.ReadLine());
            sum += temp;
            if (temp < min)
            {
                min = temp;
            }
            if (temp > max)
            {
                max = temp;
            }
        }
        if (min > max)
        {
            max = min + max;
            min = max - min;
            max = max - min;
        }
        average = (double)sum / n;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("average = {0:F2}", average);
    }
}