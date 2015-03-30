using System;
using System.Reflection;

namespace Test
{
    class PrivateFieldTest : MyTest
    {
        class A
        {
            private int _a;

            public A()
            {
                _a = 123;
            }
        }

        class B
        {
            private A field;

            public B()
            {
                field = new A();
            }
            public Int32 Private
            {
                get
                {
                    return (Int32)(typeof(A).GetField("_a", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(field));
                }
                set
                {
                    typeof(A).GetField("_a", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(field, value);
                }
            }
        }

        override protected void OnTest()
        {
            B tmp = new B();

            Console.WriteLine(tmp.Private);
            tmp.Private = 321;
            Console.WriteLine(tmp.Private);
        }
    }
}
