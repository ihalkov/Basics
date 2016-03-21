using System;
using System.Collections.Generic;
using System.Linq;
class JoinLists
{
    static void Main()
    {
        List<int> fList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> sList = Console.ReadLine().Split().Select(int.Parse).ToList();
        fList.AddRange(sList);  // join lists
        fList.Sort();
        for (int i = 0; i < fList.Count - 1;)
        {
            if (fList[i] == fList[i + 1])
            {
                fList.RemoveAt(i + 1);
            }
            else
            {
                i++;
            }
        }
        foreach (var item in fList)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}