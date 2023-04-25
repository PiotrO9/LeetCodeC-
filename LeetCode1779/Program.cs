using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1779
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3; int y = 4;
            int[][] points = new int[][] {
                new int[] { 1, 2 },
            };

            Console.WriteLine(NearestValidPoint(x, y, points));


            Console.ReadLine();
        }

        public static int NearestValidPoint(int x, int y, int[][] points)
        {
            List<int> pointsLength = new List<int>();
            List<int> pointsIndexes = new List<int>();

            for (int i = 0; i < points.Length; i++)
            {
                if (points[i][0] == x || points[i][1] == y)
                {
                    int tmp = Math.Abs(points[i][0] - x) + Math.Abs(points[i][1] - y);
                    pointsLength.Add(tmp);
                    pointsIndexes.Add(i);
                }
            }

            if(pointsLength.Count == 0) 
            {
                return -1;
            }

            int tmpNumber = pointsLength.Min();
            int index = pointsLength.FindIndex(a => a == tmpNumber);

            return pointsIndexes[index];
        }
    }
}
