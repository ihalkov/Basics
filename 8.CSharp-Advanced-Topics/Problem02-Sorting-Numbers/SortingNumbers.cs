using System;
class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());  // numbers
        int[] numbers = new int[n]; // array of numbers
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Array.Sort(numbers);
        foreach (var item in numbers)
        {
            Console.WriteLine("{0}", item);
        }
    }
}