using System;
class RandomizeTheNumbersOneToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Random r = new Random();
        for (int i = 0; i < n; i++)
        {
            int elem = r.Next(1, n + 1);
            arr[i] = elem;
            for (int j = 0; j < n; j++)
            {
                if (arr[i] == arr[j] && i != j)
                {
                    arr[i] = 0;
                    i--;
                }
            }
        }
        foreach (var item in arr)
        {
            Console.Write("{0} ", item);
        }
    }
}