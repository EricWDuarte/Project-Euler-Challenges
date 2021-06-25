using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] divisorsSum = new int[size];
            bool[] isAmicable = new bool[size];

            int result = 0;

            for (int i = 0; i < divisorsSum.Length; i++)
            {
                divisorsSum[i] = SumDivisors(i);
            }

            for (int i = 0; i < divisorsSum.Length; i++)
            {
                if(divisorsSum[i] == 0 || divisorsSum[i] == 1)
                {
                    isAmicable[i] = false;
                }
                else if (divisorsSum[i] < size && divisorsSum[divisorsSum[i]] == i && divisorsSum[i] != i)
                {
                    isAmicable[i] = true;
                    Console.WriteLine(divisorsSum[i]);
                }
                else
                {
                    isAmicable[i] = false;
                }

            }

            for (int i = 0; i < isAmicable.Length; i++)
            {
                if(isAmicable[i] == true)
                {
                    result += i;
                }
            }

            Console.WriteLine(result);
            Console.Read();


        }

        public static int SumDivisors(int n)
        {
            int result = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    result += i;
            }

            return result;
        }
    }
}
