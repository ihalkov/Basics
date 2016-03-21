using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());  // num of rows
        int c = int.Parse(Console.ReadLine());  // num of columns
        char chRow = 'a';
        char chCol = 'a';
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                Console.Write("{0}{1}{0} ", chRow, chCol);
                chCol++;
            }
            Console.WriteLine();
            chRow++;
            chCol = chRow;
        }
    }
}