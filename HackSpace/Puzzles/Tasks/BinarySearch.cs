using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class BinarySearch
    {
        public int GetIndexOfSearchItem(int[] arr, int item, int l, int r)
        {
            int mid = l + (r - 1) / 2;

            /*if the item is present at mid point of the array*/
            if (item == arr[mid])
                return mid;

            /*if the item is present at right side of mid point of the array*/
            if (item > arr[mid])
                return GetIndexOfSearchItem(arr, item, mid + 1, r);

            /*if the item is present at right side of mid point of the array*/
            if (item < arr[mid])
                return GetIndexOfSearchItem(arr, item, l, mid - 1);

            return 1;
        }
        public void BSMain()
        {
            int[] arr = {2,4,10,29,37,40,51,98 };
            int n = arr.Length - 1;
            int item = 10;

            int index = GetIndexOfSearchItem(arr, item, 0, n);
        }
    }
}
