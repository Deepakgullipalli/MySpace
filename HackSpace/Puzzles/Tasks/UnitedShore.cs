using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class UnitedShore
    {
        public void UnitedShoreMain()
        {
            long p = FindPthFactor(1,1);
            List<int> test = new List<int>();
            test.Add(3);
            test.Add(1);
            test.Add(2);
            test.Add(4);
            int minSwaps = MinSwaps(test);

        }

        private long FindPthFactor(long n, long p)
        {
            if(n >= 1 && n <= 1000000000000000 && p >=1 && p <= 1000000000)
            {
                List<int> factors = new List<int>();
                for (int i = 1; i <= n; i++)
                    if (n % i == 0)
                        factors.Add(i);

                var sortedFactors = factors.OrderBy(x => x).ToList();
                if (p <= sortedFactors.Count)
                {
                    for (int j = 0; j < sortedFactors.Count; j++)
                    {
                        if (j == p - 1)
                        {
                            return sortedFactors[j];
                        }
                    }
                }
                else
                {
                    return 0;
                }
            }

            return 0;

        }

        private int MinSwaps(List<int> popularity) {
            int arrLen = popularity.Count;
            int count = 0;
            var sarr = popularity.ToList();
            sarr = sarr.OrderBy(x => x).ToList();

            for (int i = 0; i < arrLen; i++)
            {
                if (popularity[i] != sarr[i])
                {
                    count++;
                    for (int j = i + 1; j < arrLen; j++)
                    {
                        if (popularity[j] == sarr[i])
                        {
                            int tmp = popularity[j];
                            popularity[j] = popularity[i];
                            popularity[i] = tmp;
                            break;
                        }
                    }
                }
            }
            return count;
        }
    }
}
