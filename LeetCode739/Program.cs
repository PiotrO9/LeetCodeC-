using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode739
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] datas = { 73, 74, 75, 71, 69, 72, 76, 73 };

            var tmp = DailyTemperatures(datas);

            Console.ReadLine();
        }

        public static int[] DailyTemperatures(int[] temperatures)
        {
            int length = temperatures.Length;

            int[] tmp = new int[length];
            Array.Clear(tmp, 0, length);

            for (int i = 0; i < length; i++)
            {
                if(i + 1 != length)
                {
                    int counter = 0;

                    for (int j = i + 1;j < length; j++)
                    {
                        if (temperatures[i] < temperatures[j])
                        {
                            counter++;
                            tmp[i] = counter;
                            break;
                        }
                        else
                        {
                            counter++;
                        }
                    }
                }
            }

            return tmp;
        }
    }
}
