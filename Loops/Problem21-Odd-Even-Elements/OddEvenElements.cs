using System;
using System.Linq;
using System.Collections.Generic;
class OddEvenElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] n = input.Split().ToArray();
        List<decimal> oddArr = new List<decimal>();
        List<decimal> evenArr = new List<decimal>();

        if (input == "")
        {
            n = new string[0];
        }
        if (n.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (n.Length == 1)
        {
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum=No, EvenMin=No, EvenMax=No",
                decimal.Parse(n[0]), decimal.Parse(n[0]), decimal.Parse(n[0]));
        }
        else
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddArr.Add(decimal.Parse(n[i]));
                }
                else
                {
                    evenArr.Add(decimal.Parse(n[i]));
                }
            }
            Console.WriteLine("OddSum={0:0.##}, OddMin={1:0.##}, OddMax={2:0.##}, EvenSum={3:0.##}, EvenMin={4:0.##}, EvenMax={5:0.##}",
            oddArr.Sum(), oddArr.Min(), oddArr.Max(), evenArr.Sum(), evenArr.Min(), evenArr.Max());
        }
        
    }
}