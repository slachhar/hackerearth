using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            var inputArray = Console.ReadLine();

            int[] numbers = new int[size];

            int index = 0;

            double sum = 1;
            foreach (var item in inputArray.Split(' '))
            {
                numbers[index] = Convert.ToInt32(item);
                sum = (sum * numbers[index]) % (Math.Pow(10,9) + 7);
                index++;
            }

            Console.WriteLine(sum);
            Console.Read();
        }
    }
}
