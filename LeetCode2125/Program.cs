using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode2125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] datas = new string[] { "011001", "000000", "010100", "001000" };

            Console.WriteLine(NumberOfBeams(datas));

            Console.ReadLine();
        }

        public static int NumberOfBeams(string[] bank)
        {
            int count = 0;
            List<int> tmp = new List<int>();

            if (bank.Length != 0)
            {
                tmp.Add(bank[0].ToCharArray().Count(c => c == '1'));

                for (int i = 1; i < bank.Length; i++)
                {
                    int onesCounter = bank[i].ToCharArray().Count(c => c == '1');

                    if(onesCounter != 0)
                    {
                        tmp.Add(onesCounter);
                        count += tmp[tmp.Count - 1] * tmp[tmp.Count - 2];
                    }
                }
            }

            return count;
        }
    }
}
