using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    class Program
    {
        public static List<int> its = new List<int>();

        static void Main()
        {
            int iterations = int.Parse(Console.ReadLine());
            int biggest = 0;
            int value = 0;

            its.Add(0);

            for (int i = 1; i < iterations; i++)
            {
                long o = i;
                int times = 0;
                while(o != 1)
                {
                    if (o < its.Count)
                    {
                        times += its[(int)o];
                        break;
                    }
                    else
                    {
                        o = Collatz(o);
                        times++;
                    }

                }

                its.Add(times);
            }

            for (int i = 0; i < its.Count; i++)
            {
                if(its[i] > biggest)
                {
                    biggest = its[i];
                    value = i;
                }
            }

            Console.WriteLine("Most Collatz iterations = {0} with the number {1}", biggest, value);
            Console.ReadLine();
        }

        public static long Collatz (long n)
        {
            if (n % 2 == 0)
                n = n / 2;
            else
                n = (3 * n) + 1;

            return n;
        }
    }
}
