using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var tests = new List<MyTest>()
            {
                new DictionaryTest(),
                new PrivateFieldTest()
            };

            foreach (var test in tests)
            {
                test.RunTest();
            }
            Console.WriteLine("All tests done.\nPress any key to finish.");
            Console.ReadKey();
        }
    }
}
