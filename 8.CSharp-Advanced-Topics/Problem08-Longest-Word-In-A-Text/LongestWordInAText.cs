using System;
using System.Collections.Generic;
using System.Linq;
class LongestWordInAText
{
    static void Main()
    {
        List<string> text = Console.ReadLine().Split().ToList();
        int maxL = 0;
        string longestWord = "";
        char[] trimChars = new char[] { '?', '!', ',', '.', '1', '$', '%', '#', 's' };
        // move in list
        for (int l = 0; l < text.Count; l++)
        {
            if (text[l].Length > maxL)
            {
                maxL = text[l].Length;
                longestWord = text[l].Trim(trimChars);
            }
        }
        Console.WriteLine(longestWord);
    }
}