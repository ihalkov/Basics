using System;
using System.Linq;
class OddAndEvenProduct
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int oddProduct = 1;
        int evenProduct = 1;
        for (int odd = 0; odd < numbers.Length; odd += 2)
        {
            oddProduct *= numbers[odd];
        }
        for (int even = 1; even < numbers.Length; even += 2)
        {
            evenProduct *= numbers[even];
        }
        if (oddProduct == evenProduct)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("product = {0}", oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}", evenProduct);
        }
    }
}