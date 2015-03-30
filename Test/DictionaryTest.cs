using System;
using System.Collections.Generic;

namespace Test
{
    class DictionaryTest : MyTest
    {
        private const Int32 N = 10000;
        private const Int32 M = 17519;
        private Double summ = 0;

        override protected void OnTest()
        {
            var keys = new Int32[N];
            var dict = new Dictionary<Int32, Double>();

            for (int i = 0; i < N; i++)
            {
                keys[i] = i*M;
                dict.Add(keys[i], Math.Sqrt(i));
            }

            var start = DateTime.Now;
            for (int i = 0; i < 10*N; i++)
            {
                summ += dict[keys[i%N]];
            }
            Console.WriteLine((DateTime.Now - start).TotalMilliseconds);
        }
    }
}