using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class Codility_AmazonIreland
    {
        public static string Str { get; set; }
        public static int OneCount { get; set; }
        public static void Codility_AmazonIrelandMain()
        {
            int x = Solution(10, 7);
        }

        public static int Solution(int A, int B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A >= 0 && B >= 0 && A <= 100000000 && B <= 100000000)
            {
                int product = A * B;
                Bin(product);
                int r = Convert.ToInt32(Str);
                int p = OneCount;
                return Convert.ToInt32(Str);
            }
            return -1;
        }
        static void Bin(int n)
        {
            // step 1 
            if (n > 1)
            {
                Bin(n / 2);
            }
                

            // step 2 
            if(n % 2 == 1)
            {
                OneCount++;
            }
            Str += n % 2;
        }
    }
}
