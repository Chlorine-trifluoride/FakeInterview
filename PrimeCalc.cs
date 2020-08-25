using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FakeInterview
{
    class PrimeCalc
    {
        public bool DebugOn { get; set; }

        public PrimeCalc(bool debugOn)
        {
            this.DebugOn = debugOn;
        }

        /// <summary>
        /// Returns (long) the first prime with n digits
        /// This is a very slow method
        /// </summary>
        public ulong GetFirstPrimeWithNDigits(int n)
        {
            string num = "1".PadRight(n, '0');
            ulong l = ulong.Parse(num);
            l += 1;

            for (; l <= ulong.MaxValue ; l+=2)
            {
                if (IsPrimePrintTime(l))
                    return l;
            }

            return 0;
        }

        /// <summary>
        /// Returns (bool) if the input is a prime number or not and prints the time to calculate in ms
        /// </summary>
        private bool IsPrimePrintTime(ulong input)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            bool isPrime = IsPrime(input);
            sw.Stop();

            if (DebugOn)
                Console.WriteLine($"Time: {sw.ElapsedMilliseconds}ms for value {input}. isPrime = {isPrime}");

            return isPrime;
        }

        /// <summary>
        /// Returns (bool) if the input is a prime number or not
        /// </summary>
        public bool IsPrime(ulong input)
        {
            for (ulong l = 1; l < input; l+=2)
            {
                if (input % l == 0 && l != 1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
