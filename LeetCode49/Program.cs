using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tmpWords = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            Console.WriteLine(GroupAnagrams(tmpWords));
            Console.ReadLine();
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs) {
            bool isAnagram(string originalWord, string wordTocheck)
            {
                for (int i = 0; i < originalWord.Length; i++)
                {
                    if (!wordTocheck.Contains(originalWord[i]))
                    {
                        return false;
                    }
                }

                return true;
            }

            List<List<string>> result = new List<List<string>>();

            while(strs.Length > 1)
            {
                string tmpWord = strs[0];
                List<string> tmpList = new List<string>();

                for (int i = 1; i < strs.Length; i++)
                {
                    if(isAnagram(tmpWord, strs[i]))
                    {
                        tmpList.Add(strs[i]);
                    }
                }

                tmpList.Add(tmpWord);

                for (int i = 0; i < tmpList.Count; i++)
                {
                    strs = strs.Where(w => w != tmpList[i]).ToArray();
                }

                if(tmpList.Count > 0)
                {
                    result.Add(tmpList);
                }
            }


            if (strs.Length == 0)
            {
                result.Add(new List<string>() { "" });
                    
            }
            else
            {
                result.Add(new List<string>() { strs[0] });
                    
            }


            return (IList<IList<string>>)result;
        }

        
    }
}
