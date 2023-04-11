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
            string[] datas = new string[] { "000", "111", "000" };

            Console.WriteLine(NumberOfBeams(datas));

            Console.ReadLine();
        }

        public static int NumberOfBeams(string[] bank)
        {
            int count = 0;
            List<int> tmp = new List<int>();

            if(bank.Length > 0)
            {
                for (int i = 0; i < bank.Length; i++)
                {
                    int onesCounter = 0;

                    for (int j = 0; j < bank[i].Length; j++)
                    {
                        if (bank[i][j] == '1')
                        {
                            onesCounter++;
                        }
                    }

                    if(onesCounter != 0)
                    {
                        tmp.Add(onesCounter);
                    }
                }

                for (int i = 1; i < tmp.Count; i++)
                {
                    count += tmp[i] * tmp[i - 1];
                }
            }
            else
            {
                return 0;
            }

            return count;
        }
    }
}
