using Concepts.Asynchronous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ITestOne cOne = new ConcreteOne();
            cOne.Print();
            DemoOne d1 = new DemoOne();
            d1.DemoOneMain();
        }
    }

    class ConcreteOne : ITestOne, ITestTwo
    {
        public void Print()
        {
            throw new NotImplementedException();
        }
    }

    interface ITestOne
    {
        void Print();
    }
    interface ITestTwo
    {
        void Print();
    }

    public class Test
    {
        private void Hello()
        {

        }

        protected void Hey()
        {
            Hello();
        }
    }

    public class DTest : Test
    {
        protected void Hey()
        {

        }
    }
}
