using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_ForLoops
{
    class Program
    {
        static void exercise2()
        {
            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7 - i; j++)
                Console.WriteLine(j);

                for (int k = 7-i; k >= 1; k--)
                Console.WriteLine("*");
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }

        static void exercise1()
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 1; j <= 7-i; j++)
                Console.WriteLine("*");
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            exercise2();
            //exercise1();
        }
    }
}
