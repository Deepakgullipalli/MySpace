using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Sorting
{
    public class SelectionSort
    {
        public void SelectionSortMain()
        {
            int[] arr = new int[] { 64, 25, 12, 22, 11 };
            Sort(arr);
        }
        public void Sort(int[] arr)
        {
            int tempSmallValue;
            int tempSmallIndex;
            for (int i = 0; i < arr.Length; i++)
            {
                tempSmallValue = arr[i];
                tempSmallIndex = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(tempSmallValue > arr[j])
                    {
                        tempSmallValue = arr[j];
                        tempSmallIndex = j;
                    }
                }
                int swapTemp = tempSmallValue;
                arr[tempSmallIndex] =arr[i] ;
                arr[i] = swapTemp;
            }
        }
    }
}
