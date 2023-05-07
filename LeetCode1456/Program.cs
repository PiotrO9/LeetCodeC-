using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode1456
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "ibpbhixfiouhdljnjfflpapptrxgcomvnbf";

            Console.WriteLine(MaxVowels(word, 33));

            Console.ReadKey();
        }

        public static int MaxVowels(string s, int k)
        {
            int longestVowelSeries = 0;


            if(s.Length > k) 
            {
                for (int i = k; i < s.Length; i++)
                {
                    int VowelSeriesCounter = 0;

                    for (int j = i; j > 0; j--)
                    {
                        if (IsLetterMatching(s[j]))
                        {
                            VowelSeriesCounter++;
                        }
                    }

                    if(VowelSeriesCounter > longestVowelSeries)
                    {
                        longestVowelSeries = VowelSeriesCounter;
                    }
                }
            }

            return longestVowelSeries;
        }

        public static bool IsLetterMatching(char c)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

            foreach (char vowel in vowels)
            {
                if(c == vowel)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
