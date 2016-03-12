using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int [n, n]; // row, cols
        int rowLength = matrix.GetLength(0);
        int colLength = matrix.GetLength(1);
        string direction = "right";
        int count = 1;
        // right [0, 0]
        int row = 0;
        int col = 0;

        while (count <= n * n)  // count n * n - > numbers
        {
            // directions: right to down, down to left, left to up, up to right...
            if (direction == "right")
            {
                for (int right = col; right < n; right++)
                {
                    if (matrix[row, right] == 0)
                    {
                        matrix[row, right] = count;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    col = right;
                }
                direction = "down";
            }
            if (direction == "down")
            {
                for (int down = row + 1; down < n; down++)
                {
                    if (matrix[down, col] == 0)
                    {
                        matrix[down, col] = count;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    row = down;
                }
                direction = "left";
            }
            if (direction == "left")
            {
                for (int left = col - 1; left >= 0; left--)
                {
                    if (matrix[row, left] == 0)
                    {
                        matrix[row, left] = count;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    col = left;
                }
                direction = "up";
            }
            if (direction == "up")
            {
                for (int up = row - 1; up >= 0; up--)
                {
                    if (matrix[up, col] == 0)
                    {
                        matrix[up, col] = count;
                        count++;
                    }
                    else
                    {
                        break;
                    }
                    row = up;
                }
                direction = "right";
                col++;
            }
        }

        // print spiral matrix
        for (row = 0; row < rowLength; row++)
        {
            for (col = 0; col < colLength; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
                if (matrix[row, col] < 10)
                {
                    Console.Write("  ");
                }
                else if (matrix[row, col] < 100)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();    
            Console.WriteLine();    // for beauty view
        }
    }
}