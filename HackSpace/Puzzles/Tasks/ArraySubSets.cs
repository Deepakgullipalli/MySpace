using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class ArraySubSets
    {
        public List<int> subsetA(List<int> arr)
        {
            List<int> leftList = new List<int>();
            List<int> rightList;
            for (int i = 0; i < arr.Count; i++)
            {
                leftList.Add(arr[i]);
                rightList = arr.Skip(i).ToList();

                var CommonList = leftList.Intersect(rightList);

                if(CommonList != null)
                {

                }
                continue;
            }
            return new List<int>();
        }

        public void ArraySubSetsMain()
        {
            List<int> myList = new List<int>() { 5, 3, 2, 4, 1, 2 };
            subsetA(myList);
        }
    }
}
