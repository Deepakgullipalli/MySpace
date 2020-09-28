using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.DanskeIT
{
    public class Danske
    {
        public void DanskeMain()
        {
            int n = 2, sum = 5;
            Console.Write(finalCount(n, sum));
        }

        static int countRec(int n, int sum)
        {

            // Base case 
            if (n == 0)
                return sum == 0 ? 1 : 0;

            if (sum == 0)
                return 1;

            // Initialize answer 
            int ans = 0;

            // Traverse through every 
            // digit and count numbers  
            // beginning with it using 
            // recursion 
            for (int i = 0; i <= 9; i++)
                if (sum - i >= 0)
                    ans += countRec(n - 1, sum - i);

            return ans;
        }

        // This is mainly a  
        // wrapper over countRec. It 
        // explicitly handles leading 
        // digit and calls countRec()  
        // for remaining digits. 
        static int finalCount(int n, int sum)
        {

            // Initialize final answer 
            int ans = 0;

            // Traverse through every  
            // digit from 1 to 9 and  
            // count numbers beginning 
            // with it 
            for (int i = 1; i <= 9; i++)
                if (sum - i >= 0)
                    ans += countRec(n - 1, sum - i);

            return ans;
        }

    }
}
