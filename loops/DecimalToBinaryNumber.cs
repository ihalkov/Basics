using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long num = long.Parse(Console.ReadLine());  // decimal num
        string ans = "";

        do
        {
            ans += num % 2;
            num /= 2;
        }
        while (num > 0);
        string rightAns = "";
        for (int i = ans.Length - 1; i >= 0; i--)
        {
            rightAns += ans[i];
        }
        Console.WriteLine(rightAns);    // answer in binary
    }
}