using System;
class BinaryToDecimalNumber
{
    static void Main()
    {
        string str = Console.ReadLine();
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
    }
}