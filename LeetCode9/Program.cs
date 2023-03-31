using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();

            Console.WriteLine(isPalindrom(inputNumber));
            Console.ReadLine();
        }

        static bool isPalindrom(string textNumber)
        {
            string temporaryText = "";
            for (int i = textNumber.Length - 1; i >= 0; i--)
            {
                temporaryText += textNumber[i];
            }

            return (temporaryText == textNumber) ? true : false;
        }
    }
}
