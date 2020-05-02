using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class Knapsack
    {
        public void KnapsackMain()
        {
            // Input: set of items each with a weight and a value
            int[] v = { 20, 5, 10, 40, 15, 25 };
            int[] w = { 1, 2, 3, 8, 7, 4 };

            // Knapsack capacity
            int W = 10;

            Console.WriteLine("Knapsack value is " + knapSack(v, w, v.Length - 1, W));
        }

        // Values (stored in array v)
        // Weights (stored in array w)
        // Number of distinct items (n)
        // Knapsack capacity W
        public static int knapSack(int[] v, int[] w, int n, int W)
        {
            // base case: Negative capacity
            if (W < 0)
            {
                return int.MinValue;
            }
            // base case: no items left or capacity becomes 0
            if (n < 0 || W == 0)
            {
                return 0;
            }

            //int[] v = { 20, 5, 10, 40, 15, 25 };
            //int[] w = { 1, 2, 3, 8, 7, 4 };

            // Case 1. include current item n in knapSack (v[n]) and recurse for
            // remaining items (n - 1) with decreased capacity (W - w[n])

            int include = v[n] + knapSack(v, w, n - 1, W - w[n]);

            // Case 2. exclude current item n from knapSack and recurse for remaining items (n - 1)

            int exclude = knapSack(v, w, n - 1, W);

            // return maximum value we get by including or excluding current item
            return Math.Max(include, exclude);
        }
    }
}
