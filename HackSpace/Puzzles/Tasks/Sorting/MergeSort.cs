using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Sorting
{
    /// <summary>
    /// Refer to the below link in Geeks for Geeks for python Implementation
    /// https://www.geeksforgeeks.org/merge-sort/
    /// </summary>
    public class MergeSort
    {
        public void MergeSortMain()
        {
            int[] sortArr = new int[] { 12, 11, 13};
            int n = sortArr.Length;
            sortMe(sortArr);
        }

        private void sortMe(int[] sortArr)
        {
            if(sortArr.Length > 1)
            {
                int mid = sortArr.Length / 2;
                var L = sortArr.Take(mid).ToArray();
                var R = sortArr.Skip(mid).ToArray();

                sortMe(L);
                sortMe(R);

                int i= 0, j= 0, k = 0;

                // Copy data to temp arrays L[] and R[] 
                while (i < L.Length && j < R.Length)
                {
                    if(L[i] < R[j])
                    {
                        sortArr[k] = L[i];
                        i += 1;
                    }
                    else
                    {
                        sortArr[k] = R[j];
                        j += 1;
                    }

                    k += 1;
                }

                // Checking if any element was left 
                while (i < L.Length)
                {
                    sortArr[k] = L[i];
                    i += 1;
                    k += 1;
                }
            
                while(j < R.Length)
                {
                    sortArr[k] = R[j];
                    j += 1;
                    k += 1;
                } 
            
            }
        }
    }
}
