using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercise_PascalTriangle
{
    class Program
    {
        static void exercise1()
        {
            int i, j, k, l, n;
            //Console.WriteLine("Input n: ");
            n = 4; //Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = n - i; j < 0; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < i; k++)
                {
                    Console.Write("{0}",k);
                }
                for (l = i; l > 0; l--)
                {
                    Console.Write("{0}",l);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            exercise1();
        }
    }
}
