using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode704
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -1, 0, 5 };

            Console.WriteLine(Search(nums, -1));
            Console.ReadKey();
        }

        public static int Search(int[] nums, int target)
        {
            int min = 0;
            int max = nums.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (target < nums[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }

            }

            return -1;
        }
    }
}
