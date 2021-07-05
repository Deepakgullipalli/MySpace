using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Sorting
{
    /// <summary>
    /// Quick Sort Using Last element to partition
    /// </summary>
    public class QuickSort
    {
        public void QuickSortMain()
        {
            int[] sortArr = new int[] { 10, 30, 80, 50, 40, 90, 70 };
            int n = sortArr.Length;
            sortMe(sortArr, 0, n-1);
        }

        private int[] sortMe(int[] arr, int sI, int eI)
        {
            if(sI < eI)
            {
                int pI = GetPartitionIndex(arr, sI, eI);

                sortMe(arr, sI, pI - 1);
                sortMe(arr, pI + 1, eI);
            }
            return arr;
        }

        private int GetPartitionIndex(int[] arr, int sI, int eI)
        {
            int sVal = sI - 1;
            int pivotVal = arr[eI];

            for (int i = sI; i < eI; i++)
            {
                if(arr[i] <= pivotVal)
                {
                    sVal++;
                    swap(arr, i, sVal);
                }
            }
            swap(arr, eI, sVal + 1);
            return sVal + 1;
        }

        private int[] swap(int[] arr, int from, int to)
        {
            int temp;
            temp = arr[to];
            arr[to] = arr[from];
            arr[from] = temp;

            return arr;
        }
    }
}
