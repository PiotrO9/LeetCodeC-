using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode287
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] datas = new int[] { 1, 3, 4, 2, 2 };
            Console.WriteLine(FindDuplicate(datas));
            Console.Read();
        }

        public static int FindDuplicate(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[0];

            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            }
            while (slow != fast);

            int ptr1 = nums[0], ptr2 = slow;
            while (ptr1 != ptr2)
            {
                ptr1 = nums[ptr1];
                ptr2 = nums[ptr2];
            }

            return ptr1;
        }
    }
}
