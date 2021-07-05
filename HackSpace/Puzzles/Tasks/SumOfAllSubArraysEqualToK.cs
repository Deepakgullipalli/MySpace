using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class SumOfAllSubArraysEqualToK
    { 
        /// <summary>
        /// SimpleSolution
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static int findSubarraySum(int[] arr,int n, int sum)
        {
            int finalRes=0;
            int innerCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                innerCount = 0;
                for(int j = i; j < arr.Length; j++)
                {
                    innerCount += arr[j];
                    if (arr[i] == sum && arr[j] == sum)
                    {
                        finalRes++;
                        continue;
                    }
                    else
                    {
                        if(innerCount == sum)
                        {
                            finalRes++;
                            continue;
                        }
                    }
                }
            }
            return finalRes;
        }

        public static int efficientSubarraySum(int[] arr, int n, int sum)
        {
            Dictionary<int, int> prevSum = new Dictionary<int, int>();

            int res = 0;

            // Sum of elements so far 
            int currsum = 0;

            for (int i = 0; i < n; i++)
            {

                // Add current element to sum so far. 
                currsum += arr[i];

                // If currsum is equal to desired sum,  
                // then a new subarray is found. So  
                // increase count of subarrays. 
                if (currsum == sum)
                    res++;

                // currsum exceeds given sum by currsum  
                // - sum. Find number of subarrays having  
                // this sum and exclude those subarrays  
                // from currsum by increasing count by  
                // same amount. 
                if (prevSum.ContainsKey(currsum - sum))
                    res += prevSum[currsum - sum];

                // Add currsum value to count of  
                // different values of sum. 
                if (!prevSum.ContainsKey(currsum))
                    prevSum.Add(currsum, 1);
                else
                {
                    int count = prevSum[currsum];
                    prevSum[currsum] = count + 1;
                }
            }
            return res;
        }

        public static int arraySum(int[] arr, int n, int sum)
        {
            int innerCount;
            for (int i = 0; i < arr.Length; i++)
            {
                innerCount = arr[i];
                if (innerCount == sum)
                {
                    Console.WriteLine(i);
                    continue;
                }
                for (int j = i+1; j < arr.Length; j++)
                {
                    innerCount += arr[j];
                    if (innerCount == sum)
                    {
                        Console.WriteLine(i+ ","+ j);
                        
                    }
                    continue;
                }

            }
            return 1;
        }

        // Driver Code 
        public static void LocalMain()
        {
            int[] arr = { 10, 2, -2, -20,10, -10 };
            int sum = -10;
            int n = arr.Length;
            Console.Write(arraySum(arr, n, sum));
        }
    }
}
