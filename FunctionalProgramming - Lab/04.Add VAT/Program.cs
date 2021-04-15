using System;
using System.Linq;

namespace _04.Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<string, decimal> selector = Parse;
            var price = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(selector).ToArray();
            foreach (var item in Vat(price,1.2m))
            {
                Console.WriteLine($"{item:F2}");
            }
            
        }

        private static decimal [] Vat(decimal [] input ,decimal x)
        {
            
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] * x;
            }
            return input;
        }

        private static decimal Parse(string n)
        {
            return decimal.Parse(n);
        }
    }
}
