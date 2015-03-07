using System;
using System.Collections.Generic;

namespace Test
{
    class DictionaryTest
    {
        private const Int32 N = 10000;
        private const Int32 SimpleN = 10103;

        public static void RunTest()
        {

            Double summ = 0;
            var keys = new Int32[N];
            var dict = new Dictionary<Int32, Double>(10000);

            // filling dict
            for (int i = 0; i < N; i++)
            {
                //keys[i] = i;
                keys[i] = i*SimpleN;
                dict.Add(keys[i], Math.Sqrt(i));
            }

            // calculation start
            var start = DateTime.Now;
            for (int i = 0; i < 10*N; i++)
            {
                summ += dict[keys[i%N]];
            }
            var end = DateTime.Now;

            Console.WriteLine((end - start).TotalMilliseconds);
            Console.ReadKey();
        }
    }
}