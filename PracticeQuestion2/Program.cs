using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion2
{
    class Program
    {
        private static string input;
        private static char xChar = 'z', yChar = 'o';
        private static int x, y;
        static void Main(string[] args)
        {
            input = Console.ReadLine();

            foreach (var item in input)
            {
                if (xChar == item)
                    x++;
                else if (yChar == item)
                    y++;
            }

            string result = 2 * x == y ? "Yes" : "No";
            Console.WriteLine($"{result}");
            Console.ReadLine();
        }
    }
}
