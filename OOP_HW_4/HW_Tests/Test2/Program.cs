using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new C();
            A c = new C();
            a.Method1();
            b.Method1();
            c.Method1();
            Console.ReadKey();
        }
    }

    public class A
    {
        public virtual void Method1()
        {
            Console.WriteLine("class A Method1");
        }
    } 

    public static abstract class B : A
    {
        private new void Method1()
        {
            Console.WriteLine("class BBB Method1");
        }
    }

    public class C : B
    {
        public override void Method1()
        {
            Console.WriteLine("class C Method1");
        }
    }
}
