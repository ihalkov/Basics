using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hex = Console.ReadLine();
        long dec = 0;

        char ch = 'a';
        int tempNum = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            ch = hex[i];
            tempNum = (int)ch - 48;
            switch (ch)
            {
                case 'A':
                    tempNum = 10;
                    break;
                case 'B':
                    tempNum = 11;
                    break;
                case 'C':
                    tempNum = 12;
                    break;
                case 'D':
                    tempNum = 13;
                    break;
                case 'E':
                    tempNum = 14;
                    break;
                case 'F':
                    tempNum = 15;
                    break;
            }
            dec += tempNum * (long)Math.Pow(16, (hex.Length - i - 1));
        }
        Console.WriteLine(dec);
    }
}