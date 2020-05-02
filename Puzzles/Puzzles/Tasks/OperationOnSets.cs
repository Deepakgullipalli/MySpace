using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class OperationOnSets
    {
        public void OperationOnSetsMain()
        {
            int noOfTestCases = Convert.ToInt32(Console.ReadLine());
            List<MyInputSet> mySet = new List<MyInputSet>();
            if (noOfTestCases <= 500 && noOfTestCases >= 1)
            {
                for (int i = 0; i < noOfTestCases; i++)
                {
                    var nm = Console.ReadLine();
                    int n = Convert.ToInt32(nm.Split(' ')[0]);
                    int m = Convert.ToInt32(nm.Split(' ')[1]);
                    
                    HashSet<int> nSet = new HashSet<int>();
                    HashSet<int> mSet = new HashSet<int>();

                    var nValues = Console.ReadLine().Split(' ');
                    for (int j = 0; j < n; j++)
                    {
                        nSet.Add(Convert.ToInt32(nValues[j]));
                    }

                    var mValues = Console.ReadLine().Split(' ');
                    for (int k = 0; k < m; k++)
                    {
                        mSet.Add(Convert.ToInt32(mValues[k]));
                    }

                    int x = Convert.ToInt32(Console.ReadLine());

                    mySet.Add(new MyInputSet(n, m, nSet.ToArray(), mSet.ToArray(), x));
                }

            }

            ProcessSetResult(mySet);


            int[] arr1 = { 30, 10, 20 };
            int[] arr2 = { 20, 25, 30, 40, 50 };
            int n1 = arr1.Length;
            quickSort(arr1, 0, n1 - 1);
            int n2 = arr2.Length;
            quickSort(arr2, 0, n2 - 1);

            SetXor(arr1, arr2, n1, n2);
        }

        static void ProcessSetResult(List<MyInputSet> mySet)
        {
            foreach (var item in mySet)
            {
                var op = getOuputByOperartion(item);
                Console.WriteLine(op);
            }
        }

        static string getOuputByOperartion(MyInputSet item)
        {
            string myOp = "{}";
            switch (item.oper)
            {
                case 1:
                    myOp = getOpByOpOne(item.nArr,item.mArr);
                    break;
                case 2:
                    myOp = getOpByOpTwo(item.nArr, item.mArr);
                    break;
                case 3:
                    myOp = getOpByOpThree(item.nArr, item.mArr);
                    break;
                case 4:
                    myOp = getOpByOpFour(item.nArr, item.mArr);
                    break;
                case 5:
                    myOp = getOpByOpFive(item.nArr, item.mArr);
                    break;
                default:
                    break;
            }

            return myOp;
        }

        static string getOpByOpFive(int[] nArr, int[] mArr)
        {
            Array.Sort(nArr);
            Array.Sort(mArr);
            List<int> diffArr = setDiff(mArr, nArr,  mArr.Length, nArr.Length);
            diffArr.Sort();
            return PrepareOp(diffArr);
        }

        static string getOpByOpFour(int[] nArr, int[] mArr)
        {
            Array.Sort(nArr);
            Array.Sort(mArr);
            List<int> diffArr = setDiff(nArr, mArr, nArr.Length, mArr.Length);
            diffArr.Sort();
            return PrepareOp(diffArr);
        }

        static string getOpByOpThree(int[] nArr, int[] mArr)
        {
            Array.Sort(nArr);
            Array.Sort(mArr);
            List<int> xorArr = SetXor(nArr, mArr, nArr.Length, mArr.Length);
            xorArr.Sort();
            return PrepareOp(xorArr);
        }

        static string getOpByOpTwo(int[] nArr, int[] mArr)
        {
            List<int> orArr = SetOr(nArr, mArr, nArr.Length, mArr.Length);
            orArr.Sort();
            return PrepareOp(orArr);
        }

        static string getOpByOpOne(int[] nArr, int[] mArr)
        {
            List<int> andArr = SetAnd(nArr, mArr, nArr.Length, mArr.Length);
            andArr.Sort(); 
            return PrepareOp(andArr);
        }

        static string PrepareOp(List<int> myArr)
        {
            string op = "{";
            int myLen = myArr.Count;
            for (int i = 0; i < myLen; i++)
            {
                if(i == myLen-1)
                    op = op + myArr[i];
                else
                    op = op + myArr[i] + ", ";
            }
            op = op + "}";
            return op;
        }
        
        static List<int> SetOr(int[] arr1, int[] arr2, int m, int n)
        {
            List<int> myList = new List<int>();
            if (m > n)
            {
                int[] tempp = arr1;
                arr1 = arr2;
                arr2 = tempp;

                int temp = m;
                m = n;
                n = temp;
            } 
            Array.Sort(arr1);
            for (int i = 0; i < m; i++)
                //Console.Write(arr1[i] + " ");
                myList.Add(arr1[i]);
            
            for (int i = 0; i < n; i++)
            {
                if (binarySearch(arr1, 0, m - 1,arr2[i]) == -1)
                    //Console.Write(arr2[i] + " ");
                    myList.Add(arr2[i]);
            }

            return myList;
        }
        
        static List<int> SetAnd(int[] arr1, int[] arr2, int m, int n)
        {
            List<int> myList = new List<int>();
            if (m > n)
            {
                int[] tempp = arr1;
                arr1 = arr2;
                arr2 = tempp;

                int temp = m;
                m = n;
                n = temp;
            }
            
            Array.Sort(arr1);
            
            for (int i = 0; i < n; i++)
            {
                if (binarySearch(arr1, 0, m - 1, arr2[i]) != -1)
                    //Console.Write(arr2[i] + " ");
                    myList.Add(arr2[i]);
            }

            return myList;
        }
        
        static int binarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;
                
                if (arr[mid] == x)
                    return mid;
 
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);
                
                return binarySearch(arr, mid + 1, r, x);
            }
            
            return -1;
        }

        static List<int> SetXor(int[] arr1, int[] arr2, int n1, int n2)
        {
            List<int> myList = new List<int>();

            int i = 0, j = 0, k = 0;
            while (i < n1 && j < n2)
            {
                if (arr1[i] < arr2[j])
                {
                    //Console.Write(arr1[i] + " ");
                    myList.Add(arr1[i]);
                    i++;
                    k++;
                }
                else if (arr2[j] < arr1[i])
                {
                    //Console.Write(arr2[j] + " ");
                    myList.Add(arr2[j]);
                    k++;
                    j++;
                }
                
                else
                {
                    i++;
                    j++;
                }
            }
            
            while (i < n1)
            {
                //Console.Write(arr1[i] + " ");
                myList.Add(arr1[i]);
                i++;
                k++;
            }
            while (j < n2)
            {
                //Console.Write(arr2[j] + " ");
                myList.Add(arr2[j]);
                j++;
                k++;
            }

            return myList;
        }

        static List<int> setDiff(int[] a, int[] b, int n, int m)
        {
            List<int> myList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int j;

                for (j = 0; j < m; j++)
                    if (a[i] == b[j])
                        break;

                if (j == m)
                    //Console.Write(a[i] + " ");
                    myList.Add(a[i]);
            }

            return myList;
        }

        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

        
    }

    public class MyInputSet
    {
        public int n { get; set; }

        public int m { get; set; }

        public int[] nArr { get; set; }

        public int[] mArr { get; set; }

        public int oper { get; set; }

        public MyInputSet(int nVal, int mVal, int[] nArray, int[] mArray, int myOper)
        {
            n = nVal;
            m = mVal;
            nArr = nArray;
            mArr = mArray;
            oper = myOper;
        }
    }
}
