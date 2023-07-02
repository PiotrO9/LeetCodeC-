﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode268
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public static int MissingNumber(int[] nums)
        {
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                {
                    return i;
                }
            }

            return nums.Length;
        }
    }
}
