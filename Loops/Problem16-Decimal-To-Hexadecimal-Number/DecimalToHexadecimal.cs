using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        long dec = long.Parse(Console.ReadLine());  // decimal num
        string hex = "";

        do
        {
            long temp = dec % 16;
            switch (temp)
            {
                case 10:
                    hex += 'A';
                    break;
                case 11:
                    hex += 'B';
                    break;
                case 12:
                    hex += 'C';
                    break;
                case 13:
                    hex += 'D';
                    break;
                case 14:
                    hex += 'E';
                    break;
                case 15:
                    hex += 'F';
                    break;
                default:
                    hex += temp;
                    break;
            }
            dec /= 16;
        }
        while (dec > 0);
        string rightAns = "";
        for (int i = hex.Length - 1; i >= 0; i--)
        {
            rightAns += hex[i];
        }
        Console.WriteLine(rightAns);    // answer in hex
    }
}