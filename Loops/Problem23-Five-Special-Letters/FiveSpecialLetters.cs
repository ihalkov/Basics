using System;
using System.Collections.Generic;
class FiveSpecialLetters
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int numOfLetters = 5;
        List<string> letters = new List<string> { "a", "b", "c", "d", "e" };
        List<string> temp = new List<string>();
        int weightA = 5;
        int weightB = -12;
        int weightC = 47;
        int weightD = 7;
        int weightE = -32;
        int count = 0;
        for (int q = 0; q < numOfLetters; q++)
        {
            for (int w = 0; w < numOfLetters; w++)
            {
                for (int e = 0; e < numOfLetters; e++)
                {
                    for (int r = 0; r < numOfLetters; r++)
                    {
                        for (int t = 0; t < numOfLetters; t++)
                        {
                            temp.Add(letters[q]);
                            temp.Add(letters[w]);
                            temp.Add(letters[e]);
                            temp.Add(letters[r]);
                            temp.Add(letters[t]);

                            // calculate formula
                            int formula = 0;
                            List<int> fIndex = new List<int>();
                            int multiplier = 0;
                            for (int i = 0; i < temp.Count; i++)
                            {
                                switch (temp[i])
                                {
                                    case "a":
                                        fIndex.Add(weightA);    // we use weight of "a", "b", "c", "d", "e"
                                        if (weightA == 0)
                                        {
                                            multiplier--;
                                        }
                                        multiplier++;
                                        weightA = 0;   // when use given weight, if we meet again this weight is ZERO in sequence
                                        break;
                                    case "b":
                                        fIndex.Add(weightB);
                                        if (weightB == 0)
                                        {
                                            multiplier--;
                                        }
                                        multiplier++;
                                        weightB = 0;
                                        break;
                                    case "c":
                                        fIndex.Add(weightC);
                                        if (weightC == 0)
                                        {
                                            multiplier--;
                                        }
                                        multiplier++;
                                        weightC = 0;
                                        break;
                                    case "d":
                                        fIndex.Add(weightD);
                                        if (weightD == 0)
                                        {
                                            multiplier--;
                                        }
                                        multiplier++;
                                        weightD = 0;
                                        break;
                                    case "e":
                                        fIndex.Add(weightE);
                                        if (weightE == 0)
                                        {
                                            multiplier--;
                                        }
                                        multiplier++;
                                        weightE = 0;
                                        break;
                                    default:
                                        break;
                                }
                                formula += multiplier * fIndex[i];
                            }
                            // initialize weight again
                            weightA = 5;
                            weightB = -12;
                            weightC = 47;
                            weightD = 7;
                            weightE = -32;

                            if (formula >= start && formula <= end)
                            {
                                foreach (var item in temp)
                                {
                                    Console.Write("{0}", item);
                                }
                                count++;
                                temp.RemoveRange(0, temp.Count);
                                Console.Write(" ");
                            }
                            else
                            {
                                temp.RemoveRange(0, temp.Count);
                            }
                        }
                    }
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine();
        }
    }
}