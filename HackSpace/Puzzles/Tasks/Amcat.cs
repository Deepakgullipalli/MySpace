using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class Amcat
    {
        public void AmcatMain()
        {
            Dictionary<int, int> test = new Dictionary<int, int>();
            test[1] = 2;
            test[2] = 3;
            test[4] = 5;

            foreach (var item in test)
            {
                var val = test[item.Value];
            }
        }
    }

    class Node
    {
        int key;
        Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }
}
