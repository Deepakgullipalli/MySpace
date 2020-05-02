using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    /// <summary>
    /// Algorithm to find All elements who has only single occurence in an array
    /// </summary>
    public class SingleOccurenceElements
    {
        public void SOEMain()
        {
            int x = 3 ^ 4;
            int[] arr = new int[] { 1, 1, 2, 2, 3, 4, 5, 5 };
            GetSingleElementOccurenceArrXOR(arr);
            //GetSingleElementOccurenceArr(arr);
        }

        /// <summary>
        /// https://www.geeksforgeeks.org/elements-that-occurred-only-once-in-the-array/
        /// </summary>
        /// <param name="arr"></param>
        private void GetSingleElementsOccurenceArr(int[] arr)
        {
            SortedDictionary<int, int> elementOccurenceIndex = new SortedDictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int noOfOccurences;
                if (!elementOccurenceIndex.TryGetValue(arr[i],out noOfOccurences))
                {
                    elementOccurenceIndex[arr[i]] = 1;
                }
                else
                {
                    noOfOccurences += 1;
                    elementOccurenceIndex[arr[i]] = noOfOccurences;
                }
            }

        }

        /// <summary>
        /// XOR Implementation
        /// https://www.geeksforgeeks.org/find-element-appears-array-every-element-appears-twice/
        /// </summary>
        /// <param name="arr"></param>
        private void GetSingleElementOccurenceArrXOR(int[] arr)
        {
            int res = arr[0];
            for (int i = 1; i < arr.Length; i++)
                res = res ^ arr[i];
            
        }

        /// <summary>
        /// 
        /// </summary>
        private void GetSingleElementOccurenceInSortedArray()
        {

        }
    }
}
