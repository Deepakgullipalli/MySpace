using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Shell
{
    public class ShellOne
    {
        public void ShellOneMain()
        {
            solution(7);
        }
        public static void solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Console.WriteLine(findInt(N));
            }

        static int digitSum(int n)
        {
            int ans = 0;
            while (n != 0)
            {
                ans += n % 10;
                n /= 10;
            }

            return ans;
        }
        static int findInt(int n)
        {
            //int minDigit = (int)Math.Floor((double)(m / 9));

            // Start of the iterator (Smallest multiple of n)  
            //int start = (int)Math.Pow(10, minDigit) -
            //            (int)Math.Pow(10, minDigit) % n;
            int start = 1;
            while (start < int.MaxValue)
            {
                if (digitSum(start) == n)
                    return start;
                else
                    start++;
            }
            return -1;
        }



    }
}
