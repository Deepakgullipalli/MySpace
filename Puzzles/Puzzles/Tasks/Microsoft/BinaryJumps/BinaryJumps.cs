using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Microsoft.BinaryJumps
{
    class BinaryJumps
    {
        public void BJMain()
        {
            string game = "1111111110";
            int gameLen = game.Length;
            int tstValOfMax = 0;
            int[] tstArr = new int[gameLen];
            for (int i = 0; i < gameLen; i++)
            {
                tstArr[i] = Convert.ToInt32(game[i].ToString());
            }

            int arrMax = maxDistance(tstArr, gameLen, tstValOfMax);
            Console.WriteLine("Maximum distance = " + arrMax);
        }
        private int maxDistance(int[] arr, int n, int tstVal)
        {
            SortedDictionary<int, int> indexDiffSet = new SortedDictionary<int, int>();
            int maxDict = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == tstVal)
                {
                    if (!indexDiffSet.Keys.Contains(arr[i]))
                    {
                        indexDiffSet[arr[i]] = i;
                        maxDict = Math.Max(maxDict, i + 1);
                    }
                    else
                    {
                        maxDict = Math.Max(maxDict, i - indexDiffSet[arr[i]]);
                        indexDiffSet[arr[i]] = i;
                    }
                }
            }

            return maxDict;
        }
        
    }
}
