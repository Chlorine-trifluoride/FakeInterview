using System;

namespace FakeInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeCalc primeCalc = new PrimeCalc(true);

            long a = primeCalc.GetFirstPrimeWithNDigits(10);
            Console.WriteLine($"a: {a}");

            long b = primeCalc.GetFirstPrimeWithNDigits(11);
            Console.WriteLine($"a: {b}");

            long result = a * b;

            Console.WriteLine($"Result: {a} * {b} =  {result}");

            string output = result.ToString();
            int outputLen = output.Length;
            int startIndex = outputLen - 15;

            Console.WriteLine($"Last 15 digits = {output.Substring(startIndex)}");
        }
    }
}
