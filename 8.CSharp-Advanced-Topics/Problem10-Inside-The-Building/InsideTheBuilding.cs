using System;
using System.Collections.Generic;
class InsideTheBuilding
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        // input points
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        int x4 = int.Parse(Console.ReadLine());
        int y4 = int.Parse(Console.ReadLine());
        int x5 = int.Parse(Console.ReadLine());
        int y5 = int.Parse(Console.ReadLine());

        // answers
        Console.WriteLine(Answer(x1, y1, h));
        Console.WriteLine(Answer(x2, y2, h));
        Console.WriteLine(Answer(x3, y3, h));
        Console.WriteLine(Answer(x4, y4, h));
        Console.WriteLine(Answer(x5, y5, h));
    }
    static string Answer(int x, int y, int h)
    {
        // constrains
        string ans = "";
        if ((x >= 0 && x <= 3 * h) && (y >= 0 && y <= h))
        {
            ans = "inside";
            
        }
        else if ((x >= h && x <= 2 * h) && (y >= 0 && y <= 4 * h))
        {
            ans = "inside";
        }
        else
        {
            ans = "outside";
        }
        return ans;
    }
}