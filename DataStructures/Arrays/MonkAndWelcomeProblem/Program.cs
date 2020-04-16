using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkAndWelcomeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());

            string[] array1 = Console.ReadLine().Split(' ');
            string[] array2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < size; i++)
            {
                Console.Write((Convert.ToInt32(array1[i]) + Convert.ToInt32(array2[i])) + " ");
            }

            Console.ReadLine();
        }
    }
}
