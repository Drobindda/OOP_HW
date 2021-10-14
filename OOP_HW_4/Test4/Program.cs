using System;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class A
    {

        protected int a;
        void Method(A a1, B b1)
        {
            a1.a = 1;
            b1.a = 2;
        }
    }

    class B : A
    {
        protected new int a;
        void MethodB(A a1, B b1)
        {
            a1.a = 1;
            this.a = 10;
            b1.a = 2;
        }
    }
}
