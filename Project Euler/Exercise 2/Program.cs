using System;
using System.Collections;

public class Program
{
	static void Main()
	{
        ArrayList fibonacci = new ArrayList();

        fibonacci.Add(1);
        fibonacci.Add(1);

        int i = 1;

        do
        {
            i++;
            int sum = (int)fibonacci[i - 1] + (int)fibonacci[i - 2];
            fibonacci.Add(sum);
            Console.WriteLine(sum);
        }
        while ((int)fibonacci[i] < 4000000);

        Console.WriteLine("");
        int result = 0;


        for(int o = 2; o < fibonacci.Count; o += 3)
        {
            result += (int)fibonacci[o];
        }

        Console.WriteLine("Result = {0}", result);

	}
}
