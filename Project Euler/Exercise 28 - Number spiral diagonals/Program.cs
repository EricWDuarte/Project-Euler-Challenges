using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_28
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            int n = 1;
            int step = 2;
            int count = 1;


            while (n < 1001 * 1001)
            {

                n += step;
                result += n;
                Console.WriteLine(n);


                if (count == 4)
                {
                    count = 0;
                    step+=2;
                }

                count++;
            }

            Console.WriteLine(result);

            Console.Read();

        }
        
    }
}
