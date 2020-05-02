using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class DisjointIntervals
    {
        public static void DisjointIntervalsMain()
        {
            int[] a = new int[] { 1, 12, 42, 70, 36, -4, 43, 15 };
            int[] b = new int[] { 5, 15, 44, 72, 36, 2, 69, 24 };
            Console.WriteLine(Solution(a, b));
        }

        public static int Solution(int[] a, int[] b)
        {
            List<Tuple<int, int>> myTuple = new List<Tuple<int, int>>();
            for (int i = 0; i < a.Length; i++)
            {
                myTuple.Add(Tuple.Create(a[i], b[i]));
            }


            return 1;
        }

        static void findIntersection(int[,] intervals, int N)
        {
            // First interval  
            int l = intervals[0, 0];
            int r = intervals[0, 1];

            // Check rest of the intervals  
            // and find the intersection  
            for (int i = 1; i < N; i++)
            {

                // If no intersection exists  
                if (intervals[i, 0] > r ||
                    intervals[i, 1] < l)
                {
                    Console.WriteLine(-1);
                    return;
                }

                // Else update the intersection  
                else
                {
                    l = Math.Max(l, intervals[i, 0]);
                    r = Math.Min(r, intervals[i, 1]);
                }
            }
            Console.WriteLine("[" + l + ", " + r + "]");
        }

        // Driver code  
        public static void TestMain()
        {
            int[,] intervals = {{ 1, 6 }, { 2, 8 },
                        { 3, 10 }, { 5, 8 }};
            int N = intervals.GetLength(0);
            findIntersection(intervals, N);
        }

        public static void AnotherTestMain()
        {
            int[,] intervals = {{ 1, 5 }, { 12, 15 },
                        { 42,44 }, { 70,72 },{36,36 },{-4,2 },{43, 69 } ,{ 15, 24} };
            int N = intervals.GetLength(0);
            TestfindIntersection(intervals, N);
        }

        static void TestfindIntersection(int[,] intervals, int N)
        {
            List<Tuple<int, int>> myTuple = new List<Tuple<int, int>>();
            // First interval  
            int l = intervals[0, 0];
            int r = intervals[0, 1];

            // Check rest of the intervals  
            // and find the intersection  
            for (int i = 1; i < N; i++)
            {

                // If no intersection exists  
                if (intervals[i, 0] > r ||
                    intervals[i, 1] < l)
                {
                    myTuple.Add(Tuple.Create(intervals[i, 0], intervals[i, 1]));
                    //Console.WriteLine(-1);
                    //return;
                }

                // Else update the intersection  
                else
                {
                    l = Math.Min(l, intervals[i, 0]);
                    r = Math.Max(r, intervals[i, 1]);
                }
            }
            Console.WriteLine("[" + l + ", " + r + "]");
        }

        public static void mergeIntervals(List<Interval> intList)
        {
            // Test if the given set has at least one interval  
            if (intList.Count <= 0)
                return;

            // Create an empty stack of intervals  
            Stack<Interval> stack = new Stack<Interval>();

            // sort the intervals in increasing order of start time
            var orderList = intList.OrderBy(x => x.end).ToList();


            // push the first interval to stack  
            stack.Push(orderList[0]);

            // Start from the next interval and merge if necessary  
            for (int i = 1; i < orderList.Count; i++)
            {
                // get interval from stack top  
                Interval top = stack.Peek();

                // if current interval is not overlapping with stack top,  
                // push it to the stack  
                if (top.end < orderList[i].start)
                    stack.Push(orderList[i]);

                // Otherwise update the ending time of top if ending of current  
                // interval is more  
                else if (top.end < orderList[i].end)
                {
                    top.end = orderList[i].end;
                    if(top.start > orderList[i].start)
                    {
                        top.start = orderList[i].start;
                    }
                    stack.Pop();
                    stack.Push(top);
                }
            }

            // Print contents of stack  
            Console.WriteLine("The Merged Intervals are: "); 
            while (!(stack.Count() == 0))
            {
                Interval t = stack.Pop();
                Console.WriteLine("["+t.start+","+t.end+"] "); 
            }
        }

        public static void gegmain()
        {
            List<Interval> intList = new List<Interval>();
            intList.Add(new Interval(1, 5));
            intList.Add(new Interval(12, 15));
            intList.Add(new Interval(42, 44));
            intList.Add(new Interval(70, 72));
            intList.Add(new Interval(36, 36));
            intList.Add(new Interval(-4, 2));
            intList.Add(new Interval(43, 69));
            intList.Add(new Interval(15, 24));
            mergeIntervals(intList);
        }
    }
    public class Interval
    {
        public int start;
        public int end;
        public Interval(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
    }
}
