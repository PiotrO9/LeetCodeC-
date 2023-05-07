using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode283
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12 };

            nums = MoveZeroes(nums);

            Console.Read();
        }

        public static int[] MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {

                if (nums[i] == 0)
                {
                    for (int j = i; j < nums.Length - 1; j++)
                    {
                        int number1 = nums[j + 1];
                        int tmp = nums[j];
                        nums[j] = number1;
                        nums[j + 1] = number1;
                    }
                }
            }

            return nums;
        }
    }
}
