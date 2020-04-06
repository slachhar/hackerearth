using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0, y = 0;
            string input = Console.ReadLine();

            foreach (var item in input)
            {
                switch (item)
                {
                    case 'L':
                        x--;
                        break;

                    case 'R':
                        x++;
                        break;

                    case 'D':
                        y--;
                        break;

                    case 'U':
                        y++;
                        break;
                }
            }

            Console.WriteLine(x + " " + y);
            Console.ReadLine();
        }
    }
}
