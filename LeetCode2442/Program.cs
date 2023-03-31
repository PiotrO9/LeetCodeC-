using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode2442
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] datas = { 1, 10, 20 };
            CountDistinctIntegers(datas);
            Console.ReadLine();
        }

        public static int CountDistinctIntegers(int[] nums)
        {
            List<int> tmp = nums.ToList<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                string temporaryNumber = Reverse(nums[i].ToString());
                tmp.Add(int.Parse(temporaryNumber));
            }

            tmp = tmp.Distinct().ToList();

            return tmp.Count;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
