using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroAndArrayUpdate
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader stream = new StreamReader("a2457f62fe-input-a245091.txt.clean.txt");
            int numOfTestCases = Convert.ToInt32(Console.ReadLine());
            int[] seconds = new int[numOfTestCases];

            for (int i = 0; i < numOfTestCases; i++)
            {
                string[] nAndk = Console.ReadLine().Split(' ');
                int arraySize = Convert.ToInt32(nAndk[0]);
                int k = Convert.ToInt32(nAndk[1]);

                int[] arrayDiff = new int[arraySize];

                int index = 0;

                foreach (var item in Console.ReadLine().Split(' '))
                {
                    arrayDiff[index] = k - Convert.ToInt32(item);
                    index++;
                }

                seconds[i] = arrayDiff.Max() < 0 ? 0 : arrayDiff.Max();
            }

            foreach (var itemSecond in seconds)
            {
                Console.WriteLine(itemSecond);
            }

            Console.Read();
        }
    }
}
