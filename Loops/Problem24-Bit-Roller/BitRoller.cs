using System;
using System.Collections.Generic;
class BitRoller
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine()); // freezed bit
        int r = int.Parse(Console.ReadLine()); // rolls

        int nineteenBit = 19;   // how bit is a number
        int bitAtPositionF = nineteenBit - f - 1;
        string nToBinary = DecimalToBinary(n, nineteenBit);
        List<int> binary = new List<int>();
        for (int i = 0; i < nToBinary.Length; i++)  // from string to List<int>
        {
            binary.Add(nToBinary[i] - 48);
        }
        List<int> temp = new List<int>(binary); // temp list for add new values in exact positions
        // roll binary to right
        for (int i = 0; i < r; i++) // whole process roll "r" times
        {
            binary = new List<int>(temp);
            int last = binary[nineteenBit - 1];
            int beforeLast = binary[nineteenBit - 2];
            for (int j = 1; j < nineteenBit; j++)
            {
                // stay freezed bit on position
                if (j == bitAtPositionF)
                {
                    temp[j] = binary[bitAtPositionF];
                    continue;
                }
                if (j == bitAtPositionF + 1)
                {
                    if (bitAtPositionF - 1 < 0)
                    {
                        temp[j] = binary[nineteenBit - 1];
                    }
                    else
                    {
                        temp[j] = binary[bitAtPositionF - 1];
                    }
                    continue;
                }
                // normal
                temp[j] = binary[j - 1];
            }
            if (f == 0)
            {
                temp[0] = beforeLast;
            }
            else if (f == 18)
            {
                temp[1] = last;
            }
            else
            {
                temp[0] = last;
            }
        }
        string ans = "";
        foreach (var item in temp)
        {
            ans += item;
        }
        BinaryToDecimal(ans);
    }

    static long BinaryToDecimal(string str)
    {
        char ch = 'a';
        int tempNum = 0;
        long answer = 0;
        for (int i = 0; i < str.Length; i++)
        {
            ch = str[i];
            tempNum = (int)ch - 48;
            answer += tempNum * (long)Math.Pow(2, (str.Length - i - 1));
        }
        Console.WriteLine(answer);
        return answer;
    }

    static string DecimalToBinary(long num, int nineteenBit)
    {
        string ans = "";

        do
        {
            ans += num % 2;
            num /= 2;
        }
        while (num > 0);
        int length = nineteenBit - ans.Length;
        for (int i = 0; i < length; i++)
        {
            ans += 0;
        }
        string rightAns = "";
        for (int i = ans.Length - 1; i >= 0; i--)
        {
            rightAns += ans[i];
        }
        return rightAns;
    }
}