using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Siemens
{
    public class MaximumPositiveIndex
    {
        public void MPImain()
        {
            int[] arr = { 5, 3, 2, 1, 1, 4 };
            int res = GetMPI(arr);
        }

        /// <summary>
        /// This is Implementation with O(n^2)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        private int GetMPI(int[] arr)
        {
            int min = arr[0], max = arr[0], minIndex = 0, maxIndex = 0;
            int maximumIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                min = arr[i];
                minIndex = i;
                bool isMaxPresent = false;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] > min)
                    {
                        max = arr[j];
                        maxIndex = j;
                        isMaxPresent = true;
                    }
                }
                if (maximumIndex < ((maxIndex - minIndex) + 1))
                    maximumIndex = (maxIndex - minIndex) + 1;
            }
            return maximumIndex;
        }
    }
}
