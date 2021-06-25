using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main()
        {

            int x = 0;
            int y = 0;
            int n = 0;
            string nChar;
            bool isPalyndrome = false;

            for (int a = 999; a >= 800; a--)
            {
                for (int b = 999; b >= a; b--)
                {
                    n = a * b;
                   // Console.WriteLine(b);
                    nChar = n.ToString();
              
                    isPalyndrome = true;

                    for (int i = 0; i < nChar.Length; i++)
                    {
                        if (nChar.ElementAt(i) != nChar.Reverse().ElementAt(i))
                        {
                            isPalyndrome = false;
                            break;
                        }
                    }

                    if (isPalyndrome == true)
                    {
                        x = a;
                        y = b;
                        Console.WriteLine("n = {0}, a = {1}, b = {2}", n, x, y);
                        // break;
                    }
                }

                if (isPalyndrome == true)
                {
                    //break;
                }
            }

            Console.ReadLine();
        }
    }
}
