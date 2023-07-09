using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode48
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public static void Rotate(int[][] matrix)
        {
            int length = matrix.Length;

            for (int i = 0; i < (length / 2); i++) 
            {
                for (int j = i; j < length - i - 1; j++)
                {
                    int tmp = matrix[i][j];
                    matrix[i][j] = matrix[length - j - 1][i];
                    matrix[length - j - 1][i] = matrix[length - i - 1][length - j - 1];
                    matrix[length - i - 1][length - j - 1] = matrix[j][length - 1 - i];
                    matrix[j][length - 1 - i] = tmp;
                }
            }
        }
    }
}
