using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Interfaces
{
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    //Write your code here
    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int total = 0;

            //use modulus if no leftover add result to total
            for (int i = 1; i <= n; i++)
            {

                if (n % i == 0)
                {
                    total = total + i;
                }

            }

            return total;
        }
    }
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
            Console.ReadLine();
        }
    }
}
