using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_26
{
    class Program
    {


        static void Main()
        {
            int d = 2;


            int biggest = 0;
            int result = 0;

            while (d < 1000)
            {
                if (d % 2 != 0 && d % 5 != 0)
                {
                    int a = GetSize(d);
                    Console.WriteLine(d + " with " + a + " algarisms");

                    if (a > biggest)
                    {
                        biggest = a;
                        result = d;
                    }
                }
                d++;
            }

            Console.WriteLine(result + " with " + biggest + " algarisms");
            Console.Read();

        }

        public static int GetSize(int n)
        {
            int result = 1;
            string dividend = "9";

            while(BigInteger.Parse(dividend) % n != 0)
            {
                dividend += "9";
                result++;
            }

            return result;
        }
    }
}
