using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] inputArray = Console.ReadLine().Split(' ');
            int[] numbers = new int[size];
            int[] b = new int[size + 1];
            int[] c = new int[size];
            int maxSum = 0;

            for (int i = 0; i < size; i++)
            {
                numbers[i] = Convert.ToInt32(inputArray[i]);
            }

            for (int i = 1; i <= size; i++)
            {
                b[i] = b[i - 1] + numbers[i - 1];
            }

            for (int i = 0; i < size; i++)
            {

                int j = i + 1; int demand = 2;

                int remain = size - j;

                while (demand <= remain && j < size)
                {
                    demand += 1;
                    j = j + demand - 1;
                    remain = size - j;
                }

                c[i] = b[j] - b[i];

                if (maxSum < c[i])
                    maxSum = c[i];
            }

            Console.WriteLine(maxSum);
            Console.ReadLine();

        }
    }
}
