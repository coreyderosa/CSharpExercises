using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises_ForLoops
{
    class Program
    {
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
            exercise1();
        }
    }
}
