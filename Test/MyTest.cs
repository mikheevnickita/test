using System;

namespace Test
{
    public abstract class MyTest
    {
        protected abstract void OnTest();

        public virtual void RunTest()
        {
            Console.WriteLine(String.Format("\nRunning test {0}\n======", this.GetType().ToString()));
            OnTest();
            Console.WriteLine("======\n");
        }

    }
}
