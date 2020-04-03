using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarthPractice
{
    class Program
    {
        static string[] seats = new string[108];
        static void Main(string[] args)
        {
            /*
                // Sample code to perform I/O:

                name = Console.ReadLine();                  // Reading input from STDIN
                Console.WriteLine("Hi, {0}.", name);        // Writing output to STDOUT

                // Warning: Printing unwanted or ill-formatted data to output will cause the test cases to fail
            */
            int num = Convert.ToInt32(Console.ReadLine());
            int[] inputSeats = new int[num];

            string[,] outputSeats = new String[num, 2];

            string side = "left";
            for (int i = 0, j = 0; i < 108; i++, j++)
            {
                if (j == 6)
                {
                    side = (side == "left") ? "right" : "left";
                    j = 0;
                }

                seats[i] = side;
            }

            int seatNo;
            for (int i = 0; i < num; i++)
            {
                seatNo = Convert.ToInt32(Console.ReadLine());
                outputSeats[i, 0] = Convert.ToString(FetchOppositeSeat(seatNo - 1));
                outputSeats[i, 1] = FetchSeatType(seatNo);
            }

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{outputSeats[i, 0]} {outputSeats[i, 1]}");
            }

            Console.ReadLine();
        }

        public static string FetchSeatType(int seatNo)
        {
            string[] seatType = { "WS", "WS", "MS", "AS", "AS", "MS" };

            return seatType[seatNo % 6];
        }

        public static int FetchOppositeSeat(int seatNo)
        {
            int[] diffLeft = { 11, 9, 7, 5, 3, 1 };
            int[] diffRight = { 1, 3, 5, 7, 9, 11 };
            if (seats[seatNo] == "left")
            {
                return (seatNo + diffLeft[seatNo % 6]) + 1;
            }
            else if (seats[seatNo] == "right")
            {
                return (seatNo - diffRight[seatNo % 6]) + 1;
            }
            return 0;
        }
    }
}
