using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks.Shell
{
    public class ShellTwo
    {
        public void ShellTwoMain()
        {
            // Declare the array of two elements.
            int[][] arr = new int[2][];

            // Initialize the elements.
            arr[0] = new int[2] { 1, 4 };
            arr[1] = new int[2] { 2, 3 };

            int max;
            // Display the array elements.
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    //System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");

                }
            }
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();


            //solution(tst);
        }

        public int solution(int[][] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int i = 0; i < 1; i++)
            {

            }
            return 1;
        }
    }
}
