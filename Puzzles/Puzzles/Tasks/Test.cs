using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class Test
    {
        public void TestMain()
        {
            int[] arr1 = new int[] { 12, 11, 90, 2, 30, 70, 50 };
            QuickSort(arr1, 0, arr1.Length - 1);
            int[] arr2 = new int[] { 12, 11, 13 };
            MergeSort(arr2);
        }

        #region Quick Sort

        private void QuickSort(int[] arr, int startIndex, int endIndex)
        {
            if(startIndex < endIndex)
            {
                int partitionIndex = GetPartitionIndex(arr, startIndex, endIndex);

                QuickSort(arr, startIndex, partitionIndex - 1);
                QuickSort(arr, partitionIndex + 1, endIndex);
            }
        }

        private int GetPartitionIndex(int[] arr, int startIndex, int endIndex)
        {
            int partitionValue = arr[endIndex];
            int smallestIndex = startIndex - 1;
            for (int i = startIndex; i < endIndex; i++)
            {
                if(arr[i] <= partitionValue)
                {
                    smallestIndex += 1;
                    int temp1 = arr[smallestIndex];
                    arr[smallestIndex] = arr[i];
                    arr[i] = temp1;
                }
            }
            int temp2 = arr[smallestIndex + 1];
            arr[smallestIndex + 1] = arr[endIndex];
            arr[endIndex] = temp2;

            return smallestIndex + 1;
        }

        #endregion

        #region Merge Sort

        private void MergeSort(int[] arr)
        {
            if(arr.Length > 1)
            {
                int mid = arr.Length / 2;

                var leftArr = arr.Take(mid).ToArray();
                var rightArr = arr.Skip(mid).ToArray();

                MergeSort(leftArr);
                MergeSort(rightArr);

                int i = 0, j = 0, k = 0;

                while(i < leftArr.Length && j < rightArr.Length)
                {
                    if(leftArr[i] < rightArr[j])
                    {
                        arr[k] = leftArr[i];
                        k += 1;
                        i += 1;
                    }
                    else
                    {
                        arr[k] = rightArr[j];
                        k += 1;
                        j += 1;
                    }
                }

                while(i < leftArr.Length)
                {
                    arr[k] = leftArr[i];
                    k += 1;
                    i += 1;
                }

                while (j < rightArr.Length)
                {
                    arr[k] = rightArr[j];
                    k += 1;
                    j += 1;
                }
            }
        }

        private void MyMergeSort(int[] arr)
        {
            int len = arr.Length;
            
            if(len > 0)
            {
                int mid = len / 2;

                int[] leftArr = arr.Take(mid).ToArray();
                int[] rightArr = arr.Skip(mid).ToArray();

                MyMergeSort(leftArr);
                MyMergeSort(rightArr);


                int i=0, j=0 , k = 0;
                while(i < leftArr.Length && j < rightArr.Length)
                {
                    if (leftArr[i] < rightArr[j])
                    {
                        arr[k] = leftArr[i];
                        i += 1;
                        
                    }
                    else
                    {
                        arr[k] = rightArr[j];
                        j += 1;
                    }
                    k += 1;
                }
                while (i < leftArr.Length)
                {
                    arr[k] = leftArr[i];
                    i += 1;
                    k += 1;
                }
                while (j < rightArr.Length)
                {
                    arr[k] = rightArr[j];
                    j += 1;
                    k += 1;
                }
            }
        }
        #endregion
    }
}
