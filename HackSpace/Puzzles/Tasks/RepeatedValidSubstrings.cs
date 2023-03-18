using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class RepeatedValidSubstrings
    {
        public int[][] FindValidSubstrings(string k)
        {
            List<int[]> result = new List<int[]>();
            int n = k.Length;
            int i = 0;

            while (i < n)
            {
                int j = i + 1;
                while (j < n && k[j] == k[i])
                {
                    j++;
                }
                if (j - i >= 3)
                {
                    result.Add(new int[] { i, j - 1 });
                }
                i = j;
            }

            return result.ToArray();
        }
        public IList<IList<int>> FindValidSubstringList(string k)
        {
            List<int[]> result = new List<int[]>();
            IList<IList<int>> ret = new List<IList<int>>();
            int n = k.Length;
            int i = 0;

            while (i < n)
            {
                int j = i + 1;
                while (j < n && k[j] == k[i])
                {
                    j++;
                }
                if (j - i >= 3)
                {
                    result.Add(new int[] { i, j - 1 });
                    ret.Add(new List<int>(new int[] { i, j - 1 }));
                }
                i = j;
            }
            return ret;
        }
    }
}
