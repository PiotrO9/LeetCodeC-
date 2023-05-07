using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] coins = new int[] { 2};

            Console.WriteLine(CoinChange(coins, 0));

            Console.ReadLine();
        }

        public static int CoinChange(int[] coins, int amount)
        {
            int result = 0;

            if(amount < 0)
            {
                result = -1;
            }
            else if(amount == 0)
            {
                return 0;
            }
            else
            {
                int index = coins.Length - 1;

                while(amount > 0)
                {
                    if(index < 0)
                    {
                        return -1;
                    }

                    if(amount >= coins[index])
                    {
                        amount -= coins[index];
                        result++;
                    }
                    else
                    {
                        index -= 1;
                    }
                }
            }

            return result;
        }
    }
}
