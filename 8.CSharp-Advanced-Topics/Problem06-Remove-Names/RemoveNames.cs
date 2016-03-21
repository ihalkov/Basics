using System;
using System.Collections.Generic;
using System.Linq;
class RemoveNames
{
    static void Main()
    {
        List<string> fList = Console.ReadLine().Split().ToList();
        List<string> sList = Console.ReadLine().Split().ToList();

        for (int s = 0; s < sList.Count; s++)
        {
            for (int f = 0; f < fList.Count; f++)
            {
                if (fList.Contains(sList[s]))
                {
                    fList.Remove(sList[s]);
                }
            }
        }
        foreach (var item in fList)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}