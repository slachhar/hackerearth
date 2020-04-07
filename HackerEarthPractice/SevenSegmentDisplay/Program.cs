using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenSegmentDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matchSticksCountPerNumber = new int[10];

            matchSticksCountPerNumber[0] = 6;
            matchSticksCountPerNumber[1] = 2;
            matchSticksCountPerNumber[2] = 5;
            matchSticksCountPerNumber[3] = 5;
            matchSticksCountPerNumber[4] = 4;
            matchSticksCountPerNumber[5] = 5;
            matchSticksCountPerNumber[6] = 6;
            matchSticksCountPerNumber[7] = 3;
            matchSticksCountPerNumber[8] = 7;
            matchSticksCountPerNumber[9] = 6;

            int size = Convert.ToInt32(Console.ReadLine());
            string[] largestNumberArray = new string[size];

            for (int i = 0; i < size; i++) //loop through numbers 
            {
                string num = Console.ReadLine();
                int sum = 0;
                StringBuilder largestNumber = new StringBuilder();

                for (int j = 0; j < num.Length; j++)
                {
                    sum += matchSticksCountPerNumber[Convert.ToInt32(num.Substring(j, 1))];
                }

                int index = 0;

                if (sum % 2 == 0)
                {
                    index = sum / 2;

                    while (index > 0)
                    {
                        largestNumber.Append(1);
                        index--;
                    }
                }
                else
                {
                    index = (sum / 2) - 1;
                    largestNumber.Append(7);
                    while (index > 0)
                    {
                        largestNumber.Append(1);
                        index--;
                    }
                }

                largestNumberArray[i] = largestNumber.ToString();
            }

            foreach (var largestNumber in largestNumberArray)
            {
                Console.WriteLine(largestNumber);
            }
            Console.ReadLine();
        }
    }
}
