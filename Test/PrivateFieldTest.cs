using System;
using System.Reflection;

namespace Test
{
    class PrivateFieldTest
    {
        class A
        {
            private int _a;

            public A()
            {
                _a = 123;
            }
        }

        class B : A
        {
            public Int32 Private
            {
                get
                {
                    return (Int32)(typeof(A).GetField("_a", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this));
                }
                set
                {
                    typeof(A).GetField("_a", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(this, value);
                }
            }
        }

        public static void RunTest()
        {
            B tmp = new B();

            Console.WriteLine(tmp.Private);
            tmp.Private = 321;
            Console.WriteLine(tmp.Private);
        }
    }
}
