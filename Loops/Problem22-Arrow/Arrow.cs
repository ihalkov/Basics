using System;

class Arrow
{
    static void Main()
    {
        // odd number
        int n = int.Parse(Console.ReadLine());
        int size = n + (n - 1);
        char markArrow = '#';
        char markRest = '.';

        int[,] picture = new int[size, size];

        int beginBodyWidth = (n - 1) / 2;    // 2
        int endBodyWidth = beginBodyWidth + (n - 1);  // 6
        int endBodyHeight = size - n;
        // arrow head
        int arrowHeadBegin = 1;
        int arrowHeadEnd = size - 2;
        int rowHead = (size / 2) + 1;
        for (int row = 0; row < picture.GetLength(0); row++)
        {
            for (int col = 0; col < picture.GetLength(1); col++)
            {
                // arrow
                if (row >= 0 && row < endBodyHeight)
                {
                    if (row == 0 && (col >= beginBodyWidth && col <= endBodyWidth))
                    {
                        Console.Write(markArrow);
                    }
                   else if ((row >= 1 && row < endBodyHeight) && (col == beginBodyWidth || col == endBodyWidth))
                    {
                        Console.Write(markArrow);
                    }
                    else
                    {
                        Console.Write(markRest);
                    }
                }
                if (row == size / 2)
                {
                    if ((col >= 0) && (col <= beginBodyWidth) || (col >= endBodyWidth && col < size))
                    {
                        Console.Write(markArrow);
                    }
                    else
                    {
                        Console.Write(markRest);
                    }
                }
                if (row > size / 2)
                {
                    if (col == arrowHeadBegin || col == arrowHeadEnd)
                    {
                        Console.Write(markArrow);
                    }
                    else
                    {
                        Console.Write(markRest);
                    }
                }
            }
            if (row > size / 2)
            {
                arrowHeadBegin++;
                arrowHeadEnd--;
            }
            Console.WriteLine();
        }
    }
}