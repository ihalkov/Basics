using System;
using System.Text.RegularExpressions;
class ExtractURLsFromText
{
    static void Main()
    {
        string text = "RR1234566-001";
        string regex = @"^([A-Z a-z]{2})(\d{7})(\-)(\d+)";
        Match mtch = Regex.Match(text, regex, RegexOptions.IgnoreCase);
        if (mtch.Success)
        {
            Console.WriteLine(mtch.Groups[1].Value);
            Console.WriteLine(mtch.Groups[2].Value);
            Console.WriteLine(mtch.Groups[3].Value);
        }
    }
}