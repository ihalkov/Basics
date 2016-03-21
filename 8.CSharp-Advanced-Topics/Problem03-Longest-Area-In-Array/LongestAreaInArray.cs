using System;

class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());  // numbers
        string[] str = new string[n];// array of numbers
        
        for (int i = 0; i < str.Length; i++)
       {
            str[i] = Console.ReadLine();
        }
        int count = 1;
        string longest = str[0];
        int longestCount = count;
        for (int i = 1; i < str.Length; i++)
        {
            if (str[i] == str[i - 1])
            {
                count++;
            }
            if (str[i] != str[i - 1] || str[i] == str[str.Length - 1])
            {
                if (count > longestCount)
                {
                    longestCount = count;
                    longest = str[i - 1];
                    count = 1;
                }
            }
        }
        Console.WriteLine(longestCount);
        for (int i = 0; i < longestCount; i++)
        {
            Console.WriteLine("{0}", longest);
        }
    }
}