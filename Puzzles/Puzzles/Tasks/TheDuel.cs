using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    class TheDuel
    {
        public void TheDuelMain()
        {
            /*Below are the sample test cases*/
            //List<int> p = new List<int>() { -5,4,-2,3,1,-1,-6,-1,0,5};
            //List<int> p = new List<int>() { -5, 4, -2, 3, 1};
            //List<int> p = new List<int>() { -5, 4, -2, 3, 1, -1, -6, -1, 0, -5 };

            List<int> p = new List<int>();
            int pCount = Convert.ToInt32(Console.ReadLine().Trim());
            if(pCount >= 1 && pCount <= Math.Pow(10, 5))
            {
                for (int i = 0; i < pCount; i++)
                {
                    int pItem = Convert.ToInt32(Console.ReadLine().Trim());
                    if (pItem >= -100 && pItem <= 100)
                    {
                        p.Add(pItem);
                    }
                }

                int result = MinPower(p, 0);
            }
        }
        /// <summary>
        /// Used Recursion to achieve this pblm statement
        /// </summary>
        /// <param name="p"></param>
        /// <param name="sVal"></param>
        /// <returns></returns>
        private int MinPower(List<int> pCollection, int sVal)
        {
            int cVal = sVal;
            foreach (var pItem in pCollection)
            {
                if(pItem > 0)
                {
                    cVal += pItem;
                }
                else
                {
                    if ((cVal + pItem) > 0)
                    {
                        cVal += pItem;
                    }
                    else
                    {
                        sVal += Math.Abs(cVal + pItem) + 1;
                        cVal += pItem;
                        sVal = MinPower(pCollection, sVal);
                        break;
                    }
                }
            }
            return sVal;
        }
        /// <summary>
        /// Neha's Solution
        /// </summary>
        public static void FindMinimumPowerLevel()
        {
            //int[] p = { -2, -3, -1, -5 };
            Console.WriteLine("enter no of powers");
            int noOfPowers = Convert.ToInt32(Console.ReadLine());
            //int[] p = { -2, -3, -1, -5 };
            if (noOfPowers >= 1 && noOfPowers <= 100000)
            {
                int[] powers = new int[noOfPowers];
                for (int i = 0; i < noOfPowers; i++)
                {
                    Console.WriteLine("enter power");
                    powers[i] = Convert.ToInt32(Console.ReadLine());
                }
                int initialPower = 0;
                if (powers[0] >= 1)
                {
                    initialPower = powers[0];
                }
                else if (powers[0] == 0)
                {
                    initialPower = 1;
                }
                else
                {
                    initialPower = 1 - powers[0];
                }
                int energyAfterBattle = initialPower;
                for (int i = 0; i < powers.Length; i++)
                {
                    if (powers[i] >= -100 && powers[i] <= 100)
                        if (energyAfterBattle + powers[i] >= 1)
                        {
                            energyAfterBattle = energyAfterBattle + powers[i];
                        }
                        else
                        {
                            energyAfterBattle = 1 - powers[i];
                            initialPower = initialPower + 1;
                            energyAfterBattle = energyAfterBattle + powers[i];
                        }



                }

                Console.WriteLine(initialPower);
                Convert.ToInt32(Console.ReadLine());


            }


        }
    }
}
