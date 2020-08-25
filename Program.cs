using System;

namespace FakeInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimeCalc primeCalc = new PrimeCalc(false);

            ulong a = primeCalc.GetFirstPrimeWithNDigits(10);
            Console.WriteLine($"a: {a}");

            ulong b = primeCalc.GetFirstPrimeWithNDigits(11);
            Console.WriteLine($"b: {b}");

            ulong result = a * b;

            Console.WriteLine($"Result: {a} * {b} =  {result}");

            string output = result.ToString();
            int outputLen = output.Length;
            int startIndex = outputLen - 15;

            Console.WriteLine($"Last 15 digits = {output.Substring(startIndex)}");
        }
    }
}
