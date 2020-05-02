using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzles.Tasks
{
    public class Fibonacci
    {
        public void FibonacciMain()
        {
            //Console.WriteLine(MyFib(0, 1, 6, 13, 10));//89
            //Console.WriteLine(MyFib(0, 1, 6, 13, 10));//89
            //Console.WriteLine(MyFib(3, 65, 6, 315, -10));//4620
            //Console.WriteLine(MyFib(0, 11, 1, -6, 2));5
            //Console.WriteLine(MyFib(9, 36, 15, 646, -5));-1/4
            //Console.WriteLine(MyFib(11, 72, 20, 5473, 6));13/2

            int valCoeff;
            int varCoeff;
            int p = 0;
            int fp = 11;
            int q = 1;
            int fq = -6;
            int r = 2;
            int fr=0;
            int noOfIterations = p > q ? p - q : q - p;

            //int r = -4;
            //r = 9;
            //int valCoeff;
            //int varCoeff;
            //int p = 2;
            //int fp = 1;
            //int q = 8;
            //int fq = 21;
            //int fr;
            //int noOfIterations = p > q ? p - q : q - p;

            GetValAndVarCoeff(noOfIterations, fp, out valCoeff,out varCoeff);
            var fpNext = (fq - valCoeff) / varCoeff;

            if (r < p)
            {
                noOfIterations = p - r;
                fr = ToBeFetchedLessThanP(noOfIterations, fp, fpNext);
            }
            else if(r > p)
            {
                noOfIterations = r - (p+1);
                fr = ToBeFetchedGreaterThanP(noOfIterations, fpNext, fp);
            }

            Console.WriteLine(fr);
            //int x = varFib(3);
            //int vx = valFib(3, 65);
            //int y = varFib(6);
            //int vy = valFib(6, 1);
            //fib(9);
            
        }
        public void fib(int n)
        {
            int a = 0, b = 1, c;
            if (n >= 0)
                Console.Write(a + " ");
            if (n >= 1)
                Console.Write(b + " ");
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }

        public int? MyFib(int p, int fp, int q, int fq, int r)
        {
            int? fr = null;
            string prevValMinusOne = "";
            string prevValMinusTwo = "";
            string temp = "";
            if (p < q)
            {
                for (int i = p + 1; i <= q; i++)
                {
                    temp = prevValMinusOne;
                    prevValMinusOne = CreateLinearEquation(prevValMinusOne, prevValMinusTwo);
                    prevValMinusTwo = temp;
                }
            }
            else
            {
                CreateLinearEquation("", "");
            }


            return fr;
        }

        public int valFib(int noOfIterations, int Val)
        {
            if (noOfIterations == 1)
            {
                return 0;
            }
            if (noOfIterations == 2 || noOfIterations == 3)
            {
                return Val;
            }
            else
            {
                for (int i = 4; i <= noOfIterations; i++)
                {
                    Val += Val;
                }

                return Val;
            }
        }

        public int varFib(int noOfIterations)
        {
            int minusTwo = 1;
            int minusOne = 1;
            if (noOfIterations == 1 || noOfIterations == 2)
            {
                return minusOne;
            }
            else
            {
                for (int i = 3; i <= noOfIterations; i++)
                {
                    minusOne = minusOne + minusTwo;
                    minusTwo = minusOne - minusTwo;
                }

                return minusOne;
            }
        }

        public string CreateLinearEquation(string preValMinusOne, string preValMinusTwo)
        {
            string equation = "";

            if (preValMinusTwo == "")
            {
                equation = "x";
                return equation;
            }
            else
            {
                if (preValMinusOne.Split('+').Length > 1)
                {
                    string valPart = preValMinusOne.Split('+')[0];
                    string varPart = preValMinusOne.Split('+')[1];
                    int coeff;
                    if (varPart.Length > 1)
                    {
                        coeff = Convert.ToInt32(varPart[0].ToString());
                    }
                    coeff = Convert.ToInt32(varPart[0].ToString());
                }
                else
                {
                    equation = preValMinusOne + "+" + preValMinusTwo;
                }
            }

            return "";
        }

        public string solveEquation(string equation)
        {
            int n = equation.Length,
                sign = 1, coeff = 0;
            int total = 0, i = 0;

            // Traverse the equation 
            for (int j = 0; j < n; j++)
            {
                if (equation[j] == '+' ||
                    equation[j] == '-')
                {
                    if (j > i)
                        total += sign *
                                 Int32.Parse(
                                 equation.Substring(i, j - i));
                    i = j;
                }

                // For cases such  
                // as: x, -x, +x 
                else if (equation[j] == 'x')
                {
                    if ((i == j) ||
                         equation[j - 1] == '+')
                        coeff += sign;

                    else if (equation[j - 1] == '-')
                        coeff -= sign;

                    else
                        coeff += sign *
                                 Int32.Parse(
                                 equation.Substring(i, j - i));
                    i = j + 1;
                }

                // Flip sign once  
                // '=' is seen 
                else if (equation[j] == '=')
                {
                    if (j > i)
                        total += sign *
                                 Int32.Parse(
                                 equation.Substring(i, j - i));
                    sign = -1;
                    i = j + 1;
                }
            }

            // There may be a  
            // number left in the end 
            if (i < n)
                total += sign *
                         Int32.Parse(
                         equation.Substring(i));

            // For infinite 
            // solutions 
            if (coeff == 0 && total == 0)
                return "Infinite solutions";

            // For no solution 
            if (coeff == 0 && total != 0)
                return "No solution";

            // x = total sum / coeff  
            // of x '-' sign indicates  
            // moving numeric value to  
            // right hand side 
            int ans = -total / coeff;
            return "x = " + ans.ToString();
        }

        public void GetValAndVarCoeff(int noOfIterations, int initialVal, out int valCoeff, out int varCoeff)
        {
            valCoeff = 1;
            varCoeff = 1;

            if (noOfIterations == 1)
            {
                valCoeff = 0;
                varCoeff = 1;
            }
            for (int i = 3; i <= noOfIterations; i++)
            {
                varCoeff = varCoeff + valCoeff;
                valCoeff = varCoeff - valCoeff;
            }

            valCoeff = valCoeff * initialVal;
        }

        public int ToBeFetchedLessThanP(int noOfIterations, int current,int next)
        {
            for (int i = 1; i <= noOfIterations; i++)
            {
                current = next - current;
                next = next - current;
            }

            return current;
        }

        public int ToBeFetchedGreaterThanP(int noOfIterations, int current, int prev)
        {
            for (int i = 1; i <= noOfIterations; i++)
            {
                current = current + prev;
                prev = current - prev;
            }

            return current;
        }
    }
}
