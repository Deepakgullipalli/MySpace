using Puzzles.Tasks;
using Puzzles.Tasks.Microsoft.AsyncTask;
using Puzzles.Tasks.Microsoft.BinaryJumps;
using Puzzles.Tasks.Microsoft.Constructor;
using Puzzles.Tasks.Microsoft.Delegates;
using Puzzles.Tasks.Microsoft.Exception;
using Puzzles.Tasks.Microsoft.Inheritance;
using Puzzles.Tasks.Microsoft.MainMethod;
using Puzzles.Tasks.Microsoft.NullCheck;
using Puzzles.Tasks.Shell;
using Puzzles.Tasks.Siemens;
using Puzzles.Tasks.Sorting;
using Puzzles.Tasks.VMWare;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles
{
    public class Program
    {
        static int x = 1;
        static void Main(string[] i)
        {
            MsftCodility msftCodility = new MsftCodility();
            msftCodility.TreeMain();

            //try
            //{
            //    try
            //    {
            //        int x = 0;
            //        int sgh = 5/x;    
            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //string ssjkgr = "slalkgdjo";
            ////ssjkgr = ssjkgr.Distinct().ToList();
            //HashSet<char> charSet = new HashSet<char>();
            //foreach (var item in ssjkgr)
            //{
            //    if (charSet.Add(item))
            //    {

            //    }
            //}
            //string sfhgeyu = charSet.
            //var akjfh = ssjkgr.Substring(6);
            //int ssjkhf = int.Parse(ssjkgr.Substring(6));
            //Amcat amcat = new Amcat();
            //amcat.AmcatMain();

            //QueOne queOne = new QueOne();
            //queOne.QueOneMain();

            //DisjointIntervals.gegmain();
            //SumOfAllSubArraysEqualToK.LocalMain();

            //ShellTwo s1 = new ShellTwo();
            //s1.ShellTwoMain();

            //string s = "011100";
            //int y = mysolution(s); /*Convert.ToInt32(s, 2);*/

            //p jdkvn = new p();
            //r lkdvnk = new r();
            //p ekjnfjk = new r();

            //int idgd = 0;
            //int inti = 2;
            //ArrayList al = new ArrayList();
            //al.Add(inti);

            //MyParent mp = new MyParent();
            //mp.MyMethod1();

            MyParent mpc = new MyChild();
            mpc.MyMethod2();

            //OperationOnSets os = new OperationOnSets();
            //os.OperationOnSetsMain();

            //Fibonacci fb = new Fibonacci();
            //fb.FibonacciMain();

            //List<int> test1 = new List<int>() { 1,2,3,4};
            //List<int> test2 = new List<int>() { 3,7,8,9};


            //var me = from one in test1
            //         join two in test2 on one equals two
            //         select new { test1 = one, test2 = two };



            //MaxSumArray msa = new MaxSumArray();
            //int[] arr = new int[] { -1, 0, 3, 2 };
            //var val = msa.max_sum(arr,4);
            //MyTest t = new MyTest();
            //int[] arr = new int[] { 1, 2 };
            //if(1 < 2 && arr[2] > arr[1])
            //{
            //    Console.WriteLine("Hi");
            //    //Console.ReadLine();
            //}

            //Ms

            //MsOne m1 = new MsOne();
            //m1.MsOneMain();

            //MsTwo m2 = new MsTwo();
            //m2.MsTwoMain();

            //MsThree m3 = new MsThree();
            //m3.MsThreeMain();

            //MsFour m4 = new MsFour();
            //m4.MsFourMain();

            //NewModifier nm = new NewModifier();
            //nm.NewModifierMain();

            //MsSeven m7 = new MsSeven();
            //m7.MsSevenMain();

            //MsEight m8 = new MsEight();
            //m8.MsEightMain();

            //MsNine m9 = new MsNine();
            //m9.MsNineMain();

            //MsTen m10 = new MsTen();
            //m10.MsTenMain();

            //MsEleven m11 = new MsEleven();
            //m11.MsElevenMain();

            //ArrayContentCountSorting a = new ArrayContentCountSorting();

            //RollingString rs = new RollingString();
            //string test = rs.rollString("babybabymonster", new List<string>());

            //TheDuel td = new TheDuel();
            //td.TheDuelMain();

            //DataLayer dl = new DataLayer();
            //dl.TestDataConnection();

            //Knapsack kp = new Knapsack();
            //kp.KnapsackMain();

            //#if (!pi)
            //Console.WriteLine("i");
            //#else
            //        Console.WriteLine("pi not define");
            //#endif
            //Console.WriteLine("ok");
            //Console.ReadLine();

            //C a = new A();
            //a.show();

            //ThePerfectTeam tpt = new ThePerfectTeam();
            //tpt.ThePerfectTeamMain();

            //MaximumPositiveIndex mpimain = new MaximumPositiveIndex();
            //mpimain.MPImain();

            //BinarySearch bs = new BinarySearch();
            //bs.BSMain();

            //BinaryJumps bj = new BinaryJumps();
            //bj.BJMain();

            //QuickSort qs = new QuickSort();
            //qs.QuickSortMain();

            //MergeSort ms = new MergeSort();
            //ms.MergeSortMain();

            //SingleOccurenceElements soe = new SingleOccurenceElements();
            //soe.SOEMain();

            //Dijkstra dj = new Dijkstra();
            //dj.DijkstraMain();

            //TowerOfHanoi toh = new TowerOfHanoi();
            //toh.HanoiMain();

            //Test t = new Test();
            //t.TestMain();

            //InsertionSort ins = new InsertionSort();
            //ins.InsertionSortMain();

            //SelectionSort ss = new SelectionSort();
            //ss.SelectionSortMain();

            //HeapSort hs = new HeapSort();
            //hs.HeapSortMain();

            //BubbleSort bs = new BubbleSort();
            //bs.BubbleSortMain();

            //FunWithAnagrams fwa = new FunWithAnagrams();
            //fwa.FunWithAnagramsMain();

            FactorsOfThreeAndFive ftf = new FactorsOfThreeAndFive();
            ftf.FactorsOfThreeAndFiveMain();

            //str = j.ToString()
        }

        public void m1()
        {

        }

        //static int Main(string[] args)
        //{

        //    //Ms

        //    MsFive m5 = new MsFive();
        //    m5.MsFiveMain();
        //    return 0;

        //}

        public long MyInt1(int x)
        {
            return 1;
        }

        public long MyInt1(long x)
        {
            return 2;
        }

        private static int totCount;
        public static int mysolution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int integerValue = Convert.ToInt32(S, 2);
            if (integerValue % 2 == 0)
            {
                return EvenValueHandler(integerValue);
            }
            return oddValueHandler(integerValue);
        }

        public static int oddValueHandler(int val)
        {
            totCount++;
            if (val == 0)
            {
                return totCount-1;
            }
            else if (val % 2 == 0)
            {
                return EvenValueHandler(val / 2);
            }
            else
            {
                return oddValueHandler(val-1);
            }

        }
        public static int EvenValueHandler(int val)
        {
            totCount++;
            if (val == 0)
            {
                return totCount-1;
            }
            else if (val % 2 == 0)
            {
                return EvenValueHandler(val / 2);
            }
            else
            {
                return oddValueHandler(val-1);
            }
        }

    }
    public class Classroom
    {
        public Classroom(List<string> students)
        {
            myStudents = students;
        }
        private List<string> myStudents;
        public IEnumerable<string> Students { get; private set; }
        //public static void Main(string[] args)
        //{
        //    List<string> students = new List<string>() { "John", "Ana", "Carol" };
        //    Classroom classroom = new Classroom(students);

        //    foreach (string student in classroom.Students)
        //    {
        //        Console.WriteLine(student);
        //    }
        //}
    }
    class MyTest
    {
        static string myString;
        readonly int myInt;

        static MyTest()
        {
            myString = "Deepak";
        }

        public MyTest()
        {
            myString = "Kumar";
            myInt = 1;
        }

        public MyTest(int i)
        {
            myInt = i;
        }

        public void myMethod()
        {
            
        }

        public static void myStaticMethodInNonStaticClass()
        {

        }
    }

    public static class MyStatic
    {
        static string myStaticString = "DS";
    }

    public class MyParent
    {
        static MyParent()
        {

        }
        public MyParent()
        {

        }
        public virtual string MyMethod1()
        {
            return "P 1";
        }

        public virtual string MyMethod2()
        {
            return "P 2";
        }
    }

    public class MyChild : MyParent
    {
        static MyChild()
        {

        }
        public MyChild()
        {

        }
        public new string MyMethod1()
        {
            return "1";
        }


        new public string MyMethod2()
        {
            return "P 2";
        }

        public new int MyMethod3()
        {
            return 1;
        }
    }

    public class p
    {
        static p()
        {

        }
        public p()
        {

        }
        protected class q
        {

        }
    }

    public class r : p
    {
        static r()
        {

        }
        public r()
        {
                
        }
        public void MyMo()
        { 
            q ksjf = new q();
        }
    }
}
