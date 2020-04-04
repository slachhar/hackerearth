using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "YES";

            for (int i = 0, j = input.Length - 1; i < input.Length / 2; i++, j--)
            {
                if (input[i] != input[j])
                    result = "NO";
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
