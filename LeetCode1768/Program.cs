using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1768
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MergeAlternately("ab", "pqrs"));
            Console.Read();
        }

        public static string MergeAlternately(string word1, string word2)
        {
            string result = "";

            for (int i = 0; i < word1.Length; i++)
            {
                if(word1.Length > i)
                {
                    result += word1[i];
                }

                if (word2.Length > i)
                {
                    result += word2[i];
                }
            }

            if(word2.Length > word1.Length)
            {
                int lengthDifference = word2.Length - word1.Length;

                for (int i = (word2.Length - lengthDifference); i < word2.Length; i++)
                {
                    result += word2[i];
                }
            }

            return result;
        }
    }
}
