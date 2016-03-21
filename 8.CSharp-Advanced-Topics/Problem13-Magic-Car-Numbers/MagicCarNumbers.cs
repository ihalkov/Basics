using System;

class MagicCarNumbers
{
    static void Main()
    {
        int magicWeight = int.Parse(Console.ReadLine());
        char[] letters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        int count = 0;
        for (int a = 0; a <= 9; a++)
        {
            for (int b = 0; b <= 9; b++)
            {
                for (int c = 0; c <= 9; c++)
                {
                    for (int d = 0; d <= 9; d++)
                    {
                        for (int x = 0; x < letters.Length; x++)
                        {
                            for (int y = 0; y < letters.Length; y++)
                            {
                                int sum = 40;   // C = 30, A = 10
                                    sum += a + b + c + d;
                                int temp = LettersWeight(letters[x]);
                                temp += LettersWeight(letters[y]);
                                sum += temp;
                                if (sum == magicWeight)
                                {
                                    if ((a == b) && (b == c) && (c == d))       // CAaaaaXY
                                    {
                                        count++;
                                    }
                                    else if ((a != b) && (b == c) && (c == d))  // CAabbbXY
                                    {
                                        count++;
                                    }
                                    else if ((a == b) && (b == c) && (c != d))  // CAaaabXY
                                    {
                                        count++;
                                    }
                                    else if ((a == b) && (b != c) && (c == d))  // CAaabbXY
                                    {
                                        count++;
                                    }
                                    else if ((a == c) && (b == d) && (a != b))  // CAababXY
                                    {
                                        count++;
                                    }
                                    else if ((a == d) && (b == c) && (a != b))  // CAabbaXY
                                    {
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
    static int LettersWeight(char letter)
    {
        int temp = 0;
        switch (letter)
        {
            case 'A':
                temp = 10;
                break;
            case 'B':
                temp = 20;
                break;
            case 'C':
                temp = 30;
                break;
            case 'E':
                temp = 50;
                break;
            case 'H':
                temp = 80;
                break;
            case 'K':
                temp = 110;
                break;
            case 'M':
                temp = 130;
                break;
            case 'P':
                temp = 160;
                break;
            case 'T':
                temp = 200;
                break;
            case 'X':
                temp = 240;
                break;
            default:
                break;
        }
        return temp;
    }
}