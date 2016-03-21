using System;
using System.Collections.Generic;
class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());              // length of DNA
        char startLetter = char.Parse(Console.ReadLine());  // start char

        char[,] matrix = new char[n, 7];
        int rowLength = matrix.GetLength(0);
        int colLength = matrix.GetLength(1);
        // constrains [2, 3, 4]
        int start = 3;
        int end = 3;
        int count = 1;
        // solution
        for (int row = 0; row < rowLength; row++)
        {
            for (int col = 0; col < colLength; col++)
            {
                if (col >= start && col <= end)
                {
                    matrix[row, col] = startLetter;
                    if (startLetter == 'G')
                    {
                        startLetter = 'A';
                        continue;
                    }
                    startLetter++;
                }
                else
                {
                    matrix[row, col] = '.';
                }
            }
            count++;
            if (count <= 4)
            {
                start--;
                end++;
            }
            if (count > 4)
            {
                start++;
                end--;
            }
            if (count == 8)
            {
                count = 1;
                start = 3;
                end = 3;
            }
        }
        // print DNA
        for (int row = 0; row < rowLength; row++)
        {
            for (int col = 0; col < colLength; col++)
            {
                Console.Write("{0}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}