using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string[,] testCases = new string[num, 2];
            int[] output = new int[num];

            for (int j = 0; j < num; j++)
            {
                testCases[j, 0] = Console.ReadLine();
                testCases[j, 1] = Console.ReadLine();

                Dictionary<string, int> a = new Dictionary<string, int>();
                Dictionary<string, int> b = new Dictionary<string, int>();

                foreach (var item in testCases[j, 0])
                {
                    if (a.ContainsKey(item.ToString()))
                    {
                        a[item.ToString()]++;
                    }
                    else
                    {
                        a.Add(item.ToString(), 1);
                    }
                }

                foreach (var item in testCases[j, 1])
                {
                    if (b.ContainsKey(item.ToString()))
                    {
                        b[item.ToString()]++;
                    }
                    else
                    {
                        b.Add(item.ToString(), 1);
                    }
                }

                int deletion = 0;
                foreach (var item in a.Keys)
                {
                    if (!b.ContainsKey(item))
                        deletion += a[item];
                    else if (a[item] > b[item])
                    {
                        deletion += a[item] - b[item];
                    }
                }

                foreach (var item in b.Keys)
                {
                    if (!a.ContainsKey(item))
                    {
                        deletion += b[item];
                    }
                    else if (b[item] > a[item])
                    {
                        deletion += b[item] - a[item];
                    }
                }
                output[j] = deletion;
            }



            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(output[i]);
            }

            Console.Read();
        }
    }
}
