using System;
using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primes = new ArrayList();
            ArrayList equalDividers = new ArrayList();

            int n = int.Parse(Console.ReadLine());
            BigInteger i = 1;
            BigInteger s = 0;


            while (primes.Count < n)
            {
                i++;
                bool isPrime = true;
                s = BigSqrt(i, s);

                for (int p = 0; p < primes.Count; p++)
                {
                    if ((BigInteger)primes[p] > s)
                    {
                        break;
                    }

                    if (i % (BigInteger)primes[p] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                }
            }

            Console.WriteLine("the {0}th prime is {1}", n, primes[primes.Count - 1]);
            Console.ReadLine();
        }

        public static BigInteger BigSqrt(BigInteger n, BigInteger last)
        {
            BigInteger result = last;

            while (result * result < n)
            {
                result++;
            }


            return result;
        }
    }
}
