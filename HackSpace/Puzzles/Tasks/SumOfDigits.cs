using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class SumOfDigits
    {
        public int GetSum(int n)
        {
            int sum = 0;

            while (n != 0)
            {
                sum = sum + (n % 10);
                n = n / 10;
            }

            return sum;
        }
}
