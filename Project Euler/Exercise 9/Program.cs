using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main()
        {

            int abc;

            Console.WriteLine("Write the desired sum of pytagorean numbers: ");
            int n = int.Parse(Console.ReadLine());

            bool found = false;

            int a;
            for (int c = n; c > n/3; c--)
            {
                for (int b = n - c; b > (n - c)/2; b--)
                {
                    a = n - b - c;

                    if(a > 0 && (a * a) + (b * b) == (c * c))
                    {
                        abc = a * b * c;
                        Console.WriteLine("a = {0}, b = {1}, c = {2} and abc = {3}", a,b,c, abc);
                        found = true;
                    }
                }
            }

            if (!found)
                Console.WriteLine("None Found!");
            Console.ReadLine();
        }
    }
}
