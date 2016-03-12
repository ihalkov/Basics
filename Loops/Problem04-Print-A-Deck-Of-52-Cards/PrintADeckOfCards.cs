using System;
using System.Text;
class PrintADeckOfCards
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char spade = '\u2660';
        char heart = '\u2665';
        char diamond = '\u2666';
        char club = '\u2663';
        char j = 'J';
        char q = 'Q';
        char k = 'K';
        char a = 'A';
        int numCards = 10; // form 2 to 10
        int numColors = 4;
        for (int i = 2; i <= numCards; i++)
        {
            Console.Write("{0}{1} ", i, spade);
            Console.Write("{0}{1} ", i, heart);
            Console.Write("{0}{1} ", i, club);
            Console.Write("{0}{1}", i, diamond);
            Console.WriteLine();
        }
        for (int w = 11; w <= 14; w++)
        {
            switch (w)
            {
                case 11: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", j, spade, heart, club, diamond); break;
                case 12: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", q, spade, heart, club, diamond); break;
                case 13: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", k, spade, heart, club, diamond); break;
                case 14: Console.WriteLine("{0}{1} {0}{2} {0}{3} {0}{4}", a, spade, heart, club, diamond); break;
                default:
                    break;
            }
        }
    }
}