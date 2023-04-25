using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode189
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] datas = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            Rotate(datas, 3);

            Console.ReadLine();
        }

        public static void Rotate(int[] nums, int k)
        {
            List<int> list = nums.ToList<int>();

            for (int i = 0; i < k; i++)
            {
                int tmp = list[list.Count - 1];
                list.Insert(0, tmp);
                list.RemoveAt(list.Count - 1);
            }

            nums = list.ToArray();
        }
    }
}
