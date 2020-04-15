using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader streamReader = new StreamReader("cf972712-8-in00.txt");
            string[] s = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(s[0]);
            int q = Convert.ToInt32(s[1]);
            string[] numArray = Console.ReadLine().Split(' ');
            int lastBit = -1;

            for (int i = 0; i < q; i++)
            {
                string[] query = Console.ReadLine().Split(' ');
                int firstBit = Convert.ToInt32(query[0]);

                if (firstBit == 1)
                {
                    int secondBit = Convert.ToInt32(query[1]);
                    numArray[secondBit - 1] = numArray[secondBit - 1] == "0" ? "1" : "0";
                    lastBit = Convert.ToInt32(query[0]);
                }
                else if (firstBit == 0)
                {
                    int L = Convert.ToInt32(query[1]);
                    int R = Convert.ToInt32(query[2]);
                    lastBit = Convert.ToInt32(numArray[R - 1]);
                    if (lastBit == 0)
                    {
                        Console.WriteLine("EVEN");
                    }
                    else if (lastBit == 1)
                    {
                        Console.WriteLine("ODD");
                    }
                }
            }

           

            Console.Read();
        }
    }
}
