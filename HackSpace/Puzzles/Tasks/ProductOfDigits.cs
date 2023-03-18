using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class ProductOfDigits
    {
        public int GetProduct(int n)
        {
            int product = 1;

            while (n != 0)
            {
                product = product * (n % 10);
                n = n / 10;
            }

            return product;
        }
    }
}
