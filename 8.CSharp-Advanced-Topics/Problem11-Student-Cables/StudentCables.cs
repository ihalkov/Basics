using System;

class StudentCables
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());  // num of cables
        int[] cables = new int[n];
        // declarate lenghts, measures, sum
        int join = 3;   // joining to pieces of cable
        int crimp = 2;  // crimping each RJ45 connector 
        int joinedCable = 0;  // joining centimeters
        int studentCableLength = 500;   // centimeters
        for (int i = 0; i < cables.Length; i++)
        {
            cables[i] = int.Parse(Console.ReadLine());
            string centiMeters = Console.ReadLine();
            // change to centimeters if have to
            if (centiMeters == "meters")
            {
                cables[i] = cables[i] * 100;
            }
            if (cables[i] < 20)
            {
                cables[i] = 0;
                n--;
            }
            joinedCable += cables[i];
        }
        joinedCable -= join * (n - 1);
        int officialLength = studentCableLength + (2 * crimp);
        int numStCables = joinedCable / officialLength;
        Console.WriteLine(numStCables);
        int remainLength = joinedCable - (officialLength * numStCables);
        Console.WriteLine(remainLength);
    }
}