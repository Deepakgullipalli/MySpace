using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class FactorsOfThreeAndFive
    {
        public int GetCountOfArr()
        {
            int startIndex = 1;
            int endIndex = 10;

            var maxPowOfThree = (int)(Math.Log(endIndex) / Math.Log(3));
            var maxPowOfFive = (int)(Math.Log(endIndex) / Math.Log(5));

            HashSet<double> mySet = new HashSet<double>();
            int count = 0;
            for (int i = 0; i <= maxPowOfThree; i++)
            {
                for (int j = 0; j <= maxPowOfFive; j++)
                {
                    var toBeComparedVal = Math.Pow(3, i) * Math.Pow(5, j);
                    if(toBeComparedVal <= endIndex && toBeComparedVal >= startIndex)
                    {
                        mySet.Add(toBeComparedVal);
                        count++;
                    }
                }
            }

            return count;
        }
        public void FactorsOfThreeAndFiveMain()
        {
            GetCountOfArr();
        }
    }
}
