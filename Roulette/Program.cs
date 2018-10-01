using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] drop = new int[38];
            string[] color = new string[2];
            bool roul = true;
            do
            {
                Random select = new Random();
                drop = new int[] { 0,1, 2, 3, 4, 5, 6,
                            7, 8, 9, 10, 11, 12,
                            13, 14, 15, 16, 17, 18,
                            19, 20, 21, 22, 23, 24,
                            25, 26, 27, 28, 29, 30,
                            31, 32, 33, 34, 35, 36, 00};
                int draw = drop[select.Next(0, 38)];
                color = new string[] {"Green", "Red"};
                string drawing = color[select.Next(0, 2)];
                Console.WriteLine(draw + ", " + drawing);
                Console.ReadKey();
            }while(roul);
        }
    }
}
