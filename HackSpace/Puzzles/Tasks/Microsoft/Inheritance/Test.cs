using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Microsoft.Inheritance
{
    class C
    {
        public C()
        {
            Console.WriteLine("C Constructor Called");
        }
        public void show()
        {
            Console.WriteLine("Hello: C Class!");
            Console.ReadLine();
        }
    }
    class A : C
    {
        public A()
        {
            Console.WriteLine("A Constructor Called");
        }
        public new void show()
        {
            Console.WriteLine("Hello: Base Class!");
            Console.ReadLine();
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B Constructor Called");
        }
        public new void show()
        {
            Console.WriteLine("Hello: Derived Class!");
            Console.ReadLine();
        }
    }
}
