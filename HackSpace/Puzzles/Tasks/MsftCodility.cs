using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class MsftCodility
    {
        public void TreeMain()
        {
            Tree root = new Tree();
            root.x = 5;
            root.l = new Tree() { x = 3 };
            root.r = new Tree() { x = 10 };
            //root.l.l = new Tree() { x = 20 };
            //root.l.r = new Tree() { x = 21 };
            root.r.l = new Tree() { x = 1 };
            //root.x = 8;
            //root.l = new Tree() { x = 2 };
            //root.r = new Tree() { x = 6 };
            //root.l.l = new Tree() { x = 8 };
            //root.l.r = new Tree() { x = 7 };

            var noOfNodes = countNodes(root, root.x);
        }

        public Tuple<int, int> countNodes(Tree tree, int max)
        {
            int c = 1;
            int nonVisibleNodes = 0;
            if (tree == null)
                return Tuple.Create(0, 0); 
            else
            {
                if (tree.l == null)
                {
                }
                else if(tree.l?.x > max)
                {
                    var t0 = countNodes(tree.l, tree.l.x);
                    c += t0.Item1;
                    nonVisibleNodes += t0.Item2;
                }
                else
                {
                    nonVisibleNodes++;
                    var t1 = countNodes(tree.l, max);
                    c += t1.Item1;
                    if (nonVisibleNodes < t1.Item2)
                    {
                        nonVisibleNodes = t1.Item2;
                    }

                }
                if(tree.r == null)
                {
                }
                else if (tree.r?.x > max)
                {
                    var t2 = countNodes(tree.r, max);
                    c += t2.Item1;
                    nonVisibleNodes += t2.Item2;
                }
                else
                {
                    nonVisibleNodes++;
                    var t3 = countNodes(tree.r, max);
                    c += t3.Item1;
                    if (nonVisibleNodes < t3.Item2)
                    {
                        nonVisibleNodes = t3.Item2;
                    }
                }
                
                return Tuple.Create(c, nonVisibleNodes);
            }
        }
        public int solution(Tree T)
        {
            return 1;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
        }
    }

    public class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
    };
}
