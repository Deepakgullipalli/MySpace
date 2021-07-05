using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts.Generics
{
    /// <summary>
    /// https://www.c-sharpcorner.com/UploadFile/31514f/importance-of-generics-in-C-Sharp/
    /// </summary>
    class MyGenerics
    {
        public void TestGenericSort()
        {
            ArrayList.SortList();
            int x = 1;
            string y = "ksdhk";
            int[] iInputArray = { 3, 5, 8, 6, 10, 6, 2, 1, 12 };
            IList<int> xjsa;
            TestParameterType(y);
        }

        public object TestParameterType(object myTest)
        {
            return myTest;
        }
    }

    public class ArrayList
    {
        private static object[] Sort<T>(object[] iInputeArray)
        {
            Array.Sort(iInputeArray);
            return iInputeArray;
        }


        public static void SortList()
        {
            object[] iInputArray = { 3, 5, 8, 6, 10, 6, 2, 1, 12 };
            iInputArray = Sort<int>(iInputArray);

            foreach (Object obj in iInputArray)
                Console.Write("   {0}", obj);

            object[] strInputArray = { "A", "C", "T", "R", "E", "D" };
            strInputArray = Sort<string>(strInputArray);

            foreach (Object obj in strInputArray)
                Console.Write("   {0}", obj);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
