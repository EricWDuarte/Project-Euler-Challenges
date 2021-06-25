using System;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            ArrayList primes = new ArrayList();
            ArrayList equalDividers = new ArrayList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                int m = i;
                bool isPrime = true;

                for (int p = 2; p <= Math.Sqrt(i); p++)
                {
                    if (i % p == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                    equalDividers.Add(0);
                }

                if (primes.Count > 0)
                {
                    for (int o = 0; o < primes.Count; o++)
                    {
                        int d = 0;
                        while (m != 1 && m % (int)primes[o] == 0)
                        {
                            m /= (int)primes[o];
                            d ++;
                        }

                        if ((int)equalDividers[o] < d)
                        {
                            equalDividers[o] = d;
                        } 
                    }
                }
            }

            BigInteger result = 1;

            for (int y = 0; y < primes.Count; y++)
            {
                result *= (long)Math.Pow((int)primes[y], (int)equalDividers[y]);
                Console.WriteLine("Prime {0} = {1} and apears {2} times", y + 1, primes[y], equalDividers[y]);
            }

            Console.WriteLine("Smallest multiplier = {0}", result);
            Console.ReadLine();
        }
    }
}
