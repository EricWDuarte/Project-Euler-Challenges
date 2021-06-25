using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_29
{

    class Number
    {
        public static List<int> AllPrimes = new List<int>();

        public List<int> PrimeFactors;

        public Number(List<int> l) { PrimeFactors = l; }

        public bool Equals(Number other)
        {
            return other.PrimeFactors.SequenceEqual(PrimeFactors);
        }
    }

    class Program
    {



        static void Main()
        {
            Number.AllPrimes = FindPrimes(100);
            List<Number> noExponent = new List<Number>();

            for (int i = 2; i <= 100; i++)
            {
                noExponent.Add(new Number(Factorize(i)));
            }

            List<Number> distinctNumbers = new List<Number>();

            for (int i = 2; i <= 100; i++)
            {
                foreach (Number n in noExponent)
                {
                    Number temp = new Number(Raise(n, i));

                    bool contains = false;

                    foreach (Number number in distinctNumbers)
                    {
                        if (number.Equals(temp))
                        {
                            contains = true;
                            break;
                        }
                    }

                    if(contains == false)
                    {
                        distinctNumbers.Add(temp);
                    }
                }
            }

            Console.WriteLine("Result: " + distinctNumbers.Count);            
            Console.Read();


        }

        public static List<int> Raise(Number n, int p)
        {
            List<int> result = new List<int>(n.PrimeFactors);

            for (int i = 0; i < result.Count; i++)
            {
                result[i] *= p;
            }

            result.ForEach(x => Console.Write(x + ", "));
            Console.WriteLine();


            return result;
        }

        public static List<int> Factorize(int n)
        {
            int number = n;
            int p = 0;


            List<int> result = new List<int>();
            for (int i = 0; i < Number.AllPrimes.Count; i++)
            {
                p = 0;

                while(number % Number.AllPrimes[i] == 0)
                {
                    number /= Number.AllPrimes[i];
                    p++;
                }

                result.Add(p);
            }

            return result;
        }

        public static List<int> FindPrimes(int n)
        {
            List<int> result = new List<int>();
            result.Add(2);
            int i = 3;
            bool isPrime = true;

            while (i <= n)
            {
                isPrime = true;

                foreach (int prime in result)
                {
                    if (i % prime == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    result.Add(i);
                }

                i++;
            }

            return result;
        }
    }
}
