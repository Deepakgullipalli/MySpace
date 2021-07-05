using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class MaxSumArray
    {
        public int max_sum(int[] arr, int i)
        {
            if (i == 0)
            {
                return arr[0];
            }
            if(i == 1)
            {
                return Math.Max(arr[0], arr[1]);
            }
            return Math.Max(max_sum(arr, i - 1), arr[i] + max_sum(arr, i - 2));
        }
    }
}
