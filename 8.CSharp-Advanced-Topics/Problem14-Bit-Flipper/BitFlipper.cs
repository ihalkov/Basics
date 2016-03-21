using System;
using System.Collections.Generic;
class BitFlipper
{
    static void Main()
    {
        // ulong [0 … 18 446 744 073 709 551 615]
        ulong num = ulong.Parse(Console.ReadLine());    // input
        string str = DecimalToBinary(num);  // binary representation of input
        int trailZeroes = 64 - str.Length;
        List<int> binary = new List<int>();
        for (int i = 0; i < trailZeroes; i++)
        {
            binary.Add(0);
        }
        for (int i = trailZeroes; i < str.Length + trailZeroes; i++)
        {
            binary.Add(str[i - trailZeroes] - 48);
        }
        int cnt = 1; // three equal bits
        for (int i = 0; i < binary.Count - 1; i++)
        {
            if (binary[i] == binary[i + 1])
            {
                cnt++;
                if (cnt == 3)
                {
                    if (binary[i] == 1)
                    {
                        binary[i - 1] = 0;
                        binary[i] = 0;
                        binary[i + 1] = 0;
                        i++;
                    }
                    else
                    {
                        binary[i - 1] = 1;
                        binary[i] = 1;
                        binary[i + 1] = 1;
                        i++;
                    }
                    cnt = 1;
                }
            }
            else
            {
                cnt = 1;
            }
        }
        str = "";
        for (int i = 0; i < binary.Count; i++)
        {
            str += binary[i];
        }
        Console.WriteLine(BinaryToDecimal(str));
    }

    static string DecimalToBinary(ulong num)    // method
    {
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
        return rightAns;
    }

    static ulong BinaryToDecimal(string str)
    {
        char ch = 'a';
        int tempNum = 0;
        ulong answer = 0;
        for (int i = 0; i < str.Length; i++)
        {
            ch = str[i];
            tempNum = (int)ch - 48;
            answer += (ulong)tempNum * (ulong)Math.Pow(2, (str.Length - i - 1));
        }
        return answer;
    }
}