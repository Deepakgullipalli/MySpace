using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Sorting
{
    public class InsertionSort
    {
        public void InsertionSortMain()
        {
            int[] arr = new int[] { 12, 11, 13, 5, 6 };
            ISort(arr);
        }
        private void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int eI = i - 1;//2
                int val = arr[i];//5
                while (eI >= 0)
                {
                    if(val < arr[eI])
                    {
                        int temp = arr[eI];
                        arr[eI] = arr[eI+1];
                        arr[eI+1] = temp;
                    }
                    eI -= 1;
                }
            }
        }

        private void ISort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int j = i - 1;
                int key = arr[i];
                while (j >= 0 && key < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}
