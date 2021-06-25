using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    class Program
    {
        static void Main()
        {
            ArrayList primes = new ArrayList();
            primes.Add((long)2);

            int n = int.Parse(Console.ReadLine());
            long i = 1;
            long s = 0;


            while ((long)primes[primes.Count - 1] < n)
            {
                i++;
                bool isPrime = true;
                s = BigSqrt(i, s);

                for (int p = 0; p < primes.Count; p++)
                {
                    if ((long)primes[p] > s)
                    {
                        break;
                    }

                    if (i % (long)primes[p] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                    Console.WriteLine(i);
                }
            }

            primes.RemoveAt(primes.Count - 1);

            long result = 0;

            foreach(long prime in primes)
            {
                result += prime;
            }

            Console.WriteLine("sum of all primes less than {0} is {1}", n, result);
            Console.ReadLine();

        }

        public static long BigSqrt(long n, long last)
        {
            long result = last;

            while (result * result < n)
            {
                result++;
            }


            return result;
        }
    }
}
