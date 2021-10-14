using System;
using TestModifiersLibrary;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            a.MethodA();
            b.MethodB();
        }
    }

    class Modifiers
    {
        static void A()
        {
            Console.WriteLine("Modifiers A");
        }

        public static void B()
        {
            Console.WriteLine("Modifiers B");
        }

        protected static void C()
        {
            Console.WriteLine("Modifiers C");
        }
    }

    class ModifiersChild : Modifiers
    {
        public static void D()
        {
            A();
            B();
            C();
        }
    }
}
