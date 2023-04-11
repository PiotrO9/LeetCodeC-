using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClimbStairs(45));

            Console.ReadLine();
        }

        public static int ClimbStairsRec(int n)
        {
            if(n <= 2) return n;

            return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }
        public static int ClimbStairs(int n)
        {
            if(n <= 2) return n;

            int[] ans = new int[n];

            ans[0] = 1;
            ans[1] = 2;

            for (int i = 2; i < n; i++)
            {
                ans[i] = ans[i - 1] + ans[i - 2];
            }

            return ans[n - 1];
        }

    }
}
