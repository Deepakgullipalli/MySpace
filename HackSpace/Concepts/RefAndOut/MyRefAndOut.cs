using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.RefAndOut
{
    /// <summary>
    /// https://stackoverflow.com/questions/41522016/what-is-the-difference-between-reference-type-and-ref-in-c
    /// https://stackoverflow.com/questions/186891/why-use-the-ref-keyword-when-passing-an-object?noredirect=1&lq=1
    /// </summary>
    public class MyRefAndOut
    {
        public void TestObject(Person person)
        {
            person = new Person { Name = "Two" };
        }

        public void TestObjectByRef(ref Person person)
        {
            person = new Person { Name = "Two" };
        }
    }

    public class Person
    {
        public string Name { get; set; }
    }
}
