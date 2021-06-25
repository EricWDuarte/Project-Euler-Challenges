using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_19
{
    class Program
    {
        public static int[] monthSizes = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        static void Main(string[] args)
        {
            int mod = 1;
            int firstsSundays = 0;

            for (int i = 1901; i < 2000; i++)
            {
                if (i % 400 == 0)
                {
                    monthSizes[1] = 29;
                }
                else if (i % 100 == 0)
                {
                    monthSizes[1] = 28;
                }
                else if (i % 4 == 0)
                {
                    monthSizes[1] = 29;
                }
                else
                {
                    monthSizes[1] = 28;
                }

                foreach (int monthSize in monthSizes)
                {
                    mod = (mod + monthSize) % 7;
                    if (mod == 0)
                        firstsSundays++;
                }
            }

            Console.WriteLine("There are {0} sundays at the start of the month", firstsSundays);
            Console.ReadLine();
        }
    }
}
